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
be %icc, .L10594
nop
ba %icc, .L10600
nop
.L10594:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L10617
nop
.L10600:
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
ba %icc, .L10617
nop
.L10617:
	.size    fun2, .-fun2
	.align 4
	.global fun1
.type    fun1, #function
fun1:
save %sp, -104, %sp
sethi %hi(11), %l1
or %l1, %lo(11), %l1
mov %i0, %l0
sll %l0, 1, %l0
sub %l1, %l0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
mov %i1, %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l1
mov %i2, %l0
add %l1, %l0, %l0
or %l0, 0, %l4
or %l4, 0, %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L10655
nop
ba %icc, .L10666
nop
.L10655:
or %l4, 0, %l1
mov %i0, %l0
mov %l1, %o0
mov %l0, %o1
call fun2
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L10700
nop
.L10666:
sethi %hi(5), %l1
or %l1, %lo(5), %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l1, %l0
movl %icc, 1, %l3
or %l4, 0, %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
and %l3, %l2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L10681
nop
ba %icc, .L10692
nop
.L10681:
or %l4, 0, %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call fun2
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L10698
nop
.L10692:
ba %icc, .L10698
nop
.L10698:
ba %icc, .L10700
nop
.L10700:
or %l4, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    fun1, .-fun1
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
.L10716:
or %l0, 0, %l2
sethi %hi(10000), %l1
or %l1, %lo(10000), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movl %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L10722
nop
ba %icc, .L10750
nop
.L10722:
sethi %hi(3), %l3
or %l3, %lo(3), %l3
or %l0, 0, %l2
sethi %hi(5), %l1
or %l1, %lo(5), %l1
mov %l3, %o0
mov %l2, %o1
mov %l1, %o2
call fun1
nop
mov %o0, %l1
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l1, %o1
call printf
nop
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l0
ba %icc, .L10716
nop
.L10750:
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

