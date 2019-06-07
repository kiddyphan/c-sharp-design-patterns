Bridge
====================

EN

Decouple an abstraction from its implementation so that the two can vary independently.

VI

Tách các class trừu tượng khỏi các thành phần thêm vào để cả 2 đều độc lập.

VD: Chúng ta có 2 bảng users và projects đều thuộc 1 database. Khi muốn xuất ra 
dữ liệu để làm report, chúng ta có thể chọn nhiều loại format khác nhau 
và thay đổi tuỳ theo ý định của mình mà không cần phải tạo ra 
nhiều đối tượng để áp dụng format.

Trước: UserExcelExport, ProductHTMLExport, UserSqlExport, ProductHTMLExport

Sau: UserExport(IFormatter), ProductExport(IFormatter)
