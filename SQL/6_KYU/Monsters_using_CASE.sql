SELECT
  top_half.id as id,
  top_half.heads as heads,
  top_half.arms as arms,
  bottom_half.legs as legs,
  bottom_half.tails as tails,
  CASE
    WHEN top_half.heads > top_half.arms OR bottom_half.tails > bottom_half.legs
      THEN 'BEAST'
      ELSE 'WEIRDO'
  END as species
FROM
  top_half 
  JOIN bottom_half ON top_half.id = bottom_half.id
ORDER BY species; 