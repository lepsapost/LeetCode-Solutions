# LeetCode 584 - Find Customer Referee

## Problem Description

You are given a `Customer` table, which contains information about customers and who referred them. The table has the following structure:

| Column Name | Type    |
|-------------|---------|
| id          | int     |
| name        | varchar |
| referee_id  | int     |

- `id`: Customer's unique identifier.
- `name`: Customer's name.
- `referee_id`: The `id` of the customer who referred this customer. If a customer was not referred by anyone, the `referee_id` will be `NULL`.

In this problem, you are tasked with finding the names of customers who **are not referred by the customer with `id = 2`**.

### Requirements:
- Return the names of customers who were **not** referred by the customer with `id = 2`.
- You may return the result in any order.

### SQL Query

To solve this problem, you can write the following SQL query:

```sql
SELECT name
FROM Customer
WHERE referee_id != 2 OR referee_id IS NULL;
