using Pizzaria.Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Desktop.Forms
{
    public partial class PizzaFormDialog : Form
    {
        public CreatePizzaDto? PizzaDto { get; private set; }
        public UpdatePizzaDto? UpdateDto { get; private set; }

        private List<CategoriaResponseDto> _categorias;
        private PizzaResponseDto? pizzaexistente;

        public PizzaFormDialog(List<CategoriaResponseDto> categorias, PizzaResponseDto? pizza)
        {
            _categorias = categorias;
            pizzaexistente = pizza;
        }

        private void PizzaFormDialog_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            this.Text = pizzaexistente == null ? "Nova Pizza" : "Editar Pizza";
            lblTituloForm.Text = pizzaexistente == null ? "+Nova Pizza" : "Editar Pizza";

            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");
            foreach (var categoria in _categorias)


                cmbCategoria.Items.Add(categoria.Name);
            cmbCategoria.SelectedIndex = 0;
            PreencherCampos();
        }
        private void PreencherCampos()
        {
            if (pizzaexistente == null) return;
            txtTítulo.Text = pizzaexistente.Name;
            txtDescricao.Text = pizzaexistente.Descrição;
            txtCoverUrl.Text = pizzaexistente.CoverImageUrl;
            chkDestaque.Checked = pizzaexistente.IsFeatured;

            var idx = _categorias.FindIndex(c => c.Id == pizzaexistente.CategoriaId);
            if (idx >= 0) cmbCategoria.SelectedIndex = idx + 1;
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTítulo.Text))
            {
                MessageBox.Show(
                    "Informe o nome da Pizza.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show(
                 "Selecione uma categoria",
                 "Validação",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            var categoriaIdx = cmbCategoria.SelectedIndex - 1;
            var categoriaId = _categorias[categoriaIdx].Id;

            if (pizzaexistente == null)
            {
                PizzaDto = new CreatePizzaDto
                {
                    Name = txtTítulo.Text.Trim(),
                    Descrição = txtDescricao.Text.Trim(),
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    IsFeatured = chkDestaque.Checked,
                    CategoriaId = categoriaId
                };
            }
            else
            {
                UpdateDto = new UpdatePizzaDto
                {
                    Name = txtTítulo.Text.Trim(),
                    Descrição = txtDescricao.Text.Trim(),
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    IsFeatured = chkDestaque.Checked,
                    CategoriaId = categoriaId
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
