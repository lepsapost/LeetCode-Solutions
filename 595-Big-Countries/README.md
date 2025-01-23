# LeetCode 595 - Big Countries

## Problem Description

You are given a table called `World`, which contains information about countries. The table has the following structure:

| Column Name  | Type   |
|--------------|--------|
| name         | varchar|
| continent    | varchar|
| area         | int    |
| population   | int    |
| gdp          | bigint |

- `name`: The name of the country.
- `continent`: The continent the country is located in.
- `area`: The area of the country (in square kilometers).
- `population`: The population of the country.
- `gdp`: The Gross Domestic Product (GDP) of the country.

In this problem, you are tasked with finding the names of countries with an area greater than 3 million square kilometers.

### Requirements:
- Return the name and area of the countries where the area is greater than 3 million square kilometers.
- You may return the result in any order.

### SQL Query

To solve this problem, you can use the following SQL query:

```sql
SELECT name, area
FROM World
WHERE area > 3000000;
