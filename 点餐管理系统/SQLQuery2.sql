select employee_Name Ա������,count(o.Order_ID) ������,sum(profit) ������
from employee e,Orders o
where e.employee_id=o.employee_id and Status='�����'
group by e.employee_Name