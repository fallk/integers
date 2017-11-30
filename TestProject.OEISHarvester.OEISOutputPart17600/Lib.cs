using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A075528
{
public static readonly BigInteger[] Value={ 0L,3L,105L,3570L,121278L,4119885L,139954815L,4754343828L,161507735340L,5486508657735L,186379786627653L,6331426236682470L,215082112260576330L,7306460390622912753L,BigInteger.Parse("248204571168918457275"),BigInteger.Parse("8431648959352604634600"),BigInteger.Parse("286427860046819639119128") };
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
public class A075528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075528Inst Instance=new A075528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075527
{
public static readonly long[] Value={ 2L,3L,4L,6L,6L,6L,6L,6L,10L,8L,8L,10L,6L,6L,10L,12L,8L,8L,10L,6L,8L,10L,10L,14L,12L,6L,6L,6L,6L,18L,18L,10L,8L,12L,12L,8L,12L,10L,10L,12L,8L,12L,12L,6L,6L,14L,24L,16L,6L,6L,10L,8L,12L,16L,12L,12L,8L,8L,10L,6L,12L,24L,18L,6L,6L,18L,20L,16L,12L,6L,10L,14L,14L,12L,10L,10L,14L,12L,12L,18L,12L };
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
public class A075527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075527Inst : IEnumerable<long>
{
public static readonly long[] Value=A075527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075527.Bytes);
public long this[int i]=>Value[i];

public static A075527Inst Instance=new A075527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075526
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,6L,4L,2L,4L,6L,6L,2L,6L,4L,2L,6L,4L,6L,8L,4L,2L,4L,2L,4L,14L,4L,6L,2L,10L,2L,6L,6L,4L,6L,6L,2L,10L,2L,4L,2L,12L,12L,4L,2L,4L,6L,2L,10L,6L,6L,6L,2L,6L,4L,2L,10L,14L,4L,2L,4L,14L,6L,10L,2L,4L,6L,8L,6L,6L,4L,6L,8L,4L,8L,10L,2L,10L,2L,6L,4L,6L,8L,4L,2L,4L,12L,8L,4L,8L,4L,6L };
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
public class A075526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075526Inst : IEnumerable<long>
{
public static readonly long[] Value=A075526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075526.Bytes);
public long this[int i]=>Value[i];

public static A075526Inst Instance=new A075526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075525
{
public static readonly long[] Value={ 1L,1L,1L,8L,3L,1L,6L,35L,6L,1L,144L,110L,95L,10L,1L,480L,1594L,585L,205L,15L,1L,5760L,8064L,8974L,1995L,385L,21L,1L,5040L,125292L,70252L,35329L,5320L,658L,28L,1L,524160L,684144L,1178540L,392364L,110649L,12096L,1050L,36L,1L,2177280L,14215536L };
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
public class A075525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075525Inst : IEnumerable<long>
{
public static readonly long[] Value=A075525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075525.Bytes);
public long this[int i]=>Value[i];

public static A075525Inst Instance=new A075525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075524
{
public static readonly long[] Value={ 10L,15L,21L,69L,95L,117L,165L,175L,213L,245L,287L,319L,335L,357L,405L,415L,437L,453L,511L,527L,549L,559L,597L,629L,655L,671L,693L,725L,767L,789L,799L,847L,895L,917L,933L,959L,965L,1007L,1029L,1055L,1077L,1125L,1135L,1173L,1247L,1253L,1269L,1349L,1391L };
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
public class A075524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075524Inst : IEnumerable<long>
{
public static readonly long[] Value=A075524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075524.Bytes);
public long this[int i]=>Value[i];

public static A075524Inst Instance=new A075524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075523
{
public static readonly long[] Value={ 10L,15L,21L,511L,767L,213L,69L,319L,95L,117L,511L,597L,165L,175L,767L,213L,959L,245L,4351L,287L,1173L,319L,335L,357L,1557L,405L,415L,1727L,437L,453L,511L,527L,549L,559L,597L,2431L,629L,655L,671L,693L,46079L,725L,767L,3093L,789L,799L,847L,895L,3647L,917L };
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
public class A075523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075523Inst : IEnumerable<long>
{
public static readonly long[] Value=A075523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075523.Bytes);
public long this[int i]=>Value[i];

public static A075523Inst Instance=new A075523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075522
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L };
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
public class A075522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075522Inst : IEnumerable<long>
{
public static readonly long[] Value=A075522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075522.Bytes);
public long this[int i]=>Value[i];

public static A075522Inst Instance=new A075522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075521
{
public static readonly long[] Value={ 7L,11L,13L,19L,31L,37L,47L,59L,67L,73L,97L,107L,151L,179L,193L,227L,271L,277L,307L,331L,359L,367L,373L,409L,433L,439L,467L,487L,499L,571L,577L,587L,599L,647L,673L,691L,709L,719L,839L,853L,907L,991L,997L,1019L,1031L,1033L,1039L,1093L,1129L,1187L,1259L,1279L };
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
public class A075521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075521Inst : IEnumerable<long>
{
public static readonly long[] Value=A075521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075521.Bytes);
public long this[int i]=>Value[i];

public static A075521Inst Instance=new A075521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075520
{
public static readonly long[] Value={ 10L,15L,21L,31L,47L,53L,69L,79L,95L,117L,127L,149L,165L,175L,191L,213L,239L,245L,271L,287L,293L,319L,335L,357L,389L,405L,415L,431L,437L,453L,511L,527L,549L,559L,597L,607L,629L,655L,671L,693L,719L,725L,767L,773L,789L,799L,847L,895L,911L,917L,933L,959L,965L };
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
public class A075520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075520Inst : IEnumerable<long>
{
public static readonly long[] Value=A075520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075520.Bytes);
public long this[int i]=>Value[i];

public static A075520Inst Instance=new A075520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075519
{
public static readonly long[] Value={ 11L,13L,23L,29L,31L,47L,53L,71L,79L,127L,149L,151L,167L,173L,191L,239L,269L,271L,293L,317L,359L,389L,431L,439L,509L,557L,599L,607L,631L,653L,719L,727L,773L,797L,911L,919L,967L,1031L,1087L,1109L };
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
public class A075519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075519Inst : IEnumerable<long>
{
public static readonly long[] Value=A075519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075519.Bytes);
public long this[int i]=>Value[i];

public static A075519Inst Instance=new A075519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075518
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,4L,4L,5L,7L,7L,9L,10L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,25L,25L,26L,27L,28L,31L,32L,34L,34L,37L,37L,39L,40L,41L,43L,44L,45L,47L,48L,49L,49L,52L,55L,56L,57L,58L,59L,60L,62L,64L,65L,67L,67L,69L,70L,70L,73L,76L,77L,78L,79L,82L,84L,86L,87L,88L,89L,91L };
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
public class A075518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075518Inst : IEnumerable<long>
{
public static readonly long[] Value=A075518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075518.Bytes);
public long this[int i]=>Value[i];

public static A075518Inst Instance=new A075518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075517
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,28L,29L,37L,38L,39L,46L,47L,48L,49L,55L,56L,57L,58L,59L,64L,65L,66L,67L,68L,69L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,97L,98L,99L,109L,118L,119L,127L,128L,129L,136L,137L,138L,139L,145L,146L,147L };
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
public class A075517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075517Inst : IEnumerable<long>
{
public static readonly long[] Value=A075517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075517.Bytes);
public long this[int i]=>Value[i];

public static A075517Inst Instance=new A075517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075516
{
public static readonly BigInteger[] Value={ 1L,63L,2394L,71442L,1848987L,43615341L,964942308L,20385709344L,416206043253L,8280505692459L,161494678323342L,3101091077181006L,58823743379417199L,1104995938593100617L,BigInteger.Parse("20595841868175915096") };
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
public class A075516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075516Inst Instance=new A075516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075515
{
public static readonly ulong[] Value={ 1L,45L,1260L,28350L,563031L,10333575L,179866170L,3016747800L,49263275061L,788796913905L,12445575859080L,194186867360850L,3004103990159091L,46168557763591035L,705914973500103990L,10750288516418083500UL };
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
public class A075515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075515Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A075515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075515.Bytes);
public ulong this[int i]=>Value[i];

public static A075515Inst Instance=new A075515Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075514
{
public static readonly BigInteger[] Value={ 1L,3L,154L,7941L,429036L,24123105L,1399303662L,83176893681L,5041470373624L,310449199290489L,19369215839341710L,1221826010437625703L,BigInteger.Parse("77798300823672280164"),BigInteger.Parse("4993767938470070592261"),BigInteger.Parse("322795606469564782029126") };
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
public class A075514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075514Inst Instance=new A075514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075513
{
public static readonly long[] Value={ 1L,-1L,2L,1L,-8L,9L,-1L,24L,-81L,64L,1L,-64L,486L,-1024L,625L,-1L,160L,-2430L,10240L,-15625L,7776L,1L,-384L,10935L,-81920L,234375L,-279936L,117649L,-1L,896L,-45927L,573440L,-2734375L,5878656L,-5764801L,2097152L,1L,-2048L,183708L };
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
public class A075513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075513Inst : IEnumerable<long>
{
public static readonly long[] Value=A075513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075513.Bytes);
public long this[int i]=>Value[i];

public static A075513Inst Instance=new A075513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075512
{
public static readonly long[] Value={ 1L,56L,1848L,47040L,1023792L,20076672L,365787136L,6314147840L,104637781248L,1680323893248L,26325099300864L,404403166003200L,6115019304300544L,91287994741981184L,1348582723009708032L };
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
public class A075512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075512Inst : IEnumerable<long>
{
public static readonly long[] Value=A075512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075512.Bytes);
public long this[int i]=>Value[i];

public static A075512Inst Instance=new A075512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075511
{
public static readonly long[] Value={ 1L,42L,1064L,21168L,365232L,5743584L,84713728L,1193127936L,16239711488L,215394955776L,2800564795392L,35851775791104L,453374980255744L,5677724481773568L,70550796621971456L,871159544637161472L };
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
public class A075511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075511Inst : IEnumerable<long>
{
public static readonly long[] Value=A075511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075511.Bytes);
public long this[int i]=>Value[i];

public static A075511Inst Instance=new A075511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075510
{
public static readonly long[] Value={ 1L,30L,560L,8400L,111216L,1360800L,15790720L,176563200L,1922176256L,20518417920L,215825326080L,2244998246400L,23153670762496L,237224718704640L,2418102840688640L,24549985173504000L,248464183682727936L };
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
public class A075510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075510Inst : IEnumerable<long>
{
public static readonly long[] Value=A075510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075510.Bytes);
public long this[int i]=>Value[i];

public static A075510Inst Instance=new A075510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075509
{
public static readonly BigInteger[] Value={ 1L,1L,11L,131L,1761L,27601L,506651L,10674211L,251686881L,6524202561L,183991725451L,5605930566051L,183428104316161L,6409252239788881L,237948848526923611L,9346097294356706051UL,BigInteger.Parse("386966245108218203201"),BigInteger.Parse("16836505067572362863361"),BigInteger.Parse("767645305770283165781131") };
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
public class A075509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075509Inst Instance=new A075509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075508
{
public static readonly BigInteger[] Value={ 1L,1L,10L,109L,1351L,19612L,333451L,6493069L,141264820L,3376695763L,87799365343L,2465959810690L,74353064138749L,2393123710957813L,81812390963020066L,2958191064076428793L,BigInteger.Parse("112727516544416978299"),BigInteger.Parse("4513118224822056822772"),BigInteger.Parse("189305466502867876489519") };
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
public class A075508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075508Inst Instance=new A075508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075507
{
public static readonly BigInteger[] Value={ 1L,1L,9L,89L,1009L,13457L,210105L,3747753L,74565473L,1628999841L,38704241897L,993034281593L,27340167242321L,803154583649329L,25050853217628313L,826165199464341705L,BigInteger.Parse("28707262835597618369"),BigInteger.Parse("1047731789671001235265"),BigInteger.Parse("40053733152627299592137"),BigInteger.Parse("1599910554128824794493593") };
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
public class A075507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075507Inst Instance=new A075507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075506
{
public static readonly BigInteger[] Value={ 1L,1L,8L,71L,729L,8842L,125399L,2026249L,36458010L,719866701L,15453821461L,358100141148L,8899677678109L,235877034446341L,6634976621814472L,197269776623577659L,6177654735731310917L,BigInteger.Parse("203136983117907790890"),BigInteger.Parse("6994626418539177737803"),BigInteger.Parse("251584328242318030774781") };
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
public class A075506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075506Inst Instance=new A075506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075505
{
public static readonly long[] Value={ 1L,10L,1L,100L,30L,1L,1000L,700L,60L,1L,10000L,15000L,2500L,100L,1L,100000L,310000L,90000L,6500L,150L,1L,1000000L,6300000L,3010000L,350000L,14000L,210L,1L,10000000L,127000000L,96600000L,17010000L,1050000L,26600L,280L,1L };
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
public class A075505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075505Inst : IEnumerable<long>
{
public static readonly long[] Value=A075505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075505.Bytes);
public long this[int i]=>Value[i];

public static A075505Inst Instance=new A075505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075504
{
public static readonly long[] Value={ 1L,9L,1L,81L,27L,1L,729L,567L,54L,1L,6561L,10935L,2025L,90L,1L,59049L,203391L,65610L,5265L,135L,1L,531441L,3720087L,1974861L,255150L,11340L,189L,1L,4782969L,67493007L,57041334L,11160261L,765450L,21546L,252L,1L };
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
public class A075504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075504Inst : IEnumerable<long>
{
public static readonly long[] Value=A075504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075504.Bytes);
public long this[int i]=>Value[i];

public static A075504Inst Instance=new A075504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075503
{
public static readonly long[] Value={ 1L,8L,1L,64L,24L,1L,512L,448L,48L,1L,4096L,7680L,1600L,80L,1L,32768L,126976L,46080L,4160L,120L,1L,262144L,2064384L,1232896L,179200L,8960L,168L,1L,2097152L,33292288L,31653888L,6967296L,537600L,17024L,224L,1L };
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
public class A075503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075503Inst : IEnumerable<long>
{
public static readonly long[] Value=A075503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075503.Bytes);
public long this[int i]=>Value[i];

public static A075503Inst Instance=new A075503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075502
{
public static readonly long[] Value={ 1L,7L,1L,49L,21L,1L,343L,343L,42L,1L,2401L,5145L,1225L,70L,1L,16807L,74431L,30870L,3185L,105L,1L,117649L,1058841L,722701L,120050L,6860L,147L,1L,823543L,14941423L,16235562L,4084101L,360150L,13034L,196L,1L };
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
public class A075502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075502Inst : IEnumerable<long>
{
public static readonly long[] Value=A075502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075502.Bytes);
public long this[int i]=>Value[i];

public static A075502Inst Instance=new A075502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075501
{
public static readonly long[] Value={ 1L,6L,1L,36L,18L,1L,216L,252L,36L,1L,1296L,3240L,900L,60L,1L,7776L,40176L,19440L,2340L,90L,1L,46656L,489888L,390096L,75600L,5040L,126L,1L,279936L,5925312L,7511616L,2204496L,226800L,9576L,168L,1L,1679616L,71383680L };
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
public class A075501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075501Inst : IEnumerable<long>
{
public static readonly long[] Value=A075501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075501.Bytes);
public long this[int i]=>Value[i];

public static A075501Inst Instance=new A075501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075500
{
public static readonly long[] Value={ 1L,5L,1L,25L,15L,1L,125L,175L,30L,1L,625L,1875L,625L,50L,1L,3125L,19375L,11250L,1625L,75L,1L,15625L,196875L,188125L,43750L,3500L,105L,1L,78125L,1984375L,3018750L,1063125L,131250L,6650L,140L,1L,390625L,19921875L };
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
public class A075500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075500Inst : IEnumerable<long>
{
public static readonly long[] Value=A075500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075500.Bytes);
public long this[int i]=>Value[i];

public static A075500Inst Instance=new A075500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075499
{
public static readonly long[] Value={ 1L,4L,1L,16L,12L,1L,64L,112L,24L,1L,256L,960L,400L,40L,1L,1024L,7936L,5760L,1040L,60L,1L,4096L,64512L,77056L,22400L,2240L,84L,1L,16384L,520192L,989184L,435456L,67200L,4256L,112L,1L,65536L,4177920L,12390400L,7956480L,1779456L,169344L,7392L,144L,1L };
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
public class A075499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075499Inst : IEnumerable<long>
{
public static readonly long[] Value=A075499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075499.Bytes);
public long this[int i]=>Value[i];

public static A075499Inst Instance=new A075499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075498
{
public static readonly long[] Value={ 1L,3L,1L,9L,9L,1L,27L,63L,18L,1L,81L,405L,225L,30L,1L,243L,2511L,2430L,585L,45L,1L,729L,15309L,24381L,9450L,1260L,63L,1L,2187L,92583L,234738L,137781L,28350L,2394L,84L,1L,6561L,557685L,2205225L,1888110L,563031L,71442L,4158L,108L,1L };
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
public class A075498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075498Inst : IEnumerable<long>
{
public static readonly long[] Value=A075498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075498.Bytes);
public long this[int i]=>Value[i];

public static A075498Inst Instance=new A075498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075497
{
public static readonly long[] Value={ 1L,2L,1L,4L,6L,1L,8L,28L,12L,1L,16L,120L,100L,20L,1L,32L,496L,720L,260L,30L,1L,64L,2016L,4816L,2800L,560L,42L,1L,128L,8128L,30912L,27216L,8400L,1064L,56L,1L,256L,32640L,193600L,248640L,111216L,21168L,1848L,72L,1L };
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
public class A075497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075497Inst : IEnumerable<long>
{
public static readonly long[] Value=A075497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075497.Bytes);
public long this[int i]=>Value[i];

public static A075497Inst Instance=new A075497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075496
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,40L,118L,349L,1042L,3112L,9322L,27926L,83738L,251096L,753170L,2259161L,6777134L,20330360L,60990038L,182967002L,548897894L,1646684360L,4940043758L,14820103348L,44460282118L,133380762616L,400142204110L,1200426361234L };
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
public class A075496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075496Inst : IEnumerable<long>
{
public static readonly long[] Value=A075496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075496.Bytes);
public long this[int i]=>Value[i];

public static A075496Inst Instance=new A075496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075495
{
public static readonly long[] Value={ 1L,1L,-6L,4L,7L,-15L,8L,12L,-31L,29L,10L,-72L,95L,-11L,-160L,264L,-111L,-311L,682L,-484L,-505L,1673L,-1656L,-524L,3857L,-4987L,602L,8240L,-13825L,6189L,15872L,-35888L,26209L,25553L,-87654L,88308L,24903L,-200863L,264264L,-38500L,-426623L,729389L,-341270L,-814744L,1885407L,-1411931L,-1288224L };
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
public class A075495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075495Inst : IEnumerable<long>
{
public static readonly long[] Value=A075495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075495.Bytes);
public long this[int i]=>Value[i];

public static A075495Inst Instance=new A075495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075494
{
public static readonly long[] Value={ 4L,9L,16L,25L,49L,64L,81L,121L,169L,196L,256L,289L,361L,484L,529L,625L,676L,729L,784L,841L,961L,1089L,1156L,1225L,1369L,1444L,1681L,1849L,1936L,2116L,2209L,2401L,2809L,3025L,3249L,3364L,3481L,3721L,3844L,3969L,4096L,4225L,4489L,4624L,4761L,5041L,5329L };
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
public class A075494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075494Inst : IEnumerable<long>
{
public static readonly long[] Value=A075494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075494.Bytes);
public long this[int i]=>Value[i];

public static A075494Inst Instance=new A075494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075493
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,13L,14L,15L,16L,17L,18L,19L,23L,25L,26L,27L,28L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L };
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
public class A075493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075493Inst : IEnumerable<long>
{
public static readonly long[] Value=A075493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075493.Bytes);
public long this[int i]=>Value[i];

public static A075493Inst Instance=new A075493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075492
{
public static readonly long[] Value={ 10L,12L,20L,21L,24L,30L,32L,40L,42L,50L,60L,70L,72L,80L,90L,100L,102L,104L,105L,108L,110L,111L,112L,114L,120L,126L,130L,132L,140L,144L,150L,160L,162L,168L,180L,192L,200L,201L,204L,210L,212L,216L,220L,222L,224L,230L,231L,232L,234L,240L,250L,252L,260L,264L,270L };
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
public class A075492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075492Inst : IEnumerable<long>
{
public static readonly long[] Value=A075492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075492.Bytes);
public long this[int i]=>Value[i];

public static A075492Inst Instance=new A075492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075475
{
public static readonly long[] Value={ 1L,3L,15L,129L,270L,833L,5044L,59815L,9633693L,26427528L,4642779313L };
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
public class A075475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075475Inst : IEnumerable<long>
{
public static readonly long[] Value=A075475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075475.Bytes);
public long this[int i]=>Value[i];

public static A075475Inst Instance=new A075475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075474
{
public static readonly long[] Value={ 1L,65L,2771L,10920L,158804L,2413091L,16636354L,117650080L };
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
public class A075474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075474Inst : IEnumerable<long>
{
public static readonly long[] Value=A075474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075474.Bytes);
public long this[int i]=>Value[i];

public static A075474Inst Instance=new A075474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075473
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,30L,653L,13762L,304295L,7251598L,187783369L,5287733418L,161516858963L,5332258661782L,189493508862461L,7219703867130466L,293780009979371503L,12721918893479808030UL,BigInteger.Parse("584361555380576356625"),BigInteger.Parse("28385640762100638931546") };
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
public class A075473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075473Inst Instance=new A075473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075472
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,13L,16L,19L,21L,25L,31L,38L,46L,55L,62L,68L,75L,83L,92L,102L,111L,120L,129L,139L,151L,163L,174L,187L,201L,217L,232L,247L,263L,280L,299L,319L,340L,362L,385L,410L,434L,457L,481L,506L,533L,561L,588L,614L,642L,671L,701L,732L,763L,793L,825L,857L,891L };
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
public class A075472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075472Inst : IEnumerable<long>
{
public static readonly long[] Value=A075472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075472.Bytes);
public long this[int i]=>Value[i];

public static A075472Inst Instance=new A075472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075471
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,10L,11L,13L,15L,17L,20L,22L,24L,26L,29L,31L,34L,36L,39L,41L,43L,46L,48L,51L,54L,57L,59L,62L,64L,67L,70L,73L,76L,79L,81L,84L,87L,90L,93L,96L,99L,102L,105L,108L,111L,114L,117L,120L,124L,127L,130L,133L,136L,139L,142L,145L,148L,151L,155L,157L,161L,164L };
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
public class A075471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075471Inst : IEnumerable<long>
{
public static readonly long[] Value=A075471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075471.Bytes);
public long this[int i]=>Value[i];

public static A075471Inst Instance=new A075471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075470
{
public static readonly long[] Value={ 2L,5L,13L,23L,37L,53L,71L,97L,131L,157L,191L,223L,263L,307L,347L,383L,431L,467L,521L,587L,653L,709L,787L,853L,937L,1009L,1087L,1153L,1237L,1327L,1423L,1511L,1613L,1709L,1823L,1931L,2053L,2161L,2269L,2377L,2503L,2617L,2749L,2879L,3011L,3137L,3299L,3449L,3613L };
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
public class A075470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075470Inst : IEnumerable<long>
{
public static readonly long[] Value=A075470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075470.Bytes);
public long this[int i]=>Value[i];

public static A075470Inst Instance=new A075470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075469
{
public static readonly BigInteger[] Value={ 1L,20L,253L,3122L,46651L,823540L,16777155L,387420478L,9999999939L,285311670528L,8916100448227L,302875106592216L,11112006825558003L,437893890380859368L,18446744073709551537UL,BigInteger.Parse("827240261886336764070"),BigInteger.Parse("39346408075296537575383") };
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
public class A075469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075469Inst Instance=new A075469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075468
{
public static readonly long[] Value={ 1L,4L,15L,42L,7L,186L,75L,10L,33L,1302L,487L,114L,297L,58L,2253L,1980L,1045L,1638L,1767L,2032L,8067L,10800L,257L,588L,3423L,3334L,5907L,12882L,1213L,12972L,8547L,3644L,7035L,2178L,16747L,24324L,5523L,12628L,2241L,25602L,16495L,41706L,23127L,22376L,24927L };
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
public class A075468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075468Inst : IEnumerable<long>
{
public static readonly long[] Value=A075468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075468.Bytes);
public long this[int i]=>Value[i];

public static A075468Inst Instance=new A075468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075467
{
public static readonly long[] Value={ 270798L,1005135L,1994670L,5058075L,20047500L,33313725L,66545850L,112201785L,225464610L,368353785L,835135950L,1587633825L,2841028950L,5347819200L,5598498225L,10862757750L,21453946560L,22456662705L,43576370550L };
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
public class A075467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075467Inst : IEnumerable<long>
{
public static readonly long[] Value=A075467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075467.Bytes);
public long this[int i]=>Value[i];

public static A075467Inst Instance=new A075467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075466
{
public static readonly long[] Value={ 266718L,1017375L,2019150L,4934715L,20413980L,34239885L,64220175L,127195950L,321080475L,1286586060L,2154739965L,4288508415L,8571775230L,21401016315L,85781907180L,149736661725L,278082371775L,1369020907200L,1433193762225L };
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
public class A075466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075466Inst : IEnumerable<long>
{
public static readonly long[] Value=A075466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075466.Bytes);
public long this[int i]=>Value[i];

public static A075466Inst Instance=new A075466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075465
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,7L,8L,10L,11L,13L,15L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,45L,47L,49L,51L,53L,55L,58L,60L,63L,65L,67L,70L,72L,75L,77L,80L,82L,85L,87L,90L,92L,94L,97L,100L,102L,105L,107L,110L,113L,115L,118L,121L,123L,126L,128L,131L,133L,136L };
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
public class A075465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075465Inst : IEnumerable<long>
{
public static readonly long[] Value=A075465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075465.Bytes);
public long this[int i]=>Value[i];

public static A075465Inst Instance=new A075465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075464
{
public static readonly long[] Value={ 1L,4L,5L,4L,15L,28L,33L,40L,25L,44L,55L,72L,105L,56L,117L,104L,147L,188L,141L,224L,245L,276L,231L,270L,353L,356L,405L,416L,345L,376L,553L,428L,469L,520L,563L,600L,761L,772L,561L,696L,891L,940L,953L,772L,1069L,1188L,971L,1096L,1165L,1220L,1317L,1256L,1487L,1400L };
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
public class A075464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075464Inst : IEnumerable<long>
{
public static readonly long[] Value=A075464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075464.Bytes);
public long this[int i]=>Value[i];

public static A075464Inst Instance=new A075464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075463
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,1L,1L,1L,43L,1L,10L,1L,1L,5L,1L,43L,1L,1L,8356L,1L,1L,1L,2080L,5L,1L,1L,1L,1L,136L,131720L,1L,131720L,8356L,5L,10L,1L,1L,1L,536911936L,1L,1L,1L,1L,5L,1L,1L,134225920L,1L,43L,43L,1L,1L,1L,5L,1L,1L,1L,1L,524800L,1L,137439609088L,2099728L,1L,33564704L,549756338176L,1L,536911936L,1L,43L,1L,2080L,1L,1L,5L,1L,1L,1L,1L,2305843011898064896L };
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
public class A075463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075463Inst : IEnumerable<long>
{
public static readonly long[] Value=A075463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075463.Bytes);
public long this[int i]=>Value[i];

public static A075463Inst Instance=new A075463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075462
{
public static readonly long[] Value={ 1L,1L,1L,16L,4L,1L,1L,1L,256L,1L,64L,1L,1L,16L,1L,256L,4L,1L,65536L,1L,1L,1L,16384L,16L,1L,1L,1L,1L,1024L,1048576L,1L,1048576L,65536L,16L,64L,1L,1L,1L,4294967296L,1L,4L,1L,1L,16L,1L,1L,1073741824L,1L,256L,256L,1L,1L,4L,16L,1L,1L,1L,1L,4194304L,1L,1099511627776L,16777216L };
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
public class A075462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075462Inst : IEnumerable<long>
{
public static readonly long[] Value=A075462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075462.Bytes);
public long this[int i]=>Value[i];

public static A075462Inst Instance=new A075462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075461
{
public static readonly long[] Value={ 2L,3L,7L,47L,395L,2L,3L,11L,23L,31L,2L,3L,7L,43L,1823L,193667L,2L,3L,7L,47L,403L,19403L,2L,3L,7L,47L,415L,8111L,2L,3L,7L,47L,583L,1223L,2L,3L,7L,55L,179L,24323L,2L,3L,7L,43L,1807L,3263447L,2130014000915L,2L,3L,7L,43L,1807L,3263591L,71480133827L,2L,3L,7L,43L };
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
public class A075461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075461Inst : IEnumerable<long>
{
public static readonly long[] Value=A075461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075461.Bytes);
public long this[int i]=>Value[i];

public static A075461Inst Instance=new A075461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075460
{
public static readonly long[] Value={ 1575L,2835L,3465L,4095L,5355L,5775L,5985L,6435L,6615L,6825L,7245L,8085L,9135L,9765L,11655L,12705L,12915L,13545L,14805L,15015L,15435L,16695L,18585L,19215L,19635L,21105L,21945L,22275L,22365L,22995L,23205L,24885L,25245L,25935L,26145L,26565L };
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
public class A075460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075460Inst : IEnumerable<long>
{
public static readonly long[] Value=A075460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075460.Bytes);
public long this[int i]=>Value[i];

public static A075460Inst Instance=new A075460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075459
{
public static readonly long[] Value={ 2L,38L,110L,3066L,60020L,740282L,2340038L,29380602L,957565746L };
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
public class A075459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075459Inst : IEnumerable<long>
{
public static readonly long[] Value=A075459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075459.Bytes);
public long this[int i]=>Value[i];

public static A075459Inst Instance=new A075459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075458
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,5L,5L,5L,5L,6L,7L,8L,9L,9L,9L,9L,10L };
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
public class A075458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075458Inst : IEnumerable<long>
{
public static readonly long[] Value=A075458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075458.Bytes);
public long this[int i]=>Value[i];

public static A075458Inst Instance=new A075458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075457
{
public static readonly long[] Value={ 1L,198L,1070L,2574L,10769L,66908L,1036663L,6436241L,12745650L,2253183029L,81422343214L,278747505724L,352663623088L,537668537432L,807810573770L,3169762558125L,3623176921864L,4225712901909L,4395991005975L,15435175116616L,1361811565229752L };
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
public class A075457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075457Inst : IEnumerable<long>
{
public static readonly long[] Value=A075457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075457.Bytes);
public long this[int i]=>Value[i];

public static A075457Inst Instance=new A075457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075456
{
public static readonly long[] Value={ 6L,26L,34L,123L,136L,206L,234L,352L,498L,1350L,1746L,3075L,3428L,5804L,6874L,8146L,10732L,13874L,16724L,19782L,24519L,26948L,29860L,32946L,35829L,39254L,50639L,59184L,63752L,69045L,74036L,79234L,90863L,97340L,195238L,215648L,287396L,328419L };
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
public class A075456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075456Inst : IEnumerable<long>
{
public static readonly long[] Value=A075456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075456.Bytes);
public long this[int i]=>Value[i];

public static A075456Inst Instance=new A075456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075455
{
public static readonly long[] Value={ 2203L,77983L,90863L,185477L,371087L,388573L,613607L,912349L,1293899L,1600919L,2146457L,30661333L,35608189L,48823147L };
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
public class A075455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075455Inst : IEnumerable<long>
{
public static readonly long[] Value=A075455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075455.Bytes);
public long this[int i]=>Value[i];

public static A075455Inst Instance=new A075455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075454
{
public static readonly long[] Value={ 6L,26L,34L,123L,136L,206L,234L,352L,498L,1012L,1350L,1746L,2082L,2192L,2203L,2724L,3075L,3428L,4977L,5804L,6874L,7760L,8050L,8146L,9335L,10732L,12244L,13874L,16724L,17500L,19782L,21928L,24519L,26948L,29860L,32946L,35829L,39254L,42862L,50639L };
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
public class A075454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075454Inst : IEnumerable<long>
{
public static readonly long[] Value=A075454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075454.Bytes);
public long this[int i]=>Value[i];

public static A075454Inst Instance=new A075454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075453
{
public static readonly long[] Value={ 5L,3L,17L,25L,41L,52L,59L,17L,85L,113L,145L,181L,221L,246L,253L,17L,313L,365L,103L,49L,52L,499L,545L,613L,667L,704L,761L,841L,925L,249L,1041L,1105L,1201L,1301L,1405L,1513L,1625L,1741L,1861L,1961L,253L,2113L,2245L,2381L,2521L,2627L,2700L,2813L,2965L,3121L };
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
public class A075453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075453Inst : IEnumerable<long>
{
public static readonly long[] Value=A075453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075453.Bytes);
public long this[int i]=>Value[i];

public static A075453Inst Instance=new A075453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075452
{
public static readonly long[] Value={ 0L,0L,1L,25L,33L,101L,97L,247L,243L,417L,1007L,1095L,1603L,1997L,2143L,2201L,3123L,3069L,4103L,4781L,4933L,6959L,8411L,8153L,11839L,11711L,14173L,12725L,16297L,18097L,20431L,23427L,22301L,25847L,28789L,26341L,33449L,33209L,35933L };
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
public class A075452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075452Inst : IEnumerable<long>
{
public static readonly long[] Value=A075452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075452.Bytes);
public long this[int i]=>Value[i];

public static A075452Inst Instance=new A075452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075451
{
public static readonly long[] Value={ 1L,2L,5L,13L,17L,25L,29L,37L,41L,53L,73L,89L,101L,109L,113L,125L,137L,149L,157L,169L,173L,193L,229L,233L,257L,269L,289L,293L,317L,337L,349L,353L,373L,389L,397L,401L,421L,449L,461L,509L,521L,557L,569L,577L,593L,613L,617L,625L,641L,653L,673L };
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
public class A075451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075451Inst : IEnumerable<long>
{
public static readonly long[] Value=A075451.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075451.Bytes);
public long this[int i]=>Value[i];

public static A075451Inst Instance=new A075451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075450
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,6L,4L,10L,0L,16L,12L,8L,0L,64L,72L,80L,48L,96L,168L,352L,180L,288L,240L,264L,320L,96L,792L,480L,576L,648L,1344L,1188L,960L,1248L,1488L,1600L,1344L,1344L,3168L,3816L,2976L,2448L,7728L,3312L,4608L,3072L,4140L,4704L,9024L };
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
public class A075450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075450Inst : IEnumerable<long>
{
public static readonly long[] Value=A075450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075450.Bytes);
public long this[int i]=>Value[i];

public static A075450Inst Instance=new A075450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075449
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,16L,18L,20L,24L,32L,36L,40L,42L,48L,52L,64L,66L,70L,72L,78L,80L,84L,92L,96L,108L,114L,136L,138L,140L,144L,156L,160L,168L,170L,208L,214L,224L,234L,261L,270L,272L,280L,282L,288L,291L,312L,328L,336L,358L };
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
public class A075449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075449Inst : IEnumerable<long>
{
public static readonly long[] Value=A075449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075449.Bytes);
public long this[int i]=>Value[i];

public static A075449Inst Instance=new A075449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075448
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,11L,10L,0L,0L,13L,6L,0L,4L,0L,10L,0L,0L,0L,24L,0L,8L,25L,24L,0L,0L,0L,10L,6L,24L,29L,6L,12L,32L,31L,6L,0L,24L,15L,44L,0L,0L,0L,40L,42L,8L,47L,24L,4L,0L,0L,8L,0L,36L,47L,32L,0L,0L,62L,42L,0L,28L,0L,52L };
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
public class A075448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075448Inst : IEnumerable<long>
{
public static readonly long[] Value=A075448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075448.Bytes);
public long this[int i]=>Value[i];

public static A075448Inst Instance=new A075448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075447
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,3L,1L,1L,1L,1L,1L,12L,3L,2L,1L,16L,1L,9L,1L,2L,5L,11L,1L,20L,3L,3L,3L,28L,2L,3L,1L,10L,2L,12L,1L,36L,9L,2L,1L,40L,1L,21L,5L,4L,11L,23L,1L,7L,5L,8L,1L,52L,3L,20L,3L,2L,7L,29L,2L,20L,15L,6L,1L,24L,1L,11L,2L,22L,1L,35L,1L };
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
public class A075447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075447Inst : IEnumerable<long>
{
public static readonly long[] Value=A075447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075447.Bytes);
public long this[int i]=>Value[i];

public static A075447Inst Instance=new A075447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075446
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,0L,1L,1L,1L,0L,25L,2L,3L,2L,33L,2L,23L,1L,7L,16L,29L,0L,101L,11L,10L,14L,97L,3L,13L,4L,63L,9L,49L,6L,247L,40L,9L,5L,243L,4L,155L,16L,27L,98L,156L,6L,59L,43L,57L,7L,417L,20L,151L,22L,21L,71L,222L,15L,243L,94L,49L };
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
public class A075446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075446Inst : IEnumerable<long>
{
public static readonly long[] Value=A075446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075446.Bytes);
public long this[int i]=>Value[i];

public static A075446Inst Instance=new A075446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075445
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,2L,4L,6L,4L,10L,4L,1L,2L,4L,8L,1L,6L,2L,8L,6L,2L,2L,8L,1L,4L,6L,4L,1L,4L,10L,16L,2L,8L,2L,12L,1L,2L,12L,16L,1L,12L,2L,4L,6L,2L,2L,16L,6L,4L,4L,24L,1L,6L,2L,8L,18L,4L,2L,8L,3L,2L,6L,32L,2L,20L,6L,16L,2L,24L,2L,24L,1L,4L };
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
public class A075445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075445Inst : IEnumerable<long>
{
public static readonly long[] Value=A075445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075445.Bytes);
public long this[int i]=>Value[i];

public static A075445Inst Instance=new A075445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075444
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,4L,0L,0L,0L,0L,0L,1L,4L,4L,0L,1L,0L,10L,0L,6L,2L,14L,0L,1L,8L,6L,8L,13L,4L,10L,0L,6L,8L,2L,0L,31L,8L,12L,0L,3L,0L,16L,4L,18L,20L,36L,0L,18L,12L,4L,0L,1L,12L,22L,8L,18L,4L,38L,8L,9L,8L,6L,0L,22L,0L,12L,16L,38L,0L,24L,0L };
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
public class A075444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075444Inst : IEnumerable<long>
{
public static readonly long[] Value=A075444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075444.Bytes);
public long this[int i]=>Value[i];

public static A075444Inst Instance=new A075444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075427
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,14L,15L,30L,31L,62L,63L,126L,127L,254L,255L,510L,511L,1022L,1023L,2046L,2047L,4094L,4095L,8190L,8191L,16382L,16383L,32766L,32767L,65534L,65535L,131070L,131071L,262142L,262143L,524286L,524287L,1048574L,1048575L,2097150L,2097151L };
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
public class A075427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075427Inst : IEnumerable<long>
{
public static readonly long[] Value=A075427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075427.Bytes);
public long this[int i]=>Value[i];

public static A075427Inst Instance=new A075427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075426
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,14L,15L,30L,31L,62L,95L,318L,319L,734L,959L,2798L,2879L,5758L,5759L,11518L,11519L,23038L,23039L,46078L,46079L,92158L,92159L,184318L,184319L,368638L,368639L,737278L,737279L,1548286L,1548287L,3096574L,5160959L,10321918L,10321919L };
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
public class A075426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075426Inst : IEnumerable<long>
{
public static readonly long[] Value=A075426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075426.Bytes);
public long this[int i]=>Value[i];

public static A075426Inst Instance=new A075426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075425
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,3L,4L,5L,6L,1L,2L,3L,4L,3L,4L,5L,6L,3L,2L,3L,2L,5L,6L,7L,8L,1L,2L,3L,4L,3L,4L,5L,6L,3L,4L,5L,6L,5L,6L,7L,8L,3L,4L,3L,4L,3L,4L,3L,4L,5L,6L,7L,8L,7L,8L,9L,4L,1L,2L,3L,4L,3L,4L,5L,6L,3L,4L,5L,6L,5L,6L,7L,8L,3L,2L,3L,4L,5L,6L,7L,8L,5L,6L,7L,8L,7L,8L,9L,10L,3L,4L,5L,2L,3L,4L,5L,6L,3L };
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
public class A075425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075425Inst : IEnumerable<long>
{
public static readonly long[] Value=A075425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075425.Bytes);
public long this[int i]=>Value[i];

public static A075425Inst Instance=new A075425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075424
{
public static readonly long[] Value={ 0L,1L,0L,1L,4L,5L,0L,1L,2L,9L,4L,5L,12L,13L,0L,1L,4L,5L,2L,9L,20L,21L,4L,1L,4L,1L,12L,13L,28L,29L,0L,1L,32L,33L,4L,5L,36L,37L,2L,9L,40L,41L,20L,13L,14L,45L,4L,5L,2L,9L,4L,25L,4L,5L,12L,13L,56L,57L,28L,29L,60L,9L,0L,1L,64L,65L,32L,33L,68L,69L,4L,5L,72L,13L,36L,37L,76L,77L,2L,1L,2L,81L,40L,41L };
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
public class A075424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075424Inst : IEnumerable<long>
{
public static readonly long[] Value=A075424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075424.Bytes);
public long this[int i]=>Value[i];

public static A075424Inst Instance=new A075424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075423
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,5L,6L,1L,2L,9L,10L,5L,12L,13L,14L,1L,16L,5L,18L,9L,20L,21L,22L,5L,4L,25L,2L,13L,28L,29L,30L,1L,32L,33L,34L,5L,36L,37L,38L,9L,40L,41L,42L,21L,14L,45L,46L,5L,6L,9L,50L,25L,52L,5L,54L,13L,56L,57L,58L,29L,60L,61L,20L,1L,64L,65L,66L,33L,68L,69L,70L,5L,72L,73L,14L,37L,76L,77L };
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
public class A075423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075423Inst : IEnumerable<long>
{
public static readonly long[] Value=A075423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075423.Bytes);
public long this[int i]=>Value[i];

public static A075423Inst Instance=new A075423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075422
{
public static readonly long[] Value={ 24L,30L,36L,40L,54L,84L,100L,102L,112L,126L,132L,140L,156L,176L,198L,208L,220L,228L,234L,260L,272L,276L,294L,308L,340L,342L,348L,350L,364L,372L,380L,392L,414L,444L,460L,462L,476L,490L,492L,516L,522L,532L,546L,558L,564L,572L,580L,608L,620L,636L,644L,666L,708L };
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
public class A075422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075422Inst : IEnumerable<long>
{
public static readonly long[] Value=A075422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075422.Bytes);
public long this[int i]=>Value[i];

public static A075422Inst Instance=new A075422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075421
{
public static readonly long[] Value={ 290L,318L,719L,795L,799L,1210L,3903L,4199L,4207L,4219L,4236L,4278L,4279L,4294L,4326L,4333L,4334L,4338L,4402L,4598L,4662L,4726L,5046L,5357L,6157L,6174L,7246L,7247L,7295L,7407L,7549L,8063L,8191L,9211L,12319L,12431L,12463L,12539L,15487L,16519L,16587L };
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
public class A075421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075421Inst : IEnumerable<long>
{
public static readonly long[] Value=A075421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075421.Bytes);
public long this[int i]=>Value[i];

public static A075421Inst Instance=new A075421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075420
{
public static readonly long[] Value={ 290L,318L,378L,381L,438L,444L,462L,498L,501L,504L,510L,545L,567L,573L,627L,633L,636L,639L,693L,696L,699L,717L,719L,732L,751L,753L,756L,759L,765L,775L,795L,799L,800L,822L,823L,828L,835L,847L,859L,882L,883L,888L,894L,895L,915L,919L,927L,948L,954L,967L,972L };
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
public class A075420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075420Inst : IEnumerable<long>
{
public static readonly long[] Value=A075420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075420.Bytes);
public long this[int i]=>Value[i];

public static A075420Inst Instance=new A075420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075419
{
public static readonly long[] Value={ 3L,-1L,-4L,6L,-1L,-7L,12L,-8L,-9L,31L,-32L,-10L,75L,-95L,8L,160L,-261L,111L,308L,-682L,487L,505L,-1676L,1656L,527L,-3857L,4984L,-602L,-8237L,13825L,-6192L,-15872L,35891L,-26209L,-25556L,87654L,-88305L,-24903L,200860L,-264264L,38503L,426623L,-729392L,341270L,814747L,-1885407L,1411928L,1288224L };
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
public class A075419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075419Inst : IEnumerable<long>
{
public static readonly long[] Value=A075419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075419.Bytes);
public long this[int i]=>Value[i];

public static A075419Inst Instance=new A075419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075418
{
public static readonly long[] Value={ 4L,2L,-2L,12L,12L,10L,54L,68L,108L,282L,422L,772L,1604L,2674L,5006L,9580L,16884L,31506L,58606L,105948L,196508L,362298L,662022L,1222772L,2249116L,4127210L,7605718L,13984148L,25701652L,47311458L,86994846L,159975004L,294336612L,541281698L,995529822L,1831291692L,3367998380L,6194717674L };
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
public class A075418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075418Inst : IEnumerable<long>
{
public static readonly long[] Value=A075418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075418.Bytes);
public long this[int i]=>Value[i];

public static A075418Inst Instance=new A075418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075417
{
public static readonly BigInteger[] Value={ 0L,64L,7744L,788544L,78996544L,7901076544L,790121876544L,79012329876544L,7901234409876544L,790123455209876544L,BigInteger.Parse("79012345663209876544"),BigInteger.Parse("7901234567743209876544"),BigInteger.Parse("790123456788543209876544") };
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
public class A075417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075417Inst Instance=new A075417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075416
{
public static readonly BigInteger[] Value={ 0L,49L,5929L,603729L,60481729L,6049261729L,604937061729L,60493815061729L,6049382595061729L,604938270395061729L,BigInteger.Parse("60493827148395061729"),BigInteger.Parse("6049382715928395061729"),BigInteger.Parse("604938271603728395061729") };
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
public class A075416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075416Inst Instance=new A075416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075415
{
public static readonly BigInteger[] Value={ 0L,36L,4356L,443556L,44435556L,4444355556L,444443555556L,44444435555556L,4444444355555556L,444444443555555556L,BigInteger.Parse("44444444435555555556"),BigInteger.Parse("4444444444355555555556"),BigInteger.Parse("444444444443555555555556") };
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
public class A075415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075415Inst Instance=new A075415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075414
{
public static readonly BigInteger[] Value={ 0L,25L,3025L,308025L,30858025L,3086358025L,308641358025L,30864191358025L,3086419691358025L,308641974691358025L,BigInteger.Parse("30864197524691358025"),BigInteger.Parse("3086419753024691358025"),BigInteger.Parse("308641975308024691358025") };
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
public class A075414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075414Inst Instance=new A075414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075413
{
public static readonly BigInteger[] Value={ 0L,16L,1936L,197136L,19749136L,1975269136L,197530469136L,19753082469136L,1975308602469136L,197530863802469136L,BigInteger.Parse("19753086415802469136"),BigInteger.Parse("1975308641935802469136"),BigInteger.Parse("197530864197135802469136") };
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
public class A075413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075413Inst Instance=new A075413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075412
{
public static readonly BigInteger[] Value={ 0L,9L,1089L,110889L,11108889L,1111088889L,111110888889L,11111108888889L,1111111088888889L,111111110888888889L,11111111108888888889UL,BigInteger.Parse("1111111111088888888889"),BigInteger.Parse("111111111110888888888889") };
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
public class A075412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075412Inst Instance=new A075412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075283
{
public static readonly long[] Value={ 56L,376L,1016L,1864L,2344L,2696L,3064L,3544L,3736L,4024L,4168L,5384L,5864L,6376L,7016L,8696L,8744L,9224L,9736L,9784L,13096L,14312L,15208L,15464L,15592L,16424L,16696L,17096L,19384L,19816L,20344L,21064L,21496L,22856L,23336L,23704L,26984L };
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
public class A075283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075283Inst : IEnumerable<long>
{
public static readonly long[] Value=A075283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075283.Bytes);
public long this[int i]=>Value[i];

public static A075283Inst Instance=new A075283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075282
{
public static readonly long[] Value={ 21L,217L,2191L,2933L,3073L,3353L,7063L,7091L,8813L,9079L,9233L,9527L,9569L,10493L,10717L,11851L,12131L,16667L,17857L,18263L,18347L,19243L,19733L,22421L,23093L,24703L,24787L,25417L,27349L,28637L,32347L,32473L,33607L,33691L,35273L,35413L };
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
public class A075282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075282Inst : IEnumerable<long>
{
public static readonly long[] Value=A075282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075282.Bytes);
public long this[int i]=>Value[i];

public static A075282Inst Instance=new A075282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075281
{
public static readonly long[] Value={ 12L,18L,30L,42L,102L,138L,186L,246L,282L,426L,582L,618L,642L,822L,834L,1158L,1698L,1878L,2022L,2082L,2094L,2238L,2382L,2526L,2658L,2802L,2922L,2946L,3462L,3522L,3558L,3714L,3786L,3858L,3918L,4038L,4146L,4206L,4638L,4722L,4866L,4962L,5442L,5946L,6126L };
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
public class A075281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075281Inst : IEnumerable<long>
{
public static readonly long[] Value=A075281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075281.Bytes);
public long this[int i]=>Value[i];

public static A075281Inst Instance=new A075281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075280
{
public static readonly long[] Value={ 15L,205L,515L,1465L,1795L,1895L,2105L,3265L,3505L,3665L,4105L,4415L,4535L,4555L,4685L,5045L,6185L,7115L,7835L,8135L,8185L,9655L,9865L,10085L,10645L,11015L,11405L,12085L,12295L,12385L,13235L,14395L,16045L,16355L,16735L,17065L };
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
public class A075280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075280Inst : IEnumerable<long>
{
public static readonly long[] Value=A075280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075280.Bytes);
public long this[int i]=>Value[i];

public static A075280Inst Instance=new A075280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075279
{
public static readonly long[] Value={ 12L,76L,236L,356L,436L,596L,604L,1268L,1324L,1436L,1556L,1604L,1756L,2284L,2396L,3316L,3764L,3812L,4076L,4612L,4996L,5116L,5276L,5492L,5524L,5804L,6628L,6676L,6932L,6964L,7468L,7484L,7892L,8524L,8644L,8716L,9004L,9836L,11276L,12476L,14156L,14636L };
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
public class A075279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075279Inst : IEnumerable<long>
{
public static readonly long[] Value=A075279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075279.Bytes);
public long this[int i]=>Value[i];

public static A075279Inst Instance=new A075279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075278
{
public static readonly long[] Value={ 6L,9L,15L,21L,39L,69L,93L,111L,129L,309L,381L,393L,453L,489L,501L,687L,723L,771L,879L,933L,939L,1011L,1167L,1299L,1527L,1563L,1569L,1839L,1941L,1983L,2157L,2217L,2229L,2271L,2391L,2463L,2661L,2811L,2859L,2913L,3039L,3099L,3189L,3453L,3459L,3651L,3849L };
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
public class A075278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075278Inst : IEnumerable<long>
{
public static readonly long[] Value=A075278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075278.Bytes);
public long this[int i]=>Value[i];

public static A075278Inst Instance=new A075278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075277
{
public static readonly long[] Value={ 4L,6L,26L,34L,86L,134L,254L,274L,334L,386L,446L,566L,974L,1126L,1226L,1234L,1286L,1294L,1546L,2066L,2374L,2386L,2554L,2854L,2906L,2966L,3086L,3326L,3694L,3898L,4054L,4286L,4594L,4742L,4846L,4874L,4954L,5006L,5218L,5366L,5686L,5714L,5854L,6238L,6274L,6326L };
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
public class A075277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075277Inst : IEnumerable<long>
{
public static readonly long[] Value=A075277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075277.Bytes);
public long this[int i]=>Value[i];

public static A075277Inst Instance=new A075277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075276
{
public static readonly long[] Value={ 1L,3L,11L,41L,131L,153L,571L,1561L,1803L,2131L,5761L,7953L,17291L,18601L,25091L,29681L,79291L,110771L,221651L,253353L,295681L,349451L,413403L,817961L,1542841L,2282281L,2453891L,2641211L,3018753L,3252611L,3487001L,4114771L,4867203L,5757961L,11141771L };
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
public class A075276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075276Inst : IEnumerable<long>
{
public static readonly long[] Value=A075276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075276.Bytes);
public long this[int i]=>Value[i];

public static A075276Inst Instance=new A075276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075275
{
public static readonly long[] Value={ 5L,7L,10L,11L,22L,41L,67L,76L,91L,96L,163L,245L,299L,341L,434L,510L,535L };
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
public class A075275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075275Inst : IEnumerable<long>
{
public static readonly long[] Value=A075275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075275.Bytes);
public long this[int i]=>Value[i];

public static A075275Inst Instance=new A075275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075274
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,7L,16L,9L,25L,55L,24L,91L,196L,70L };
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
public class A075274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075274Inst : IEnumerable<long>
{
public static readonly long[] Value=A075274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075274.Bytes);
public long this[int i]=>Value[i];

public static A075274Inst Instance=new A075274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075273
{
public static readonly long[] Value={ 5L,8L,37L,176L,196L,1471L,6885L,5948L,60460L,280600L,199316L,2533987L,11698223L,7080928L };
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
public class A075273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075273Inst : IEnumerable<long>
{
public static readonly long[] Value=A075273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075273.Bytes);
public long this[int i]=>Value[i];

public static A075273Inst Instance=new A075273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075272
{
public static readonly BigInteger[] Value={ 1L,2L,6L,34L,422L,11586L,678982L,82653026L,20565923814L,10362872458882L,10517568142605446L,BigInteger.Parse("21434335059927667362"),BigInteger.Parse("87558678536857464017446"),BigInteger.Parse("716228573446369122069676994"),BigInteger.Parse("11725371140175829761708518252742") };
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
public class A075272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075272Inst Instance=new A075272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075271
{
public static readonly BigInteger[] Value={ 1L,3L,17L,211L,5793L,339491L,41326513L,10282961907L,5181436229441L,5258784071302723L,10717167529963833681UL,BigInteger.Parse("43779339268428732008723"),BigInteger.Parse("358114286723184561034838497"),BigInteger.Parse("5862685570087914880854259126371"),BigInteger.Parse("192026370558313054275618817346778353") };
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
public class A075271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075271Inst Instance=new A075271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075270
{
public static readonly long[] Value={ 3L,-2L,7L,-3L,18L,-7L,47L,-18L,123L,-47L,322L,-123L,843L,-322L,2207L,-843L,5778L,-2207L,15127L,-5778L,39603L,-15127L,103682L,-39603L,271443L,-103682L,710647L,-271443L,1860498L,-710647L,4870847L,-1860498L,12752043L,-4870847L,33385282L,-12752043L,87403803L,-33385282L,228826127L,-87403803L };
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
public class A075270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075270Inst : IEnumerable<long>
{
public static readonly long[] Value=A075270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075270.Bytes);
public long this[int i]=>Value[i];

public static A075270Inst Instance=new A075270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075269
{
public static readonly long[] Value={ 2L,-3L,12L,-28L,77L,-198L,522L,-1363L,3572L,-9348L,24477L,-64078L,167762L,-439203L,1149852L,-3010348L,7881197L,-20633238L,54018522L,-141422323L,370248452L,-969323028L,2537720637L,-6643838878L,17393796002L,-45537549123L,119218851372L,-312119004988L,817138163597L };
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
public class A075269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075269Inst : IEnumerable<long>
{
public static readonly long[] Value=A075269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A075269.Bytes);
public long this[int i]=>Value[i];

public static A075269Inst Instance=new A075269Inst();

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