using BUS.Service;
using DAL.DomainClass;

namespace PRL
{
    public partial class Form1 : Form
    {
        private ThanhphoService service;
        private QuanService quanService;
        private string idWhenClick;
        public Form1()
        {
            InitializeComponent();
            service = new ThanhphoService();
            quanService = new QuanService();
            SettingComboBox();
            LoadGrid();
        }
        public void SettingComboBox()
        {
            //3 bước
            //b1 : truyền dữ liệu vào combobox
            foreach (var quan in quanService.GetQuans())
            {
                cb_Quan.Items.Add(quan.Tenquan);
            }
            //B2 : không cho edit combobox
            cb_Quan.DropDownStyle = ComboBoxStyle.DropDownList;
            //chỉ át tên phòng ban
            // B3 Chọn sẵn 1 item mặc định
            cb_Quan.SelectedIndex = 0;
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng mới 
            Thanhpho thanhpho = new Thanhpho();
            //gán các giá trị trong màn hình vào thuộc tính đối tượng
            thanhpho.Matp = txt_Ma.Text;
            thanhpho.Tentp = txt_Ten.Text;
            thanhpho.Maquan = quanService.GetQuans().ElementAt(cb_Quan.SelectedIndex).Maquan;
            //tìm theo vị trí mà ta đa chọn trên combobox và lấy ra thuộc tính mã phòng ban
            // =>thêm vào database 
            MessageBox.Show(service.Them_TP(thanhpho));
            LoadGrid();
        }
        private void LoadGrid()
        {
            dtg_View.ColumnCount = 5;
            dtg_View.Columns[0].Name = "STT";
            dtg_View.Columns[1].Name = "Guild ID";
            dtg_View.Columns[2].Name = "Mã TP";
            dtg_View.Columns[3].Name = "Tên TP";
            dtg_View.Columns[4].Name = " Quận";
            dtg_View.Rows.Clear();
            var lst = service.GetTPWithQuans().ToList();
            var t = lst.First().Tenquan;
            int count = dtg_View.ColumnCount;
            foreach (var thanhpho in service.GetTPWithQuans())
            {
                dtg_View.Rows.Add(thanhpho.Stt, thanhpho.Guidid, thanhpho.Matp, thanhpho.Maquan, thanhpho.Tenquan);
            }
        }
        private void BindData()
        {
            var tp = service.GetTPWithQuans().First(x => x.Matp == idWhenClick);
            txt_Ma.Text = tp.Matp;
            txt_Ten.Text = tp.Tentp;
            cb_Quan.Text = tp.Tenquan;
        }
        private void dtg_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xác định dòng
            int rowIndex = e.RowIndex;
            //Kiểm tra
            if (rowIndex < 0 || rowIndex >= service.GetTPWithQuans().Count())
            {
                return;
            }
            //Lấy id
            idWhenClick = dtg_View.Rows[rowIndex].Cells[2].Value.ToString();
            BindData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var tp = service.GetThanhphos().Find(x => x.Matp == idWhenClick);
            MessageBox.Show(service.Xoa_TP(tp));
            LoadGrid();
        }

        private void btn__Clear_Click(object sender, EventArgs e)
        {
            txt_Ma.Clear();
            txt_Ten.Clear();
            cb_Quan.Enabled = false;
        }

        private void cb_Quan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
