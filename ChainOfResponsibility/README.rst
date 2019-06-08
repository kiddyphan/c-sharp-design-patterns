Chain of Responsibility
====================

EN

It helps building a chain of objects. Request enters from one end 
and keeps going from object to object till it finds the suitable handler.

VI

Tập hợp một chuỗi các object và lần lượt duyệt từ object này sang object khác 
cho đến khi hoàn thành mục tiêu.

VD: Chúng ta có 3 tài khoản thanh toán ATM, VISA, PAYPAL và cả 3 loại có số tiền khác nhau 
100$, 200$, 500$. Chúng ta phải trả một số tiền là 150$ tại một trang web mua sắm trực tuyến 
đã kết nối sẵn 3 tài khoản kể trên. Trang web tự động trừ tiền vào tài khoản phù hợp 
và kết thúc giao dịch. 
