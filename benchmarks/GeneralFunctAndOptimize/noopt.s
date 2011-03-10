	.section        ".text"
	.align 4
	.global multBy4xTimes
.type    multBy4xTimes, #function
multBy4xTimes:
save %sp, -96, %sp
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
be %icc, .L17698
nop
ba %icc, .L17705
nop
.L17698:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L17710
nop
.L17705:
ba %icc, .L17710
nop
.L17710:
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
or %l0, 0, %l1
sethi %hi(1000000), %l4
or %l4, %lo(1000000), %l4
sethi %hi(end), %l0
or %l0, %lo(end), %l0
stw %l4, [%l0 + 0]
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
ldsw [%sp + 92], %l5
sethi %hi(interval), %l4
or %l4, %lo(interval), %l4
stw %l5, [%l4 + 0]
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
or %l0, 0, %l0
.L17802:
or %l0, 0, %l5
sethi %hi(50), %l4
or %l4, %lo(50), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movl %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L17808
nop
ba %icc, .L17954
nop
.L17808:
sethi %hi(0), %l3
or %l3, %lo(0), %l3
or %l3, 0, %l3
.L17814:
or %l3, 0, %l5
sethi %hi(end), %l4
or %l4, %lo(end), %l4
ldsw [%l4 + 0], %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movle %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L17821
nop
ba %icc, .L17938
nop
.L17821:
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sethi %hi(2), %l2
or %l2, %lo(2), %l2
mulx %l4, %l2, %l4
sethi %hi(3), %l2
or %l2, %lo(3), %l2
mulx %l4, %l2, %l4
sethi %hi(4), %l2
or %l2, %lo(4), %l2
mulx %l4, %l2, %l4
sethi %hi(5), %l2
or %l2, %lo(5), %l2
mulx %l4, %l2, %l4
sethi %hi(6), %l2
or %l2, %lo(6), %l2
mulx %l4, %l2, %l4
sethi %hi(7), %l2
or %l2, %lo(7), %l2
mulx %l4, %l2, %l4
sethi %hi(8), %l2
or %l2, %lo(8), %l2
mulx %l4, %l2, %l4
sethi %hi(9), %l2
or %l2, %lo(9), %l2
mulx %l4, %l2, %l4
sethi %hi(10), %l2
or %l2, %lo(10), %l2
mulx %l4, %l2, %l4
sethi %hi(11), %l2
or %l2, %lo(11), %l2
mulx %l4, %l2, %l2
or %l2, 0, %l2
or %l3, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
add %l4, %l3, %l3
or %l3, 0, %l3
or %l1, 0, %l5
or %l3, 0, %l4
stw %l4, [%l5 + 0]
or %l1, 0, %l4
ldsw [%l4 + 0], %l4
or %l4, 0, %l4
or %l1, 0, %l5
sethi %hi(2), %l4
or %l4, %lo(2), %l4
mov %l5, %o0
mov %l4, %o1
call multBy4xTimes
nop
or %l1, 0, %l4
mov %l4, %o0
call divideBy8
nop
sethi %hi(interval), %l4
or %l4, %lo(interval), %l4
ldsw [%l4 + 0], %l5
sethi %hi(1), %l4
or %l4, %lo(1), %l4
sub %l5, %l4, %l4
or %l4, 0, %l7
or %l7, 0, %l5
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movle %icc, 1, %l6
or %l6, 0, %l4
or %l7, 0, %l5
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movle %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L17909
nop
ba %icc, .L17915
nop
.L17909:
sethi %hi(1), %l4
or %l4, %lo(1), %l4
or %l4, 0, %l7
ba %icc, .L17920
nop
.L17915:
ba %icc, .L17920
nop
.L17920:
or %l3, 0, %l4
or %l7, 0, %l3
add %l4, %l3, %l3
or %l3, 0, %l3
ba %icc, .L17814
nop
.L17938:
or %l0, 0, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l4, %l0, %l0
or %l0, 0, %l0
ba %icc, .L17802
nop
.L17954:
or %l3, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l2, 0, %l0
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

