	.section        ".text"
	.align 4
	.global fun2
.type    fun2, #function
fun2:
save %sp, -104, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6555
nop
ba %icc, .L6561
nop
.L6555:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6578
nop
.L6561:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call fun2
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6578
nop
.L6578:
	.size    fun2, .-fun2
	.align 4
	.global fun1
.type    fun1, #function
fun1:
save %sp, -112, %sp
sethi %hi(5), %l1
or %l1, %lo(5), %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
add %l1, %l0, %l2
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
mov %i1, %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l1
mov %i2, %l0
add %l1, %l0, %l0
stw %l0, [%sp + 104]
ldsw [%sp + 104], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6616
nop
ba %icc, .L6627
nop
.L6616:
ldsw [%sp + 104], %l1
mov %i0, %l0
mov %l1, %o0
mov %l0, %o1
call fun2
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6661
nop
.L6627:
sethi %hi(5), %l1
or %l1, %lo(5), %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l1, %l0
movl %icc, 1, %l3
ldsw [%sp + 104], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
and %l3, %l2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L6642
nop
ba %icc, .L6653
nop
.L6642:
ldsw [%sp + 104], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call fun2
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6659
nop
.L6653:
ba %icc, .L6659
nop
.L6659:
ba %icc, .L6661
nop
.L6661:
ldsw [%sp + 104], %l0
or %l0, 0, %i0
ret
restore
	.size    fun1, .-fun1
	.align 4
	.global main
.type    main, #function
main:
save %sp, -104, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 92]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 96, %o1
call scanf
nop
ldsw [%sp + 96], %l0
stw %l0, [%sp + 92]
.L6677:
ldsw [%sp + 92], %l1
sethi %hi(10000), %l0
or %l0, %lo(10000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6683
nop
ba %icc, .L6711
nop
.L6683:
sethi %hi(3), %l2
or %l2, %lo(3), %l2
ldsw [%sp + 92], %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
mov %l2, %o0
mov %l1, %o1
mov %l0, %o2
call fun1
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 92]
ba %icc, .L6677
nop
.L6711:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common GLOBAL,4,4
	.common count,4,4
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

