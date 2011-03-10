	.section        ".text"
	.align 4
	.global buildList
.type    buildList, #function
buildList:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l6
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l5
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l4
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l3
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l6, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l7
stw %l7, [%l0 + 0]
or %l5, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l7
stw %l7, [%l0 + 0]
or %l4, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l7
stw %l7, [%l0 + 0]
or %l3, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l7
stw %l7, [%l0 + 0]
or %l2, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l7
stw %l7, [%l0 + 0]
or %l1, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l7
stw %l7, [%l0 + 0]
or %l6, 0, %l7
or %l5, 0, %l0
stw %l0, [%l7 + 4]
or %l5, 0, %l5
or %l4, 0, %l0
stw %l0, [%l5 + 4]
or %l4, 0, %l4
or %l3, 0, %l0
stw %l0, [%l4 + 4]
or %l3, 0, %l3
or %l2, 0, %l0
stw %l0, [%l3 + 4]
or %l2, 0, %l2
or %l1, 0, %l0
stw %l0, [%l2 + 4]
or %l1, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
or %l6, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    buildList, .-buildList
	.align 4
	.global multiple
.type    multiple, #function
multiple:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
mov %i0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
.L3836:
or %l2, 0, %l4
sethi %hi(5), %l3
or %l3, %lo(5), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L3842
nop
ba %icc, .L3880
nop
.L3842:
or %l1, 0, %l3
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
mulx %l3, %l1, %l1
or %l1, 0, %l1
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
or %l1, 0, %l3
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l3, %o1
call printf
nop
or %l2, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
add %l3, %l2, %l2
or %l2, 0, %l2
ba %icc, .L3836
nop
.L3880:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    multiple, .-multiple
	.align 4
	.global add
.type    add, #function
add:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
mov %i0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
.L3912:
or %l2, 0, %l4
sethi %hi(5), %l3
or %l3, %lo(5), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L3918
nop
ba %icc, .L3956
nop
.L3918:
or %l1, 0, %l3
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
add %l3, %l1, %l1
or %l1, 0, %l1
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
or %l1, 0, %l3
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l3, %o1
call printf
nop
or %l2, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
add %l3, %l2, %l2
or %l2, 0, %l2
ba %icc, .L3912
nop
.L3956:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    add, .-add
	.align 4
	.global recurseList
.type    recurseList, #function
recurseList:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3974
nop
ba %icc, .L3981
nop
.L3974:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L3998
nop
.L3981:
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call recurseList
nop
mov %o0, %l1
mulx %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L3998
nop
.L3998:
	.size    recurseList, .-recurseList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
call buildList
nop
mov %o0, %l1
or %l1, 0, %l3
or %l3, 0, %l1
mov %l1, %o0
call multiple
nop
mov %o0, %l1
or %l1, 0, %l1
or %l3, 0, %l4
mov %l4, %o0
call add
nop
mov %o0, %l4
or %l4, 0, %l5
or %l1, 0, %l4
or %l5, 0, %l1
sra %l1, 1, %l1
sub %l4, %l1, %l1
or %l1, 0, %l1
.L4042:
or %l2, 0, %l5
sethi %hi(10000), %l4
or %l4, %lo(10000), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movl %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L4048
nop
ba %icc, .L4077
nop
.L4048:
or %l0, 0, %l0
or %l3, 0, %l4
mov %l4, %o0
call recurseList
nop
mov %o0, %l4
add %l0, %l4, %l0
or %l0, 0, %l0
or %l2, 0, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
add %l4, %l2, %l2
or %l2, 0, %l2
ba %icc, .L4042
nop
.L4077:
or %l0, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
.L4081:
or %l0, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movne %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L4087
nop
ba %icc, .L4105
nop
.L4087:
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L4081
nop
.L4105:
or %l1, 0, %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
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

