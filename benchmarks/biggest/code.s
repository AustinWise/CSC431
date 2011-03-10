	.section        ".text"
	.align 4
	.global getIntList
.type    getIntList, #function
getIntList:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l4
or %l4, 0, %l2
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
move %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L69
nop
ba %icc, .L75
nop
.L69:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L271
nop
.L75:
or %l1, 0, %l2
or %l4, 0, %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l0
call getIntList
nop
mov %o0, %l2
stw %l2, [%l0 + 4]
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L271
nop
.L271:
	.size    getIntList, .-getIntList
	.align 4
	.global biggest
.type    biggest, #function
biggest:
save %sp, -96, %sp
mov %i0, %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L710
nop
ba %icc, .L721
nop
.L710:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L734
nop
.L721:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L734
nop
.L734:
	.size    biggest, .-biggest
	.align 4
	.global biggestInList
.type    biggestInList, #function
biggestInList:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %l3
.L766:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L773
nop
ba %icc, .L801
nop
.L773:
or %l3, 0, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call biggest
nop
mov %o0, %l0
or %l0, 0, %l3
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
ba %icc, .L766
nop
.L801:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    biggestInList, .-biggestInList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
call getIntList
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
mov %l0, %o0
call biggestInList
nop
mov %o0, %l0
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

