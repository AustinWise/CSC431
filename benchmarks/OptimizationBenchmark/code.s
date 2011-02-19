	.section        ".text"
	.align 4
	.global constantFolding
.type    constantFolding, #function
constantFolding:
save %sp, -96, %sp
sethi %hi(8), %l1
or %l1, %lo(8), %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mulx %l1, %l0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sdivx %l1, %l0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l2
sethi %hi(5), %l1
or %l1, %lo(5), %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
add %l1, %l0, %l1
sethi %hi(12), %l0
or %l0, %lo(12), %l0
sub %l1, %l0, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
add %l1, %l0, %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
sub %l1, %l0, %l1
sethi %hi(18), %l0
or %l0, %lo(18), %l0
sub %l1, %l0, %l2
sethi %hi(23), %l1
or %l1, %lo(23), %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mulx %l1, %l0, %l1
sethi %hi(23), %l0
or %l0, %lo(23), %l0
sdivx %l1, %l0, %l1
sethi %hi(90), %l0
or %l0, %lo(90), %l0
mulx %l1, %l0, %l0
add %l2, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    constantFolding, .-constantFolding
	.align 4
	.global constantPropagation
.type    constantPropagation, #function
constantPropagation:
save %sp, -136, %sp
sethi %hi(4), %l0
or %l0, %lo(4), %l0
or %l0, 0, %l1
stw %l1, [%sp + 132]
sethi %hi(7), %l0
or %l0, %lo(7), %l0
or %l0, 0, %l0
stw %l0, [%sp + 124]
sethi %hi(8), %l0
or %l0, %lo(8), %l0
or %l0, 0, %l0
stw %l0, [%sp + 116]
sethi %hi(5), %l0
or %l0, %lo(5), %l0
or %l0, 0, %l1
stw %l1, [%sp + 112]
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %l0
stw %l0, [%sp + 108]
sethi %hi(21), %l0
or %l0, %lo(21), %l0
or %l0, 0, %l0
stw %l0, [%sp + 100]
ldsw [%sp + 132], %l1
or %l1, 0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l5
ldsw [%sp + 116], %l0
or %l0, 0, %l2
ldsw [%sp + 112], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l4
ldsw [%sp + 108], %l0
or %l0, 0, %l1
ldsw [%sp + 100], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 96]
or %l5, 0, %l1
or %l4, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ldsw [%sp + 96], %l1
or %l1, 0, %l1
or %l3, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 108], %l0
or %l0, 0, %l0
or %l4, 0, %l2
ldsw [%sp + 96], %l1
or %l1, 0, %l1
mulx %l2, %l1, %l1
add %l0, %l1, %l1
ldsw [%sp + 92], %l0
or %l0, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 104]
or %l4, 0, %l0
ldsw [%sp + 96], %l1
or %l1, 0, %l2
or %l3, 0, %l1
mulx %l2, %l1, %l1
sub %l0, %l1, %l1
ldsw [%sp + 92], %l0
or %l0, 0, %l2
ldsw [%sp + 104], %l0
or %l0, 0, %l0
sdivx %l2, %l0, %l0
add %l1, %l0, %l0
or %l0, 0, %l2
ldsw [%sp + 108], %l0
or %l0, 0, %l1
ldsw [%sp + 100], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
or %l5, 0, %l0
add %l1, %l0, %l1
or %l4, 0, %l0
add %l1, %l0, %l6
ldsw [%sp + 96], %l1
or %l1, 0, %l0
add %l6, %l0, %l1
or %l3, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 120], %l0
or %l0, 0, %l1
or %l2, 0, %l0
sub %l1, %l0, %l1
or %l4, 0, %l0
add %l1, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 128]
ldsw [%sp + 92], %l0
or %l0, 0, %l1
ldsw [%sp + 104], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
or %l5, 0, %l0
sub %l1, %l0, %l1
or %l4, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l6
ldsw [%sp + 124], %l0
or %l0, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sub %l2, %l0, %l2
ldsw [%sp + 112], %l1
or %l1, 0, %l0
mulx %l2, %l0, %l2
ldsw [%sp + 96], %l1
or %l1, 0, %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
ldsw [%sp + 104], %l0
or %l0, 0, %l1
ldsw [%sp + 116], %l0
or %l0, 0, %l0
mulx %l1, %l0, %l2
ldsw [%sp + 112], %l1
or %l1, 0, %l0
mulx %l2, %l0, %l1
ldsw [%sp + 128], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l5
ldsw [%sp + 124], %l0
or %l0, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
mulx %l2, %l0, %l1
ldsw [%sp + 116], %l0
or %l0, 0, %l0
mulx %l1, %l0, %l1
ldsw [%sp + 108], %l0
or %l0, 0, %l0
sdivx %l1, %l0, %l1
ldsw [%sp + 128], %l0
or %l0, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l3
ldsw [%sp + 96], %l1
or %l1, 0, %l1
ldsw [%sp + 92], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 116], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
or %l6, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l4
ldsw [%sp + 120], %l0
or %l0, 0, %l1
ldsw [%sp + 128], %l0
or %l0, 0, %l0
add %l1, %l0, %l2
ldsw [%sp + 100], %l0
or %l0, 0, %l0
ldsw [%sp + 132], %l1
or %l1, 0, %l1
mulx %l0, %l1, %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
ldsw [%sp + 132], %l1
or %l1, 0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
mulx %l1, %l0, %l1
ldsw [%sp + 92], %l0
or %l0, 0, %l0
sub %l1, %l0, %l1
ldsw [%sp + 104], %l0
or %l0, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
or %l3, 0, %l0
sub %l1, %l0, %l0
or %l5, 0, %l3
ldsw [%sp + 112], %l1
or %l1, 0, %l1
mulx %l3, %l1, %l1
sub %l0, %l1, %l0
or %l0, 0, %l1
ldsw [%sp + 128], %l0
or %l0, 0, %l3
or %l1, 0, %l0
sub %l3, %l0, %l3
or %l2, 0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 120], %l0
or %l0, 0, %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
or %l6, 0, %l3
or %l0, 0, %l2
mulx %l3, %l2, %l3
or %l4, 0, %l2
mulx %l3, %l2, %l3
or %l1, 0, %l2
sub %l3, %l2, %l2
or %l2, 0, %l3
or %l1, 0, %l2
or %l0, 0, %l1
or %l3, 0, %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 92], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    constantPropagation, .-constantPropagation
	.align 4
	.global deadCodeElimination
.type    deadCodeElimination, #function
deadCodeElimination:
save %sp, -96, %sp
sethi %hi(4), %l0
or %l0, %lo(4), %l0
or %l0, 0, %l4
sethi %hi(5), %l0
or %l0, %lo(5), %l0
or %l0, 0, %l4
sethi %hi(7), %l0
or %l0, %lo(7), %l0
or %l0, 0, %l4
sethi %hi(8), %l0
or %l0, %lo(8), %l0
or %l0, 0, %l4
sethi %hi(6), %l0
or %l0, %lo(6), %l0
or %l0, 0, %l3
sethi %hi(9), %l0
or %l0, %lo(9), %l0
or %l0, 0, %l3
sethi %hi(12), %l0
or %l0, %lo(12), %l0
or %l0, 0, %l3
sethi %hi(8), %l0
or %l0, %lo(8), %l0
or %l0, 0, %l3
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %l2
sethi %hi(13), %l0
or %l0, %lo(13), %l0
or %l0, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
or %l0, 0, %l2
sethi %hi(45), %l0
or %l0, %lo(45), %l0
or %l0, 0, %l1
sethi %hi(12), %l0
or %l0, %lo(12), %l0
or %l0, 0, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l1
sethi %hi(23), %l0
or %l0, %lo(23), %l0
or %l0, 0, %l0
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %l0
sethi %hi(11), %l6
or %l6, %lo(11), %l6
sethi %hi(global1), %l5
or %l5, %lo(global1), %l5
stw %l6, [%l5 + 0]
sethi %hi(5), %l6
or %l6, %lo(5), %l6
sethi %hi(global1), %l5
or %l5, %lo(global1), %l5
stw %l6, [%l5 + 0]
sethi %hi(9), %l6
or %l6, %lo(9), %l6
sethi %hi(global1), %l5
or %l5, %lo(global1), %l5
stw %l6, [%l5 + 0]
or %l4, 0, %l4
or %l3, 0, %l3
add %l4, %l3, %l3
or %l2, 0, %l2
add %l3, %l2, %l2
or %l1, 0, %l1
add %l2, %l1, %l1
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    deadCodeElimination, .-deadCodeElimination
	.align 4
	.global sum
.type    sum, #function
sum:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L4685:
mov %i0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
movg %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L4691
nop
ba %icc, .L4718
nop
.L4691:
or %l0, 0, %l1
mov %i0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
mov %i0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sub %l2, %l1, %l1
mov %l1, %i0
ba %icc, .L4685
nop
.L4718:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    sum, .-sum
	.align 4
	.global doesntModifyGlobals
.type    doesntModifyGlobals, #function
doesntModifyGlobals:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l0
or %l1, 0, %l1
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    doesntModifyGlobals, .-doesntModifyGlobals
	.align 4
	.global interProceduralOptimization
.type    interProceduralOptimization, #function
interProceduralOptimization:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(global2), %l0
or %l0, %lo(global2), %l0
stw %l1, [%l0 + 0]
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(global3), %l0
or %l0, %lo(global3), %l0
stw %l1, [%l0 + 0]
sethi %hi(100), %l0
or %l0, %lo(100), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l0
sethi %hi(global1), %l1
or %l1, %lo(global1), %l1
ldsw [%l1 + 0], %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
move %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L4774
nop
ba %icc, .L4782
nop
.L4774:
sethi %hi(10000), %l0
or %l0, %lo(10000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l0
ba %icc, .L4825
nop
.L4782:
sethi %hi(global2), %l1
or %l1, %lo(global2), %l1
ldsw [%l1 + 0], %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
move %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L4790
nop
ba %icc, .L4798
nop
.L4790:
sethi %hi(20000), %l0
or %l0, %lo(20000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l0
ba %icc, .L4803
nop
.L4798:
ba %icc, .L4803
nop
.L4803:
sethi %hi(global3), %l1
or %l1, %lo(global3), %l1
ldsw [%l1 + 0], %l2
sethi %hi(3), %l1
or %l1, %lo(3), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l1
move %icc, 1, %l3
sethi %hi(1), %l1
or %l1, %lo(1), %l1
cmp %l3, %l1
be %icc, .L4809
nop
ba %icc, .L4817
nop
.L4809:
sethi %hi(30000), %l0
or %l0, %lo(30000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l0
ba %icc, .L4823
nop
.L4817:
ba %icc, .L4823
nop
.L4823:
ba %icc, .L4825
nop
.L4825:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    interProceduralOptimization, .-interProceduralOptimization
	.align 4
	.global commonSubexpressionElimination
.type    commonSubexpressionElimination, #function
commonSubexpressionElimination:
save %sp, -176, %sp
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %l6
sethi %hi(22), %l0
or %l0, %lo(22), %l0
or %l0, 0, %l2
stw %l2, [%sp + 168]
sethi %hi(33), %l0
or %l0, %lo(33), %l0
or %l0, 0, %l1
stw %l1, [%sp + 164]
sethi %hi(44), %l0
or %l0, %lo(44), %l0
or %l0, 0, %l1
stw %l1, [%sp + 156]
sethi %hi(55), %l0
or %l0, %lo(55), %l0
or %l0, 0, %l2
stw %l2, [%sp + 152]
sethi %hi(66), %l0
or %l0, %lo(66), %l0
or %l0, 0, %l2
stw %l2, [%sp + 136]
sethi %hi(77), %l0
or %l0, %lo(77), %l0
or %l0, 0, %l1
stw %l1, [%sp + 132]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 128]
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 120]
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 112]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 104]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 100]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 96]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 92]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 108]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 116]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 124]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 144]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 140]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 148]
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 160]
ldsw [%sp + 168], %l2
or %l2, 0, %l1
or %l6, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
ldsw [%sp + 136], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l5
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l1
sdivx %l2, %l1, %l1
add %l0, %l1, %l0
ldsw [%sp + 136], %l2
or %l2, 0, %l3
ldsw [%sp + 152], %l2
or %l2, 0, %l1
mulx %l3, %l1, %l1
sub %l0, %l1, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l1
stw %l1, [%sp + 172]
ldsw [%sp + 132], %l1
or %l1, 0, %l3
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
add %l3, %l0, %l0
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l1
sdivx %l2, %l1, %l1
add %l0, %l1, %l0
ldsw [%sp + 152], %l2
or %l2, 0, %l3
ldsw [%sp + 136], %l2
or %l2, 0, %l1
mulx %l3, %l1, %l1
sub %l0, %l1, %l0
or %l0, 0, %l4
or %l6, 0, %l1
ldsw [%sp + 168], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l1
sdivx %l2, %l1, %l1
add %l0, %l1, %l0
ldsw [%sp + 152], %l2
or %l2, 0, %l3
ldsw [%sp + 136], %l2
or %l2, 0, %l1
mulx %l3, %l1, %l1
sub %l0, %l1, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l3
ldsw [%sp + 164], %l1
or %l1, 0, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l1
or %l6, 0, %l0
ldsw [%sp + 168], %l2
or %l2, 0, %l2
mulx %l0, %l2, %l0
add %l1, %l0, %l1
ldsw [%sp + 152], %l2
or %l2, 0, %l0
ldsw [%sp + 136], %l2
or %l2, 0, %l2
mulx %l0, %l2, %l0
sub %l1, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l0
or %l6, 0, %l6
ldsw [%sp + 168], %l2
or %l2, 0, %l1
add %l6, %l1, %l2
ldsw [%sp + 164], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 156], %l1
or %l1, 0, %l1
add %l2, %l1, %l6
ldsw [%sp + 152], %l2
or %l2, 0, %l1
add %l6, %l1, %l6
ldsw [%sp + 136], %l2
or %l2, 0, %l1
add %l6, %l1, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 128], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 120], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 112], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 104], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 100], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 96], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 92], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 108], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 116], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 124], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 144], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 140], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 148], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 160], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
or %l5, 0, %l1
add %l2, %l1, %l2
ldsw [%sp + 172], %l1
or %l1, 0, %l1
add %l2, %l1, %l2
or %l4, 0, %l1
add %l2, %l1, %l2
or %l3, 0, %l1
add %l2, %l1, %l1
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    commonSubexpressionElimination, .-commonSubexpressionElimination
	.align 4
	.global hoisting
.type    hoisting, #function
hoisting:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l5
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l4
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l3
sethi %hi(4), %l0
or %l0, %lo(4), %l0
or %l0, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
.L5484:
or %l1, 0, %l7
sethi %hi(1000000), %l6
or %l6, %lo(1000000), %l6
sethi %hi(0), %l0
or %l0, %lo(0), %l0
cmp %l7, %l6
movl %icc, 1, %l0
sethi %hi(1), %l6
or %l6, %lo(1), %l6
cmp %l0, %l6
be %icc, .L5490
nop
ba %icc, .L5538
nop
.L5490:
sethi %hi(5), %l0
or %l0, %lo(5), %l0
or %l0, 0, %l0
or %l5, 0, %l6
or %l4, 0, %l0
add %l6, %l0, %l6
or %l3, 0, %l0
add %l6, %l0, %l0
or %l0, 0, %l0
or %l3, 0, %l7
or %l2, 0, %l6
add %l7, %l6, %l6
or %l0, 0, %l0
add %l6, %l0, %l0
or %l0, 0, %l0
or %l1, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l1
ba %icc, .L5484
nop
.L5538:
or %l4, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    hoisting, .-hoisting
	.align 4
	.global doubleIf
.type    doubleIf, #function
doubleIf:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
or %l1, 0, %l1
sethi %hi(2), %l2
or %l2, %lo(2), %l2
or %l2, 0, %l2
sethi %hi(3), %l2
or %l2, %lo(3), %l2
or %l2, 0, %l2
or %l1, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L5566
nop
ba %icc, .L5609
nop
.L5566:
sethi %hi(20), %l0
or %l0, %lo(20), %l0
or %l0, 0, %l2
or %l1, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5578
nop
ba %icc, .L5588
nop
.L5578:
sethi %hi(200), %l0
or %l0, %lo(200), %l0
or %l0, 0, %l2
sethi %hi(300), %l0
or %l0, %lo(300), %l0
or %l0, 0, %l2
ba %icc, .L5605
nop
.L5588:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l2
ba %icc, .L5605
nop
.L5605:
sethi %hi(50), %l0
or %l0, %lo(50), %l0
or %l0, 0, %l0
ba %icc, .L5614
nop
.L5609:
ba %icc, .L5614
nop
.L5614:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    doubleIf, .-doubleIf
	.align 4
	.global integerDivide
.type    integerDivide, #function
integerDivide:
save %sp, -96, %sp
sethi %hi(3000), %l0
or %l0, %lo(3000), %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(16), %l0
or %l0, %lo(16), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(32), %l0
or %l0, %lo(32), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(64), %l0
or %l0, %lo(64), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(128), %l0
or %l0, %lo(128), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    integerDivide, .-integerDivide
	.align 4
	.global association
.type    association, #function
association:
save %sp, -96, %sp
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
sethi %hi(3), %l1
or %l1, %lo(3), %l1
or %l0, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sub %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(50), %l0
or %l0, %lo(50), %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l1
sethi %hi(50), %l0
or %l0, %lo(50), %l0
sdivx %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    association, .-association
	.align 4
	.global tailRecursionHelper
.type    tailRecursionHelper, #function
tailRecursionHelper:
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
be %icc, .L5802
nop
ba %icc, .L5808
nop
.L5802:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L5829
nop
.L5808:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l2
mov %i1, %l1
mov %i0, %l0
add %l1, %l0, %l0
mov %l2, %o0
mov %l0, %o1
call tailRecursionHelper
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L5829
nop
.L5829:
	.size    tailRecursionHelper, .-tailRecursionHelper
	.align 4
	.global tailRecursion
.type    tailRecursion, #function
tailRecursion:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l1, %o0
mov %l0, %o1
call tailRecursionHelper
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    tailRecursion, .-tailRecursion
	.align 4
	.global unswitching
.type    unswitching, #function
unswitching:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l0
.L5857:
or %l1, 0, %l3
sethi %hi(1000000), %l2
or %l2, %lo(1000000), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movl %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L5863
nop
ba %icc, .L5902
nop
.L5863:
or %l0, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L5871
nop
ba %icc, .L5881
nop
.L5871:
or %l1, 0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l2, %l1, %l1
or %l1, 0, %l1
ba %icc, .L5900
nop
.L5881:
or %l1, 0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
add %l2, %l1, %l1
or %l1, 0, %l1
ba %icc, .L5900
nop
.L5900:
ba %icc, .L5857
nop
.L5902:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    unswitching, .-unswitching
	.align 4
	.global randomCalculation
.type    randomCalculation, #function
randomCalculation:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L5920:
or %l1, 0, %l3
mov %i0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movl %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L5927
nop
ba %icc, .L6033
nop
.L5927:
sethi %hi(4), %l2
or %l2, %lo(4), %l2
or %l2, 0, %l4
sethi %hi(7), %l2
or %l2, %lo(7), %l2
or %l2, 0, %l3
sethi %hi(8), %l2
or %l2, %lo(8), %l2
or %l2, 0, %l2
or %l4, 0, %l4
or %l3, 0, %l3
add %l4, %l3, %l3
or %l3, 0, %l3
or %l3, 0, %l3
or %l2, 0, %l2
add %l3, %l2, %l2
or %l2, 0, %l3
or %l0, 0, %l2
or %l3, 0, %l0
add %l2, %l0, %l0
or %l0, 0, %l0
or %l1, 0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
mulx %l2, %l1, %l1
or %l1, 0, %l1
or %l1, 0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sdivx %l2, %l1, %l1
or %l1, 0, %l1
sethi %hi(3), %l2
or %l2, %lo(3), %l2
or %l1, 0, %l1
mulx %l2, %l1, %l1
or %l1, 0, %l1
or %l1, 0, %l2
sethi %hi(3), %l1
or %l1, %lo(3), %l1
sdivx %l2, %l1, %l1
or %l1, 0, %l1
or %l1, 0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
mulx %l2, %l1, %l1
or %l1, 0, %l1
or %l1, 0, %l2
sethi %hi(4), %l1
or %l1, %lo(4), %l1
sdivx %l2, %l1, %l1
or %l1, 0, %l1
or %l1, 0, %l2
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l2, %l1, %l1
or %l1, 0, %l1
ba %icc, .L5920
nop
.L6033:
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    randomCalculation, .-randomCalculation
	.align 4
	.global iterativeFibonacci
.type    iterativeFibonacci, #function
iterativeFibonacci:
save %sp, -96, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L6056:
or %l0, 0, %l4
mov %i0, %l3
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l3
movl %icc, 1, %l5
sethi %hi(1), %l3
or %l3, %lo(1), %l3
cmp %l5, %l3
be %icc, .L6063
nop
ba %icc, .L6101
nop
.L6063:
or %l1, 0, %l3
or %l2, 0, %l2
add %l3, %l2, %l2
or %l2, 0, %l3
or %l1, 0, %l1
or %l1, 0, %l2
or %l3, 0, %l1
or %l1, 0, %l1
or %l0, 0, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l3, %l0, %l0
or %l0, 0, %l0
ba %icc, .L6056
nop
.L6101:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    iterativeFibonacci, .-iterativeFibonacci
	.align 4
	.global recursiveFibonacci
.type    recursiveFibonacci, #function
recursiveFibonacci:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l1, %l0
movle %icc, 1, %l3
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
or %l3, %l2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L6124
nop
ba %icc, .L6130
nop
.L6124:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6153
nop
.L6130:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %o0
call recursiveFibonacci
nop
mov %o0, %l2
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sub %l1, %l0, %l0
mov %l0, %o0
call recursiveFibonacci
nop
mov %o0, %l0
add %l2, %l0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6153
nop
.L6153:
	.size    recursiveFibonacci, .-recursiveFibonacci
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
or %l0, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l0
.L6165:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movl %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L6172
nop
ba %icc, .L6324
nop
.L6172:
call constantFolding
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call constantPropagation
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call deadCodeElimination
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call interProceduralOptimization
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call commonSubexpressionElimination
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call hoisting
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call doubleIf
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call integerDivide
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call association
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(1000), %l2
or %l2, %lo(1000), %l2
sdivx %l3, %l2, %l2
mov %l2, %o0
call tailRecursion
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
call unswitching
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l2
mov %l2, %o0
call randomCalculation
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(5), %l2
or %l2, %lo(5), %l2
sdivx %l3, %l2, %l2
mov %l2, %o0
call iterativeFibonacci
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l1, 0, %l3
sethi %hi(1000), %l2
or %l2, %lo(1000), %l2
sdivx %l3, %l2, %l2
mov %l2, %o0
call recursiveFibonacci
nop
mov %o0, %l2
or %l2, 0, %l2
or %l2, 0, %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l0
ba %icc, .L6165
nop
.L6324:
sethi %hi(9999), %l0
or %l0, %lo(9999), %l0
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
	.common global1,4,4
	.common global2,4,4
	.common global3,4,4
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

