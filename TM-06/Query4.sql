select emp_id,fname,minit,lname,job_id,job_lvl,pub_id,hire_date from pubs.dbo.employee where hire_date > CONVERT(DateTime,'01-12-1990',105);