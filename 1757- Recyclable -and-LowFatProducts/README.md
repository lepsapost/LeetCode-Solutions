# LeetCode 1757 - Recyclable and Low Fat Products

## Problem Description

You are given a table called `products`, with the following columns:
- `product`: The name of the product.
- `recyclable`: A flag indicating whether the product is recyclable (1 for recyclable, 0 for not recyclable).
- `low_fat`: A flag indicating whether the product is low fat (1 for low fat, 0 for not low fat).

Write an SQL query to find all the products that are both recyclable and low fat.

## Solution

The solution is an SQL query that selects all the products from the `products` table where both the `recyclable` and `low_fat` columns are equal to 1.

```sql
SELECT product
FROM products
WHERE recyclable = 1 AND low_fat = 1;
