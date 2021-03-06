select sum(qty) as Total_Sales from pubs.dbo.sales inner join pubs.dbo.titles on sales.title_id = titles.title_id where titles.title_id in
(
select title_id as id from pubs.dbo.publishers,pubs.dbo.titles where publishers.pub_id = titles.pub_id and pub_name = 'New Moon Books') group by sales.title_id;