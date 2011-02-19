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
or %l0, 0, %l7
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
or %l7, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
stw %l0, [%l1 + 0]
or %l6, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
stw %l0, [%l1 + 0]
or %l5, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
stw %l0, [%l1 + 0]
or %l4, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
stw %l0, [%l1 + 0]
or %l3, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l0
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l1
stw %l1, [%l0 + 0]
or %l7, 0, %l1
or %l6, 0, %l0
stw %l0, [%l1 + 4]
or %l6, 0, %l1
or %l5, 0, %l0
stw %l0, [%l1 + 4]
or %l5, 0, %l1
or %l4, 0, %l0
stw %l0, [%l1 + 4]
or %l4, 0, %l1
or %l3, 0, %l0
stw %l0, [%l1 + 4]
or %l3, 0, %l1
or %l2, 0, %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
or %l7, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    buildList, .-buildList
	.align 4
	.global multiple
.type    multiple, #function
multiple:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
mov %i0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
.L2055:
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
be %icc, .L2061
nop
ba %icc, .L2099
nop
.L2061:
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
ba %icc, .L2055
nop
.L2099:
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
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
mov %i0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
ldsw [%l1 + 0], %l1
or %l1, 0, %l1
or %l0, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l0
.L2130:
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
be %icc, .L2136
nop
ba %icc, .L2174
nop
.L2136:
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
ba %icc, .L2130
nop
.L2174:
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
be %icc, .L2191
nop
ba %icc, .L2198
nop
.L2191:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L2215
nop
.L2198:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call recurseList
nop
mov %o0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L2215
nop
.L2215:
	.size    recurseList, .-recurseList
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
sethi %hi(0), %l1
or %l1, %lo(0), %l1
or %l1, 0, %l1
call buildList
nop
mov %o0, %l2
or %l2, 0, %l3
or %l3, 0, %l2
mov %l2, %o0
call multiple
nop
mov %o0, %l2
or %l2, 0, %l4
or %l3, 0, %l2
mov %l2, %o0
call add
nop
mov %o0, %l2
or %l2, 0, %l2
or %l4, 0, %l5
or %l2, 0, %l4
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sdivx %l4, %l2, %l2
sub %l5, %l2, %l2
or %l2, 0, %l2
.L2259:
or %l0, 0, %l5
sethi %hi(10000), %l4
or %l4, %lo(10000), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movl %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L2265
nop
ba %icc, .L2294
nop
.L2265:
or %l1, 0, %l4
or %l3, 0, %l1
mov %l1, %o0
call recurseList
nop
mov %o0, %l1
add %l4, %l1, %l1
or %l1, 0, %l1
or %l0, 0, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l4, %l0, %l0
or %l0, 0, %l0
ba %icc, .L2259
nop
.L2294:
or %l1, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
.L2298:
or %l1, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l0
movne %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L2304
nop
ba %icc, .L2322
nop
.L2304:
or %l1, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
or %l0, 0, %l1
ba %icc, .L2298
nop
.L2322:
or %l2, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
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

