# Lương Văn Học - K225480106025
# k58ktp - Môn phát triển ứng dụng trên nền web
# nội dung bài tập 1
## TẠO SOLUTION GỒM CÁC PROJECT SAU:
1.	DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
2.	Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
3.	Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
4.	Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
## Đề tài: Hệ thống đo “số bước đơn giản” 

Input: Quãng đường (km), trọng lượng (kg), chiều dài bước (m)

Output: Số bước (Steps), Năng lượng tiêu hao (Calories)

# -----BÀI LÀM-----
## 1.Tạo Solution & 4 project
### A. Tạo Solution rỗng

1. Mở Visual Studio 2022.
2. Chọn Create a new project.
3. Tìm "Blank Solution" trên thanh tìm kiếm->chọn Blank Solution -> Nhấn Next

<img width="1257" height="838" alt="image" src="https://github.com/user-attachments/assets/e509566e-1d7b-4dcf-a21e-a1ee95412d65" />

5. Tại Solution name: Đặt tên Solution "StepSuite"
6. Tại location: chọn nơi lưu trữ -> Create.

<img width="1259" height="838" alt="image" src="https://github.com/user-attachments/assets/e4acf262-47b2-4b04-b75f-48df0e6b4b51" />

### B. Project 1 — Class Library (DLL)
1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

<img width="1081" height="562" alt="image" src="https://github.com/user-attachments/assets/a3f2eb28-eec2-42c2-a71b-29e406d3b7a4" />


2. Tìm Class Library (.NET Framework)-> Chọn -> Next.

<img width="1720" height="924" alt="image" src="https://github.com/user-attachments/assets/84957d00-467d-4caa-9773-d94f0fe2a62c" />

3. Project name: StepLib 

   Frame work: Chọn .NET Framework 2.0 -> Create

<img width="1713" height="911" alt="image" src="https://github.com/user-attachments/assets/30c37d62-4bea-45a2-a25a-62c649e402a9" />

4. Viết code vào StepCalculator.cs

5. Build StepLib

<img width="1895" height="1032" alt="image" src="https://github.com/user-attachments/assets/f77103ef-0240-499c-a9ae-4c9763fac3ea" />

### C. Project 2 — Console appConsole

1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

<img width="1920" height="1031" alt="image" src="https://github.com/user-attachments/assets/b5864eed-9419-4e2c-b0db-c284f8dd9fd7" />

2. Chọn Console App (.NET Framework) → Next.

<img width="1710" height="922" alt="image" src="https://github.com/user-attachments/assets/ae14ad92-2f95-41b6-93a5-1e7fa8ce0a26" />

3. Project name: StepConsole → Create.

    Frame work: Chọn .NET Framework 2.0 -> Create

4. Thêm tham chiếu tới DLL:

Solution Explorer → StepConsole → chuột phải References → Add Reference… → tab Projects → tích StepLib → OK.

<img width="1907" height="1020" alt="image" src="https://github.com/user-attachments/assets/99bee6cb-d23e-492e-96b8-f61df9e42318" />

<img width="1711" height="928" alt="image" src="https://github.com/user-attachments/assets/9b5a20d3-3ca8-4eeb-a2bc-8e7de2b438b0" />

5. Ctrl+Shift+B (Build) → Run
<img width="1909" height="1011" alt="image" src="https://github.com/user-attachments/assets/744aaae5-ffe8-49e6-a80e-41b1a43dbdb8" />

### B.Project 3 -	Windows Form Application
1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….


2. Chọn Windows Forms App (.NET Framework)->Next.

<img width="1899" height="1010" alt="image" src="https://github.com/user-attachments/assets/cd81f6d9-c065-4aa3-ace4-cf20a8119677" />

3. Project name: StepWinForms → Create.

   Frame work: Chọn .NET Framework 2.0 -> Create



4. Thêm tham chiếu DLL

References (của StepWinForms) → chuột phải → Add Reference… → Projects → tích StepLib → OK.

<img width="1891" height="1026" alt="image" src="https://github.com/user-attachments/assets/4c4c57b6-e818-48ad-a6e8-9636e7e4168d" />
<img width="1892" height="1022" alt="image" src="https://github.com/user-attachments/assets/adc45821-4cd9-412b-9021-e0e87dd6d3df" />

5. Thiết kế Form:

View → Toolbox (hoặc Ctrl+Alt+X).


<img width="1875" height="1014" alt="image" src="https://github.com/user-attachments/assets/52d90f31-622c-461c-9817-43c7ca68163a" />

Tạo giao diện


<img width="1857" height="999" alt="image" src="https://github.com/user-attachments/assets/e93e3cfc-4de3-451f-b9af-4a9325bc377e" />

6. Build → Run

<img width="1914" height="1025" alt="image" src="https://github.com/user-attachments/assets/7d84e956-335d-42ce-8d8e-6d82d2db6417" />

### B5. Project 4 — WebForms

1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

Solution → Add → New Project… → ASP.NET Web Application (.NET Framework).

Project name: StepWeb → Create → chọn template Empty (hoặc “Web Forms” tối giản) → Create.

Properties → Target framework = .NET Framework 2.0 → Yes.

Thêm tham chiếu:

StepWeb → References → Add Reference… → Projects → tích StepLib → OK.

<img width="1901" height="1021" alt="image" src="https://github.com/user-attachments/assets/722aee77-a017-4893-b682-da1d6016d3e2" />

<img width="1701" height="911" alt="image" src="https://github.com/user-attachments/assets/ea3c9b15-327b-4438-a489-03e4cfba0bc4" />


Thêm file index.html:

StepWeb → chuột phải → Add → New Item… → HTML Page → Name: index.html → Add.

<img width="1790" height="958" alt="image" src="https://github.com/user-attachments/assets/7d27331a-2ee1-4a53-940b-ffc0fe2185b3" />

<img width="1688" height="917" alt="image" src="https://github.com/user-attachments/assets/cdbdcc15-1ec1-4a74-b789-e1e36a781fa7" />

Thêm file api.aspx:

StepWeb → chuột phải → Add → New Item… → Web Form → Name: api.aspx → Add.

<img width="1790" height="958" alt="image" src="https://github.com/user-attachments/assets/7d27331a-2ee1-4a53-940b-ffc0fe2185b3" />

<img width="1819" height="1004" alt="image" src="https://github.com/user-attachments/assets/64fd0de4-c594-4240-8e37-f01ca589b197" />

VS tự tạo kèm api.aspx.cs. 

Build → Run
<img width="1920" height="1026" alt="image" src="https://github.com/user-attachments/assets/d194f6fd-dcda-47c6-8f2f-f161a08daac1" />



