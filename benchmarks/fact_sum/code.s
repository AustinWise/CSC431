	.section        ".text"
	.align 4
	.global sum
.type    sum, #function
sum:
save %sp, -96, %sp
mov %i0, %l1
mov %i1, %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    sum, .-sum
	.align 4
	.global fact
.type    fact, #function
fact:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l1, %l0
move %icc, 1, %l3
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
or %l3, %l2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L3609
nop
ba %icc, .L3614
nop
.L3609:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L3619
nop
.L3614:
ba %icc, .L3619
nop
.L3619:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3625
nop
ba %icc, .L3637
nop
.L3625:
sethi %hi(-1), %l1
or %l1, %lo(-1), %l1
mov %i0, %l0
mulx %l1, %l0, %l0
mov %l0, %o0
call fact
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L3642
nop
.L3637:
ba %icc, .L3642
nop
.L3642:
mov %i0, %l0
mov %i0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
mov %l1, %o0
call fact
nop
mov %o0, %l1
mulx %l0, %l1, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    fact, .-fact
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
.L3670:
or %l0, 0, %l1
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L3677
nop
ba %icc, .L3733
nop
.L3677:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l1
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l1, 0, %l1
mov %l1, %o0
call fact
nop
mov %o0, %l1
or %l1, 0, %l1
or %l0, 0, %l0
mov %l0, %o0
call fact
nop
mov %o0, %l0
or %l0, 0, %l0
or %l1, 0, %l1
or %l0, 0, %l0
mov %l1, %o0
mov %l0, %o1
call sum
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
ba %icc, .L3670
nop
.L3733:
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

