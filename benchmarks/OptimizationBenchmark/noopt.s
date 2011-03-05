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
save %sp, -96, %sp
sethi %hi(4), %l0
or %l0, %lo(4), %l0
or %l0, 0, %o5
sethi %hi(7), %l0
or %l0, %lo(7), %l0
or %l0, 0, %o4
sethi %hi(8), %l0
or %l0, %lo(8), %l0
or %l0, 0, %l7
sethi %hi(5), %l0
or %l0, %lo(5), %l0
or %l0, 0, %g4
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %l5
sethi %hi(21), %l0
or %l0, %lo(21), %l0
or %l0, 0, %o3
or %o5, 0, %l1
or %o4, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l3
or %l7, 0, %l1
or %g4, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l2
or %l5, 0, %l1
or %o3, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l6
or %l3, 0, %l1
or %l2, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l1
or %l6, 0, %l4
or %l1, 0, %l0
mulx %l4, %l0, %l0
or %l0, 0, %g5
or %l5, 0, %o1
or %l2, 0, %l4
or %l6, 0, %l0
mulx %l4, %l0, %l0
add %o1, %l0, %l4
or %g5, 0, %l0
sub %l4, %l0, %l0
or %l0, 0, %o2
or %l2, 0, %o1
or %l6, 0, %l4
or %l1, 0, %l0
mulx %l4, %l0, %l0
sub %o1, %l0, %o1
or %g5, 0, %l4
or %o2, 0, %l0
sdivx %l4, %l0, %l0
add %o1, %l0, %l0
or %l0, 0, %l0
or %l5, 0, %o1
or %o3, 0, %l4
add %o1, %l4, %o1
or %l3, 0, %l4
add %o1, %l4, %o1
or %l2, 0, %l4
add %o1, %l4, %o1
or %l6, 0, %l4
add %o1, %l4, %l4
or %l1, 0, %l1
sub %l4, %l1, %l1
or %l1, 0, %g1
or %g1, 0, %l1
or %l0, 0, %l0
sub %l1, %l0, %l1
or %l2, 0, %l0
add %l1, %l0, %l1
or %o5, 0, %l0
sub %l1, %l0, %l1
or %o4, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %o1
or %g5, 0, %l1
or %o2, 0, %l0
add %l1, %l0, %l1
or %l3, 0, %l0
sub %l1, %l0, %l1
or %l2, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l4
or %o4, 0, %l1
or %o5, 0, %l0
sub %l1, %l0, %l1
or %g4, 0, %l0
mulx %l1, %l0, %l1
or %l6, 0, %l0
sub %l1, %l0, %l0
or %l0, 0, %l0
or %o2, 0, %l1
or %l7, 0, %l0
mulx %l1, %l0, %l1
or %g4, 0, %l0
mulx %l1, %l0, %l1
or %o1, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l1
or %o4, 0, %l2
or %o5, 0, %l0
mulx %l2, %l0, %l2
or %l7, 0, %l0
mulx %l2, %l0, %l2
or %l5, 0, %l0
sdivx %l2, %l0, %l2
or %o1, 0, %l0
sub %l2, %l0, %l0
or %l0, 0, %l0
or %l6, 0, %l3
or %g5, 0, %l2
add %l3, %l2, %l3
or %l7, 0, %l2
add %l3, %l2, %l3
or %l4, 0, %l2
sub %l3, %l2, %l2
or %l2, 0, %l3
or %g1, 0, %l5
or %o1, 0, %l2
add %l5, %l2, %l6
or %o3, 0, %l5
or %o5, 0, %l2
mulx %l5, %l2, %l2
sub %l6, %l2, %l2
or %l2, 0, %l2
or %o5, 0, %l5
or %o4, 0, %l2
mulx %l5, %l2, %l5
or %g5, 0, %l2
sub %l5, %l2, %l5
or %o2, 0, %l2
sub %l5, %l2, %l2
or %l2, 0, %l2
or %l2, 0, %l5
or %l0, 0, %l0
sub %l5, %l0, %l5
or %l1, 0, %l1
or %g4, 0, %l0
mulx %l1, %l0, %l0
sub %l5, %l0, %l0
or %l0, 0, %l0
or %o1, 0, %l5
or %l0, 0, %l1
sub %l5, %l1, %l5
or %l2, 0, %l1
sub %l5, %l1, %l2
or %g1, 0, %l1
sub %l2, %l1, %l1
or %l1, 0, %l5
or %l4, 0, %l2
or %l5, 0, %l1
mulx %l2, %l1, %l2
or %l3, 0, %l1
mulx %l2, %l1, %l2
or %l0, 0, %l1
sub %l2, %l1, %l1
or %l1, 0, %l3
or %l0, 0, %l2
or %l5, 0, %l1
or %l3, 0, %l0
mulx %l1, %l0, %l0
sub %l2, %l0, %l1
or %g5, 0, %l0
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
or %l0, 0, %l3
.L20119:
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
be %icc, .L20125
nop
ba %icc, .L20152
nop
.L20125:
or %l3, 0, %l1
mov %i0, %l0
add %l1, %l0, %l0
or %l0, 0, %l3
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i0
ba %icc, .L20119
nop
.L20152:
or %l3, 0, %l0
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
or %l0, 0, %l3
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
be %icc, .L20208
nop
ba %icc, .L20216
nop
.L20208:
sethi %hi(10000), %l0
or %l0, %lo(10000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
ba %icc, .L20259
nop
.L20216:
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
be %icc, .L20224
nop
ba %icc, .L20232
nop
.L20224:
sethi %hi(20000), %l0
or %l0, %lo(20000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
ba %icc, .L20237
nop
.L20232:
ba %icc, .L20237
nop
.L20237:
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
be %icc, .L20243
nop
ba %icc, .L20251
nop
.L20243:
sethi %hi(30000), %l0
or %l0, %lo(30000), %l0
mov %l0, %o0
call sum
nop
mov %o0, %l0
or %l0, 0, %l3
ba %icc, .L20257
nop
.L20251:
ba %icc, .L20257
nop
.L20257:
ba %icc, .L20259
nop
.L20259:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    interProceduralOptimization, .-interProceduralOptimization
	.align 4
	.global commonSubexpressionElimination
.type    commonSubexpressionElimination, #function
commonSubexpressionElimination:
save %sp, -144, %sp
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %g5
sethi %hi(22), %l0
or %l0, %lo(22), %l0
or %l0, 0, %l2
stw %l2, [%sp + 140]
sethi %hi(33), %l0
or %l0, %lo(33), %l0
or %l0, 0, %l1
stw %l1, [%sp + 136]
sethi %hi(44), %l0
or %l0, %lo(44), %l0
or %l0, 0, %l1
stw %l1, [%sp + 132]
sethi %hi(55), %l0
or %l0, %lo(55), %l0
or %l0, 0, %g4
sethi %hi(66), %l0
or %l0, %lo(66), %l0
or %l0, 0, %l2
stw %l2, [%sp + 128]
sethi %hi(77), %l0
or %l0, %lo(77), %l0
or %l0, 0, %l0
stw %l0, [%sp + 124]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 120]
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
or %l0, 0, %g1
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 116]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 96]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 92]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 100]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 104]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 108]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l0
stw %l0, [%sp + 112]
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %o5
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %o4
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %o3
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %o2
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %o1
ldsw [%sp + 140], %l2
or %l2, 0, %l1
or %g5, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l7
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l3
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l0
add %l3, %l0, %l3
ldsw [%sp + 128], %l2
or %l2, 0, %l1
or %g4, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l6
ldsw [%sp + 124], %l0
or %l0, 0, %l3
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
add %l3, %l0, %l0
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l1
sdivx %l2, %l1, %l1
add %l0, %l1, %l3
or %g4, 0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
sub %l3, %l0, %l0
or %l0, 0, %l5
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
mulx %l1, %l0, %l0
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l1
sdivx %l2, %l1, %l1
add %l0, %l1, %l0
or %g4, 0, %l3
ldsw [%sp + 128], %l2
or %l2, 0, %l1
mulx %l3, %l1, %l1
sub %l0, %l1, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ldsw [%sp + 136], %l1
or %l1, 0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
sdivx %l2, %l0, %l1
or %g5, 0, %l0
ldsw [%sp + 140], %l2
or %l2, 0, %l2
mulx %l0, %l2, %l0
add %l1, %l0, %l1
or %g4, 0, %l0
ldsw [%sp + 128], %l2
or %l2, 0, %l2
mulx %l0, %l2, %l0
sub %l1, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l3
or %g5, 0, %l1
ldsw [%sp + 140], %l2
or %l2, 0, %l0
add %l1, %l0, %l2
ldsw [%sp + 136], %l1
or %l1, 0, %l0
add %l2, %l0, %l2
ldsw [%sp + 132], %l1
or %l1, 0, %l0
add %l2, %l0, %l1
or %g4, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 128], %l2
or %l2, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 124], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 120], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
or %g1, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 116], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 96], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 92], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 100], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 104], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 108], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
ldsw [%sp + 112], %l0
or %l0, 0, %l0
add %l1, %l0, %l1
or %o5, 0, %l0
add %l1, %l0, %l1
or %o4, 0, %l0
add %l1, %l0, %l1
or %o3, 0, %l0
add %l1, %l0, %l1
or %o2, 0, %l0
add %l1, %l0, %l1
or %o1, 0, %l0
add %l1, %l0, %l1
or %l7, 0, %l0
add %l1, %l0, %l1
or %l6, 0, %l0
add %l1, %l0, %l1
or %l5, 0, %l0
add %l1, %l0, %l1
or %l4, 0, %l0
add %l1, %l0, %l1
or %l3, 0, %l0
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
or %l0, 0, %l4
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l3
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l2
sethi %hi(4), %l0
or %l0, %lo(4), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l0
.L20918:
or %l0, 0, %l6
sethi %hi(1000000), %l5
or %l5, %lo(1000000), %l5
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l5
movl %icc, 1, %l7
sethi %hi(1), %l5
or %l5, %lo(1), %l5
cmp %l7, %l5
be %icc, .L20924
nop
ba %icc, .L20972
nop
.L20924:
sethi %hi(5), %l5
or %l5, %lo(5), %l5
or %l5, 0, %l5
or %l4, 0, %l6
or %l3, 0, %l5
add %l6, %l5, %l6
or %l2, 0, %l5
add %l6, %l5, %l5
or %l5, 0, %l7
or %l2, 0, %l6
or %l1, 0, %l5
add %l6, %l5, %l6
or %l7, 0, %l5
add %l6, %l5, %l5
or %l5, 0, %l5
or %l0, 0, %l5
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l5, %l0, %l0
or %l0, 0, %l0
ba %icc, .L20918
nop
.L20972:
or %l3, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    hoisting, .-hoisting
	.align 4
	.global doubleIf
.type    doubleIf, #function
doubleIf:
save %sp, -96, %sp
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l4
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l0
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l0
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21000
nop
ba %icc, .L21043
nop
.L21000:
sethi %hi(20), %l0
or %l0, %lo(20), %l0
or %l0, 0, %l0
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21012
nop
ba %icc, .L21022
nop
.L21012:
sethi %hi(200), %l0
or %l0, %lo(200), %l0
or %l0, 0, %l0
sethi %hi(300), %l0
or %l0, %lo(300), %l0
or %l0, 0, %l0
ba %icc, .L21039
nop
.L21022:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l4
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l0
sethi %hi(3), %l0
or %l0, %lo(3), %l0
or %l0, 0, %l0
ba %icc, .L21039
nop
.L21039:
sethi %hi(50), %l0
or %l0, %lo(50), %l0
or %l0, 0, %l3
ba %icc, .L21048
nop
.L21043:
ba %icc, .L21048
nop
.L21048:
or %l3, 0, %l0
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
be %icc, .L21236
nop
ba %icc, .L21242
nop
.L21236:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L21263
nop
.L21242:
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
ba %icc, .L21263
nop
.L21263:
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
or %l0, 0, %l4
sethi %hi(2), %l0
or %l0, %lo(2), %l0
or %l0, 0, %l3
.L21291:
or %l4, 0, %l1
sethi %hi(1000000), %l0
or %l0, %lo(1000000), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21297
nop
ba %icc, .L21336
nop
.L21297:
or %l3, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21305
nop
ba %icc, .L21315
nop
.L21305:
or %l4, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ba %icc, .L21334
nop
.L21315:
or %l4, 0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
add %l1, %l0, %l0
or %l0, 0, %l4
ba %icc, .L21334
nop
.L21334:
ba %icc, .L21291
nop
.L21336:
or %l4, 0, %l0
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
.L21354:
or %l1, 0, %l3
mov %i0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movl %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L21361
nop
ba %icc, .L21467
nop
.L21361:
sethi %hi(4), %l2
or %l2, %lo(4), %l2
or %l2, 0, %l3
sethi %hi(7), %l2
or %l2, %lo(7), %l2
or %l2, 0, %l5
sethi %hi(8), %l2
or %l2, %lo(8), %l2
or %l2, 0, %l4
or %l3, 0, %l3
or %l5, 0, %l2
add %l3, %l2, %l2
or %l2, 0, %l2
or %l2, 0, %l3
or %l4, 0, %l2
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
ba %icc, .L21354
nop
.L21467:
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
or %l0, 0, %l5
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %l4
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l3
.L21490:
or %l3, 0, %l1
mov %i0, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L21497
nop
ba %icc, .L21535
nop
.L21497:
or %l4, 0, %l1
or %l5, 0, %l0
add %l1, %l0, %l0
or %l0, 0, %l1
or %l4, 0, %l0
or %l0, 0, %l5
or %l1, 0, %l0
or %l0, 0, %l4
or %l3, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
or %l0, 0, %l3
ba %icc, .L21490
nop
.L21535:
or %l4, 0, %l0
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
be %icc, .L21558
nop
ba %icc, .L21564
nop
.L21558:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L21587
nop
.L21564:
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
ba %icc, .L21587
nop
.L21587:
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
.L21599:
or %l0, 0, %l3
or %l1, 0, %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movl %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L21606
nop
ba %icc, .L21758
nop
.L21606:
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
ba %icc, .L21599
nop
.L21758:
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

