select quantity
from inventory
where store_id=2 and UPC_code='11410579805cam'

select *
from Transactions
where store_id=2 and UPC_code='11410579805cam'
order by date_time desc