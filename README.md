# 🧩 Lab 01 – Introduction to C# Winform Application
> **Môn học:** Lập Trình Mạng Căn Bản  
> **Sinh viên thực hiện:** Tốp – Khoa Mạng Máy Tính & Truyền Thông  
> **Giảng viên hướng dẫn:** ThS. Phan Trung Phát  

---

## 🎯 Mục tiêu
- Làm quen với lập trình **C# WinForms**.  
- Biết cách thiết kế giao diện cơ bản, xử lý sự kiện, và tổ chức logic trong form.  
- Hiểu cách truyền dữ liệu giữa các form, cấu trúc project, và cách đóng gói chương trình nhỏ.

---

## 🧠 Tổng quan các bài tập

| Bài | Nội dung | Kỹ năng chính |
|-----|-----------|---------------|
| **Bài 01** | Nhập họ tên, MSSV, năm sinh – hiển thị kết quả. | TextBox, Label, Event Click |
| **Bài 02** | Tính toán biểu thức số học. | Parse dữ liệu, toán tử, exception handling |
| **Bài 03** | Đọc số nguyên thành chữ (0–9) và đọc số nguyên dài (<= 12 chữ số). | Cấu trúc điều kiện, mảng chuỗi, xử lý chuỗi |
| **Bài 04** | Quản lý phòng vé rạp phim, phân loại giá vé. | `Dictionary`, `HashSet`, `ComboBox`, `CheckedListBox` |
| **Bài 05** | Tính toán giá trị `(A–B)!` và tổng `S = A¹ + A² + … + Aᴮ`. | Vòng lặp lồng nhau, phép toán cơ bản |
| **Bài 06** | Xác định **Cung hoàng đạo** theo ngày/tháng sinh. | DateTime, điều kiện rẽ nhánh |
| **Bài 07** | Xử lý mảng điểm sinh viên: trung bình, đậu/rớt, xếp loại. | Chuỗi, mảng 1 chiều, tính toán logic |
| **Bài 08** | Chọn món ăn ngẫu nhiên từ danh sách nhập vào. | Xử lý chuỗi, Random, thêm dữ liệu động |

---

## 🧩 Bài 04 – Quản lý phòng vé 🎬

### 🧾 Mô tả
Viết chương trình hỗ trợ rạp phim trong việc phân phối vé và tính toán tiền vé:
- **Phim**:
  - “Đào, phở và piano”: 45.000đ – phòng 1,2,3  
  - “Mai”: 100.000đ – phòng 2,3  
  - “Gặp lại chị bầu”: 70.000đ – phòng 1  
  - “Tarot”: 90.000đ – phòng 3  
- **Ghế**:
  - Vé vớt: A1, A5, C1, C5 → ¼ giá  
  - Vé thường: A2–A4, C2–C4 → giá chuẩn  
  - Vé VIP: B2–B4 → gấp đôi giá chuẩn  
- Không được chọn hơn **2 vé**, và ghế đã bán không thể chọn lại.

### ⚙️ Chức năng chính
- Chọn **phim**, **phòng**, **ghế**.  
- Kiểm tra ghế đã bán và **hiển thị ghế trống/đã bán**.  
- Xuất thông tin vé: tên khách, phim, phòng, ghế, tổng tiền.  
- Dữ liệu quản lý bằng `Dictionary` và `HashSet`.  

### 🖼️ Giao diện mẫu
![Form Rạp phim](./screenshots/Lab01_Bai04.png)

---

## 💻 Cấu trúc Project

```bash
NT106_Lab01/
│
├── Home.cs                # Form Menu
├── Lab01_Bai01.cs         # Bài 1 – Tổng 2 số nguyên
├── Lab01_Bai02.cs         # Bài 2 – Min, max
├── Lab01_Bai03.cs         # Bài 3 – Đọc số
├── Lab01_Bai04.cs         # Bài 4 – Quản lý phòng vé
├── Lab01_Bai05.cs         # Bài 5 – Bảng cửu chương & giá trị
├── Lab01_Bai06.cs         # Bài 6 – Cung hoàng đạo
├── Lab01_Bai07.cs         # Bài 7 – Xử lý mảng điểm
├── Lab01_Bai08.cs         # Bài 8 – Hôm nay ăn gì
│
├── Program.cs             # Entry point
├── README.md              # Báo cáo trên GitHub
└── /bin /obj              # Build output (tự động tạo)
