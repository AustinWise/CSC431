	.section        ".text"
	.align 4
	.global wait
.type    wait, #function
wait:
save %sp, -96, %sp
.L1684:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L1690
nop
ba %icc, .L1708
nop
.L1690:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L1684
nop
.L1708:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    wait, .-wait
	.align 4
	.global power
.type    power, #function
power:
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l0
.L1721:
mov %i1, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movg %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L1727
nop
ba %icc, .L1754
nop
.L1727:
or %l0, 0, %l1
mov %i0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
mov %i1, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
mov %l1, %i1
ba %icc, .L1721
nop
.L1754:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    power, .-power
	.align 4
	.global recursiveDecimalSum
.type    recursiveDecimalSum, #function
recursiveDecimalSum:
save %sp, -104, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L1770
nop
ba %icc, .L1846
nop
.L1770:
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l1
mov %i0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mulx %l2, %l0, %l0
or %l0, 0, %l0
mov %i0, %l2
or %l0, 0, %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
move %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L1807
nop
ba %icc, .L1823
nop
.L1807:
mov %i1, %l0
or %l1, 0, %l2
mov %i2, %l1
mov %l2, %o0
mov %l1, %o1
call power
nop
mov %o0, %l1
add %l0, %l1, %l0
mov %l0, %i1
ba %icc, .L1828
nop
.L1823:
ba %icc, .L1828
nop
.L1828:
mov %i0, %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
sdivx %l1, %l0, %l3
mov %i1, %l2
mov %i2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
mov %l3, %o0
mov %l2, %o1
mov %l0, %o2
call recursiveDecimalSum
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1851
nop
.L1846:
ba %icc, .L1851
nop
.L1851:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
	.size    recursiveDecimalSum, .-recursiveDecimalSum
	.align 4
	.global convertToDecimal
.type    convertToDecimal, #function
convertToDecimal:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
mov %i0, %l2
or %l0, 0, %l1
or %l3, 0, %l0
mov %l2, %o0
mov %l1, %o1
mov %l0, %o2
call recursiveDecimalSum
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    convertToDecimal, .-convertToDecimal
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l0, 0, %l0
mov %l0, %o0
call convertToDecimal
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
or %l0, 0, %l1
mulx %l2, %l1, %l1
or %l1, 0, %l4
.L1905:
or %l4, 0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movg %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L1911
nop
ba %icc, .L1933
nop
.L1911:
or %l4, 0, %l1
mov %l1, %o0
call wait
nop
or %l4, 0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
or %l1, 0, %l4
ba %icc, .L1905
nop
.L1933:
or %l0, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.section        ".rodata"
	.align 8
.ConstantString0:
	.asciz  "%d "
	.align 8
.ConstantString1:
	.asciz  "%d\n"
	.align 8
.ConstantString2:
	.asciz  "%d"

