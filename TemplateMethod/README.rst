Template Method
====================

EN

Template method defines the skeleton of how a certain algorithm could be performed, 
but defers the implementation of those steps to the children classes.

VI

Xây dựng một bộ khung cho một quy trình nào đó mà bắt buộc phải tuân thủ thứ tự các bước 
do bộ khung đưa ra.

VD: Chúng ta deploy một ứng dụng hay một trang web lên môi trường Production đều phải 
tuân thủ các bước như: 
_ CommitCode
_ QA/QC
_ Assemble
_ Deploy