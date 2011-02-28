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
save %sp, -136, %sp
or %g0, 1, %o0
or %g0, 4, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 116]
sethi %hi(1000000), %l1
or %l1, %lo(1000000), %l1
sethi %hi(end), %l0
or %l0, %lo(end), %l0
stw %l1, [%l0 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 128, %o1
call scanf
nop
ldsw [%sp + 128], %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 128, %o1
call scanf
nop
ldsw [%sp + 128], %l1
sethi %hi(interval), %l0
or %l0, %lo(interval), %l0
stw %l1, [%l0 + 0]
ldsw [%sp + 92], %l0
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
stw %l0, [%sp + 96]
.L2668:
ldsw [%sp + 96], %l1
sethi %hi(50), %l0
or %l0, %lo(50), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2674
nop
ba %icc, .L2820
nop
.L2674:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 100]
.L2680:
ldsw [%sp + 100], %l1
sethi %hi(end), %l0
or %l0, %lo(end), %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
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
stw %l0, [%sp + 104]
ldsw [%sp + 100], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 116], %l1
ldsw [%sp + 100], %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 116], %l0
ldsw [%l0 + 0], %l0
stw %l0, [%sp + 108]
ldsw [%sp + 116], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l1, %o0
mov %l0, %o1
call multBy4xTimes
nop
ldsw [%sp + 116], %l0
mov %l0, %o0
call divideBy8
nop
sethi %hi(interval), %l0
or %l0, %lo(interval), %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 112]
ldsw [%sp + 112], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
stw %l2, [%sp + 120]
ldsw [%sp + 112], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L2775
nop
ba %icc, .L2781
nop
.L2775:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 112]
ba %icc, .L2786
nop
.L2781:
ba %icc, .L2786
nop
.L2786:
ldsw [%sp + 100], %l1
ldsw [%sp + 112], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ba %icc, .L2680
nop
.L2804:
ldsw [%sp + 96], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
ba %icc, .L2668
nop
.L2820:
ldsw [%sp + 100], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 104], %l0
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

