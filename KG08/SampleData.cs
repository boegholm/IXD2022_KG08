﻿using System;

namespace KG08
{
    public class SampleData
    {
        //public List<Sale> Sales => 
        public void Parse()
        {
            var v = RawString.Split("\n");
            foreach(var s in v)
            {
                Console.WriteLine(s);
            }
        }
        public class Sale
        {
            public DateTime OrderDate { get; set; }
            public string Region { get; set; }
            public string Representative { get; set; }
            public string Item { get; set; }
            public int Units { get; set; }
            public decimal UnitCost { get; set; }
            public decimal Total { get; set; }
        }
        // copy/paste fra: https://www.contextures.com/xlsampledata01.html
        string RawString = @"1/6/2020

East

Jones

Pencil

95

1.99

189.05

1/23/2020

Central

Kivell

Binder

50

19.99

999.50

2/9/2020

Central

Jardine

Pencil

36

4.99

179.64

2/26/2020

Central

Gill

Pen

27

19.99

539.73

3/15/2020

West

Sorvino

Pencil

56

2.99

167.44

4/1/2020

East

Jones

Binder

60

4.99

299.40

4/18/2020

Central

Andrews

Pencil

75

1.99

149.25

5/5/2020

Central

Jardine

Pencil

90

4.99

449.10

5/22/2020

West

Thompson

Pencil

32

1.99

63.68

6/8/2020

East

Jones

Binder

60

8.99

539.40

6/25/2020

Central

Morgan

Pencil

90

4.99

449.10

7/12/2020

East

Howard

Binder

29

1.99

57.71

7/29/2020

East

Parent

Binder

81

19.99

1,619.19

8/15/2020

East

Jones

Pencil

35

4.99

174.65

9/1/2020

Central

Smith

Desk

2

125.00

250.00

9/18/2020

East

Jones

Pen Set

16

15.99

255.84

10/5/2020

Central

Morgan

Binder

28

8.99

251.72

10/22/2020

East

Jones

Pen

64

8.99

575.36

11/8/2020

East

Parent

Pen

15

19.99

299.85

11/25/2020

Central

Kivell

Pen Set

96

4.99

479.04

12/12/2020

Central

Smith

Pencil

67

1.29

86.43

12/29/2020

East

Parent

Pen Set

74

15.99

1,183.26

1/15/2021

Central

Gill

Binder

46

8.99

413.54

2/1/2021

Central

Smith

Binder

87

15.00

1,305.00

2/18/2021

East

Jones

Binder

4

4.99

19.96

3/7/2021

West

Sorvino

Binder

7

19.99

139.93

3/24/2021

Central

Jardine

Pen Set

50

4.99

249.50

4/10/2021

Central

Andrews

Pencil

66

1.99

131.34

4/27/2021

East

Howard

Pen

96

4.99

479.04

5/14/2021

Central

Gill

Pencil

53

1.29

68.37

5/31/2021

Central

Gill

Binder

80

8.99

719.20

6/17/2021

Central

Kivell

Desk

5

125.00

625.00

7/4/2021

East

Jones

Pen Set

62

4.99

309.38

7/21/2021

Central

Morgan

Pen Set

55

12.49

686.95

8/7/2021

Central

Kivell

Pen Set

42

23.95

1,005.90

8/24/2021

West

Sorvino

Desk

3

275.00

825.00

9/10/2021

Central

Gill

Pencil

7

1.29

9.03

9/27/2021

West

Sorvino

Pen

76

1.99

151.24

10/14/2021

West

Thompson

Binder

57

19.99

1,139.43

10/31/2021

Central

Andrews

Pencil

14

1.29

18.06

11/17/2021

Central

Jardine

Binder

11

4.99

54.89

12/4/2021

Central

Jardine

Binder

94

19.99

1,879.06

12/21/2021

Central

Andrews

Binder

28

4.99

139.72

";
    }
}
