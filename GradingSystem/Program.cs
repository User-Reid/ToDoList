char ConvertPointsToGrade(int points)
{
  return points switch
  {
    >= 90 => 'A',
    >= 80 => 'B',
    >= 50 => 'C',
    _ => 'D', //Anything below a 50 is a D.
  };
}