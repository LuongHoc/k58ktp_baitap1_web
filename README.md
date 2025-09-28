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
### A. Tạo Solution

1. Mở Visual Studio 2022.
2. Chọn Create a new project.
3. Tìm "Blank Solution" trên thanh tìm kiếm->chọn Blank Solution -> Nhấn Next

<img width="1257" height="838" alt="image" src="https://github.com/user-attachments/assets/e509566e-1d7b-4dcf-a21e-a1ee95412d65" />

5. Tại Solution name: Đặt tên Solution "StepSuite"
6. Tại location: chọn nơi lưu trữ -> Create.

<img width="1259" height="838" alt="image" src="https://github.com/user-attachments/assets/e4acf262-47b2-4b04-b75f-48df0e6b4b51" />

### B. Project 1 — Class Library (DLL)
1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

<img width="1881" height="1026" alt="image" src="https://github.com/user-attachments/assets/56dd86e4-0c2b-462f-a5f0-fabd4d91d9e1" />


2. Tìm Class Library (.NET Framework)-> Chọn -> Next.

<img width="1879" height="1008" alt="image" src="https://github.com/user-attachments/assets/567d49dd-0528-4280-8064-e3a00ac87a99" />

3. Project name: StepLib 

   Frame work: Chọn .NET Framework 2.0 -> Create

<img width="1713" height="911" alt="image" src="https://github.com/user-attachments/assets/30c37d62-4bea-45a2-a25a-62c649e402a9" />

4. Viết code vào StepCalculator.cs

5. Build StepLib

<img width="1895" height="1032" alt="image" src="https://github.com/user-attachments/assets/f77103ef-0240-499c-a9ae-4c9763fac3ea" />

### C. Project 2 — Console appConsole

1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

<img width="1920" height="1031" alt="image" src="https://github.com/user-attachments/assets/b5864eed-9419-4e2c-b0db-c284f8dd9fd7" />

2. Tìm Console App (.NET Framework) ->Chọn  → Next.

<img width="1710" height="922" alt="image" src="https://github.com/user-attachments/assets/ae14ad92-2f95-41b6-93a5-1e7fa8ce0a26" />

3. Project name: StepConsole → Create.

    Frame work: Chọn .NET Framework 2.0 -> Create

<img width="1886" height="1024" alt="image" src="https://github.com/user-attachments/assets/92042076-b59c-4cb3-99b5-f7dccf39a5de" />

4. Thêm tham chiếu tới DLL:

Solution Explorer → StepConsole → chuột phải References → Add Reference… → tab Projects → tích StepLib → OK.

<img width="1907" height="1020" alt="image" src="https://github.com/user-attachments/assets/99bee6cb-d23e-492e-96b8-f61df9e42318" />

<img width="1919" height="1029" alt="image" src="https://github.com/user-attachments/assets/1e87531f-32af-434a-a0b5-514d3a45f8ac" />

5. Ctrl+Shift+B (Build) → Run
<img width="1909" height="1011" alt="image" src="https://github.com/user-attachments/assets/744aaae5-ffe8-49e6-a80e-41b1a43dbdb8" />

### D.Project 3 -	Windows Form Application
1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

<img width="1887" height="1024" alt="image" src="https://github.com/user-attachments/assets/0f181f6e-cede-4644-970e-4b9289454678" />

2. Tìm Windows Forms App (.NET Framework)->Chọn ->Next.

<img width="1899" height="1010" alt="image" src="https://github.com/user-attachments/assets/cd81f6d9-c065-4aa3-ace4-cf20a8119677" />

3. Project name: StepWinForms → Create.

   Frame work: Chọn .NET Framework 2.0 -> Create

<img width="1690" height="911" alt="image" src="https://github.com/user-attachments/assets/1bd945a9-a3f1-49d5-95cf-839e6873cc60" />


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

### E. Project 4 — WebForms

1. Tại Solution Explorer → chuột phải vào Solution StepSuite → Add → New Project….

<img width="1887" height="1024" alt="image" src="https://github.com/user-attachments/assets/0f181f6e-cede-4644-970e-4b9289454678" />

2. Tìm ASP.NET Web Application (.NET Framework)->Chọn ->Next.

<img width="1741" height="915" alt="image" src="https://github.com/user-attachments/assets/7cc6c828-79be-4490-bb40-ce5c9c4e2281" />

3. Project name: StepWeb
 
   Frame work: Chọn .NET Framework 2.0 -> Create

<img width="1805" height="935" alt="image" src="https://github.com/user-attachments/assets/488f5422-95e1-433a-8216-fa0657478130" />

chọn template Empty → Create.

<img width="1627" height="936" alt="image" src="https://github.com/user-attachments/assets/5e6de15a-7500-4d75-8e9e-2d31848a3d4a" />

4. Thêm tham chiếu:

StepWeb → References → Add Reference… → Projects → tích StepLib → OK.

<img width="1901" height="1021" alt="image" src="https://github.com/user-attachments/assets/722aee77-a017-4893-b682-da1d6016d3e2" />

<img width="1701" height="911" alt="image" src="https://github.com/user-attachments/assets/ea3c9b15-327b-4438-a489-03e4cfba0bc4" />

5. Thêm file index.html

StepWeb → chuột phải → Add → New Item… → HTML Page → Name: index.html → Add.

<img width="1790" height="958" alt="image" src="https://github.com/user-attachments/assets/7d27331a-2ee1-4a53-940b-ffc0fe2185b3" />

<img width="1688" height="917" alt="image" src="https://github.com/user-attachments/assets/cdbdcc15-1ec1-4a74-b789-e1e36a781fa7" />

6. Thêm file api.aspx:

StepWeb → chuột phải → Add → New Item… → Web Form → Name: api.aspx → Add.

<img width="1790" height="958" alt="image" src="https://github.com/user-attachments/assets/7d27331a-2ee1-4a53-940b-ffc0fe2185b3" />

<img width="1819" height="1004" alt="image" src="https://github.com/user-attachments/assets/64fd0de4-c594-4240-8e37-f01ca589b197" />

VS tự tạo kèm api.aspx.cs. 

7. Build → Run
<img width="1920" height="1026" alt="image" src="https://github.com/user-attachments/assets/d194f6fd-dcda-47c6-8f2f-f161a08daac1" />

## Cấu hình IIS cho Project Web

### A.Bật tính năng Windows cần thiết
1. Mở Control Panel → Programs and Features.

<img width="1403" height="744" alt="image" src="https://github.com/user-attachments/assets/c120a1a5-cadb-4fa2-97c5-00553ca4f72d" />

2. Chọn Turn Windows features on or off
Tích:

- .NET Framework 3.5 (includes .NET 2.0 and 3.0) → OK để cài.

- Internet Information Services → mở World Wide Web Services → Application Development Features → tích:

ASP.NET 3.5

.NET Extensibility 3.5

ISAPI Extensions

ISAPI Filters
→ OK 

<img width="1826" height="1018" alt="image" src="https://github.com/user-attachments/assets/0d3ecc58-3d5b-429b-9125-ce6e05785c57" />

### B.Tạo domain cục bộ (hosts)
1. Mở Notepad dưới quyền admin: Start → gõ Notepad → chuột phải → Run as administrator.

<img width="1838" height="1030" alt="image" src="https://github.com/user-attachments/assets/b1ddc160-01bc-462f-a2a3-b652cf1076df" />

2. File → Open… → duyệt tới C:\Windows\System32\drivers\etc → chọn All Files (.) → mở file hosts.

<img width="1863" height="1009" alt="image" src="https://github.com/user-attachments/assets/8bc1201a-2f1c-494c-9245-ca1a9f0b2aa5" />

<img width="1646" height="802" alt="image" src="https://github.com/user-attachments/assets/1f6df109-9a95-440c-9713-1c91a45c7c4b" />

3. Thêm dòng :

127.0.0.1    steps.local

<img width="1803" height="1022" alt="image" src="https://github.com/user-attachments/assets/53f97bff-7ea9-4ca0-9d2e-480145a67c3b" />

4. Ctrl + S để lưu.


### C.Thêm Website & Binding domain

1. Mở IIS Manager: nhấn Win, gõ inetmgr → Enter.

<img width="1386" height="1024" alt="image" src="https://github.com/user-attachments/assets/440c1766-39c2-45b7-a233-65535683c13a" />

2. Trong IIS Manager → cột trái Sites → chuột phải → Add Website…

<img width="1917" height="1027" alt="image" src="https://github.com/user-attachments/assets/5fefbb98-2dc3-4c8c-952d-cb615bbf8264" />

Site name: StepWebSite

Physical path: nhấn … → trỏ đúng thư mục project StepWeb (nơi có Web.config, index.html, api.aspx, thư mục bin)

Type: http

IP address: All Unassigned

Port: 80

Host name: steps.local 

Nhấn OK.

<img width="1863" height="1040" alt="image" src="https://github.com/user-attachments/assets/685776c7-0077-412d-ac60-186ddb4ef086" />

### D.Tạo Application Pool dùng .NET 2.0

1. Mở IIS Manager → cột trái chọn Application Pools.

2. Chuột phải → Add Application Pool…

<img width="1656" height="844" alt="image" src="https://github.com/user-attachments/assets/4d349fdf-3577-472d-a802-69ef5f3a652b" />

Name: StepWebSite

.NET CLR version: v2.0.50727

Managed pipeline mode: Classic

Nhấn OK.

<img width="1892" height="1023" alt="image" src="https://github.com/user-attachments/assets/d28e07d2-772e-4c9b-bd79-e0d777338292" />

### E. Kiểm tra Handler & Default Document

1. Chọn site StepWebSite → Handler Mappings

2. Tìm PageHandlerFactory-ISAPI-2.0 để đảm bảo ASP.NET 3.5 và ISAPI đã bật.

<img width="1730" height="946" alt="image" src="https://github.com/user-attachments/assets/927d4ca6-b3c5-4b61-a099-6a04fb3573e0" />

3. Chọn site StepWebSite → Default Document

Danh sách nên có index.html. Nếu chưa có:

Actions (bên phải) → Add… → nhập index.html → OK.

<img width="1888" height="1001" alt="image" src="https://github.com/user-attachments/assets/7f3cb906-77b9-4a06-b326-c0e5302a10bf" />

### F.Kiểm tra 

Mở trình duyệt → gõ http://steps.local/

<img width="1906" height="1020" alt="image" src="https://github.com/user-attachments/assets/cadc0fab-7035-47c5-8f7b-129771169b90" />

Kết quả Ok
