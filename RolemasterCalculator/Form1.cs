using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RolemasterCalculator.BLL.Weapon;
using RolemasterCalculator.Models.BaseTypes;
using RolemasterCalculator.BLL.Critical;
using RolemasterCalculator.BLL.Modifier;
using RolemasterCalculator.Models.Modifier;

namespace RolemasterCalculator
{
    public partial class Main : Form
    {

        private ModifierController _attackModifiers;
        private ModifierController _defenseModifiers;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateWeaponTypes();
            PopulateCriticalTypes();

            SetControlsToDefault();

            _attackModifiers = new ModifierController();
            _defenseModifiers = new ModifierController();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            cboArmorType.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                cboArmorType.Focus();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtCriticalRoll.Focus();
            }
        }

        private void SetControlsToDefault()
        {
            cboArmorType.SelectedIndex = 0;
            cboCriticalSeverity.SelectedIndex = 0;

            cboArmorType.Focus();
        }

        #region Weapon Tab

        private void PopulateWeaponTypes()
        {
            IBaseType types = new WeaponController();
            cboWeaponType.DisplayMember = "Type";
            cboWeaponType.ValueMember = "ID";
            cboWeaponType.DataSource = types.GetTypes();
        }

        private void btnWeaponClear_Click(object sender, EventArgs e)
        {
            dgAttackMod.DataSource = null;
            dgDefenseMod.DataSource = null;
            cboArmorType.SelectedIndex = 0;
            cboWeaponType.SelectedIndex = 0;
            txtAttackRoll.Text = "";
            txtDefenseBonus.Text = "";
            _attackModifiers.ClearModifiers();
            _defenseModifiers.ClearModifiers();
            cboArmorType.Focus();
            lblWeaponLookup.Text = "";
            cboArmorType.Focus();
        }

        private void txtAttackRoll_TextChanged(object sender, EventArgs e)
        {
            int attackRoll;
            bool a = int.TryParse(txtAttackRoll.Text, out attackRoll);

            if (a)
            {
                btnWeaponCalculate.Enabled = true;
            }
            else
            {
                btnWeaponCalculate.Enabled = false;
            }
        }

        private void btnWeaponCalculate_Click(object sender, EventArgs e)
        {
            int defenseBonus;
            bool a = int.TryParse(txtDefenseBonus.Text, out defenseBonus);

            int attackRoll;
            bool b = int.TryParse(txtAttackRoll.Text, out attackRoll);

            int modifierTotal = ModifierController.Calculate(_attackModifiers, _defenseModifiers, attackRoll, defenseBonus, Convert.ToInt32(cboWeaponType.SelectedValue));

            WeaponController weaponController = new WeaponController();
            lblWeaponLookup.Text = weaponController.GetWeaponDamage(modifierTotal, Convert.ToInt32(cboArmorType.SelectedItem), Convert.ToInt32(cboWeaponType.SelectedValue));

        }

        #region Attack Section

        private void btnAddAttackMod_Click(object sender, EventArgs e)
        {
            AddModifiers frmAddModifiers = new AddModifiers();
            DialogResult dr = frmAddModifiers.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _attackModifiers.AddModifier(new ModifierDetail(frmAddModifiers.Value, frmAddModifiers.Description));
                PopulateAttackModifiers();
            }
        }

        private void btnRemoveAttackMod_Click(object sender, EventArgs e)
        {
            if (dgAttackMod.SelectedRows.Count > 0)
            {
                _attackModifiers.RemoveModifier(dgAttackMod.SelectedRows[0].Index);
                PopulateAttackModifiers();
            }
        }

        private void PopulateAttackModifiers()
        {
            dgAttackMod.DataSource = null;
            dgAttackMod.DataSource = _attackModifiers.GetModifiers();

            SetAttackModDGProperties();
        }

        private void SetAttackModDGProperties()
        {
            dgAttackMod.Columns[0].Width = 50;
            dgAttackMod.Columns[1].Width = 150;
        }

        #endregion

        #region Defense Section

        private void btnAddDefenseMod_Click(object sender, EventArgs e)
        {
            AddModifiers frmAddModifiers = new AddModifiers();
            DialogResult dr = frmAddModifiers.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _defenseModifiers.AddModifier(new ModifierDetail(frmAddModifiers.Value, frmAddModifiers.Description));
                PopulateDefenseModifiers();
            }
        }

        private void btnRemoveDefenseMod_Click(object sender, EventArgs e)
        {
            if (dgDefenseMod.SelectedRows.Count > 0)
            {
                _defenseModifiers.RemoveModifier(dgDefenseMod.SelectedRows[0].Index);
                PopulateDefenseModifiers();
            }
        }

        private void PopulateDefenseModifiers()
        {
            dgDefenseMod.DataSource = null;
            dgDefenseMod.DataSource = _defenseModifiers.GetModifiers();

            SetDefenseModDGProperties();
        }

        private void SetDefenseModDGProperties()
        {
            dgDefenseMod.Columns[0].Width = 50;
            dgDefenseMod.Columns[1].Width = 150;
        }

        #endregion

        #endregion

        #region Critical Tab

        private void PopulateCriticalTypes()
        {
            IBaseType types = new CriticalController();
            cboCriticalType.DisplayMember = "Type";
            cboCriticalType.ValueMember = "ID";
            cboCriticalType.DataSource = types.GetTypes();
        }

        private void btnCriticalClear_Click(object sender, EventArgs e)
        {
            txtCriticalRoll.Text = "";
            cboCriticalType.SelectedIndex = 0;
            cboCriticalSeverity.SelectedIndex = 0;
            lblCriticalLookup.Text = "";
            txtCriticalRoll.Focus();
        }

        private void txtCriticalRoll_TextChanged(object sender, EventArgs e)
        {
            int roll;
            bool a = int.TryParse(txtCriticalRoll.Text, out roll);

            if (a)
            {
                btnCriticalCalculate.Enabled = true;
            }
            else
            {
                btnCriticalCalculate.Enabled = false;
            }
        }

        private void btnCriticalCalculate_Click(object sender, EventArgs e)
        {
            int roll;
            bool a = int.TryParse(txtCriticalRoll.Text, out roll);

            CriticalController criticalController = new CriticalController();
            lblCriticalLookup.Text = criticalController.GetCritical(roll, Convert.ToInt32(cboCriticalType.SelectedValue), Convert.ToString(cboCriticalSeverity.SelectedItem));
        }
        #endregion

    }
}
