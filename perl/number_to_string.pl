# Convert a Number to a String
package Kata;
use strict;
use warnings;

# My Solution

sub number_to_string {
    my ($num) = @_;
    # my $string = "$num";
    # return $string;
    return "$num";
}

1; 


=Voted Best Solution

package Kata;
use strict;
use warnings;

sub number_to_string {
    #...
    "" . $_[0];
}

'ABS';

=Cut
