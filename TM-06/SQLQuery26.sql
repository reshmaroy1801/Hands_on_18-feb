select title from titles where advance>(select min(advance) from titles join publishers on titles.pub_id=publishers.pub_id group by publishers.pub_name having publishers.pub_name='Algodata Infosystems');
