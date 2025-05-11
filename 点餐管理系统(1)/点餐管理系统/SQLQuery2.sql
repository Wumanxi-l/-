select employee_Name 员工姓名,count(o.Order_ID) 订单数,sum(profit) 总利润
from employee e,Orders o
where e.employee_id=o.employee_id and Status='已审核'
group by e.employee_Name