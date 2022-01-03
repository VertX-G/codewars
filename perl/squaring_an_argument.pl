# Write a function that takes an argument and returns the square of it.

# My Solution
use strict;
package Solution;

sub square{
    my ($s) = @_;
    return $s * $s;
}

1;

# Voted Best Solution

use strict;
package Solution;

sub square{
    my $x =shift;
    return $x*$x; #Your code
}

1;

# Another Solution

use strict;
package Solution;

sub square {
    return $_[0] ** 2;
}

1;
