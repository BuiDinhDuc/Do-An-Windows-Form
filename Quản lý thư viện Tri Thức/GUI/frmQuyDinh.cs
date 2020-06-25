using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class frmQuyDinh : Form
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            lblQuyDinh1.Text = "1. Không mang túi xách, cặp, sách, báo – tạp chí in vào phòng đọc(chấp nhận sách, báo dạng photocopy)";
            lblQuyDinh2.Text = "2. Xuất trình thẻ đọc, chứng minh thư, giấy giới thiệu tại bộ phận thủ thư";
            lblQuyDinh3.Text = "3. Chỉ đọc tại chỗ, không mang tài liệu ra khỏi phòng đọc, ra ngoài thư viện";
            lblQuyDinh4.Text = "4. Không cắt xén, xé trang tài liệu, khi phát hiện sách thiếu trang, yêu cầu báo ngay cho thủ thư, nếu không bạn đọc hoàn toàn chịu trách nhiệm";
            lblQuyDinh5.Text = "5. Bạn đọc nào vi phạm nội quy, tùy từng mức độ sẽ có hình thức xử lý thích hợp: thu thẻ đọc, bồi thường, thông báo về cơ quan, trường học…hoặc truy tố trước pháp luật";
            lblQuyDinh6.Text = "6. Không hút thuốc, chất dễ cháy nổ vào phòng đọc, giữ gìn vệ sinh chung trong thư viện";
            lblQuyDinh7.Text = "7. Không nói chuyện riêng, không nghe điện thoại tại phòng đọc, yêu cầu điện thoại để chế độ rung";
            lblQuyDinh8.Text = "8. Khi có nhu cầu photocopy tài liệu, cần liên hệ với thủ thư để được chỉ dẫn cụ thể";
        }
    }
}
