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
be %icc, .L4637
nop
ba %icc, .L4644
nop
.L4637:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L4649
nop
.L4644:
ba %icc, .L4649
nop
.L4649:
mov %i0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sll %l0, 2, %l0
stw %l0, [%l1 + 0]
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
mov %i0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sra %l0, 1, %l0
stw %l0, [%l1 + 0]
mov %i0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sra %l0, 1, %l0
stw %l0, [%l1 + 0]
mov %i0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sra %l0, 1, %l0
stw %l0, [%l1 + 0]
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
sethi %hi(1000000), %l3
or %l3, %lo(1000000), %l3
sethi %hi(end), %l0
or %l0, %lo(end), %l0
stw %l3, [%l0 + 0]
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
ldsw [%sp + 92], %l4
sethi %hi(interval), %l3
or %l3, %lo(interval), %l3
stw %l4, [%l3 + 0]
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
.L4741:
or %l0, 0, %l4
sethi %hi(50), %l3
or %l3, %lo(50), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L4747
nop
ba %icc, .L4893
nop
.L4747:
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L4753:
or %l2, 0, %l4
sethi %hi(end), %l3
or %l3, %lo(end), %l3
ldsw [%l3 + 0], %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movle %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L4760
nop
ba %icc, .L4877
nop
.L4760:
or %l2, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
add %l3, %l2, %l2
or %l2, 0, %l2
or %l1, 0, %l4
or %l2, 0, %l3
stw %l3, [%l4 + 0]
or %l1, 0, %l4
sethi %hi(2), %l3
or %l3, %lo(2), %l3
mov %l4, %o0
mov %l3, %o1
call multBy4xTimes
nop
or %l1, 0, %l3
mov %l3, %o0
call divideBy8
nop
sethi %hi(interval), %l3
or %l3, %lo(interval), %l3
ldsw [%l3 + 0], %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
sub %l4, %l3, %l3
or %l3, 0, %l6
or %l6, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l4, %l3
or %l6, 0, %l4
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movle %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L4848
nop
ba %icc, .L4854
nop
.L4848:
sethi %hi(1), %l6
or %l6, %lo(1), %l6
ba %icc, .L4859
nop
.L4854:
ba %icc, .L4859
nop
.L4859:
or %l2, 0, %l3
or %l6, 0, %l2
add %l3, %l2, %l2
or %l2, 0, %l2
ba %icc, .L4753
nop
.L4877:
or %l0, 0, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l3, %l0, %l0
or %l0, 0, %l0
ba %icc, .L4741
nop
.L4893:
or %l2, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(39916800), %l0
or %l0, %lo(39916800), %l0
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

