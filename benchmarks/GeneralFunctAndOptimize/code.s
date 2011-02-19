	.section        ".text"
	.align 4
	.global multBy4xTimes
.type    multBy4xTimes, #function
multBy4xTimes:
save %sp, -104, %sp
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2565
nop
ba %icc, .L2572
nop
.L2565:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L2577
nop
.L2572:
ba %icc, .L2577
nop
.L2577:
mov %i0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mulx %l1, %l0, %l0
stw %l0, [%l2 + 0]
mov %i0, %l2
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l2, %o0
mov %l0, %o1
call multBy4xTimes
nop
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
	.size    multBy4xTimes, .-multBy4xTimes
	.align 4
	.global divideBy8
.type    divideBy8, #function
divideBy8:
save %sp, -96, %sp
mov %i0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
stw %l0, [%l2 + 0]
mov %i0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
stw %l0, [%l2 + 0]
mov %i0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
stw %l0, [%l2 + 0]
ret
restore
	.size    divideBy8, .-divideBy8
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 4, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l5
sethi %hi(1000000), %l1
or %l1, %lo(1000000), %l1
sethi %hi(end), %l0
or %l0, %lo(end), %l0
stw %l1, [%l0 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l2
sethi %hi(interval), %l1
or %l1, %lo(interval), %l1
stw %l2, [%l1 + 0]
or %l0, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(interval), %l0
or %l0, %lo(interval), %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
.L2668:
or %l2, 0, %l1
sethi %hi(50), %l0
or %l0, %lo(50), %l0
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l1, %l0
movl %icc, 1, %l6
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l6, %l0
be %icc, .L2674
nop
ba %icc, .L2820
nop
.L2674:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l4
.L2680:
or %l4, 0, %l1
sethi %hi(end), %l0
or %l0, %lo(end), %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l1, %l0
movle %icc, 1, %l6
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l6, %l0
be %icc, .L2687
nop
ba %icc, .L2804
nop
.L2687:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mulx %l1, %l0, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mulx %l1, %l0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mulx %l1, %l0, %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
mulx %l1, %l0, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
mulx %l1, %l0, %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
mulx %l1, %l0, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
mulx %l1, %l0, %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mulx %l1, %l0, %l1
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mulx %l1, %l0, %l1
sethi %hi(11), %l0
or %l0, %lo(11), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l3
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
or %l5, 0, %l1
or %l4, 0, %l0
stw %l0, [%l1 + 0]
or %l5, 0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l0
or %l5, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l1, %o0
mov %l0, %o1
call multBy4xTimes
nop
or %l5, 0, %l0
mov %l0, %o0
call divideBy8
nop
sethi %hi(interval), %l0
or %l0, %lo(interval), %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
or %l0, 0, %l1
or %l1, 0, %l6
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movle %icc, 1, %l7
or %l7, 0, %l0
or %l1, 0, %l7
sethi %hi(0), %l6
or %l6, %lo(0), %l6
sethi %hi(0), %l0
or %l0, %lo(0), %l0
cmp %l7, %l6
movle %icc, 1, %l0
sethi %hi(1), %l6
or %l6, %lo(1), %l6
cmp %l0, %l6
be %icc, .L2775
nop
ba %icc, .L2781
nop
.L2775:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l1
ba %icc, .L2786
nop
.L2781:
ba %icc, .L2786
nop
.L2786:
or %l4, 0, %l4
or %l1, 0, %l0
add %l4, %l0, %l0
or %l0, 0, %l4
ba %icc, .L2680
nop
.L2804:
or %l2, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l2
ba %icc, .L2668
nop
.L2820:
or %l4, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l3, 0, %l0
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
	.common interval,4,4
	.common end,4,4
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

