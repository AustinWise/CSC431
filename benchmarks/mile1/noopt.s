	.section        ".text"
	.align 4
	.global calcPower
.type    calcPower, #function
calcPower:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l3
.L19297:
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L19303
nop
ba %icc, .L19330
nop
.L19303:
or %l3, 0, %l1
mov %i0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l3
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
ba %icc, .L19297
nop
.L19330:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    calcPower, .-calcPower
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l5
or %l2, 0, %l3
or %l5, 0, %l0
stw %l0, [%l3 + 0]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l5
or %l5, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l0
movl %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L19360
nop
ba %icc, .L19366
nop
.L19360:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L19371
nop
.L19366:
ba %icc, .L19371
nop
.L19371:
or %l2, 0, %l3
or %l5, 0, %l0
stw %l0, [%l3 + 4]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L19381:
or %l0, 0, %l4
sethi %hi(1000000), %l3
or %l3, %lo(1000000), %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L19387
nop
ba %icc, .L19417
nop
.L19387:
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l2, 0, %l1
ldsw [%l1 + 0], %l3
or %l2, 0, %l1
ldsw [%l1 + 4], %l1
mov %l3, %o0
mov %l1, %o1
call calcPower
nop
mov %o0, %l1
or %l1, 0, %l1
ba %icc, .L19381
nop
.L19417:
or %l1, 0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(1), %l0
or %l0, %lo(1), %l0
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

