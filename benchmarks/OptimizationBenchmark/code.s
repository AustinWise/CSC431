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
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
or %l0, 0, %i0
ret
restore
	.size    constantFolding, .-constantFolding
	.align 4
	.global constantPropagation
.type    constantPropagation, #function
constantPropagation:
save %sp, -200, %sp
sethi %hi(4), %l0
or %l0, %lo(4), %l0
stw %l0, [%sp + 92]
sethi %hi(7), %l0
or %l0, %lo(7), %l0
stw %l0, [%sp + 96]
sethi %hi(8), %l0
or %l0, %lo(8), %l0
stw %l0, [%sp + 100]
sethi %hi(5), %l0
or %l0, %lo(5), %l0
stw %l0, [%sp + 104]
sethi %hi(11), %l0
or %l0, %lo(11), %l0
stw %l0, [%sp + 108]
sethi %hi(21), %l0
or %l0, %lo(21), %l0
stw %l0, [%sp + 112]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 124]
ldsw [%sp + 116], %l1
ldsw [%sp + 120], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 128]
ldsw [%sp + 124], %l1
ldsw [%sp + 128], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 132]
ldsw [%sp + 108], %l2
ldsw [%sp + 120], %l1
ldsw [%sp + 124], %l0
mulx %l1, %l0, %l0
add %l2, %l0, %l1
ldsw [%sp + 132], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 136]
ldsw [%sp + 120], %l2
ldsw [%sp + 124], %l1
ldsw [%sp + 128], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l2
ldsw [%sp + 132], %l1
ldsw [%sp + 136], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l0
stw %l0, [%sp + 140]
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
add %l1, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l1
ldsw [%sp + 120], %l0
add %l1, %l0, %l1
ldsw [%sp + 124], %l0
add %l1, %l0, %l1
ldsw [%sp + 128], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 144]
ldsw [%sp + 144], %l1
ldsw [%sp + 140], %l0
sub %l1, %l0, %l1
ldsw [%sp + 120], %l0
add %l1, %l0, %l1
ldsw [%sp + 92], %l0
sub %l1, %l0, %l1
ldsw [%sp + 96], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 148]
ldsw [%sp + 132], %l1
ldsw [%sp + 136], %l0
add %l1, %l0, %l1
ldsw [%sp + 116], %l0
sub %l1, %l0, %l1
ldsw [%sp + 120], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 152]
ldsw [%sp + 96], %l1
ldsw [%sp + 92], %l0
sub %l1, %l0, %l1
ldsw [%sp + 104], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 124], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 156]
ldsw [%sp + 136], %l1
ldsw [%sp + 100], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 104], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 148], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 160]
ldsw [%sp + 96], %l1
ldsw [%sp + 92], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 100], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 108], %l0
sdivx %l1, %l0, %l1
ldsw [%sp + 148], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 164]
ldsw [%sp + 124], %l1
ldsw [%sp + 132], %l0
add %l1, %l0, %l1
ldsw [%sp + 100], %l0
add %l1, %l0, %l1
ldsw [%sp + 152], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 168]
ldsw [%sp + 144], %l1
ldsw [%sp + 148], %l0
add %l1, %l0, %l2
ldsw [%sp + 112], %l1
ldsw [%sp + 92], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l0
stw %l0, [%sp + 172]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 132], %l0
sub %l1, %l0, %l1
ldsw [%sp + 136], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 176]
ldsw [%sp + 176], %l1
ldsw [%sp + 164], %l0
sub %l1, %l0, %l2
ldsw [%sp + 160], %l1
ldsw [%sp + 104], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l0
stw %l0, [%sp + 180]
ldsw [%sp + 148], %l1
ldsw [%sp + 180], %l0
sub %l1, %l0, %l1
ldsw [%sp + 176], %l0
sub %l1, %l0, %l1
ldsw [%sp + 144], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 184]
ldsw [%sp + 152], %l1
ldsw [%sp + 184], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 168], %l0
mulx %l1, %l0, %l1
ldsw [%sp + 180], %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 188]
ldsw [%sp + 180], %l2
ldsw [%sp + 184], %l1
ldsw [%sp + 188], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 132], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 192]
ldsw [%sp + 192], %l0
or %l0, 0, %i0
ret
restore
	.size    constantPropagation, .-constantPropagation
	.align 4
	.global deadCodeElimination
.type    deadCodeElimination, #function
deadCodeElimination:
save %sp, -112, %sp
sethi %hi(4), %l0
or %l0, %lo(4), %l0
stw %l0, [%sp + 92]
sethi %hi(5), %l0
or %l0, %lo(5), %l0
stw %l0, [%sp + 92]
sethi %hi(7), %l0
or %l0, %lo(7), %l0
stw %l0, [%sp + 92]
sethi %hi(8), %l0
or %l0, %lo(8), %l0
stw %l0, [%sp + 92]
sethi %hi(6), %l0
or %l0, %lo(6), %l0
stw %l0, [%sp + 96]
sethi %hi(9), %l0
or %l0, %lo(9), %l0
stw %l0, [%sp + 96]
sethi %hi(12), %l0
or %l0, %lo(12), %l0
stw %l0, [%sp + 96]
sethi %hi(8), %l0
or %l0, %lo(8), %l0
stw %l0, [%sp + 96]
sethi %hi(10), %l0
or %l0, %lo(10), %l0
stw %l0, [%sp + 100]
sethi %hi(13), %l0
or %l0, %lo(13), %l0
stw %l0, [%sp + 100]
sethi %hi(9), %l0
or %l0, %lo(9), %l0
stw %l0, [%sp + 100]
sethi %hi(45), %l0
or %l0, %lo(45), %l0
stw %l0, [%sp + 104]
sethi %hi(12), %l0
or %l0, %lo(12), %l0
stw %l0, [%sp + 104]
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%sp + 104]
sethi %hi(23), %l0
or %l0, %lo(23), %l0
stw %l0, [%sp + 108]
sethi %hi(10), %l0
or %l0, %lo(10), %l0
stw %l0, [%sp + 108]
sethi %hi(11), %l1
or %l1, %lo(11), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(5), %l1
or %l1, %lo(5), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
sethi %hi(9), %l1
or %l1, %lo(9), %l1
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
stw %l1, [%l0 + 0]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
add %l1, %l0, %l1
ldsw [%sp + 100], %l0
add %l1, %l0, %l1
ldsw [%sp + 104], %l0
add %l1, %l0, %l1
ldsw [%sp + 108], %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    deadCodeElimination, .-deadCodeElimination
	.align 4
	.global sum
.type    sum, #function
sum:
save %sp, -104, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
.L4897:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movg %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L4903
nop
ba %icc, .L4930
nop
.L4903:
ldsw [%sp + 96], %l1
mov %i0, %l0
add %l1, %l0, %l0
stw %l0, [%sp + 96]
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L4897
nop
.L4930:
ldsw [%sp + 96], %l0
or %l0, 0, %i0
ret
restore
	.size    sum, .-sum
	.align 4
	.global doesntModifyGlobals
.type    doesntModifyGlobals, #function
doesntModifyGlobals:
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 92]
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 96]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
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
stw %l0, [%sp + 92]
sethi %hi(global1), %l0
or %l0, %lo(global1), %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L4986
nop
ba %icc, .L4994
nop
.L4986:
sethi %hi(10000), %l0
or %l0, %lo(10000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ba %icc, .L5037
nop
.L4994:
sethi %hi(global2), %l0
or %l0, %lo(global2), %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5002
nop
ba %icc, .L5010
nop
.L5002:
sethi %hi(20000), %l0
or %l0, %lo(20000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ba %icc, .L5015
nop
.L5010:
ba %icc, .L5015
nop
.L5015:
sethi %hi(global3), %l0
or %l0, %lo(global3), %l0
ldsw [%l0 + 0], %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5021
nop
ba %icc, .L5029
nop
.L5021:
sethi %hi(30000), %l0
or %l0, %lo(30000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
stw %l0, [%sp + 92]
ba %icc, .L5035
nop
.L5029:
ba %icc, .L5035
nop
.L5035:
ba %icc, .L5037
nop
.L5037:
ldsw [%sp + 92], %l0
or %l0, 0, %i0
ret
restore
	.size    interProceduralOptimization, .-interProceduralOptimization
	.align 4
	.global commonSubexpressionElimination
.type    commonSubexpressionElimination, #function
commonSubexpressionElimination:
save %sp, -200, %sp
sethi %hi(11), %l0
or %l0, %lo(11), %l0
stw %l0, [%sp + 92]
sethi %hi(22), %l0
or %l0, %lo(22), %l0
stw %l0, [%sp + 96]
sethi %hi(33), %l0
or %l0, %lo(33), %l0
stw %l0, [%sp + 100]
sethi %hi(44), %l0
or %l0, %lo(44), %l0
stw %l0, [%sp + 104]
sethi %hi(55), %l0
or %l0, %lo(55), %l0
stw %l0, [%sp + 108]
sethi %hi(66), %l0
or %l0, %lo(66), %l0
stw %l0, [%sp + 112]
sethi %hi(77), %l0
or %l0, %lo(77), %l0
stw %l0, [%sp + 116]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 124]
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 128]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 132]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 136]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 140]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 144]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 148]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 152]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 156]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 160]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 164]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 168]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 172]
ldsw [%sp + 96], %l1
ldsw [%sp + 92], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 176]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 112], %l1
ldsw [%sp + 108], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 180]
ldsw [%sp + 116], %l2
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l0
stw %l0, [%sp + 184]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l2
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 188]
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
sdivx %l1, %l0, %l2
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
mulx %l1, %l0, %l0
add %l2, %l0, %l2
ldsw [%sp + 108], %l1
ldsw [%sp + 112], %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 192]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
add %l1, %l0, %l1
ldsw [%sp + 100], %l0
add %l1, %l0, %l1
ldsw [%sp + 104], %l0
add %l1, %l0, %l1
ldsw [%sp + 108], %l0
add %l1, %l0, %l1
ldsw [%sp + 112], %l0
add %l1, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l1
ldsw [%sp + 120], %l0
add %l1, %l0, %l1
ldsw [%sp + 124], %l0
add %l1, %l0, %l1
ldsw [%sp + 128], %l0
add %l1, %l0, %l1
ldsw [%sp + 132], %l0
add %l1, %l0, %l1
ldsw [%sp + 136], %l0
add %l1, %l0, %l1
ldsw [%sp + 140], %l0
add %l1, %l0, %l1
ldsw [%sp + 144], %l0
add %l1, %l0, %l1
ldsw [%sp + 148], %l0
add %l1, %l0, %l1
ldsw [%sp + 152], %l0
add %l1, %l0, %l1
ldsw [%sp + 156], %l0
add %l1, %l0, %l1
ldsw [%sp + 160], %l0
add %l1, %l0, %l1
ldsw [%sp + 164], %l0
add %l1, %l0, %l1
ldsw [%sp + 168], %l0
add %l1, %l0, %l1
ldsw [%sp + 172], %l0
add %l1, %l0, %l1
ldsw [%sp + 176], %l0
add %l1, %l0, %l1
ldsw [%sp + 180], %l0
add %l1, %l0, %l1
ldsw [%sp + 184], %l0
add %l1, %l0, %l1
ldsw [%sp + 188], %l0
add %l1, %l0, %l1
ldsw [%sp + 192], %l0
add %l1, %l0, %l0
or %l0, 0, %i0
ret
restore
	.size    commonSubexpressionElimination, .-commonSubexpressionElimination
	.align 4
	.global hoisting
.type    hoisting, #function
hoisting:
save %sp, -128, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 92]
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 96]
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%sp + 100]
sethi %hi(4), %l0
or %l0, %lo(4), %l0
stw %l0, [%sp + 104]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 124]
.L5696:
ldsw [%sp + 124], %l1
sethi %hi(1000000), %l0
or %l0, %lo(1000000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5702
nop
ba %icc, .L5750
nop
.L5702:
sethi %hi(5), %l0
or %l0, %lo(5), %l0
stw %l0, [%sp + 108]
ldsw [%sp + 92], %l1
ldsw [%sp + 96], %l0
add %l1, %l0, %l1
ldsw [%sp + 100], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 100], %l1
ldsw [%sp + 104], %l0
add %l1, %l0, %l1
ldsw [%sp + 116], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 124], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 124]
ba %icc, .L5696
nop
.L5750:
ldsw [%sp + 96], %l0
or %l0, 0, %i0
ret
restore
	.size    hoisting, .-hoisting
	.align 4
	.global doubleIf
.type    doubleIf, #function
doubleIf:
save %sp, -112, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 92]
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 96]
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%sp + 100]
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5778
nop
ba %icc, .L5821
nop
.L5778:
sethi %hi(20), %l0
or %l0, %lo(20), %l0
stw %l0, [%sp + 96]
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L5790
nop
ba %icc, .L5800
nop
.L5790:
sethi %hi(200), %l0
or %l0, %lo(200), %l0
stw %l0, [%sp + 96]
sethi %hi(300), %l0
or %l0, %lo(300), %l0
stw %l0, [%sp + 100]
ba %icc, .L5817
nop
.L5800:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 92]
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 96]
sethi %hi(3), %l0
or %l0, %lo(3), %l0
stw %l0, [%sp + 100]
ba %icc, .L5817
nop
.L5817:
sethi %hi(50), %l0
or %l0, %lo(50), %l0
stw %l0, [%sp + 104]
ba %icc, .L5826
nop
.L5821:
ba %icc, .L5826
nop
.L5826:
ldsw [%sp + 104], %l0
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
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(16), %l0
or %l0, %lo(16), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(32), %l0
or %l0, %lo(32), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(64), %l0
or %l0, %lo(64), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(128), %l0
or %l0, %lo(128), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
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
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
sethi %hi(3), %l1
or %l1, %lo(3), %l1
ldsw [%sp + 92], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sub %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(50), %l0
or %l0, %lo(50), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l1
sethi %hi(50), %l0
or %l0, %lo(50), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 92]
ldsw [%sp + 92], %l0
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
be %icc, .L6014
nop
ba %icc, .L6020
nop
.L6014:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6041
nop
.L6020:
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
ba %icc, .L6041
nop
.L6041:
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
save %sp, -104, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 92]
sethi %hi(2), %l0
or %l0, %lo(2), %l0
stw %l0, [%sp + 96]
.L6069:
ldsw [%sp + 92], %l1
sethi %hi(1000000), %l0
or %l0, %lo(1000000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6075
nop
ba %icc, .L6114
nop
.L6075:
ldsw [%sp + 96], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6083
nop
ba %icc, .L6093
nop
.L6083:
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 92]
ba %icc, .L6112
nop
.L6093:
ldsw [%sp + 92], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 92]
ba %icc, .L6112
nop
.L6112:
ba %icc, .L6069
nop
.L6114:
ldsw [%sp + 92], %l0
or %l0, 0, %i0
ret
restore
	.size    unswitching, .-unswitching
	.align 4
	.global randomCalculation
.type    randomCalculation, #function
randomCalculation:
save %sp, -128, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 116]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 120]
.L6132:
ldsw [%sp + 116], %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6139
nop
ba %icc, .L6245
nop
.L6139:
sethi %hi(4), %l0
or %l0, %lo(4), %l0
stw %l0, [%sp + 96]
sethi %hi(7), %l0
or %l0, %lo(7), %l0
stw %l0, [%sp + 100]
sethi %hi(8), %l0
or %l0, %lo(8), %l0
stw %l0, [%sp + 104]
ldsw [%sp + 96], %l1
ldsw [%sp + 100], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 108]
ldsw [%sp + 108], %l1
ldsw [%sp + 104], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 112]
ldsw [%sp + 120], %l1
ldsw [%sp + 112], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 116], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 116], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 116]
sethi %hi(3), %l1
or %l1, %lo(3), %l1
ldsw [%sp + 116], %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 116], %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 116], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mulx %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 116], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sdivx %l1, %l0, %l0
stw %l0, [%sp + 116]
ldsw [%sp + 116], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 116]
ba %icc, .L6132
nop
.L6245:
ldsw [%sp + 120], %l0
or %l0, 0, %i0
ret
restore
	.size    randomCalculation, .-randomCalculation
	.align 4
	.global iterativeFibonacci
.type    iterativeFibonacci, #function
iterativeFibonacci:
save %sp, -120, %sp
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
stw %l0, [%sp + 96]
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 100]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 108]
.L6268:
ldsw [%sp + 108], %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6275
nop
ba %icc, .L6313
nop
.L6275:
ldsw [%sp + 100], %l1
ldsw [%sp + 96], %l0
add %l1, %l0, %l0
stw %l0, [%sp + 112]
ldsw [%sp + 100], %l0
stw %l0, [%sp + 96]
ldsw [%sp + 112], %l0
stw %l0, [%sp + 100]
ldsw [%sp + 108], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 108]
ba %icc, .L6268
nop
.L6313:
ldsw [%sp + 100], %l0
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
be %icc, .L6336
nop
ba %icc, .L6342
nop
.L6336:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6365
nop
.L6342:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %o0
call recursiveFibonacci
nop
mov %o0, %l0
mov %i0, %l2
sethi %hi(2), %l1
or %l1, %lo(2), %l1
sub %l2, %l1, %l1
mov %l1, %o0
call recursiveFibonacci
nop
mov %o0, %l1
add %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L6365
nop
.L6365:
	.size    recursiveFibonacci, .-recursiveFibonacci
	.align 4
	.global main
.type    main, #function
main:
save %sp, -112, %sp
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 104, %o1
call scanf
nop
ldsw [%sp + 104], %l0
stw %l0, [%sp + 92]
sethi %hi(1), %l0
or %l0, %lo(1), %l0
stw %l0, [%sp + 100]
.L6377:
ldsw [%sp + 100], %l1
ldsw [%sp + 92], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L6384
nop
ba %icc, .L6536
nop
.L6384:
call constantFolding
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call constantPropagation
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call deadCodeElimination
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call interProceduralOptimization
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call commonSubexpressionElimination
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call hoisting
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call doubleIf
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call integerDivide
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call association
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 92], %l1
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
sdivx %l1, %l0, %l0
mov %l0, %o0
call tailRecursion
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
call unswitching
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 92], %l0
mov %l0, %o0
call randomCalculation
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 92], %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sdivx %l1, %l0, %l0
mov %l0, %o0
call iterativeFibonacci
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 92], %l1
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
sdivx %l1, %l0, %l0
mov %l0, %o0
call recursiveFibonacci
nop
mov %o0, %l0
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ldsw [%sp + 100], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%sp + 100]
ba %icc, .L6377
nop
.L6536:
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

