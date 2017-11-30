using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A088324
{
public static readonly long[] Value={ 0L,5L,3L,2L,2L,0L,1428571L,0L,11L,0L,0L,83L,7L,7L,0L,0L,5L,5L,5L,5L,47L,0L,43L,41L,0L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,19L,19L,0L,1851851L,181L,17L,17L,17L,0L,0L,163L,1612903L,1587301L,0L,1538461L,151L,149L,0L,0L,1428571L,0L,13L,13L,13L,13L,13L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088324Inst : IEnumerable<long>
{
public static readonly long[] Value=A088324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088324.Bytes);
public long this[int i]=>Value[i];

public static A088324Inst Instance=new A088324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088227
{
public static readonly long[] Value={ 2L,6L,7L,11L,15L,19L,20L,24L,28L,32L,33L,37L,41L,45L,46L,50L,54L,58L,59L,63L,67L,71L,72L,76L,80L,84L,85L,89L,93L,97L,98L,102L,106L,110L,111L,115L,119L,123L,124L,128L,132L,136L,137L,141L,145L,149L,150L,154L,158L,162L,163L,167L,171L,175L,176L,180L,184L,188L,189L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088227Inst : IEnumerable<long>
{
public static readonly long[] Value=A088227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088227.Bytes);
public long this[int i]=>Value[i];

public static A088227Inst Instance=new A088227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088226
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,1L,1L,2L,0L,3L,1L,2L,2L,1L,3L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,0L,6L,1L,5L,2L,4L,3L,3L,4L,2L,5L,1L,6L,0L,7L,1L,6L,2L,5L,3L,4L,4L,3L,5L,2L,6L,1L,7L,0L,8L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,6L,2L,7L,1L,8L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,0L,10L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088226Inst : IEnumerable<long>
{
public static readonly long[] Value=A088226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088226.Bytes);
public long this[int i]=>Value[i];

public static A088226Inst Instance=new A088226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088225
{
public static readonly long[] Value={ 2L,6L,7L,8L,13L,17L,18L,19L,24L,28L,29L,30L,35L,39L,40L,41L,46L,50L,51L,52L,57L,61L,62L,63L,68L,72L,73L,74L,79L,83L,84L,85L,90L,94L,95L,96L,101L,105L,106L,107L,112L,116L,117L,118L,123L,127L,128L,129L,134L,138L,139L,140L,145L,149L,150L,151L,156L,160L,161L,162L,167L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088225Inst : IEnumerable<long>
{
public static readonly long[] Value=A088225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088225.Bytes);
public long this[int i]=>Value[i];

public static A088225Inst Instance=new A088225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088224
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088224Inst : IEnumerable<long>
{
public static readonly long[] Value=A088224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088224.Bytes);
public long this[int i]=>Value[i];

public static A088224Inst Instance=new A088224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088223
{
public static readonly BigInteger[] Value={ 1L,2L,3L,12L,93L,1032L,14655L,251688L,5052909L,115925904L,2990175786L,85643490420L,2697023236056L,92629652495280L,3446174110482327L,138077674608686544L,5928227839749416895L,BigInteger.Parse("271538262681756156768") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088223Inst Instance=new A088223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088222
{
public static readonly BigInteger[] Value={ 1L,2L,3L,10L,69L,678L,8496L,128316L,2258262L,45292494L,1018882779L,25399668480L,694999352141L,20710476430548L,667708554093132L,23159551588872624L,860001996926543616L,BigInteger.Parse("34043670528120810846"),BigInteger.Parse("1431191816223150995395") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088222Inst Instance=new A088222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088221
{
public static readonly BigInteger[] Value={ 1L,2L,3L,10L,63L,558L,6226L,82836L,1272555L,22103638L,427715118L,9118752300L,212335628550L,5362040637900L,145970732893284L,4261945511044520L,132868133756374707L,4405535689300995942L,BigInteger.Parse("154819142574597555670") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088221Inst Instance=new A088221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088220
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,24L,75L,252L,903L,3376L,13068L,51960L,211222L,874440L,3676335L,15660680L,67474980L,293617248L,1288876879L,5701688928L,25397905302L,113838544880L,513117505278L,2324638603980L,10580591966824L,48362627748240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088220Inst : IEnumerable<long>
{
public static readonly long[] Value=A088220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088220.Bytes);
public long this[int i]=>Value[i];

public static A088220Inst Instance=new A088220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088219
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,6L,12L,29L,64L,114L,404L,641L,2637L,3289L,15853L,22068L,98168L,164238L,547111L,1292502L,3020056L,10442124L,15954682L,79385179L,89229089L,576106142L,595912173L,3848976774L,4853522881L,23699101223L,44768315427L,132700765034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088219Inst : IEnumerable<long>
{
public static readonly long[] Value=A088219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088219.Bytes);
public long this[int i]=>Value[i];

public static A088219Inst Instance=new A088219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088218
{
public static readonly long[] Value={ 1L,1L,3L,10L,35L,126L,462L,1716L,6435L,24310L,92378L,352716L,1352078L,5200300L,20058300L,77558760L,300540195L,1166803110L,4537567650L,17672631900L,68923264410L,269128937220L,1052049481860L,4116715363800L,16123801841550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088218Inst : IEnumerable<long>
{
public static readonly long[] Value=A088218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088218.Bytes);
public long this[int i]=>Value[i];

public static A088218Inst Instance=new A088218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088217
{
public static readonly long[] Value={ 1L,6L,777L,79455L,13602389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088217Inst : IEnumerable<long>
{
public static readonly long[] Value=A088217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088217.Bytes);
public long this[int i]=>Value[i];

public static A088217Inst Instance=new A088217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088216
{
public static readonly long[] Value={ 0L,324L,38831L,6773999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088216Inst : IEnumerable<long>
{
public static readonly long[] Value=A088216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088216.Bytes);
public long this[int i]=>Value[i];

public static A088216Inst Instance=new A088216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088215
{
public static readonly long[] Value={ 76L,32L,18L,30L,14L,47L,30L,25L,10L,41L,20L,42L,32L,25L,16L,36L,14L,31L,39L,28L,35L,39L,20L,22L,18L,33L,19L,45L,12L,21L,37L,26L,15L,41L,25L,37L,29L,27L,18L,34L,22L,24L,23L,24L,17L,48L,16L,16L,18L,15L,25L,35L,16L,21L,36L,43L,11L,30L,5L,18L,31L,17L,13L,28L,11L,42L,35L,24L,13L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088215Inst : IEnumerable<long>
{
public static readonly long[] Value=A088215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088215.Bytes);
public long this[int i]=>Value[i];

public static A088215Inst Instance=new A088215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088214
{
public static readonly long[] Value={ 324L,329L,355L,357L,358L,362L,364L,365L,367L,373L,375L,378L,381L,383L,386L,387L,394L,397L,399L,401L,403L,406L,409L,411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088214Inst : IEnumerable<long>
{
public static readonly long[] Value=A088214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088214.Bytes);
public long this[int i]=>Value[i];

public static A088214Inst Instance=new A088214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088213
{
public static readonly long[] Value={ 5L,11L,7L,13L,41L,31L,11L,17L,13L,19L,47L,37L,17L,23L,19L,41L,53L,43L,23L,29L,37L,31L,59L,73L,29L,107L,31L,37L,173L,79L,47L,41L,37L,43L,71L,61L,41L,47L,43L,89L,617L,67L,47L,53L,61L,71L,83L,73L,53L,59L,67L,61L,89L,79L,59L,137L,61L,67L,383L,109L,97L,71L,67L,73L,101L,691L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088213Inst : IEnumerable<long>
{
public static readonly long[] Value=A088213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088213.Bytes);
public long this[int i]=>Value[i];

public static A088213Inst Instance=new A088213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088212
{
public static readonly long[] Value={ 2L,3L,2L,3L,6L,5L,2L,3L,2L,3L,6L,5L,2L,3L,2L,5L,6L,5L,2L,3L,4L,3L,6L,7L,2L,9L,2L,3L,12L,7L,4L,3L,2L,3L,6L,5L,2L,3L,2L,7L,24L,5L,2L,3L,4L,5L,6L,5L,2L,3L,4L,3L,6L,5L,2L,9L,2L,3L,18L,7L,6L,3L,2L,3L,6L,25L,2L,9L,2L,3L,6L,5L,4L,3L,2L,5L,6L,5L,2L,3L,4L,5L,12L,5L,2L,9L,4L,3L,12L,7L,4L,3L,2L,3L,6L,19L,2L,3L,2L,3L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088212Inst : IEnumerable<long>
{
public static readonly long[] Value=A088212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088212.Bytes);
public long this[int i]=>Value[i];

public static A088212Inst Instance=new A088212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088195
{
public static readonly long[] Value={ 3L,3L,3L,7L,3L,3L,3L,7L,3L,11L,7L,3L,7L,11L,3L,11L,7L,3L,3L,3L,3L,7L,17L,7L,3L,3L,3L,3L,3L,3L,13L,3L,11L,3L,7L,3L,11L,3L,3L,3L,3L,3L,13L,3L,11L,3L,3L,3L,3L,3L,11L,7L,11L,13L,3L,7L,7L,11L,7L,3L,3L,11L,19L,3L,11L,3L,3L,11L,17L,3L,11L,3L,7L,3L,13L,3L,3L,3L,3L,11L,11L,3L,3L,3L,3L,13L,19L,3L,3L,3L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088195Inst : IEnumerable<long>
{
public static readonly long[] Value=A088195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088195.Bytes);
public long this[int i]=>Value[i];

public static A088195Inst Instance=new A088195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088194
{
public static readonly long[] Value={ 0L,0L,0L,-1L,0L,0L,0L,0L,0L,-5L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-10L,-1L,0L,0L,0L,0L,0L,0L,-7L,0L,-4L,0L,-1L,0L,-5L,0L,0L,0L,0L,0L,-7L,0L,-4L,0L,0L,0L,0L,0L,-4L,0L,0L,-2L,0L,-1L,0L,-5L,0L,0L,0L,0L,-8L,0L,0L,0L,0L,-4L,-11L,0L,0L,0L,-1L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,-5L,0L,0L,0L,0L,-5L,0L,0L,-5L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088194Inst : IEnumerable<long>
{
public static readonly long[] Value=A088194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088194.Bytes);
public long this[int i]=>Value[i];

public static A088194Inst Instance=new A088194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088193
{
public static readonly long[] Value={ 3L,7L,31L,71L,103L,151L,199L,239L,271L,311L,359L,463L,599L,719L,823L,839L,911L,1063L,1231L,1279L,1303L,1439L,1559L,1871L,1879L,1951L,1999L,2143L,2239L,2311L,2351L,2383L,2399L,2551L,2711L,2791L,3191L,3391L,3463L,3559L,3583L,3823L,3911L,3919L,4079L,4159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088193Inst : IEnumerable<long>
{
public static readonly long[] Value=A088193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088193.Bytes);
public long this[int i]=>Value[i];

public static A088193Inst Instance=new A088193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088192
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,1L,2L,5L,1L,3L,1L,1L,2L,5L,1L,2L,1L,2L,7L,1L,3L,2L,1L,1L,1L,3L,2L,1L,1L,3L,2L,1L,2L,1L,3L,1L,2L,5L,1L,2L,1L,7L,1L,1L,3L,2L,3L,2L,1L,1L,7L,1L,2L,1L,5L,1L,3L,1L,1L,2L,1L,2L,11L,1L,1L,2L,1L,2L,1L,1L,7L,3L,1L,2L,5L,1L,1L,1L,1L,2L,1L,7L,1L,3L,2L,1L,1L,1L,3L,2L,13L,3L,2L,2L,5L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088192Inst : IEnumerable<long>
{
public static readonly long[] Value=A088192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088192.Bytes);
public long this[int i]=>Value[i];

public static A088192Inst Instance=new A088192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088191
{
public static readonly long[] Value={ 0L,3L,0L,5L,3L,4L,1L,1L,10L,0L,8L,4L,1L,1L,10L,5L,3L,5L,-1L,8L,4L,5L,7L,8L,4L,0L,5L,3L,4L,12L,5L,7L,1L,11L,0L,8L,5L,1L,10L,5L,3L,4L,8L,4L,0L,13L,11L,5L,3L,4L,0L,8L,9L,7L,2L,10L,0L,8L,4L,1L,11L,13L,-5L,12L,4L,13L,7L,9L,3L,4L,0L,12L,8L,5L,1L,10L,8L,4L,8L,9L,3L,4L,8L,4L,5L,7L,8L,4L,0L,5L,1L,18L,5L,8L,1L,10L,12L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088191Inst : IEnumerable<long>
{
public static readonly long[] Value=A088191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088191.Bytes);
public long this[int i]=>Value[i];

public static A088191Inst Instance=new A088191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088190
{
public static readonly long[] Value={ 1L,1L,4L,4L,9L,12L,16L,17L,18L,28L,28L,36L,40L,41L,42L,52L,57L,60L,65L,64L,72L,76L,81L,88L,96L,100L,100L,105L,108L,112L,124L,129L,136L,137L,148L,148L,156L,161L,162L,172L,177L,180L,184L,192L,196L,196L,209L,220L,225L,228L,232L,232L,240L,249L,256L,258L,268L,268L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088190Inst : IEnumerable<long>
{
public static readonly long[] Value=A088190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088190.Bytes);
public long this[int i]=>Value[i];

public static A088190Inst Instance=new A088190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088189
{
public static readonly BigInteger[] Value={ 2L,10L,73L,712L,8681L,127004L,2167789L,42287088L,928006801L,22628305012L,606939739253L,17759375280200L,562952693773081L,19217673118604172L,702899000556953437L,BigInteger.Parse("27422924828816762848"),BigInteger.Parse("1136746326170994466337") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088189Inst Instance=new A088189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088188
{
public static readonly long[] Value={ 81L,46225L,151321L,588289L,769129L,1108809L,1692601L,2283121L,3367225L,6195121L,9715689L,12341169L,14814801L,18344089L,18983449L,20657025L,35271721L,38551681L,38775529L,48511225L,50993881L,54597321L,60730849L,63059481L,80156209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088188Inst : IEnumerable<long>
{
public static readonly long[] Value=A088188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088188.Bytes);
public long this[int i]=>Value[i];

public static A088188Inst Instance=new A088188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088187
{
public static readonly long[] Value={ 13L,19L,257L,443L,487L,1031L,1103L,1901L,2069L,2383L,2411L,2549L,2969L,2999L,3307L,3433L,3449L,4493L,4861L,4931L,5209L,5471L,5939L,6257L,6421L,7129L,8167L,8369L,8951L,9151L,9311L,9391L,9461L,9619L,9689L,10181L,12323L,12457L,12791L,13309L,14797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088187Inst : IEnumerable<long>
{
public static readonly long[] Value=A088187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088187.Bytes);
public long this[int i]=>Value[i];

public static A088187Inst Instance=new A088187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088186
{
public static readonly long[] Value={ 13L,19L,35L,51L,81L,111L,155L,185L,257L,273L,343L,371L,443L,471L,487L,555L,585L,655L,685L,753L,835L,1003L,1031L,1103L,1241L,1349L,1419L,1463L,1517L,1561L,1901L,1929L,1945L,2013L,2069L,2383L,2411L,2453L,2481L,2549L,2685L,2863L,2969L,2999L,3029L,3071L,3307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088186Inst : IEnumerable<long>
{
public static readonly long[] Value=A088186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088186.Bytes);
public long this[int i]=>Value[i];

public static A088186Inst Instance=new A088186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088185
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,36L,38L,40L,42L,45L,48L,50L,52L,54L,56L,60L,62L,66L,70L,72L,78L,80L,84L,90L,96L,105L,108L,110L,120L,126L,132L,138L,140L,150L,180L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088185Inst : IEnumerable<long>
{
public static readonly long[] Value=A088185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088185.Bytes);
public long this[int i]=>Value[i];

public static A088185Inst Instance=new A088185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088184
{
public static readonly long[] Value={ 13L,19L,23L,25L,29L,31L,34L,35L,37L,39L,41L,43L,44L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,63L,64L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,104L,106L,107L,109L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088184Inst : IEnumerable<long>
{
public static readonly long[] Value=A088184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088184.Bytes);
public long this[int i]=>Value[i];

public static A088184Inst Instance=new A088184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088183
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,3L,0L,0L,1L,1L,0L,2L,0L,2L,0L,2L,0L,4L,1L,0L,1L,4L,0L,2L,0L,1L,0L,3L,0L,4L,0L,1L,2L,5L,0L,6L,0L,1L,3L,1L,0L,4L,1L,3L,0L,6L,0L,5L,3L,1L,2L,3L,0L,5L,0L,3L,2L,7L,0L,1L,3L,4L,1L,4L,0L,6L,2L,2L,3L,6L,0L,7L,1L,4L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088183Inst : IEnumerable<long>
{
public static readonly long[] Value=A088183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088183.Bytes);
public long this[int i]=>Value[i];

public static A088183Inst Instance=new A088183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088182
{
public static readonly BigInteger[] Value={ 2L,9L,61L,550L,6201L,83894L,1324177L,23886552L,484745029L,10930266652L,271107065043L,7335664739264L,215030576905171L,6788059632853620L,229590704738375917L,8283076586956304128L,BigInteger.Parse("317510426598228001881") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088182Inst Instance=new A088182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088181
{
public static readonly BigInteger[] Value={ 1L,2L,8L,49L,400L,4081L,49964L,713665L,11649936L,213946513L,4365604372L,97988751433L,2399366732888L,63647177397961L,1818219651069852L,55651486523443537L,1816920458689600288L,BigInteger.Parse("63026617425620098465") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088181Inst Instance=new A088181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088180
{
public static readonly long[] Value={ 1L,5L,19L,112L,368L,2161L,7033L,41140L,133730L,781884L,2541197L,14856466L,48283738L,282274893L,917394087L,5363229225L,17430497086L,101901374524L,331179473681L,1936126175213L,6292410089388L,36786397511512L,119555791973835L,698941553280624L,2271560048351176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088180Inst : IEnumerable<long>
{
public static readonly long[] Value=A088180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088180.Bytes);
public long this[int i]=>Value[i];

public static A088180Inst Instance=new A088180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088179
{
public static readonly long[] Value={ 2L,7L,11L,23L,47L,59L,83L,107L,167L,179L,211L,227L,263L,331L,347L,359L,383L,463L,467L,479L,503L,547L,563L,571L,587L,691L,719L,839L,859L,863L,887L,911L,967L,983L,1019L,1123L,1187L,1231L,1283L,1291L,1303L,1307L,1319L,1327L,1367L,1439L,1483L,1487L,1523L,1619L,1723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088179Inst : IEnumerable<long>
{
public static readonly long[] Value=A088179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088179.Bytes);
public long this[int i]=>Value[i];

public static A088179Inst Instance=new A088179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088178
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,5L,10L,8L,12L,9L,15L,20L,16L,24L,18L,21L,7L,11L,22L,14L,28L,32L,40L,25L,30L,36L,42L,35L,45L,27L,33L,44L,48L,60L,50L,70L,49L,56L,64L,72L,54L,66L,55L,65L,13L,17L,34L,26L,39L,51L,68L,52L,78L,84L,98L,63L,81L,90L,80L,88L,77L,91L,104L,96L,108L,99L,110L,100L,120L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088178Inst : IEnumerable<long>
{
public static readonly long[] Value=A088178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088178.Bytes);
public long this[int i]=>Value[i];

public static A088178Inst Instance=new A088178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088177
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,5L,2L,4L,3L,3L,5L,4L,4L,6L,3L,7L,1L,11L,2L,7L,4L,8L,5L,5L,6L,6L,7L,5L,9L,3L,11L,4L,12L,5L,10L,7L,7L,8L,8L,9L,6L,11L,5L,13L,1L,17L,2L,13L,3L,17L,4L,13L,6L,14L,7L,9L,9L,10L,8L,11L,7L,13L,8L,12L,9L,11L,10L,10L,12L,11L,11L,13L,9L,14L,8L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088177Inst : IEnumerable<long>
{
public static readonly long[] Value=A088177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088177.Bytes);
public long this[int i]=>Value[i];

public static A088177Inst Instance=new A088177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088176
{
public static readonly long[] Value={ 7L,11L,17L,23L,37L,47L,67L,79L,107L,113L,149L,157L,191L,197L,211L,233L,251L,277L,293L,317L,353L,431L,439L,467L,541L,577L,607L,631L,647L,673L,821L,827L,839L,863L,887L,1031L,1039L,1061L,1069L,1097L,1163L,1237L,1283L,1297L,1307L,1327L,1433L,1459L,1487L,1493L,1613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088176Inst : IEnumerable<long>
{
public static readonly long[] Value=A088176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088176.Bytes);
public long this[int i]=>Value[i];

public static A088176Inst Instance=new A088176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088175
{
public static readonly long[] Value={ 2L,3L,7L,13L,23L,37L,53L,67L,97L,103L,131L,139L,173L,181L,193L,223L,233L,263L,277L,307L,337L,409L,421L,457L,509L,563L,593L,613L,631L,653L,797L,811L,823L,853L,877L,1013L,1021L,1039L,1051L,1087L,1129L,1223L,1259L,1283L,1297L,1307L,1423L,1447L,1471L,1483L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088175Inst : IEnumerable<long>
{
public static readonly long[] Value=A088175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088175.Bytes);
public long this[int i]=>Value[i];

public static A088175Inst Instance=new A088175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088174
{
public static readonly long[] Value={ 1L,2L,4L,6L,18L,30L,36L,78L,90L,114L,120L,132L,138L,144L,150L,156L,162L,168L,192L,210L,216L,222L,246L,264L,288L,306L,312L,318L,336L,372L,396L,462L,564L,606L,624L,630L,642L,648L,654L,678L,714L,738L,774L,792L,810L,816L,840L,864L,918L,936L,1002L,1020L,1038L,1062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088174Inst : IEnumerable<long>
{
public static readonly long[] Value=A088174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088174.Bytes);
public long this[int i]=>Value[i];

public static A088174Inst Instance=new A088174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088173
{
public static readonly long[] Value={ 2L,3L,7L,23L,59L,383L,1283L,2579L,8663L,16763L,29759L,44159L,61583L,80627L,101363L,123863L,148199L,174443L,202667L,239531L,283631L,330287L,379571L,440087L,509783L,592727L,686363L,783707L,884831L,997727L,1136111L,1292927L,1506371L,1824467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088173Inst : IEnumerable<long>
{
public static readonly long[] Value=A088173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088173.Bytes);
public long this[int i]=>Value[i];

public static A088173Inst Instance=new A088173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088172
{
public static readonly long[] Value={ 1L,2L,3L,7L,13L,26L,53L,106L,211L,422L,845L,1689L,3379L,6758L,13515L,27031L,54061L,108122L,216245L,432489L,864979L,1729958L,3459915L,6919830L,13839661L,27679322L,55358643L,110717287L,221434573L,442869146L,885738293L,1771476586L,3542953171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088172Inst : IEnumerable<long>
{
public static readonly long[] Value=A088172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088172.Bytes);
public long this[int i]=>Value[i];

public static A088172Inst Instance=new A088172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088171
{
public static readonly long[] Value={ 121L,1111L,11011L,12221L,110011L,121121L,1100011L,1112111L,1197801L,1208911L,1210121L,1211111L,1222221L,11000011L,11111111L,11988801L,12098911L,12100121L,12101111L,12211221L,110000011L,110121011L,111089011L,111101111L,111111011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088171Inst : IEnumerable<long>
{
public static readonly long[] Value=A088171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088171.Bytes);
public long this[int i]=>Value[i];

public static A088171Inst Instance=new A088171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088170
{
public static readonly long[] Value={ 10L,12L,14L,16L,18L,110L,132L,143L,154L,165L,176L,187L,198L,1009L,1010L,1029L,1030L,1049L,1050L,1069L,1070L,1089L,1090L,1110L,1130L,1131L,1150L,1151L,1170L,1171L,1190L,1191L,1211L,1212L,1231L,1232L,1251L,1252L,1271L,1272L,1291L,1292L,1312L,1313L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088170Inst : IEnumerable<long>
{
public static readonly long[] Value=A088170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088170.Bytes);
public long this[int i]=>Value[i];

public static A088170Inst Instance=new A088170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088169
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,141L,161L,181L,201L,202L,221L,222L,241L,242L,261L,262L,281L,282L,302L,303L,322L,323L,342L,343L,362L,363L,382L,383L,403L,404L,423L,424L,443L,444L,463L,464L,483L,484L,504L,505L,524L,525L,544L,545L,564L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088169Inst : IEnumerable<long>
{
public static readonly long[] Value=A088169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088169.Bytes);
public long this[int i]=>Value[i];

public static A088169Inst Instance=new A088169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088168
{
public static readonly long[] Value={ 1L,3L,4L,39L,6L,15L,10L,12L,16L,22L,20L,18L,75L,38L,32L,24L,52L,44L,36L,297L,30L,575L,50L,40L,76L,399L,231L,48L,66L,615L,70L,98L,134L,88L,104L,441L,60L,80L,100L,84L,72L,108L,136L,1085L,90L,112L,96L,214L,152L,132L,585L,154L,156L,126L,174L,176L,196L,170L,186L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088168Inst : IEnumerable<long>
{
public static readonly long[] Value=A088168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088168.Bytes);
public long this[int i]=>Value[i];

public static A088168Inst Instance=new A088168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088167
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,2L,5L,3L,7L,2L,8L,2L,8L,6L,9L,2L,12L,2L,11L,5L,10L,2L,16L,5L,10L,5L,11L,2L,21L,2L,15L,6L,12L,8L,19L,2L,14L,4L,24L,2L,21L,2L,18L,11L,15L,2L,28L,3L,23L,5L,17L,2L,24L,11L,24L,6L,17L,2L,37L,2L,19L,9L,24L,8L,29L,2L,23L,7L,31L,2L,41L,2L,23L,13L,25L,8L,29L,2L,38L,7L,24L,2L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088167Inst : IEnumerable<long>
{
public static readonly long[] Value=A088167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088167.Bytes);
public long this[int i]=>Value[i];

public static A088167Inst Instance=new A088167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088166
{
public static readonly long[] Value={ 12L,72L,504L,3410L,23184L,159094L,1089648L,7465176L,51170460L,350713222L,2403763488L,16475700746L,112925875764L,774004377960L,5305106018016L,36361732975514L,249227005939632L,1708227330997438L,11708364225400920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088166Inst : IEnumerable<long>
{
public static readonly long[] Value=A088166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088166.Bytes);
public long this[int i]=>Value[i];

public static A088166Inst Instance=new A088166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088165
{
public static readonly BigInteger[] Value={ 7L,41L,239L,9369319L,63018038201L,489133282872437279L,BigInteger.Parse("19175002942688032928599"),BigInteger.Parse("123426017006182806728593424683999798008235734137469123231828679") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088165Inst Instance=new A088165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088164
{
public static readonly long[] Value={ 16843L,2124679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088164Inst : IEnumerable<long>
{
public static readonly long[] Value=A088164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088164.Bytes);
public long this[int i]=>Value[i];

public static A088164Inst Instance=new A088164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088147
{
public static readonly long[] Value={ 1L,3L,3L,7L,7L,11L,3L,7L,15L,27L,31L,11L,19L,23L,31L,43L,55L,59L,7L,15L,19L,31L,39L,51L,67L,75L,79L,87L,91L,99L,127L,7L,19L,23L,43L,47L,59L,71L,79L,91L,103L,107L,127L,131L,139L,143L,167L,191L,199L,203L,211L,223L,227L,247L,3L,15L,27L,31L,43L,51L,55L,75L,103L,111L,115L,123L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088147Inst : IEnumerable<long>
{
public static readonly long[] Value=A088147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088147.Bytes);
public long this[int i]=>Value[i];

public static A088147Inst Instance=new A088147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088146
{
public static readonly long[] Value={ 1L,3L,6L,7L,13L,14L,24L,25L,27L,30L,31L,50L,52L,53L,55L,58L,61L,62L,97L,99L,100L,103L,105L,108L,112L,114L,115L,117L,118L,120L,127L,193L,196L,197L,202L,203L,206L,209L,211L,214L,217L,218L,223L,224L,226L,227L,233L,239L,241L,242L,244L,247L,248L,253L,384L,387L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088146Inst : IEnumerable<long>
{
public static readonly long[] Value=A088146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088146.Bytes);
public long this[int i]=>Value[i];

public static A088146Inst Instance=new A088146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088145
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,4L,3L,6L,6L,4L,6L,8L,6L,13L,12L,15L,8L,10L,15L,12L,14L,21L,20L,16L,20L,18L,27L,18L,24L,19L,27L,32L,24L,36L,22L,24L,28L,46L,42L,46L,24L,42L,32L,42L,35L,27L,34L,58L,36L,56L,53L,32L,52L,64L,71L,66L,39L,44L,48L,48L,72L,48L,66L,48L,78L,44L,48L,88L,56L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088145Inst : IEnumerable<long>
{
public static readonly long[] Value=A088145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088145.Bytes);
public long this[int i]=>Value[i];

public static A088145Inst Instance=new A088145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088144
{
public static readonly long[] Value={ 1L,2L,5L,8L,23L,26L,68L,57L,139L,174L,123L,222L,328L,257L,612L,636L,886L,488L,669L,1064L,876L,1105L,1744L,1780L,1552L,2020L,1853L,2890L,1962L,2712L,2413L,3536L,4384L,3335L,5364L,3322L,3768L,4564L,7683L,7266L,8235L,4344L,8021L,6176L,8274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088144Inst : IEnumerable<long>
{
public static readonly long[] Value=A088144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088144.Bytes);
public long this[int i]=>Value[i];

public static A088144Inst Instance=new A088144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088143
{
public static readonly BigInteger[] Value={ 1L,7L,47L,35398L,283L,23598775598298873L,2L,17699L,15732517L,BigInteger.Parse("1415926535897932384626433832795"),12872L,BigInteger.Parse("117993877991494365385536152732919"),1089174258383L,1L,943951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088143Inst Instance=new A088143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088142
{
public static readonly long[] Value={ 3L,10L,50L,116L,560L,1730L,6123L,30122L,116908L,507277L,2492737L,15328119L,56182092L,441156796L,2093130576L,15965840718L,77353276330L,693400983344L,3517825829117L,35126205660152L,187347585491624L,1952969742765476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088142Inst : IEnumerable<long>
{
public static readonly long[] Value=A088142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088142.Bytes);
public long this[int i]=>Value[i];

public static A088142Inst Instance=new A088142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088141
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088141Inst : IEnumerable<long>
{
public static readonly long[] Value=A088141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088141.Bytes);
public long this[int i]=>Value[i];

public static A088141Inst Instance=new A088141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088140
{
public static readonly long[] Value={ 2L,1L,4L,1L,6L,1L,8L,9L,10L,1L,12L,1L,14L,15L,16L,1L,18L,1L,20L,21L,22L,1L,24L,25L,26L,27L,28L,1L,30L,1L,32L,33L,34L,35L,36L,1L,38L,39L,40L,1L,42L,1L,44L,45L,46L,1L,48L,49L,50L,51L,52L,1L,54L,55L,56L,57L,58L,1L,60L,1L,62L,63L,64L,65L,66L,1L,68L,69L,70L,1L,72L,1L,74L,75L,76L,77L,78L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088140Inst : IEnumerable<long>
{
public static readonly long[] Value=A088140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088140.Bytes);
public long this[int i]=>Value[i];

public static A088140Inst Instance=new A088140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088139
{
public static readonly long[] Value={ 0L,1L,2L,-2L,-16L,-20L,56L,232L,128L,-1136L,-3040L,736L,19712L,35008L,-48256L,-306560L,-323584L,1192192L,4325888L,1498624L,-22958080L,-54907904L,27932672L,385312768L,603029504L,-1105817600L,-5829812224L,-5024718848L,24929435648L,80007184384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088139Inst : IEnumerable<long>
{
public static readonly long[] Value=A088139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088139.Bytes);
public long this[int i]=>Value[i];

public static A088139Inst Instance=new A088139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088138
{
public static readonly long[] Value={ 0L,1L,2L,0L,-8L,-16L,0L,64L,128L,0L,-512L,-1024L,0L,4096L,8192L,0L,-32768L,-65536L,0L,262144L,524288L,0L,-2097152L,-4194304L,0L,16777216L,33554432L,0L,-134217728L,-268435456L,0L,1073741824L,2147483648L,0L,-8589934592L,-17179869184L,0L,68719476736L,137438953472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088138Inst : IEnumerable<long>
{
public static readonly long[] Value=A088138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088138.Bytes);
public long this[int i]=>Value[i];

public static A088138Inst Instance=new A088138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088137
{
public static readonly long[] Value={ 0L,1L,2L,1L,-4L,-11L,-10L,13L,56L,73L,-22L,-263L,-460L,-131L,1118L,2629L,1904L,-4079L,-13870L,-15503L,10604L,67717L,103622L,4093L,-302680L,-617639L,-327238L,1198441L,3378596L,3161869L,-3812050L,-17109707L,-22783264L,5762593L,79874978L,142462177L,45299420L,-336787691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088137Inst : IEnumerable<long>
{
public static readonly long[] Value=A088137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088137.Bytes);
public long this[int i]=>Value[i];

public static A088137Inst Instance=new A088137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088136
{
public static readonly long[] Value={ 11L,23L,29L,41L,43L,47L,61L,67L,83L,89L,101L,131L,151L,181L,191L,211L,223L,229L,233L,239L,241L,251L,263L,269L,271L,281L,283L,293L,401L,409L,419L,421L,431L,433L,439L,443L,449L,457L,461L,463L,467L,479L,487L,491L,499L,601L,607L,617L,631L,641L,647L,661L,677L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088136Inst : IEnumerable<long>
{
public static readonly long[] Value=A088136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088136.Bytes);
public long this[int i]=>Value[i];

public static A088136Inst Instance=new A088136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088135
{
public static readonly long[] Value={ 4L,6L,10L,14L,2L,4L,8L,10L,5L,11L,4L,10L,5L,7L,11L,8L,14L,7L,13L,8L,10L,16L,11L,17L,16L,2L,4L,8L,10L,4L,8L,2L,8L,10L,10L,2L,8L,4L,8L,4L,10L,2L,2L,4L,8L,10L,3L,5L,9L,11L,5L,11L,3L,3L,9L,5L,11L,3L,9L,3L,5L,5L,10L,4L,6L,10L,4L,10L,10L,12L,6L,12L,10L,6L,12L,6L,12L,10L,5L,13L,13L,5L,5L,7L,13L,7L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088135Inst : IEnumerable<long>
{
public static readonly long[] Value=A088135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088135.Bytes);
public long this[int i]=>Value[i];

public static A088135Inst Instance=new A088135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088134
{
public static readonly long[] Value={ 1L,11L,12L,14L,16L,20L,21L,23L,25L,29L,30L,32L,34L,38L,41L,43L,47L,49L,50L,52L,56L,58L,61L,65L,67L,70L,74L,76L,83L,85L,89L,92L,94L,98L,101L,102L,104L,106L,111L,112L,114L,116L,121L,122L,124L,126L,131L,132L,134L,136L,141L,142L,144L,146L,151L,152L,154L,156L,161L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088134Inst : IEnumerable<long>
{
public static readonly long[] Value=A088134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088134.Bytes);
public long this[int i]=>Value[i];

public static A088134Inst Instance=new A088134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088133
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,8L,9L,10L,11L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088133Inst : IEnumerable<long>
{
public static readonly long[] Value=A088133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088133.Bytes);
public long this[int i]=>Value[i];

public static A088133Inst Instance=new A088133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088132
{
public static readonly long[] Value={ 1L,3L,12L,47L,185L,728L,2865L,11275L,44372L,174623L,687217L,2704496L,10643361L,41886227L,164840412L,648718287L,2552986921L,10047107272L,39539710801L,155605856283L,612376317860L,2409965560639L,9484256386273L,37324649227232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088132Inst : IEnumerable<long>
{
public static readonly long[] Value=A088132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088132.Bytes);
public long this[int i]=>Value[i];

public static A088132Inst Instance=new A088132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088131
{
public static readonly long[] Value={ 1L,1L,8L,29L,115L,452L,1779L,7001L,27552L,108429L,426715L,1679308L,6608803L,26008497L,102354680L,402809917L,1585231171L,6238570004L,24551470099L,96620649225L,380244026896L,1496424637485L,5889077900715L,23176067575964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088131Inst : IEnumerable<long>
{
public static readonly long[] Value=A088131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088131.Bytes);
public long this[int i]=>Value[i];

public static A088131Inst Instance=new A088131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088130
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,11L,11L,19L,21L,26L,29L,31L,33L,35L,41L,53L,55L,60L,64L,89L,96L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088130Inst : IEnumerable<long>
{
public static readonly long[] Value=A088130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088130.Bytes);
public long this[int i]=>Value[i];

public static A088130Inst Instance=new A088130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088129
{
public static readonly long[] Value={ 0L,1L,4L,19L,104L,661L,4812L,39607L,364240L,3704617L,41310740L,501328411L,6578864184L,92843236669L,1402257345244L,22570640656831L,385718738160032L,6975222838783057L,133078088319220260L,2671441145266564387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088129Inst : IEnumerable<long>
{
public static readonly long[] Value=A088129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088129.Bytes);
public long this[int i]=>Value[i];

public static A088129Inst Instance=new A088129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088128
{
public static readonly long[] Value={ 1L,2L,7L,30L,157L,970L,6931L,56294L,512569L,5173074L,57330271L,692227822L,9045871957L,127205130650L,1915394962027L,30748771424310L,524265894691441L,9461374592096674L,180184121539899319L,3611206508019111614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088128Inst : IEnumerable<long>
{
public static readonly long[] Value=A088128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088128.Bytes);
public long this[int i]=>Value[i];

public static A088128Inst Instance=new A088128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088127
{
public static readonly BigInteger[] Value={ 1L,1L,4L,14L,72L,424L,2960L,23568L,211456L,2109056L,23150592L,277315840L,3599704064L,50331030528L,754122723328L,12054165272576L,204743835156480L,3682557441114112L,69920454322356224L,1397542619388248064L,BigInteger.Parse("29331932133035081728"),BigInteger.Parse("644973249444408197120") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088127Inst Instance=new A088127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088126
{
public static readonly long[] Value={ 1L,18L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088126Inst : IEnumerable<long>
{
public static readonly long[] Value=A088126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088126.Bytes);
public long this[int i]=>Value[i];

public static A088126Inst Instance=new A088126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088125
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,34L,2L,1L,3L,1L,11L,42L,120L,12L,8L,1L,4L,2L,24L,86L,1L,54L,154L,202L,246L,25L,10L,60L,1L,114L,34L,22L,21L,1L,88L,14L,276L,70L,795L,518L,448L,252L,6L,2L,1L,18L,768L,124L,1L,186L,143L,1L,138L,456L,366L,19L,47L,112L,336L,772L,140L,3L,88L,30L,188L,90L,437L,90L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088125Inst : IEnumerable<long>
{
public static readonly long[] Value=A088125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088125.Bytes);
public long this[int i]=>Value[i];

public static A088125Inst Instance=new A088125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088124
{
public static readonly BigInteger[] Value={ 5L,11L,19L,241L,91393L,19004355761L,3121L,79L,456151L,113L,6214345434133L,BigInteger.Parse("647380324484508990481"),BigInteger.Parse("23727240537882663031640150881"),33371196003273361L,998893713465761L,251L,610748560241L,14136113L,BigInteger.Parse("5228581733308860742493949409") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088124Inst Instance=new A088124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088123
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,6L,1L,8L,1L,74L,6L,6L,1L,2L,11L,102L,20L,88L,1L,52L,10L,18L,2L,56L,1L,26L,37L,216L,1L,78L,1L,28L,21L,160L,3L,276L,30L,1542L,42L,598L,20L,20L,333L,186L,8L,82L,11L,90L,1L,246L,1L,240L,83L,58L,9L,76L,1L,16L,21L,700L,60L,10L,87L,250L,62L,406L,2L,502L,140L,186L,1293L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088123Inst : IEnumerable<long>
{
public static readonly long[] Value=A088123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088123.Bytes);
public long this[int i]=>Value[i];

public static A088123Inst Instance=new A088123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088122
{
public static readonly BigInteger[] Value={ 3L,17L,11L,10273L,29L,702337L,59L,358218449L,101L,BigInteger.Parse("144343444402281177689"),13269388801L,93810335233L,239L,1305289L,214201115363366099L,BigInteger.Parse("7339592775850735791497954599833793"),BigInteger.Parse("809672944130045028361241"),BigInteger.Parse("6177516768446306373088541231324219761"),569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088122Inst Instance=new A088122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088121
{
public static readonly long[] Value={ 3L,5L,23L,17L,157L,191L,383L,257L,2557L,9209L,6143L,20477L,73721L,147449L,360439L,65537L,655357L,786431L,11010029L,5242877L,31457267L,71303153L,276824033L,150994937L,301989881L,469762043L,671088637L,4026531827L,2684354557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088121Inst : IEnumerable<long>
{
public static readonly long[] Value=A088121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088121.Bytes);
public long this[int i]=>Value[i];

public static A088121Inst Instance=new A088121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088120
{
public static readonly ulong[] Value={ 2L,3L,7L,107L,947L,20161L,604801L,6652801L,726485761L,39916801L,39916801L,316234143227L,14820309504001L,10461394944001L,641171050071552001L,425757851430912001L,9366672731480064001UL,8515157028618240001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088120Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A088120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088120.Bytes);
public ulong this[int i]=>Value[i];

public static A088120Inst Instance=new A088120Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088119
{
public static readonly long[] Value={ 193L,223L,1607L,15733L,39877L,63647L,65407L,68207L,72673L,84299L,89977L,96787L,99137L,102533L,103687L,115837L,127807L,143567L,150373L,191999L,204793L,257867L,324217L,344957L,375253L,412033L,427433L,491149L,551717L,595117L,642527L,646897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088119Inst : IEnumerable<long>
{
public static readonly long[] Value=A088119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088119.Bytes);
public long this[int i]=>Value[i];

public static A088119Inst Instance=new A088119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088118
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088118Inst : IEnumerable<long>
{
public static readonly long[] Value=A088118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088118.Bytes);
public long this[int i]=>Value[i];

public static A088118Inst Instance=new A088118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088117
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L,12L,15L,18L,21L,24L,27L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088117Inst : IEnumerable<long>
{
public static readonly long[] Value=A088117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088117.Bytes);
public long this[int i]=>Value[i];

public static A088117Inst Instance=new A088117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088116
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,8L,16L,24L,32L,40L,48L,56L,64L,72L,0L,10L,20L,30L,40L,50L,60L,70L,80L,90L,0L,12L,24L,36L,48L,60L,72L,84L,96L,108L,0L,14L,28L,42L,56L,70L,84L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088116Inst : IEnumerable<long>
{
public static readonly long[] Value=A088116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088116.Bytes);
public long this[int i]=>Value[i];

public static A088116Inst Instance=new A088116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088115
{
public static readonly long[] Value={ 0L,2L,3L,31L,5L,0L,7L,71L,0L,73L,83L,0L,67L,59L,0L,97L,89L,0L,991L,983L,0L,967L,977L,0L,997L,9791L,0L,9973L,9929L,0L,9967L,9887L,0L,99961L,8999L,0L,99991L,99929L,0L,99877L,99689L,0L,98899L,99989L,0L,999883L,999983L,0L,999769L,999959L,0L,999979L,989999L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088115Inst : IEnumerable<long>
{
public static readonly long[] Value=A088115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088115.Bytes);
public long this[int i]=>Value[i];

public static A088115Inst Instance=new A088115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088114
{
public static readonly long[] Value={ 2L,4L,8L,88L,252L,2112L,2112L,2112L,4224L,8448L,48384L,48384L,405504L,405504L,405504L,40955904L,677707776L,677707776L,677707776L,677707776L,677574475776L,677574475776L,42833977933824L,6929958668599296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088114Inst : IEnumerable<long>
{
public static readonly long[] Value=A088114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088114.Bytes);
public long this[int i]=>Value[i];

public static A088114Inst Instance=new A088114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088113
{
public static readonly long[] Value={ 1L,11L,121L,1331L,13651L,150161L,1561681L,17168492L,178863412L,967497632L,10552373962L,116067113483L,1266738338413L,12944121722543L,142286328947974L,1466139717526814L,16126635892794955L,167392994830654505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088113Inst : IEnumerable<long>
{
public static readonly long[] Value=A088113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088113.Bytes);
public long this[int i]=>Value[i];

public static A088113Inst Instance=new A088113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088112
{
public static readonly long[] Value={ 16L,32L,125L,128L,196L,361L,784L,1024L,1369L,1444L,1600L,1681L,3844L,7225L,7921L,9025L,9409L,11236L,14161L,18496L,19321L,19600L,36100L,37249L,38416L,70756L,73441L,75076L,76729L,78400L,78961L,97969L,99856L,102400L,105625L,107584L,109561L,111556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088112Inst : IEnumerable<long>
{
public static readonly long[] Value=A088112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088112.Bytes);
public long this[int i]=>Value[i];

public static A088112Inst Instance=new A088112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088111
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,13L,22L,31L,40L,67L,94L,121L,202L,283L,364L,607L,850L,1093L,1822L,2551L,3280L,5467L,7654L,9112L,9841L,12757L,16402L,22963L,27337L,29524L,38272L,49207L,68890L,82012L,88573L,114817L,147622L,206671L,246037L,265720L,344452L,442867L,620014L,738112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088111Inst : IEnumerable<long>
{
public static readonly long[] Value=A088111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088111.Bytes);
public long this[int i]=>Value[i];

public static A088111Inst Instance=new A088111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088110
{
public static readonly long[] Value={ 0L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088110Inst : IEnumerable<long>
{
public static readonly long[] Value=A088110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088110.Bytes);
public long this[int i]=>Value[i];

public static A088110Inst Instance=new A088110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088109
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,2415L,26565L,1567335L,2785154295L,6918860803558935L,BigInteger.Parse("24055444284403886996443725"),BigInteger.Parse("332872543972802173225078010738842685950725"),BigInteger.Parse("571002075998998180604720399522520480910497598676930064638396594614026468525") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088109Inst Instance=new A088109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088108
{
public static readonly BigInteger[] Value={ 1L,3L,15L,45L,1035L,85905L,1116765L,657774585L,16566052923225L,BigInteger.Parse("1679075536205721159675"),BigInteger.Parse("5080495373624679083985366566435450475"),BigInteger.Parse("61777199356706369989502028371103145170633166772200816412636015025") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088108Inst Instance=new A088108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088107
{
public static readonly BigInteger[] Value={ 2L,7L,61L,2521L,120121L,9767521L,248648401L,5083737121L,2679757320241L,1105598948454001L,531670984004161L,343973251893070801L,BigInteger.Parse("65801152591041067201"),BigInteger.Parse("1102084393565113358401"),BigInteger.Parse("710288051968384142853601") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088107Inst Instance=new A088107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088106
{
public static readonly BigInteger[] Value={ 2L,7L,241L,15121L,4324321L,39070081L,29837808001L,17081356723201L,1607854392144001L,106137499051584001L,BigInteger.Parse("42873948150095462401"),BigInteger.Parse("83214009097971687936001"),BigInteger.Parse("23877922252236982465536001") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088106Inst Instance=new A088106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088105
{
public static readonly long[] Value={ 0L,1L,3L,1L,3L,3L,21L,13L,3L,17L,27L,3L,3L,63L,23L,129L,11L,31L,21L,47L,1L,13L,47L,53L,307L,11L,19L,17L,151L,11L,39L,23L,93L,33L,23L,7L,1L,147L,219L,39L,71L,201L,93L,7L,39L,153L,21L,9L,89L,247L,69L,27L,79L,137L,159L,41L,21L,253L,19L,249L,151L,101L,91L,501L,339L,269L,147L,63L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088105Inst : IEnumerable<long>
{
public static readonly long[] Value=A088105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088105.Bytes);
public long this[int i]=>Value[i];

public static A088105Inst Instance=new A088105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088104
{
public static readonly long[] Value={ 2L,31L,503L,7001L,11003L,130003L,1700021L,19000013L,230000003L,2900000017L,31000000027L,370000000003L,4100000000003L,43000000000063L,470000000000023L,5300000000000129L,59000000000000011L,610000000000000031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088104Inst : IEnumerable<long>
{
public static readonly long[] Value=A088104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088104.Bytes);
public long this[int i]=>Value[i];

public static A088104Inst Instance=new A088104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088103
{
public static readonly BigInteger[] Value={ 11L,11311L,11311511311L,BigInteger.Parse("1131151131138311311511311"),BigInteger.Parse("11311511311383113115113116061131151131138311311511311") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088103Inst Instance=new A088103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088102
{
public static readonly BigInteger[] Value={ 3L,313L,3135313L,313531363135313L,BigInteger.Parse("31353136313531307313531363135313"),BigInteger.Parse("313531363135313073135313631353131531353136313531307313531363135313") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088102Inst Instance=new A088102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088101
{
public static readonly long[] Value={ 3L,6L,7L,21L,14L,36L,27L,55L,44L,28L,22L,16L,66L,78L,31L,223L,136L,66L,153L,171L,55L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L,45L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088101Inst : IEnumerable<long>
{
public static readonly long[] Value=A088101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088101.Bytes);
public long this[int i]=>Value[i];

public static A088101Inst Instance=new A088101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088100
{
public static readonly long[] Value={ 2L,3L,3L,7L,4L,9L,6L,11L,8L,5L,4L,3L,12L,13L,5L,32L,17L,8L,18L,19L,6L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L,13L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088100Inst : IEnumerable<long>
{
public static readonly long[] Value=A088100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088100.Bytes);
public long this[int i]=>Value[i];

public static A088100Inst Instance=new A088100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088099
{
public static readonly long[] Value={ 3L,12L,21L,84L,70L,216L,189L,440L,396L,280L,242L,192L,858L,1092L,465L,3568L,2312L,1188L,2907L,3420L,1155L,990L,2691L,1080L,2925L,1170L,3159L,1260L,3393L,1350L,3627L,1440L,3861L,1530L,4095L,1620L,4329L,1710L,4563L,1800L,4797L,1890L,5031L,1980L,5265L,2070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088099Inst : IEnumerable<long>
{
public static readonly long[] Value=A088099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088099.Bytes);
public long this[int i]=>Value[i];

public static A088099Inst Instance=new A088099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088098
{
public static readonly long[] Value={ 3L,37L,37253L,372533543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088098Inst : IEnumerable<long>
{
public static readonly long[] Value=A088098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088098.Bytes);
public long this[int i]=>Value[i];

public static A088098Inst Instance=new A088098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088097
{
public static readonly long[] Value={ 3L,7L,253L,3543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088097Inst : IEnumerable<long>
{
public static readonly long[] Value=A088097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088097.Bytes);
public long this[int i]=>Value[i];

public static A088097Inst Instance=new A088097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}