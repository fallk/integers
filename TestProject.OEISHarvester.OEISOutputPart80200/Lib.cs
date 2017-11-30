using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A099841
{
public static readonly BigInteger[] Value={ 1L,4L,0L,-320L,-6400L,-102400L,-1536000L,-22528000L,-327680000L,-4751360000L,-68812800000L,-996147200000L,-14417920000000L,-208666624000000L,-3019898880000000L,-43704647680000000L,-632501043200000000L,-9153649049600000000L,BigInteger.Parse("-132472897536000000000") };
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
public class A099841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099841Inst Instance=new A099841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099842
{
public static readonly long[] Value={ 1L,-7L,45L,-291L,1881L,-12159L,78597L,-508059L,3284145L,-21229047L,137226717L,-887047443L,5733964809L,-37064931183L,239591481525L,-1548743682699L,10011236540769L,-64713650292711L,418315611378573L,-2704034619149571L,17479154549033145L,-112987031151647583L };
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
public class A099842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099842Inst : IEnumerable<long>
{
public static readonly long[] Value=A099842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099842.Bytes);
public long this[int i]=>Value[i];

public static A099842Inst Instance=new A099842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099843
{
public static readonly long[] Value={ 1L,-5L,21L,-89L,377L,-1597L,6765L,-28657L,121393L,-514229L,2178309L,-9227465L,39088169L,-165580141L,701408733L,-2971215073L,12586269025L,-53316291173L,225851433717L,-956722026041L,4052739537881L,-17167680177565L,72723460248141L,-308061521170129L,1304969544928657L };
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
public class A099843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099843Inst : IEnumerable<long>
{
public static readonly long[] Value=A099843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099843.Bytes);
public long this[int i]=>Value[i];

public static A099843Inst Instance=new A099843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099844
{
public static readonly long[] Value={ 1L,3L,6L,12L,24L,48L,98L,201L,411L,840L,1716L,3504L,7156L,14616L,29853L,60975L,124542L,254376L,519560L,1061196L,2167482L,4427061L,9042231L,18468672L,37722088L,77047008L,157367784L,321422208L,656501817L,1340898747L,2738772998L };
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
public class A099844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099844Inst : IEnumerable<long>
{
public static readonly long[] Value=A099844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099844.Bytes);
public long this[int i]=>Value[i];

public static A099844Inst Instance=new A099844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099845
{
public static readonly long[] Value={ 1L,3L,8L,18L,37L,75L,152L,309L,631L,1290L,2636L,5385L,10999L,22464L,45881L,93711L,191404L,390942L,798497L,1630923L,3331144L,6803829L,13896755L,28383990L,57974032L,118411413L,241854191L,493984896L,1008959473L,2060790171L };
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
public class A099845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099845Inst : IEnumerable<long>
{
public static readonly long[] Value=A099845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099845.Bytes);
public long this[int i]=>Value[i];

public static A099845Inst Instance=new A099845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099846
{
public static readonly long[] Value={ 1L,3L,5L,8L,15L,29L,55L,104L,196L,368L,692L,1304L,2457L,4627L,8713L,16408L,30899L,58189L,109583L,206368L,388632L,731872L,1378264L,2595552L,4887953L,9205011L,17334909L,32645160L,61477479L,115774605L,218027143L,410589480L,773223548L,1456137296L };
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
public class A099846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099846Inst : IEnumerable<long>
{
public static readonly long[] Value=A099846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099846.Bytes);
public long this[int i]=>Value[i];

public static A099846Inst Instance=new A099846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099847
{
public static readonly long[] Value={ 2L,4L,7L,9L,13L,17L,23L,27L,31L,37L,43L,49L,59L,64L,71L,79L,83L,97L,103L,109L,121L,127L,131L,139L,151L,163L,169L,179L,191L,197L,211L,227L,233L,241L,251L,257L,269L,277L,283L,293L,311L,317L,337L,347L,353L,361L,373L,383L,397L,409L,421L,433L,443L,457L,463L,479L,491L };
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
public class A099847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099847Inst : IEnumerable<long>
{
public static readonly long[] Value=A099847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099847.Bytes);
public long this[int i]=>Value[i];

public static A099847Inst Instance=new A099847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099848
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,10L,11L,12L,12L,12L,13L,14L,14L,15L,15L,16L,17L,18L,18L,18L,19L,20L,20L,20L,21L,21L,22L,22L,23L,24L,24L,24L,24L,25L,26L,26L,27L,28L,28L,28L,29L,30L,30L,30L,30L,30L,30L,31L,32L,33L,33L,34L,34L,35L,35L,36L,36L,36L,36L,36L,36L,37L,38L,38L,39L,39L,40L };
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
public class A099848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099848Inst : IEnumerable<long>
{
public static readonly long[] Value=A099848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099848.Bytes);
public long this[int i]=>Value[i];

public static A099848Inst Instance=new A099848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099849
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,12L,13L,16L,17L,19L,21L,22L,23L,26L,27L,30L,32L,34L,35L,39L,40L,42L,43L,46L,47L,53L,54L,55L,57L,59L,61L,67L,68L,70L,72L,76L,77L,83L,84L,87L,90L,92L,93L,98L,99L,102L,104L,107L,108L,112L,114L,118L,120L,122L,123L,135L,136L,138L,141L,142L,144L,150L };
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
public class A099849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099849Inst : IEnumerable<long>
{
public static readonly long[] Value=A099849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099849.Bytes);
public long this[int i]=>Value[i];

public static A099849Inst Instance=new A099849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099850
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,8L,11L,14L,19L,28L,37L,38L,40L,41L,43L,48L,56L,63L,73L,84L,94L,107L,121L,138L,160L,183L,205L,228L,250L,273L,276L,279L,284L,287L,296L,303L,312L,323L,334L,347L,362L,375L,394L,411L,428L,443L,466L,497L,528L,557L,586L,617L,646L,681L,718L,757L,798L,837L };
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
public class A099850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099850Inst : IEnumerable<long>
{
public static readonly long[] Value=A099850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099850.Bytes);
public long this[int i]=>Value[i];

public static A099850Inst Instance=new A099850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099851
{
public static readonly long[] Value={ 1L,3L,16L,57L,112L,160L,272L,404L,20924L,147153L,274617L,4409708L,24881389L,34850872L,39808233L,186610952L,980830465L,1777956414L };
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
public class A099851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099851Inst : IEnumerable<long>
{
public static readonly long[] Value=A099851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099851.Bytes);
public long this[int i]=>Value[i];

public static A099851Inst Instance=new A099851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099852
{
public static readonly long[] Value={ 0L,3L,48L,798L,2576L,7040L,16864L,48884L,94639252L,4617219681L,20716557246L,5553546567828L,183276908527336L,272413165321136L,335452673952828L,8235555774684392L,224177101582314365L,709201017174989274L };
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
public class A099852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099852Inst : IEnumerable<long>
{
public static readonly long[] Value=A099852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099852.Bytes);
public long this[int i]=>Value[i];

public static A099852Inst Instance=new A099852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099853
{
public static readonly long[] Value={ 0L,1L,3L,14L,23L,44L,62L,121L,4523L,31377L,75438L,1259391L,7366024L,7816538L,8426716L,44132221L,228558461L,398885491L };
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
public class A099853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099853Inst : IEnumerable<long>
{
public static readonly long[] Value=A099853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099853.Bytes);
public long this[int i]=>Value[i];

public static A099853Inst Instance=new A099853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099854
{
public static readonly long[] Value={ 1L,3L,7L,14L,26L,48L,90L,170L,321L,605L,1139L,2144L,4037L,7603L,14319L,26966L,50782L,95632L,180094L,339154L,638697L,1202797L,2265111L,4265664L,8033113L,15127987L,28489079L,53650734L,101035250L,190269936L,358317010L,674783850L,1270755313L };
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
public class A099854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099854Inst : IEnumerable<long>
{
public static readonly long[] Value=A099854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099854.Bytes);
public long this[int i]=>Value[i];

public static A099854Inst Instance=new A099854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099855
{
public static readonly long[] Value={ 0L,1L,6L,22L,64L,164L,392L,904L,2048L,4592L,10208L,22496L,49152L,106560L,229504L,491648L,1048576L,2227968L,4718080L,9960960L,20971520L,44041216L,92276736L,192940032L,402653184L,838856704L,1744822272L,3623870464L,7516192768L };
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
public class A099855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099855Inst : IEnumerable<long>
{
public static readonly long[] Value=A099855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099855.Bytes);
public long this[int i]=>Value[i];

public static A099855Inst Instance=new A099855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099856
{
public static readonly long[] Value={ 1L,6L,18L,54L,162L,486L,1458L,4374L,13122L,39366L,118098L,354294L,1062882L,3188646L,9565938L,28697814L,86093442L,258280326L,774840978L,2324522934L,6973568802L,20920706406L,62762119218L,188286357654L,564859072962L,1694577218886L };
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
public class A099856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099856Inst : IEnumerable<long>
{
public static readonly long[] Value=A099856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099856.Bytes);
public long this[int i]=>Value[i];

public static A099856Inst Instance=new A099856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099857
{
public static readonly long[] Value={ 1L,6L,18L,48L,126L,330L,864L,2262L,5922L,15504L,40590L,106266L,278208L,728358L,1906866L,4992240L,13069854L,34217322L,89582112L,234529014L,614004930L,1607485776L,4208452398L,11017871418L,28845161856L,75517614150L,197707680594L };
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
public class A099857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099857Inst : IEnumerable<long>
{
public static readonly long[] Value=A099857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099857.Bytes);
public long this[int i]=>Value[i];

public static A099857Inst Instance=new A099857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099858
{
public static readonly long[] Value={ 1L,6L,17L,42L,109L,288L,755L,1974L,5167L,13530L,35423L,92736L,242785L,635622L,1664081L,4356618L,11405773L,29860704L,78176339L,204668310L,535828591L,1402817466L,3672623807L,9615053952L,25172538049L,65902560198L,172535142545L };
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
public class A099858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099858Inst : IEnumerable<long>
{
public static readonly long[] Value=A099858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099858.Bytes);
public long this[int i]=>Value[i];

public static A099858Inst Instance=new A099858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099859
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L };
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
public class A099859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099859Inst : IEnumerable<long>
{
public static readonly long[] Value=A099859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099859.Bytes);
public long this[int i]=>Value[i];

public static A099859Inst Instance=new A099859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099860
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,0L,-1L,-1L,-2L,-2L,-1L,-1L,0L,1L,1L,2L,2L,1L,1L,0L,-1L,-1L,-2L,-2L,-1L,-1L,0L,1L,1L,2L,2L,1L,1L,0L,-1L,-1L,-2L,-2L,-1L,-1L,0L,1L,1L,2L,2L,1L,1L,0L,-1L,-1L,-2L,-2L,-1L,-1L,0L,1L,1L,2L,2L,1L,1L,0L,-1L,-1L,-2L,-2L,-1L,-1L,0L,1L,1L,2L,2L,1L,1L,0L,-1L,-1L,-2L,-2L };
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
public class A099860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099860Inst : IEnumerable<long>
{
public static readonly long[] Value=A099860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099860.Bytes);
public long this[int i]=>Value[i];

public static A099860Inst Instance=new A099860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099861
{
public static readonly long[] Value={ 4L,8L,10L,14L,16L,20L,22L,25L,27L,30L,33L,35L,38L,40L,44L,46L,49L,51L,54L,56L,58L,62L,64L,66L,69L,72L,75L,77L,80L,82L,85L,87L,90L,92L,94L,96L,99L,102L,105L,108L,111L,114L,116L,118L,120L,122L,124L,126L,129L,132L,134L,136L,140L,142L,144L,146L,148L,152L,154L,156L,159L,161L };
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
public class A099861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099861Inst : IEnumerable<long>
{
public static readonly long[] Value=A099861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099861.Bytes);
public long this[int i]=>Value[i];

public static A099861Inst Instance=new A099861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099862
{
public static readonly long[] Value={ 6L,9L,12L,15L,18L,21L,24L,26L,28L,32L,34L,36L,39L,42L,45L,48L,50L,52L,55L,57L,60L,63L,65L,68L,70L,74L,76L,78L,81L,84L,86L,88L,91L,93L,95L,98L,100L,104L,106L,110L,112L,115L,117L,119L,121L,123L,125L,128L,130L,133L,135L,138L,141L,143L,145L,147L,150L,153L,155L,158L,160L };
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
public class A099862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099862Inst : IEnumerable<long>
{
public static readonly long[] Value=A099862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099862.Bytes);
public long this[int i]=>Value[i];

public static A099862Inst Instance=new A099862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099863
{
public static readonly long[] Value={ 3L,5L,7L,17L,11L,13L,31L,41L,19L,53L,23L,97L,59L,29L,47L,89L,163L,37L,103L,113L,43L,109L,127L,73L,179L,149L,311L,193L,283L,61L,79L,313L,67L,197L,71L,337L,331L,461L,223L,233L,83L,373L,599L,673L,251L,349L,239L,281L,227L,101L,167L,433L,107L,173L,191L,137L,499L,853L,503L };
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
public class A099863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099863Inst : IEnumerable<long>
{
public static readonly long[] Value=A099863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099863.Bytes);
public long this[int i]=>Value[i];

public static A099863Inst Instance=new A099863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099864
{
public static readonly long[] Value={ 2L,3L,4L,7L,5L,6L,11L,13L,8L,16L,9L,25L,17L,10L,15L,24L,38L,12L,27L,30L,14L,29L,31L,21L,41L,35L,64L,44L,61L,18L,22L,65L,19L,45L,20L,68L,67L,89L,48L,51L,23L,74L,109L,122L,54L,70L,52L,60L,49L,26L,39L,84L,28L,40L,43L,33L,95L,147L,96L,55L,69L,97L,58L,135L,32L,77L,118L,79L,34L,78L,228L };
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
public class A099864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099864Inst : IEnumerable<long>
{
public static readonly long[] Value=A099864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099864.Bytes);
public long this[int i]=>Value[i];

public static A099864Inst Instance=new A099864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099865
{
public static readonly long[] Value={ 1L,27L,66L,625L,2055L,21609L,10164L,123282L,320805L,4465505L,920821L,14537549L,104285363L,41010655L,47830280L,2816662204L,6447760119L,139131611847L,26153100905L,29313445875L,13068630729L,111103313343L,91973556693L };
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
public class A099865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099865Inst : IEnumerable<long>
{
public static readonly long[] Value=A099865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099865.Bytes);
public long this[int i]=>Value[i];

public static A099865Inst Instance=new A099865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099866
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,20L,5L,35L,56L,504L,70L,770L,3960L,1144L,1001L,45045L,80080L,1361360L,204204L,184756L,67184L,470288L,323323L,7436429L,27457584L,228813200L,106234700L,2868336900L,356948592L,10351509168L,145568097675L,45581929575L,85801279200L };
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
public class A099866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099866Inst : IEnumerable<long>
{
public static readonly long[] Value=A099866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099866.Bytes);
public long this[int i]=>Value[i];

public static A099866Inst Instance=new A099866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099867
{
public static readonly long[] Value={ 1L,9L,44L,211L,1011L,4844L,23209L,111201L,532796L,2552779L,12231099L,58602716L,280782481L,1345309689L,6445765964L,30883520131L,147971834691L,708975653324L,3396906431929L,16275556506321L,77980876099676L,373628823992059L,1790163243860619L,8577187395311036L };
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
public class A099867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099867Inst : IEnumerable<long>
{
public static readonly long[] Value=A099867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099867.Bytes);
public long this[int i]=>Value[i];

public static A099867Inst Instance=new A099867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099868
{
public static readonly long[] Value={ 3L,25L,122L,585L,2803L,13430L,64347L,308305L,1477178L,7077585L,33910747L,162476150L,778470003L,3729873865L,17870899322L,85624622745L,410252214403L,1965636449270L,9417930031947L,45124013710465L,216202138520378L,1035886678891425L,4963231255936747L };
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
public class A099868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099868Inst : IEnumerable<long>
{
public static readonly long[] Value=A099868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099868.Bytes);
public long this[int i]=>Value[i];

public static A099868Inst Instance=new A099868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099869
{
public static readonly BigInteger[] Value={ 1L,4L,23L,197L,2056L,23714L,290512L,3707852L,48760367L,656043857L,8987427467L,124936258127L,1757900019101L,24987199492705L,358268702159069L,5175497420902741L,75254198337177848L,1100534370899151722L,16176618251666906476UL,BigInteger.Parse("238861285363295350240") };
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
public class A099869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099869Inst Instance=new A099869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099870
{
public static readonly long[] Value={ 2L,2L,3L,8L,1L,8L,1L,3L,0L,6L,7L,9L,6L,6L,9L,3L,0L,4L,3L,1L,8L,3L,1L,3L,6L,9L,9L,4L,1L,9L,9L,7L,1L,8L,0L,0L,9L,6L,1L,6L,1L,8L,1L,0L,8L,1L,7L,6L,5L,0L,0L,5L,4L,2L,2L,3L,9L,1L,5L,9L,0L,5L,0L,8L,1L,1L,6L,8L,2L,6L,9L,2L,7L,4L,6L,6L,2L,7L,0L,1L,2L,7L,7L,5L,7L,0L,5L,6L,4L,8L,4L,8L,3L,5L,3L,5L,5L,8L,1L,0L,8L,0L,1L,8L,6L };
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
public class A099870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099870Inst : IEnumerable<long>
{
public static readonly long[] Value=A099870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099870.Bytes);
public long this[int i]=>Value[i];

public static A099870Inst Instance=new A099870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099871
{
public static readonly long[] Value={ 3L,2L,4L,2L,6L,0L,9L,4L,1L,0L,9L,2L,5L,2L,4L,8L,2L,1L,0L,6L,0L,2L,0L,3L,8L,7L,2L,8L,4L,9L,8L,1L,2L,8L,8L,1L,7L,8L,6L,3L,5L,8L,0L,4L,0L,4L,2L,6L,1L,9L,0L,8L,3L,9L,3L,4L,5L,3L,6L,6L,6L,0L,1L,4L,9L,3L,5L,0L,3L,2L,7L,8L,3L,7L,3L,0L,5L,4L,8L,4L,6L,6L,3L,9L,8L,8L,3L,1L,9L,9L,5L,2L,1L,5L,4L,0L,1L,9L,9L,4L,2L,2L,5L,4L,4L };
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
public class A099871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099871Inst : IEnumerable<long>
{
public static readonly long[] Value=A099871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099871.Bytes);
public long this[int i]=>Value[i];

public static A099871Inst Instance=new A099871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099872
{
public static readonly long[] Value={ 5L,8L,3L,3L,0L,2L,3L,2L,8L,1L,7L,8L,3L,1L,6L,1L,4L,5L,1L,6L,3L,8L,8L,7L,4L,7L,5L,7L,8L,4L,1L,5L,3L,3L,5L,9L,2L,6L,0L,1L,0L,0L,5L,5L,8L,7L,8L,7L,0L,2L,8L,6L,4L,4L,0L,2L,3L,7L,1L,2L,3L,2L,6L,4L,4L,0L,2L,3L,4L,7L,2L,9L,9L,8L,7L,5L,9L,5L,9L,0L,2L,3L,2L,1L,2L,5L,6L,2L,4L,9L,5L,5L,6L,5L,7L,4L,2L,8L,7L,6L,7L,7L,3L,6L,0L };
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
public class A099872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099872Inst : IEnumerable<long>
{
public static readonly long[] Value=A099872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099872.Bytes);
public long this[int i]=>Value[i];

public static A099872Inst Instance=new A099872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099873
{
public static readonly long[] Value={ 1L,5L,2L,8L,3L,2L,1L,4L,1L,1L,1L,9L,2L,6L,4L,4L,9L,1L,0L,1L,6L,8L,5L,1L,3L,4L,8L,5L,9L,6L,5L,9L,8L,7L,8L,2L,0L,6L,2L,6L,5L,5L,8L,3L,3L,3L,1L,0L,0L,8L,2L,3L,1L,3L,8L,4L,6L,4L,7L,1L,0L,8L,1L,8L,7L,8L,9L,5L,5L,5L,3L,9L,3L,6L,5L,8L,0L,8L,5L,0L,3L,1L,4L,6L,1L,8L,1L,9L,7L,1L,7L,2L,0L,2L,1L,8L,0L,4L,0L,0L,7L,1L,1L,2L,9L };
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
public class A099873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099873Inst : IEnumerable<long>
{
public static readonly long[] Value=A099873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099873.Bytes);
public long this[int i]=>Value[i];

public static A099873Inst Instance=new A099873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099874
{
public static readonly long[] Value={ 1L,3L,6L,5L,3L,0L,0L,9L,4L,8L,6L,0L,4L,0L,0L,2L,9L,6L,7L,5L,5L,2L,7L,4L,2L,1L,6L,8L,9L,8L,6L,7L,3L,7L,0L,5L,7L,8L,9L,5L,7L,0L,6L,7L,6L,4L,0L,2L,2L,9L,2L,6L,9L,4L,8L,2L,7L,4L,6L,8L,6L,1L,1L,5L,0L,4L,9L,7L,1L,6L,5L,8L,4L,1L,1L,3L,5L,2L,2L,3L,8L,4L,5L,5L,6L,0L,6L,8L,5L,8L,8L,6L,3L,4L,1L,5L,3L,6L,9L,3L,1L };
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
public class A099874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099874Inst : IEnumerable<long>
{
public static readonly long[] Value=A099874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099874.Bytes);
public long this[int i]=>Value[i];

public static A099874Inst Instance=new A099874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099875
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,4L,4L,1L,3L,1L,4L,1L,3L,1L,2L,10L,1L,3L,37L,4L,1L,37L,1L,19L,1L,1L,1L,1L,4L,2L,1L,2L,9L,7L,1L,2L,1L,1L,4L,1L,10L,1L,1L,62L,1L,1L,3L,2L,2L,3L,2L,3L,2L,8L,1L,8L,2L,2L,2L,1L,1L,1L,3L,1L,2L,1L,15L,7L,1L,2L,4L,6L,1L,1L,1L,2L,3L,263L,1L,2L,1L,2L,5L,10L,1L,1L,1L,1L,2L,1L,5L,1L,2L,1L,13L,1L,1L,2L,1L };
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
public class A099875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099875Inst : IEnumerable<long>
{
public static readonly long[] Value=A099875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099875.Bytes);
public long this[int i]=>Value[i];

public static A099875Inst Instance=new A099875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099876
{
public static readonly long[] Value={ 1L,8L,2L,7L,0L,1L,4L,7L,1L,7L,6L,0L,8L,5L,9L,2L,2L,2L,6L,3L,7L,3L,8L,4L,3L,1L,9L,2L,8L,5L,2L,8L,9L,2L,4L,7L,3L,7L,4L,7L,9L,3L,6L,2L,9L,6L,0L,8L,2L,5L,4L,8L,5L,4L,4L,2L,6L,1L,6L,2L,4L,6L,2L,9L,5L,6L,2L,1L,0L,0L,1L,5L,2L,3L,8L,7L,0L,9L,6L,7L,2L,7L,8L,3L,1L,0L,7L,2L,4L,4L,1L,6L,6L,1L,4L,3L,0L,5L,5L,5L,0L };
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
public class A099876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099876Inst : IEnumerable<long>
{
public static readonly long[] Value=A099876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099876.Bytes);
public long this[int i]=>Value[i];

public static A099876Inst Instance=new A099876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099877
{
public static readonly long[] Value={ 1L,7L,9L,6L,2L,2L,6L,8L,3L,6L,9L,3L,5L,7L,1L,8L,0L,3L,1L,6L,4L,0L,0L,1L,5L,0L,4L,2L,3L,2L,6L,5L,9L,7L,5L,8L,9L,5L,4L,2L,2L,6L,6L,3L,5L,5L,3L,4L,5L,1L,6L,9L,2L,5L,2L,9L,9L,6L,0L,0L,2L,8L,1L,2L,5L,5L,4L,7L,4L,9L,6L,8L,3L,6L,9L,2L,2L,9L,7L,0L,9L,1L,8L,0L,8L,8L,7L,9L,3L,2L,6L,1L,5L,9L,6L,1L,6L,4L,4L,3L,0L };
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
public class A099877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099877Inst : IEnumerable<long>
{
public static readonly long[] Value=A099877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099877.Bytes);
public long this[int i]=>Value[i];

public static A099877Inst Instance=new A099877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099878
{
public static readonly long[] Value={ 1L,5L,8L,4L,5L,4L,1L,7L,0L,9L,9L,0L,5L,5L,6L,5L,0L,0L,2L,5L,0L,9L,1L,2L,5L,4L,5L,0L,5L,5L,2L,6L,2L,9L,1L,7L,2L,9L,4L,8L,9L,4L,7L,5L,0L,7L,8L,0L,5L,9L,2L,3L,2L,9L,1L,5L,0L,2L,0L,2L,4L,9L,3L,6L,5L,8L,9L,6L,3L,0L,0L,6L,1L,9L,8L,9L,2L,6L,0L,8L,4L,0L,2L,6L,4L,8L,9L,1L,2L,2L,8L,5L,0L,7L,7L,2L,3L,8L,4L,9L,9L,7L,9L,6L };
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
public class A099878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099878Inst : IEnumerable<long>
{
public static readonly long[] Value=A099878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099878.Bytes);
public long this[int i]=>Value[i];

public static A099878Inst Instance=new A099878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099879
{
public static readonly long[] Value={ 1L,9L,4L,2L,6L,5L,5L,4L,2L,2L,7L,6L,3L,9L,8L,7L,3L,2L,8L,2L,2L,1L,4L,1L,3L,2L,9L,1L,4L,1L,2L,6L,6L,7L,2L,3L,7L,6L,8L,8L,0L,7L,3L,6L,3L,0L,0L,0L,7L,1L,1L,5L,5L,1L,5L,1L,0L,0L,5L,6L,9L,5L,6L,1L,7L,7L,7L,6L,3L,2L,2L,3L,0L,8L,8L,9L,3L,4L,3L,4L,6L,5L,9L,7L,1L,5L,3L,2L,0L,8L,0L,6L,7L,5L,0L,1L,6L,8L,5L,3L,9L,8L,0L };
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
public class A099879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099879Inst : IEnumerable<long>
{
public static readonly long[] Value=A099879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099879.Bytes);
public long this[int i]=>Value[i];

public static A099879Inst Instance=new A099879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099880
{
public static readonly BigInteger[] Value={ 0L,2L,18L,260L,5250L,136332L,4327092L,162309576L,7024896450L,344582629820L,18890850749628L,1144656941236536L,75963981061424820L,5479642938171428600L,BigInteger.Parse("426894499408073653800"),BigInteger.Parse("35720957482170932284560"),BigInteger.Parse("3195135789350678836128450") };
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
public class A099880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099880Inst Instance=new A099880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099881
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,5L,52L,771L,21025L };
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
public class A099881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099881Inst : IEnumerable<long>
{
public static readonly long[] Value=A099881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099881.Bytes);
public long this[int i]=>Value[i];

public static A099881Inst Instance=new A099881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099882
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,52L,2015L };
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
public class A099882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099882Inst : IEnumerable<long>
{
public static readonly long[] Value=A099882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099882.Bytes);
public long this[int i]=>Value[i];

public static A099882Inst Instance=new A099882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099883
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,10L,110L,1722L,51039L };
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
public class A099883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099883Inst : IEnumerable<long>
{
public static readonly long[] Value=A099883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099883.Bytes);
public long this[int i]=>Value[i];

public static A099883Inst Instance=new A099883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099884
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,12L,10L,15L,16L,24L,20L,30L,17L,32L,48L,40L,60L,34L,51L,64L,96L,80L,120L,68L,102L,85L,128L,192L,160L,240L,136L,204L,170L,255L,256L,384L,320L,480L,272L,408L,340L,510L,257L,512L,768L,640L,960L,544L,816L,680L,1020L,514L,771L,1024L,1536L,1280L,1920L };
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
public class A099884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099884Inst : IEnumerable<long>
{
public static readonly long[] Value=A099884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099884.Bytes);
public long this[int i]=>Value[i];

public static A099884Inst Instance=new A099884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099885
{
public static readonly long[] Value={ 1L,2L,6L,12L,20L,40L,120L,240L,272L,544L,1632L,3264L,5440L,10880L,32640L,65280L,65792L,131584L,394752L,789504L,1315840L,2631680L,7895040L,15790080L,17895424L,35790848L,107372544L,214745088L,357908480L,715816960L,2147450880L,4294901760L };
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
public class A099885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099885Inst : IEnumerable<long>
{
public static readonly long[] Value=A099885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099885.Bytes);
public long this[int i]=>Value[i];

public static A099885Inst Instance=new A099885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099886
{
public static readonly long[] Value={ 1L,3L,7L,9L,21L,63L,107L,189L,273L,819L,1911L,2457L,5189L,15567L,28123L,46701L,65793L,197379L,460551L,592137L,1381653L,4144959L,7039851L,12434877L,17829905L,53489715L,124809335L,160469145L,340873541L,1022620623L,1840690907L };
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
public class A099886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099886Inst : IEnumerable<long>
{
public static readonly long[] Value=A099886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099886.Bytes);
public long this[int i]=>Value[i];

public static A099886Inst Instance=new A099886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099887
{
public static readonly long[] Value={ 1L,3L,2L,9L,10L,8L,27L,18L,24L,16L,81L,74L,88L,64L,80L,243L,162L,232L,176L,240L,160L,729L,554L,648L,608L,720L,544L,640L,2187L,2642L,2168L,2800L,2192L,2624L,2144L,2784L,6561L,4394L,7032L,4864L,6640L,4448L,6944L,4928L,6560L,19683L,21826L,17512L,24336L,19472L };
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
public class A099887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099887Inst : IEnumerable<long>
{
public static readonly long[] Value=A099887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099887.Bytes);
public long this[int i]=>Value[i];

public static A099887Inst Instance=new A099887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099888
{
public static readonly long[] Value={ 1L,2L,8L,16L,80L,160L,640L,2784L,6560L,21824L,65280L,131072L,524800L,1056192L,4201728L,8408000L,43046720L,86135424L,361186816L,1467183104L,3443838080L,11367226112L,32550397696L,70111011712L,282403304960L,569106797952L };
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
public class A099888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099888Inst : IEnumerable<long>
{
public static readonly long[] Value=A099888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099888.Bytes);
public long this[int i]=>Value[i];

public static A099888Inst Instance=new A099888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099889
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,7L,2L,4L,0L,9L,14L,12L,8L,8L,11L,2L,12L,0L,8L,0L,13L,6L,4L,8L,8L,0L,0L,15L,2L,4L,0L,8L,0L,0L,0L,17L,30L,28L,24L,24L,16L,16L,16L,16L,19L,2L,28L,0L,24L,0L,16L,0L,16L,0L,21L,6L,4L,24L,24L,0L,0L,16L,16L,0L,0L,23L,2L,4L,0L,24L,0L,0L,0L,16L,0L,0L,0L,25L,14L,12L,8L,8L,16L,16L,16L,16L,0L };
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
public class A099889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099889Inst : IEnumerable<long>
{
public static readonly long[] Value=A099889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099889.Bytes);
public long this[int i]=>Value[i];

public static A099889Inst Instance=new A099889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099890
{
public static readonly long[] Value={ 1L,2L,4L,0L,8L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,32L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,64L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,128L };
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
public class A099890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099890Inst : IEnumerable<long>
{
public static readonly long[] Value=A099890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099890.Bytes);
public long this[int i]=>Value[i];

public static A099890Inst Instance=new A099890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099891
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,2L,1L,3L,0L,6L,4L,5L,6L,6L,7L,1L,5L,0L,6L,0L,5L,2L,3L,6L,6L,0L,0L,4L,1L,3L,0L,6L,0L,0L,0L,12L,8L,9L,10L,10L,12L,12L,12L,12L,13L,1L,9L,0L,10L,0L,12L,0L,12L,0L,15L,2L,3L,10L,10L,0L,0L,12L,12L,0L,0L,14L,1L,3L,0L,10L,0L,0L,0L,12L,0L,0L,0L,10L,4L,5L,6L,6L,12L,12L,12L,12L,0L,0L,0L,0L,11L,1L };
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
public class A099891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099891Inst : IEnumerable<long>
{
public static readonly long[] Value=A099891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099891.Bytes);
public long this[int i]=>Value[i];

public static A099891Inst Instance=new A099891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099892
{
public static readonly long[] Value={ 0L,1L,3L,0L,6L,0L,0L,0L,12L,0L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,48L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,96L };
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
public class A099892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099892Inst : IEnumerable<long>
{
public static readonly long[] Value=A099892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099892.Bytes);
public long this[int i]=>Value[i];

public static A099892Inst Instance=new A099892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099893
{
public static readonly long[] Value={ 0L,1L,3L,0L,7L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,31L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,63L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,127L };
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
public class A099893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099893Inst : IEnumerable<long>
{
public static readonly long[] Value=A099893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099893.Bytes);
public long this[int i]=>Value[i];

public static A099893Inst Instance=new A099893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099894
{
public static readonly long[] Value={ 1L,2L,0L,4L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,32L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,64L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A099894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099894Inst : IEnumerable<long>
{
public static readonly long[] Value=A099894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099894.Bytes);
public long this[int i]=>Value[i];

public static A099894Inst Instance=new A099894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099895
{
public static readonly long[] Value={ 1L,3L,5L,0L,9L,0L,0L,0L,17L,0L,0L,0L,0L,0L,0L,0L,33L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,65L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,129L };
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
public class A099895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099895Inst : IEnumerable<long>
{
public static readonly long[] Value=A099895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099895.Bytes);
public long this[int i]=>Value[i];

public static A099895Inst Instance=new A099895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099896
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,4L,5L,14L,15L,13L,12L,9L,8L,10L,11L,28L,29L,31L,30L,27L,26L,24L,25L,18L,19L,17L,16L,21L,20L,22L,23L,56L,57L,59L,58L,63L,62L,60L,61L,54L,55L,53L,52L,49L,48L,50L,51L,36L,37L,39L,38L,35L,34L,32L,33L,42L,43L,41L,40L,45L,44L,46L,47L,112L,113L,115L,114L,119L,118L,116L };
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
public class A099896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099896Inst : IEnumerable<long>
{
public static readonly long[] Value=A099896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099896.Bytes);
public long this[int i]=>Value[i];

public static A099896Inst Instance=new A099896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099897
{
public static readonly long[] Value={ 1L,4L,5L,20L,16L,21L,84L,64L,80L,69L,276L,320L,256L,336L,277L,1108L,1344L,1024L,1280L,1104L,1349L,5396L,4416L,5120L,4096L,5376L,4432L,5141L,20564L,17728L,21504L,16384L,20480L,17664L,21584L,16453L,65812L,86336L,70656L,81920L,65536L,86016L,70912L };
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
public class A099897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099897Inst : IEnumerable<long>
{
public static readonly long[] Value=A099897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099897.Bytes);
public long this[int i]=>Value[i];

public static A099897Inst Instance=new A099897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099898
{
public static readonly long[] Value={ 1L,4L,20L,84L,276L,1108L,5396L,20564L,65812L,263252L,1316116L,5525588L,18153748L,72352852L,352326932L,1342197844L,4295033108L,17180132436L,85900662036L,360782778452L,1185429127444L,4758896116820L,23175995856148L,88323049672788L };
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
public class A099898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099898Inst : IEnumerable<long>
{
public static readonly long[] Value=A099898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099898.Bytes);
public long this[int i]=>Value[i];

public static A099898Inst Instance=new A099898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099899
{
public static readonly long[] Value={ 1L,5L,21L,69L,277L,1349L,5141L,16453L,65813L,329029L,1381397L,4538437L,18088213L,88081733L,335549461L,1073758277L,4295033109L,21475165509L,90195694613L,296357281861L,1189724029205L,5793998964037L,22080762418197L,70666170679365L };
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
public class A099899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099899Inst : IEnumerable<long>
{
public static readonly long[] Value=A099899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099899.Bytes);
public long this[int i]=>Value[i];

public static A099899Inst Instance=new A099899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099900
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,7L,14L,8L,12L,11L,22L,24L,16L,28L,23L,46L,56L,32L,48L,44L,59L,118L,88L,96L,64L,112L,92L,103L,206L,184L,224L,128L,192L,176L,236L,139L,278L,472L,352L,384L,256L,448L,368L,412L,279L,558L,824L,736L,896L,512L,768L,704L,944L,556L,827L,1654L,1112L,1888L,1408L };
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
public class A099900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099900Inst : IEnumerable<long>
{
public static readonly long[] Value=A099900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099900.Bytes);
public long this[int i]=>Value[i];

public static A099900Inst Instance=new A099900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099901
{
public static readonly long[] Value={ 1L,2L,6L,14L,22L,46L,118L,206L,278L,558L,1654L,3790L,5910L,11310L,28790L,49358L,65814L,131630L,394870L,921294L,1447702L,3025966L,7762038L,13549774L,18284822L,36438574L,108004982L,247467726L,385881878L,738208814L,1879076982L,3221274830L };
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
public class A099901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099901Inst : IEnumerable<long>
{
public static readonly long[] Value=A099901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099901.Bytes);
public long this[int i]=>Value[i];

public static A099901Inst Instance=new A099901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099902
{
public static readonly long[] Value={ 1L,3L,7L,11L,23L,59L,103L,139L,279L,827L,1895L,2955L,5655L,14395L,24679L,32907L,65815L,197435L,460647L,723851L,1512983L,3881019L,6774887L,9142411L,18219287L,54002491L,123733863L,192940939L,369104407L,939538491L,1610637415L,2147516555L };
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
public class A099902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099902Inst : IEnumerable<long>
{
public static readonly long[] Value=A099902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099902.Bytes);
public long this[int i]=>Value[i];

public static A099902Inst Instance=new A099902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099903
{
public static readonly long[] Value={ 2L,36L,216L,800L,2250L,5292L,10976L,20736L,36450L,60500L,95832L,146016L,215306L,308700L,432000L,591872L,795906L,1052676L,1371800L,1764000L,2241162L,2816396L,3504096L,4320000L,5281250L,6406452L,7715736L,9230816L,10975050L,12973500L };
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
public class A099903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099903Inst : IEnumerable<long>
{
public static readonly long[] Value=A099903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099903.Bytes);
public long this[int i]=>Value[i];

public static A099903Inst Instance=new A099903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099904
{
public static readonly long[] Value={ 2L,18L,36L,100L,75L,147L,98L,18L,45L,605L,121L,169L,1183L,7L,1L,289L,289L,361L,361L,1L,11L,5819L,529L,1L,13L,13L,1L,841L,841L,961L,961L,1L,17L,17L,1L,1369L,26011L,19L,1L,1681L,1681L,1849L,1849L,1L,23L,50807L,2209L,1L,1L,1L,1L,2809L,2809L,1L,1L,1L,29L,100949L,3481L,3721L };
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
public class A099904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099904Inst : IEnumerable<long>
{
public static readonly long[] Value=A099904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099904.Bytes);
public long this[int i]=>Value[i];

public static A099904Inst Instance=new A099904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099905
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,0L,1L,3L,1L,8L,1L,2L,1L,10L,0L,3L,1L,12L,1L,10L,3L,14L,1L,6L,1L,16L,10L,0L,1L,2L,1L,3L,21L,20L,21L,26L,1L,22L,10L,10L,1L,0L,1L,24L,0L,26L,1L,30L,1L,28L,27L,48L,1L,30L,16L,44L,48L,32L,1L,48L,1L,34L,6L,35L,35L,0L,1L,18L,33L,20L,1L,18L,1L,40L,60L,16L,0L,72L,1L,10L,10L,44L,1L,56L,75L };
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
public class A099905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099905Inst : IEnumerable<long>
{
public static readonly long[] Value=A099905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099905.Bytes);
public long this[int i]=>Value[i];

public static A099905Inst Instance=new A099905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099906
{
public static readonly long[] Value={ 0L,3L,1L,3L,1L,30L,1L,35L,10L,78L,1L,62L,1L,52L,135L,35L,1L,138L,1L,10L,402L,124L,1L,270L,126L,172L,253L,476L,1L,812L,1L,291L,978L,870L,616L,674L,1L,364L,10L,410L,1L,756L,1L,1124L,1260L,532L,1L,1422L,1716L,1128L,2322L,1556L,1L,1920L,1941L,2172L,1815L,844L,1L,3528L,1L,964L };
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
public class A099906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099906Inst : IEnumerable<long>
{
public static readonly long[] Value=A099906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099906.Bytes);
public long this[int i]=>Value[i];

public static A099906Inst Instance=new A099906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099907
{
public static readonly long[] Value={ 0L,3L,10L,35L,1L,30L,1L,291L,253L,378L,1L,782L,1L,2404L,1260L,291L,1L,3378L,1L,410L,7899L,3996L,1L,6030L,126L,10988L,11188L,5180L,1L,19712L,1L,8483L,5334L,34394L,1841L,21410L,1L,20580L,39556L,38810L,1L,64260L,1L,35972L,66060L,36504L,1L,61326L,1716L,123628L };
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
public class A099907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099907Inst : IEnumerable<long>
{
public static readonly long[] Value=A099907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099907.Bytes);
public long this[int i]=>Value[i];

public static A099907Inst Instance=new A099907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099908
{
public static readonly long[] Value={ 0L,3L,10L,35L,126L,462L,1716L,2339L,4627L,2378L,1332L,4238L,2198L,5148L,1260L,57635L,14740L,85026L,61732L,64410L,100509L,163716L,158172L,171918L,93876L,309780L,148969L,444220L,268280L,370712L,29792L,532771L,652200L,938386L,816466L,907874L };
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
public class A099908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099908Inst : IEnumerable<long>
{
public static readonly long[] Value=A099908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099908.Bytes);
public long this[int i]=>Value[i];

public static A099908Inst Instance=new A099908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099909
{
public static readonly long[] Value={ 11L,29L,68L,131L,206L,305L,416L,641L,869L,1113L,1478L,1721L,1976L,2441L,3071L,3539L,4023L,4688L,5111L,5691L,6476L,7301L,8540L,9698L,10301L,10916L,11555L,12206L,14231L,16508L,17813L,18905L,20567L,22349L,23553L,25431L,27056L,28721L,30791L,32219L };
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
public class A099909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099909Inst : IEnumerable<long>
{
public static readonly long[] Value=A099909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099909.Bytes);
public long this[int i]=>Value[i];

public static A099909Inst Instance=new A099909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099910
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,2L,3L,2L,1L,3L,1L,2L,1L,2L,2L,2L,3L,2L,2L,4L,3L,1L,2L,2L,3L,3L,2L,2L,3L,2L,1L,2L,3L,3L,3L,2L,3L,3L,1L,2L,3L,3L,3L,3L,3L,3L,2L,2L,2L,3L,2L,1L,2L,3L,4L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,4L,4L,2L,2L,2L,3L,2L,3L,1L,1L,3L,1L,4L,3L,1L,4L,3L,1L,2L,3L,3L,3L,3L,3L,3L,3L,2L,2L,3L,1L,1L,3L,1L,3L,3L };
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
public class A099910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099910Inst : IEnumerable<long>
{
public static readonly long[] Value=A099910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099910.Bytes);
public long this[int i]=>Value[i];

public static A099910Inst Instance=new A099910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099911
{
public static readonly long[] Value={ 11L,29L,131L,641L,1721L,2441L,3539L,10301L,22349L,36671L,70481L,79241L,170957L,175979L,186191L,198461L,212981L,304127L,313031L,324329L,434939L,655289L,777041L,852827L,1031231L,1126781L,1339781L,1511669L,1571237L,1741079L,1875521L,2003591L };
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
public class A099911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099911Inst : IEnumerable<long>
{
public static readonly long[] Value=A099911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099911.Bytes);
public long this[int i]=>Value[i];

public static A099911Inst Instance=new A099911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099912
{
public static readonly long[] Value={ 1L,4L,32L,328L,3560L,39064L,429512L,4724248L,51965960L,571624024L,6287861192L,69166466968L,760831124360L,8369142343384L,92060565728072L,1012666222910488L,11139328451818760L,122532612969613144L,1347858742664958152L };
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
public class A099912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099912Inst : IEnumerable<long>
{
public static readonly long[] Value=A099912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099912.Bytes);
public long this[int i]=>Value[i];

public static A099912Inst Instance=new A099912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099913
{
public static readonly long[] Value={ 1L,3L,25L,243L,2425L,24243L,242425L,2424243L,24242425L,242424243L,2424242425L,24242424243L,242424242425L,2424242424243L,24242424242425L,242424242424243L,2424242424242425L,24242424242424243L,242424242424242425L };
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
public class A099913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099913Inst : IEnumerable<long>
{
public static readonly long[] Value=A099913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099913.Bytes);
public long this[int i]=>Value[i];

public static A099913Inst Instance=new A099913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099914
{
public static readonly long[] Value={ 1L,14L,144L,1444L,14444L,144444L,1444444L,14444444L,144444444L,1444444444L,14444444444L,144444444444L,1444444444444L,14444444444444L,144444444444444L,1444444444444444L,14444444444444444L,144444444444444444L };
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
public class A099914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099914Inst : IEnumerable<long>
{
public static readonly long[] Value=A099914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099914.Bytes);
public long this[int i]=>Value[i];

public static A099914Inst Instance=new A099914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099915
{
public static readonly long[] Value={ 1L,15L,155L,1555L,15555L,155555L,1555555L,15555555L,155555555L,1555555555L,15555555555L,155555555555L,1555555555555L,15555555555555L,155555555555555L,1555555555555555L,15555555555555555L,155555555555555555L };
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
public class A099915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099915Inst : IEnumerable<long>
{
public static readonly long[] Value=A099915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099915.Bytes);
public long this[int i]=>Value[i];

public static A099915Inst Instance=new A099915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099916
{
public static readonly long[] Value={ 1L,0L,2L,1L,1L,2L,0L,1L,0L,-1L,0L,-2L,-1L,-1L,-2L,0L,-1L,0L,1L,0L,2L,1L,1L,2L,0L,1L,0L,-1L,0L,-2L,-1L,-1L,-2L,0L,-1L,0L,1L,0L,2L,1L,1L,2L,0L,1L,0L,-1L,0L,-2L,-1L,-1L,-2L,0L,-1L,0L,1L,0L,2L,1L,1L,2L,0L,1L,0L,-1L,0L,-2L,-1L,-1L,-2L,0L,-1L,0L,1L,0L,2L,1L,1L,2L,0L,1L,0L,-1L,0L,-2L,-1L,-1L,-2L,0L,-1L,0L,1L,0L,2L,1L,1L,2L,0L,1L,0L,-1L,0L };
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
public class A099916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099916Inst : IEnumerable<long>
{
public static readonly long[] Value=A099916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099916.Bytes);
public long this[int i]=>Value[i];

public static A099916Inst Instance=new A099916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099917
{
public static readonly long[] Value={ 1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L,2L,-1L,1L,-2L,0L,-1L,0L,1L,0L };
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
public class A099917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099917Inst : IEnumerable<long>
{
public static readonly long[] Value=A099917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099917.Bytes);
public long this[int i]=>Value[i];

public static A099917Inst Instance=new A099917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099918
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L,-1L,0L,1L,-1L,2L,-2L,1L };
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
public class A099918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099918Inst : IEnumerable<long>
{
public static readonly long[] Value=A099918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099918.Bytes);
public long this[int i]=>Value[i];

public static A099918Inst Instance=new A099918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099919
{
public static readonly long[] Value={ 0L,2L,10L,44L,188L,798L,3382L,14328L,60696L,257114L,1089154L,4613732L,19544084L,82790070L,350704366L,1485607536L,6293134512L,26658145586L,112925716858L,478361013020L,2026369768940L,8583840088782L,36361730124070L };
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
public class A099919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099919Inst : IEnumerable<long>
{
public static readonly long[] Value=A099919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099919.Bytes);
public long this[int i]=>Value[i];

public static A099919Inst Instance=new A099919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099920
{
public static readonly long[] Value={ 0L,2L,3L,8L,15L,30L,56L,104L,189L,340L,605L,1068L,1872L,3262L,5655L,9760L,16779L,28746L,49096L,83620L,142065L,240812L,407353L,687768L,1159200L,1950650L,3277611L,5499704L,9216519L,15426870L,25793240L,43080608L,71884197L,119835652L };
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
public class A099920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099920Inst : IEnumerable<long>
{
public static readonly long[] Value=A099920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099920.Bytes);
public long this[int i]=>Value[i];

public static A099920Inst Instance=new A099920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099921
{
public static readonly long[] Value={ 5L,5L,20L,45L,125L,320L,845L,2205L,5780L,15125L,39605L,103680L,271445L,710645L,1860500L,4870845L,12752045L,33385280L,87403805L,228826125L,599074580L,1568397605L,4106118245L,10749957120L,28143753125L,73681302245L,192900153620L,505019158605L,1322157322205L };
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
public class A099921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099921Inst : IEnumerable<long>
{
public static readonly long[] Value=A099921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099921.Bytes);
public long this[int i]=>Value[i];

public static A099921Inst Instance=new A099921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099922
{
public static readonly long[] Value={ 1L,17L,138L,979L,6755L,46356L,317797L,2178293L,14930334L,102334135L,701408711L,4807526952L,32951280073L,225851433689L,1548008755890L,10610209857691L,72723460248107L,498454011879228L,3416454622906669L,23416728348467645L };
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
public class A099922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099922Inst : IEnumerable<long>
{
public static readonly long[] Value=A099922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099922.Bytes);
public long this[int i]=>Value[i];

public static A099922Inst Instance=new A099922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099923
{
public static readonly long[] Value={ 16L,1L,81L,256L,2401L,14641L,104976L,707281L,4879681L,33362176L,228886641L,1568239201L,10750371856L,73680216481L,505022001201L,3461445366016L,23725169980801L,162614549665681L,1114577187760656L,7639424429247601L };
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
public class A099923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099923Inst : IEnumerable<long>
{
public static readonly long[] Value=A099923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099923.Bytes);
public long this[int i]=>Value[i];

public static A099923Inst Instance=new A099923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099924
{
public static readonly long[] Value={ 4L,4L,13L,22L,45L,82L,152L,274L,491L,870L,1531L,2676L,4652L,8048L,13865L,23798L,40713L,69446L,118144L,200510L,339559L,573894L,968183L,1630632L,2742100L,4604572L,7721797L,12933334L,21637221L,36159610L,60367976L,100687786L };
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
public class A099924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099924Inst : IEnumerable<long>
{
public static readonly long[] Value=A099924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099924.Bytes);
public long this[int i]=>Value[i];

public static A099924Inst Instance=new A099924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099925
{
public static readonly long[] Value={ 3L,0L,4L,3L,8L,10L,19L,28L,48L,75L,124L,198L,323L,520L,844L,1363L,2208L,3570L,5779L,9348L,15128L,24475L,39604L,64078L,103683L,167760L,271444L,439203L,710648L,1149850L,1860499L,3010348L,4870848L,7881195L,12752044L,20633238L,33385283L,54018520L,87403804L };
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
public class A099925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099925Inst : IEnumerable<long>
{
public static readonly long[] Value=A099925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099925.Bytes);
public long this[int i]=>Value[i];

public static A099925Inst Instance=new A099925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099926
{
public static readonly long[] Value={ 1L,2L,2L,5L,6L,12L,17L,30L,46L,77L,122L,200L,321L,522L,842L,1365L,2206L,3572L,5777L,9350L };
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
public class A099926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099926Inst : IEnumerable<long>
{
public static readonly long[] Value=A099926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099926.Bytes);
public long this[int i]=>Value[i];

public static A099926Inst Instance=new A099926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099927
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,12L,30L,12L,1L,1L,29L,174L,174L,29L,1L,1L,70L,1015L,2436L,1015L,70L,1L,1L,169L,5915L,34307L,34307L,5915L,169L,1L,1L,408L,34476L,482664L,1166438L,482664L,34476L,408L,1L,1L,985L,200940L,6791772L,39618670L,39618670L,6791772L,200940L,985L,1L };
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
public class A099927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099927Inst : IEnumerable<long>
{
public static readonly long[] Value=A099927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099927.Bytes);
public long this[int i]=>Value[i];

public static A099927Inst Instance=new A099927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099928
{
public static readonly BigInteger[] Value={ 1L,2L,4L,12L,56L,408L,4608L,80784L,2201536L,93224736L,6134017792L,627029574336L,99602689462784L,24580813373119872L,9426621978735869952UL,BigInteger.Parse("5616371724370667073792"),BigInteger.Parse("5199854362208758062125056"),BigInteger.Parse("7479400854548558531507839488"),BigInteger.Parse("16717751433807850998823619411968") };
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
public class A099928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099928Inst Instance=new A099928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099929
{
public static readonly BigInteger[] Value={ 1L,2L,30L,2436L,1166438L,3248730940L,52755584809356L,4992850354675749192L,BigInteger.Parse("2754130291777980970686150"),BigInteger.Parse("8854642279944231931659815098860"),BigInteger.Parse("165923943638796574201560736475319416580"),BigInteger.Parse("18121679707218614746613513717704194807763644600") };
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
public class A099929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099929Inst Instance=new A099929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099930
{
public static readonly long[] Value={ 1L,12L,174L,2436L,34307L,482664L,6791772L,95567064L,1344731653L,18921807828L,266250046986L,3746422451772L,52716164405255L,741772724044560L,10437534301224120L,146867252940711408L,2066579075472320521L };
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
public class A099930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099930Inst : IEnumerable<long>
{
public static readonly long[] Value=A099930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099930.Bytes);
public long this[int i]=>Value[i];

public static A099930Inst Instance=new A099930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099931
{
public static readonly BigInteger[] Value={ 1L,29L,1015L,34307L,1166438L,39618670L,1345902818L,45720876202L,1553165059215L,52761884311059L,1792350941301921L,60887169888069525L,2068371426604585180L,BigInteger.Parse("70263741326790571820"),BigInteger.Parse("2386898833730186862100") };
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
public class A099931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099931.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099931Inst Instance=new A099931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099932
{
public static readonly long[] Value={ 1L,2L,-1L,4L,-4L,8L,-12L,2L,16L,-32L,16L,32L,-80L,80L,-16L,64L,-192L,320L,-192L,128L,-448L,1120L,-1344L,272L,256L,-1024L,3584L,-7168L,4352L,512L,-2304L,10752L,-32256L,39168L,-7936L,1024L,-5120L,30720L,-129024L,261120L,-158720L,2048L,-11264L };
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
public class A099932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099932Inst : IEnumerable<long>
{
public static readonly long[] Value=A099932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099932.Bytes);
public long this[int i]=>Value[i];

public static A099932Inst Instance=new A099932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099933
{
public static readonly BigInteger[] Value={ 1L,2L,11L,110L,1555L,28248L,626219L,16383796L,494052001L,16870035070L,643387631279L,27105962133498L,1250204513874499L,62655598615243340L,3390311968553510615L,BigInteger.Parse("196993431796981792712"),BigInteger.Parse("12233255754813946704001") };
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
public class A099933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099933.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099933Inst Instance=new A099933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099934
{
public static readonly long[] Value={ 1L,2L,4L,11L,41L,195L,1130L,7716L,60599L,537676L,5316162L,57940107L,689965123L,8911606493L,124072525780L,1852176280208L,29510747957549L,499830538998126L,8967438954008720L,169881509587167555L };
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
public class A099934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099934Inst : IEnumerable<long>
{
public static readonly long[] Value=A099934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099934.Bytes);
public long this[int i]=>Value[i];

public static A099934Inst Instance=new A099934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099935
{
public static readonly long[] Value={ 7L,4L,1L,0L,2L,7L,9L,2L,1L,5L,2L,3L,5L,7L,7L,3L,5L,5L,8L,4L,1L,7L,8L,3L,9L,8L,6L,6L,7L,1L,0L,2L,4L,4L,1L,1L,7L,3L,2L,5L,5L,8L,8L,4L,2L,5L,0L,1L,5L,0L,0L,2L,1L,8L,4L,2L,5L,8L,0L,2L,8L,0L,8L,4L,7L,7L,8L,3L,8L,7L,4L,4L,4L,8L,9L,0L,8L,1L,5L,9L,6L,7L,2L,5L,1L,1L,6L,6L,2L,2L,1L,6L,0L,9L,5L,9L,4L,4L,1L,1L,5L,6L,4L,0L };
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
public class A099935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099935Inst : IEnumerable<long>
{
public static readonly long[] Value=A099935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099935.Bytes);
public long this[int i]=>Value[i];

public static A099935Inst Instance=new A099935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099936
{
public static readonly BigInteger[] Value={ 2L,3L,5L,17L,257L,12289L,14155777L,169869313L,4076863489L,BigInteger.Parse("32318253138475745281"),BigInteger.Parse("12806790724213976503626296721408001"),BigInteger.Parse("307362977381135436087031121313792001") };
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
public class A099936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099936Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099936.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099936Inst Instance=new A099936Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099937
{
public static readonly long[] Value={ 5L,37L,97L,421L,673L,2659L,3407L,3847L,7703L,13229L,176921L };
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
public class A099937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099937Inst : IEnumerable<long>
{
public static readonly long[] Value=A099937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099937.Bytes);
public long this[int i]=>Value[i];

public static A099937Inst Instance=new A099937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099938
{
public static readonly long[] Value={ 2L,4L,18L,100L,578L,3364L,19602L,114244L,665858L,3880900L,22619538L,131836324L,768398402L,4478554084L,26102926098L,152139002500L,886731088898L,5168247530884L,30122754096402L,175568277047524L,1023286908188738L,5964153172084900L,34761632124320658L };
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
public class A099938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099938Inst : IEnumerable<long>
{
public static readonly long[] Value=A099938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099938.Bytes);
public long this[int i]=>Value[i];

public static A099938Inst Instance=new A099938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099939
{
public static readonly long[] Value={ 19L,15L,18L,18L,17L,18L,19L,16L,20L,19L,15L,11L,14L,14L,13L,14L,15L,12L,16L,15L,18L,14L,17L,17L,16L,17L,18L,15L,19L,18L,18L,14L,17L,17L,16L,17L,18L,15L,19L,18L,17L,13L,16L,16L,15L,16L,17L,14L,18L,17L,18L,14L,17L,17L,16L,17L,18L,15L,19L,18L,14L,10L,13L,13L,12L,13L,14L,11L,15L };
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
public class A099939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099939Inst : IEnumerable<long>
{
public static readonly long[] Value=A099939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099939.Bytes);
public long this[int i]=>Value[i];

public static A099939Inst Instance=new A099939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099940
{
public static readonly ulong[] Value={ 2L,1L,1L,1L,5L,1L,84L,11L,184L,15L,193248L,23L,19056960L,833L,33740L,64035L,520105017600L,2473L,130859579289600L,203685L,963513600L,23748417L,16397141420298240000UL,645119L,555804546402631680L,8527366575L };
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
public class A099940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099940Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A099940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099940.Bytes);
public ulong this[int i]=>Value[i];

public static A099940Inst Instance=new A099940Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}