using Repository.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCard_SE172121
{
    public partial class GameCardManagementForm : Form
    {
        private GameCardInfoService _gameCardInfoService = new GameCardInfoService();
        private ProviderService _providerService = new ProviderService();
        public MemberAccount account { get; set; }
        public GameCardManagementForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameCardManagementForm_Load(object sender, EventArgs e)
        {
            cboProvider.DataSource = _providerService.GetAll();
            cboProvider.DisplayMember = "ProviderName";
            cboProvider.ValueMember = "ProviderId";
            dgvGameCardList.DataSource = null;
            dgvGameCardList.DataSource = _gameCardInfoService.GetAllGameCardInfo();
            if (account.Role == 2)
            {
                grbCRUD.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        private void dgvGameCardList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGameCardList.SelectedRows.Count > 0)
            {
                var selectedSunglass = (GameCardInfo)dgvGameCardList.SelectedRows[0].DataBoundItem;
                txtId.Text = selectedSunglass.GameCardId.ToString();
                txtName.Text = selectedSunglass.GameCardName;
                txtGamePlatForm.Text = selectedSunglass.GameDescription;
                txtDescription.Text = selectedSunglass.GamePlatform;
                dtpCreatedDate.Value = (DateTime)selectedSunglass.CreatedDate;
                txtQuantity.Text = selectedSunglass.Quantity.ToString();
                txtPrice.Text = selectedSunglass.Price.ToString();
                cboProvider.SelectedValue = selectedSunglass.ProviderId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GameCardInfo gamecard = new()
                {
                    GameCardId = int.Parse(txtId.Text.Trim()),
                    GameCardName = txtName.Text.Trim(),
                    GameDescription = txtDescription.Text.Trim(),
                    GamePlatform = txtGamePlatForm.Text.Trim(),
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Quantity = int.Parse(txtQuantity.Text.Trim()),
                    CreatedDate = DateTime.Parse(dtpCreatedDate.Text.Trim()),
                    ProviderId = cboProvider.SelectedValue.ToString()
                };

                _gameCardInfoService.Add(gamecard);
                dgvGameCardList.DataSource = null;
                dgvGameCardList.DataSource = _gameCardInfoService.GetAllGameCardInfo();
                MessageBox.Show("Added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvGameCardList.DataSource = null;
                dgvGameCardList.DataSource = _gameCardInfoService.SearchGameCards(txtKeyword.Text); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GameCardInfo gamecard = new()
                {
                    GameCardId = int.Parse(txtId.Text.Trim()),
                    GameCardName = txtName.Text.Trim(),
                    GameDescription = txtDescription.Text.Trim(),
                    GamePlatform = txtGamePlatForm.Text.Trim(),
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Quantity = int.Parse(txtQuantity.Text.Trim()),
                    CreatedDate = DateTime.Parse(dtpCreatedDate.Text.Trim()),
                    ProviderId = cboProvider.SelectedValue.ToString()
                };

                _gameCardInfoService.Update(gamecard);
                dgvGameCardList.DataSource = null;
                dgvGameCardList.DataSource = _gameCardInfoService.GetAllGameCardInfo();
                MessageBox.Show("Updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _gameCardInfoService.Delete(int.Parse(txtId.Text));
                dgvGameCardList.DataSource = null;
                dgvGameCardList.DataSource = _gameCardInfoService.GetAllGameCardInfo();
                MessageBox.Show("Deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
