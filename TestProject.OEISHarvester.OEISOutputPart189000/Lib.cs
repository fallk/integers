using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A219457
{
public static readonly long[] Value={ 35L,57L,2266L,27967L,435960L,5544714L,66665715L,751202772L,8208948549L,87170751438L,897312955817L,8917727697792L,85536777162139L,793356895156864L,7134205585556452L,62337420990580258L,530111165027188400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219457Inst : IEnumerable<long>
{
public static readonly long[] Value=A219457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219457.Bytes);
public long this[int i]=>Value[i];

public static A219457Inst Instance=new A219457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219458
{
public static readonly long[] Value={ 56L,116L,9146L,197308L,5544714L,124508284L,2651269670L,53196852108L,1047933583037L,20209185822504L,378007643734290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219458Inst : IEnumerable<long>
{
public static readonly long[] Value=A219458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219458.Bytes);
public long this[int i]=>Value[i];

public static A219458Inst Instance=new A219458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219459
{
public static readonly long[] Value={ 84L,231L,34529L,1324860L,66665715L,2651269670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219459Inst : IEnumerable<long>
{
public static readonly long[] Value=A219459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219459.Bytes);
public long this[int i]=>Value[i];

public static A219459Inst Instance=new A219459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219460
{
public static readonly long[] Value={ 4L,4L,4L,10L,4L,10L,20L,13L,13L,20L,35L,26L,114L,26L,35L,56L,57L,498L,498L,57L,56L,84L,116L,2266L,3422L,2266L,116L,84L,120L,231L,9146L,27967L,27967L,9146L,231L,120L,165L,450L,34529L,197308L,435960L,197308L,34529L,450L,165L,220L,859L,123778L,1324860L,5544714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219460Inst : IEnumerable<long>
{
public static readonly long[] Value=A219460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219460.Bytes);
public long this[int i]=>Value[i];

public static A219460Inst Instance=new A219460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219461
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,89L,107L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219461Inst : IEnumerable<long>
{
public static readonly long[] Value=A219461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219461.Bytes);
public long this[int i]=>Value[i];

public static A219461Inst Instance=new A219461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219462
{
public static readonly BigInteger[] Value={ 0L,5L,75L,1000L,13125L,171875L,2250000L,29453125L,385546875L,5046875000L,66064453125L,864794921875L,11320312500000L,148184814453125L,1939764404296875L,25391845703125000L,332383575439453125L,4350957489013671875L,BigInteger.Parse("56954772949218750000"),BigInteger.Parse("745547657012939453125") };
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
public class A219462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219462Inst Instance=new A219462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219463
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219463Inst : IEnumerable<long>
{
public static readonly long[] Value=A219463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219463.Bytes);
public long this[int i]=>Value[i];

public static A219463Inst Instance=new A219463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219464
{
public static readonly long[] Value={ 4L,23L,673L,87083L,43792361L,86755752059L,664221777830589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219464Inst : IEnumerable<long>
{
public static readonly long[] Value=A219464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219464.Bytes);
public long this[int i]=>Value[i];

public static A219464Inst Instance=new A219464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219465
{
public static readonly long[] Value={ 4L,23L,82L,239L,619L,1471L,3259L,6800L,13464L,25453L,46178L,80755L,136643L,224449L,358927L,560200L,855236L,1279611L,1879594L,2714591L,3859987L,5410427L,7483579L,10224424L,13810120L,18455489L,24419178L,32010547L,41597339L,53614189L,68572031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219465Inst : IEnumerable<long>
{
public static readonly long[] Value=A219465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219465.Bytes);
public long this[int i]=>Value[i];

public static A219465Inst Instance=new A219465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219466
{
public static readonly long[] Value={ 10L,68L,673L,5040L,32229L,185800L,982456L,4815782L,22059734L,95049799L,387398157L,1500899485L,5551333536L,19675267097L,67041131529L,220243855894L,699365511947L,2151361250171L,6423848162633L,18651881494908L,52745972542258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219466Inst : IEnumerable<long>
{
public static readonly long[] Value=A219466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219466.Bytes);
public long this[int i]=>Value[i];

public static A219466Inst Instance=new A219466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219467
{
public static readonly long[] Value={ 20L,211L,4838L,87083L,1306891L,17399442L,208345624L,2285009931L,23253970439L,221258732227L,1979908560027L,16752069750566L,134676183213583L,1033204910207865L,7592661274649504L,53621665489883610L,364978798507011324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219467Inst : IEnumerable<long>
{
public static readonly long[] Value=A219467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219467.Bytes);
public long this[int i]=>Value[i];

public static A219467Inst Instance=new A219467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219468
{
public static readonly BigInteger[] Value={ 35L,547L,28159L,1227441L,43792361L,1357658929L,37552353044L,947150536824L,22129769822973L,483036569368799L,9904217535401123L,191717483791553680L,3519902109176030571L,BigInteger.Parse("61551065872538233732"),BigInteger.Parse("1028861754560712576407") };
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
public class A219468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219468Inst Instance=new A219468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219469
{
public static readonly BigInteger[] Value={ 56L,1248L,143718L,14696377L,1222433026L,86755752059L,5432184254977L,310024709155795L,16405518197790913L,811074258908798713L,BigInteger.Parse("37650885062774172715"),BigInteger.Parse("1649171050584662652825"),BigInteger.Parse("68487713712896868019851") };
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
public class A219469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219469Inst Instance=new A219469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219470
{
public static readonly long[] Value={ 84L,2663L,674954L,157191488L,29873644925L,4758315482104L,664221777830589L,85045859176792827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219470Inst : IEnumerable<long>
{
public static readonly long[] Value=A219470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219470.Bytes);
public long this[int i]=>Value[i];

public static A219470Inst Instance=new A219470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219471
{
public static readonly long[] Value={ 4L,4L,10L,10L,23L,20L,20L,68L,82L,35L,35L,211L,673L,239L,56L,56L,547L,4838L,5040L,619L,84L,84L,1248L,28159L,87083L,32229L,1471L,120L,120L,2663L,143718L,1227441L,1306891L,185800L,3259L,165L,165L,5432L,674954L,14696377L,43792361L,17399442L,982456L,6800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219471Inst : IEnumerable<long>
{
public static readonly long[] Value=A219471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219471.Bytes);
public long this[int i]=>Value[i];

public static A219471Inst Instance=new A219471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219472
{
public static readonly long[] Value={ 10L,23L,68L,211L,547L,1248L,2663L,5432L,10666L,20206L,36984L,65512L,112528L,187831L,305340L,484415L,751481L,1141999L,1702831L,2495049L,3597241L,5109370L,7157245L,9897666L,13524308L,18274412L,24436354L,32358166L,42457086L,55230217L,71266378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219472Inst : IEnumerable<long>
{
public static readonly long[] Value=A219472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219472.Bytes);
public long this[int i]=>Value[i];

public static A219472Inst Instance=new A219472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219473
{
public static readonly long[] Value={ 20L,82L,673L,4838L,28159L,143718L,674954L,2941342L,11981143L,45898940L,166443227L,574474013L,1895549798L,6001932167L,18298398284L,53884690148L,153709998598L,425853237243L,1148567805278L,3022012284611L,7771027231688L,19561835095982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219473Inst : IEnumerable<long>
{
public static readonly long[] Value=A219473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219473.Bytes);
public long this[int i]=>Value[i];

public static A219473Inst Instance=new A219473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219474
{
public static readonly long[] Value={ 35L,239L,5040L,87083L,1227441L,14696377L,157191488L,1532762665L,13807624794L,116296337706L,924459750842L,6973773054426L,50113925911679L,344224992704591L,2267656840216326L,14372813464098494L,87897599949502791L,519959958984757538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219474Inst : IEnumerable<long>
{
public static readonly long[] Value=A219474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219474.Bytes);
public long this[int i]=>Value[i];

public static A219474Inst Instance=new A219474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219475
{
public static readonly long[] Value={ 56L,619L,32229L,1306891L,43792361L,1222433026L,29873644925L,662533943916L,13515253913829L,257247067131996L,4617731855899377L,78635760906475856L,1275140440612833310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219475Inst : IEnumerable<long>
{
public static readonly long[] Value=A219475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219475.Bytes);
public long this[int i]=>Value[i];

public static A219475Inst Instance=new A219475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219476
{
public static readonly long[] Value={ 84L,1471L,185800L,17399442L,1357658929L,86755752059L,4758315482104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219476Inst : IEnumerable<long>
{
public static readonly long[] Value=A219476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219476.Bytes);
public long this[int i]=>Value[i];

public static A219476Inst Instance=new A219476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219477
{
public static readonly long[] Value={ 120L,3259L,982456L,208345624L,37552353044L,5432184254977L,664221777830589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219477Inst : IEnumerable<long>
{
public static readonly long[] Value=A219477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219477.Bytes);
public long this[int i]=>Value[i];

public static A219477Inst Instance=new A219477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219478
{
public static readonly long[] Value={ 79L,281L,349L,439L,643L,677L,787L,887L,1171L,1327L,1733L,1811L,2141L,2347L,2389L,2767L,2791L,3323L,3329L,3529L,3929L,4157L,4349L,4751L,4799L,4919L,4951L,5003L,5189L,5323L,5347L,5521L,5531L,5857L,5861L,6287L,6337L,6473L,6823L,6967L,6997L,7507L,7933L,8233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219478Inst : IEnumerable<long>
{
public static readonly long[] Value=A219478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219478.Bytes);
public long this[int i]=>Value[i];

public static A219478Inst Instance=new A219478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219479
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,2L,3L,1L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,2L,4L,2L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,1L,4L,3L,0L,0L,0L,0L,3L,5L,2L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,2L,5L,3L,0L,0L,0L,0L,3L,4L,1L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,3L,6L,3L,0L,0L,0L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219479Inst : IEnumerable<long>
{
public static readonly long[] Value=A219479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219479.Bytes);
public long this[int i]=>Value[i];

public static A219479Inst Instance=new A219479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219480
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,0L,2L,3L,1L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,2L,4L,2L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,1L,4L,3L,0L,0L,0L,0L,0L,3L,5L,2L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,0L,2L,5L,3L,0L,0L,0L,0L,0L,3L,4L,1L,0L,0L,0L,0L,0L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219480Inst : IEnumerable<long>
{
public static readonly long[] Value=A219480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219480.Bytes);
public long this[int i]=>Value[i];

public static A219480Inst Instance=new A219480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219481
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,0L,0L,2L,3L,1L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,0L,2L,4L,2L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,0L,1L,4L,3L,0L,0L,0L,0L,0L,0L,3L,5L,2L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,0L,0L,2L,5L,3L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219481Inst : IEnumerable<long>
{
public static readonly long[] Value=A219481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219481.Bytes);
public long this[int i]=>Value[i];

public static A219481Inst Instance=new A219481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219482
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,0L,0L,0L,2L,3L,1L,0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,0L,0L,2L,4L,2L,0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,0L,0L,0L,1L,4L,3L,0L,0L,0L,0L,0L,0L,0L,3L,5L,2L,0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219482Inst : IEnumerable<long>
{
public static readonly long[] Value=A219482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219482.Bytes);
public long this[int i]=>Value[i];

public static A219482Inst Instance=new A219482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219483
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,1L,0L,3L,0L,2L,0L,0L,0L,0L,2L,0L,3L,0L,1L,0L,0L,0L,0L,3L,0L,3L,0L,0L,0L,0L,2L,0L,4L,0L,2L,0L,0L,0L,0L,3L,0L,3L,0L,0L,0L,0L,1L,0L,4L,0L,3L,0L,0L,0L,0L,3L,0L,5L,0L,2L,0L,0L,0L,0L,4L,0L,4L,0L,0L,0L,0L,2L,0L,5L,0L,3L,0L,0L,0L,0L,3L,0L,4L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219483Inst : IEnumerable<long>
{
public static readonly long[] Value=A219483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219483.Bytes);
public long this[int i]=>Value[i];

public static A219483Inst Instance=new A219483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219484
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,3L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,3L,0L,1L,0L,0L,0L,0L,0L,0L,3L,0L,3L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,2L,0L,0L,0L,0L,0L,0L,3L,0L,3L,0L,0L,0L,0L,0L,0L,1L,0L,4L,0L,3L,0L,0L,0L,0L,0L,0L,3L,0L,5L,0L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219484Inst : IEnumerable<long>
{
public static readonly long[] Value=A219484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219484.Bytes);
public long this[int i]=>Value[i];

public static A219484Inst Instance=new A219484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219485
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,1L,0L,0L,3L,0L,0L,2L,0L,0L,0L,2L,0L,0L,3L,0L,0L,1L,0L,0L,0L,3L,0L,0L,3L,0L,0L,0L,2L,0L,0L,4L,0L,0L,2L,0L,0L,0L,3L,0L,0L,3L,0L,0L,0L,1L,0L,0L,4L,0L,0L,3L,0L,0L,0L,3L,0L,0L,5L,0L,0L,2L,0L,0L,0L,4L,0L,0L,4L,0L,0L,0L,2L,0L,0L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219485Inst : IEnumerable<long>
{
public static readonly long[] Value=A219485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219485.Bytes);
public long this[int i]=>Value[i];

public static A219485Inst Instance=new A219485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219486
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,3L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,3L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,3L,0L,0L,0L,0L,2L,0L,0L,4L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,4L,0L,0L,3L,0L,0L,0L,0L,3L,0L,0L,5L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219486Inst : IEnumerable<long>
{
public static readonly long[] Value=A219486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219486.Bytes);
public long this[int i]=>Value[i];

public static A219486Inst Instance=new A219486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219487
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,2L,0L,0L,2L,1L,0L,1L,2L,0L,0L,3L,0L,0L,2L,2L,0L,0L,3L,0L,0L,3L,1L,0L,2L,3L,0L,0L,4L,0L,0L,3L,2L,0L,1L,3L,0L,0L,4L,0L,0L,3L,3L,0L,0L,5L,0L,0L,4L,2L,0L,2L,4L,0L,0L,5L,0L,0L,3L,3L,0L,0L,4L,0L,0L,4L,1L,0L,3L,4L,0L,0L,6L,0L,0L,5L,3L,0L,2L,5L,0L,0L,6L,0L,0L,4L,4L,0L,0L,6L,0L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219487Inst : IEnumerable<long>
{
public static readonly long[] Value=A219487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219487.Bytes);
public long this[int i]=>Value[i];

public static A219487Inst Instance=new A219487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219488
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,3L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219488Inst : IEnumerable<long>
{
public static readonly long[] Value=A219488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219488.Bytes);
public long this[int i]=>Value[i];

public static A219488Inst Instance=new A219488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219489
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,3L,2L,0L,0L,0L,2L,3L,3L,2L,0L,0L,1L,3L,4L,3L,1L,0L,0L,2L,3L,4L,3L,0L,0L,0L,3L,5L,4L,2L,0L,0L,2L,4L,5L,3L,0L,0L,0L,3L,4L,4L,3L,0L,0L,1L,4L,6L,5L,2L,0L,0L,3L,5L,6L,4L,0L,0L,0L,4L,6L,5L,3L,0L,0L,2L,5L,6L,4L,1L,0L,0L,3L,4L,5L,4L,0L,0L,0L,4L,7L,6L,3L,0L,0L,3L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219489Inst : IEnumerable<long>
{
public static readonly long[] Value=A219489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219489.Bytes);
public long this[int i]=>Value[i];

public static A219489Inst Instance=new A219489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219490
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,2L,0L,2L,0L,1L,1L,0L,2L,0L,3L,0L,2L,0L,0L,2L,0L,3L,0L,3L,0L,2L,1L,0L,3L,0L,4L,0L,3L,0L,1L,2L,0L,3L,0L,4L,0L,3L,0L,0L,3L,0L,5L,0L,4L,0L,2L,2L,0L,4L,0L,5L,0L,3L,0L,0L,3L,0L,4L,0L,4L,0L,3L,1L,0L,4L,0L,6L,0L,5L,0L,2L,3L,0L,5L,0L,6L,0L,4L,0L,0L,4L,0L,6L,0L,5L,0L,3L,2L,0L,5L,0L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219490Inst : IEnumerable<long>
{
public static readonly long[] Value=A219490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219490.Bytes);
public long this[int i]=>Value[i];

public static A219490Inst Instance=new A219490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219491
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,2L,0L,0L,2L,0L,1L,1L,0L,2L,0L,0L,3L,0L,0L,2L,0L,2L,0L,0L,3L,0L,0L,3L,0L,1L,2L,0L,3L,0L,0L,4L,0L,0L,3L,0L,2L,1L,0L,3L,0L,0L,4L,0L,0L,3L,0L,3L,0L,0L,5L,0L,0L,4L,0L,2L,2L,0L,4L,0L,0L,5L,0L,0L,3L,0L,3L,0L,0L,4L,0L,0L,4L,0L,1L,3L,0L,4L,0L,0L,6L,0L,0L,5L,0L,3L,2L,0L,5L,0L,0L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219491Inst : IEnumerable<long>
{
public static readonly long[] Value=A219491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219491.Bytes);
public long this[int i]=>Value[i];

public static A219491Inst Instance=new A219491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219492
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,2L,1L,0L,0L,1L,2L,0L,0L,0L,3L,0L,0L,0L,2L,2L,0L,0L,0L,3L,0L,0L,0L,3L,1L,0L,0L,2L,3L,0L,0L,0L,4L,0L,0L,0L,3L,2L,0L,0L,1L,3L,0L,0L,0L,4L,0L,0L,0L,3L,3L,0L,0L,0L,5L,0L,0L,0L,4L,2L,0L,0L,2L,4L,0L,0L,0L,5L,0L,0L,0L,3L,3L,0L,0L,0L,4L,0L,0L,0L,4L,1L,0L,0L,3L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219492Inst : IEnumerable<long>
{
public static readonly long[] Value=A219492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219492.Bytes);
public long this[int i]=>Value[i];

public static A219492Inst Instance=new A219492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219493
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,1L,2L,3L,2L,0L,0L,0L,0L,2L,3L,3L,2L,0L,0L,0L,1L,3L,4L,3L,1L,0L,0L,0L,2L,3L,4L,3L,0L,0L,0L,0L,3L,5L,4L,2L,0L,0L,0L,2L,4L,5L,3L,0L,0L,0L,0L,3L,4L,4L,3L,0L,0L,0L,1L,4L,6L,5L,2L,0L,0L,0L,3L,5L,6L,4L,0L,0L,0L,0L,4L,6L,5L,3L,0L,0L,0L,2L,5L,6L,4L,1L,0L,0L,0L,3L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219493Inst : IEnumerable<long>
{
public static readonly long[] Value=A219493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219493.Bytes);
public long this[int i]=>Value[i];

public static A219493Inst Instance=new A219493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219494
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,1L,2L,3L,2L,0L,0L,0L,0L,0L,2L,3L,3L,2L,0L,0L,0L,0L,1L,3L,4L,3L,1L,0L,0L,0L,0L,2L,3L,4L,3L,0L,0L,0L,0L,0L,3L,5L,4L,2L,0L,0L,0L,0L,2L,4L,5L,3L,0L,0L,0L,0L,0L,3L,4L,4L,3L,0L,0L,0L,0L,1L,4L,6L,5L,2L,0L,0L,0L,0L,3L,5L,6L,4L,0L,0L,0L,0L,0L,4L,6L,5L,3L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219494Inst : IEnumerable<long>
{
public static readonly long[] Value=A219494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219494.Bytes);
public long this[int i]=>Value[i];

public static A219494Inst Instance=new A219494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219495
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,1L,0L,0L,1L,0L,2L,0L,3L,0L,2L,0L,0L,0L,0L,2L,0L,3L,0L,3L,0L,2L,0L,0L,1L,0L,3L,0L,4L,0L,3L,0L,1L,0L,0L,2L,0L,3L,0L,4L,0L,3L,0L,0L,0L,0L,3L,0L,5L,0L,4L,0L,2L,0L,0L,2L,0L,4L,0L,5L,0L,3L,0L,0L,0L,0L,3L,0L,4L,0L,4L,0L,3L,0L,0L,1L,0L,4L,0L,6L,0L,5L,0L,2L,0L,0L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219495Inst : IEnumerable<long>
{
public static readonly long[] Value=A219495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219495.Bytes);
public long this[int i]=>Value[i];

public static A219495Inst Instance=new A219495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219496
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,1L,2L,3L,2L,0L,0L,0L,0L,0L,0L,2L,3L,3L,2L,0L,0L,0L,0L,0L,1L,3L,4L,3L,1L,0L,0L,0L,0L,0L,2L,3L,4L,3L,0L,0L,0L,0L,0L,0L,3L,5L,4L,2L,0L,0L,0L,0L,0L,2L,4L,5L,3L,0L,0L,0L,0L,0L,0L,3L,4L,4L,3L,0L,0L,0L,0L,0L,1L,4L,6L,5L,2L,0L,0L,0L,0L,0L,3L,5L,6L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219496Inst : IEnumerable<long>
{
public static readonly long[] Value=A219496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219496.Bytes);
public long this[int i]=>Value[i];

public static A219496Inst Instance=new A219496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219497
{
public static readonly long[] Value={ 2L,3L,11L,35L,107L,325L,995L,3083L,9663L,30581L,97541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219497Inst : IEnumerable<long>
{
public static readonly long[] Value=A219497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219497.Bytes);
public long this[int i]=>Value[i];

public static A219497Inst Instance=new A219497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219498
{
public static readonly long[] Value={ 4L,7L,18L,35L,58L,88L,126L,173L,230L,298L,378L,471L,578L,700L,838L,993L,1166L,1358L,1570L,1803L,2058L,2336L,2638L,2965L,3318L,3698L,4106L,4543L,5010L,5508L,6038L,6601L,7198L,7830L,8498L,9203L,9946L,10728L,11550L,12413L,13318L,14266L,15258L,16295L,17378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219498Inst : IEnumerable<long>
{
public static readonly long[] Value=A219498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219498.Bytes);
public long this[int i]=>Value[i];

public static A219498Inst Instance=new A219498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219499
{
public static readonly long[] Value={ 5L,9L,26L,58L,107L,179L,281L,421L,608L,852L,1164L,1556L,2041L,2633L,3347L,4199L,5206L,6386L,7758L,9342L,11159L,13231L,15581L,18233L,21212L,24544L,28256L,32376L,36933L,41957L,47479L,53531L,60146L,67358L,75202L,83714L,92931L,102891L,113633L,125197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219499Inst : IEnumerable<long>
{
public static readonly long[] Value=A219499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219499.Bytes);
public long this[int i]=>Value[i];

public static A219499Inst Instance=new A219499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219500
{
public static readonly long[] Value={ 6L,11L,35L,88L,179L,325L,550L,885L,1369L,2050L,2986L,4246L,5911L,8075L,10846L,14347L,18717L,24112L,30706L,38692L,48283L,59713L,73238L,89137L,107713L,129294L,154234L,182914L,215743L,253159L,295630L,343655L,397765L,458524L,526530L,602416L,686851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219500Inst : IEnumerable<long>
{
public static readonly long[] Value=A219500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219500.Bytes);
public long this[int i]=>Value[i];

public static A219500Inst Instance=new A219500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219501
{
public static readonly long[] Value={ 7L,13L,45L,126L,281L,550L,995L,1703L,2793L,4424L,6804L,10200L,14949L,21470L,30277L,41993L,57365L,77280L,102782L,135090L,175617L,225990L,288071L,363979L,456113L,567176L,700200L,858572L,1046061L,1266846L,1525545L,1827245L,2177533L,2582528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219501Inst : IEnumerable<long>
{
public static readonly long[] Value=A219501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219501.Bytes);
public long this[int i]=>Value[i];

public static A219501Inst Instance=new A219501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219502
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,4L,5L,5L,4L,5L,7L,11L,7L,5L,6L,9L,18L,18L,9L,6L,7L,11L,26L,35L,26L,11L,7L,8L,13L,35L,58L,58L,35L,13L,8L,9L,15L,45L,88L,107L,88L,45L,15L,9L,10L,17L,56L,126L,179L,179L,126L,56L,17L,10L,11L,19L,68L,173L,281L,325L,281L,173L,68L,19L,11L,12L,21L,81L,230L,421L,550L,550L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219502Inst : IEnumerable<long>
{
public static readonly long[] Value=A219502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219502.Bytes);
public long this[int i]=>Value[i];

public static A219502Inst Instance=new A219502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219503
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,137L,1457L,19355L,308961L,5766353L,123285153L,2972114803L,79782059249L,2360417058521L,76319622510289L,2677629295171979L,101318751122847297L,4113158120834726049L,BigInteger.Parse("178328823993199602241"),BigInteger.Parse("8223999403291995520995"),BigInteger.Parse("401989145900847087408849") };
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
public class A219503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219503Inst Instance=new A219503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219504
{
public static readonly BigInteger[] Value={ 1L,1L,4L,33L,512L,13005L,494976L,26383917L,1876721664L,171728626617L,19650536857600L,2749029193911033L,461590186944847872L,BigInteger.Parse("91611982632843733125"),BigInteger.Parse("21215197576393952452608"),BigInteger.Parse("5669317752667727770720965"),BigInteger.Parse("1731566894935958076783067136"),BigInteger.Parse("599421136964093700021081229041") };
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
public class A219504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219504Inst Instance=new A219504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219505
{
public static readonly long[] Value={ 79L,281L,295L,329L,349L,355L,403L,439L,511L,643L,677L,685L,787L,805L,841L,887L,949L,963L,1171L,1179L,1195L,1241L,1327L,1339L,1397L,1435L,1463L,1503L,1547L,1641L,1685L,1717L,1733L,1779L,1811L,1917L,1957L,1991L,2033L,2061L,2141L,2147L,2347L,2389L,2395L,2433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219505Inst : IEnumerable<long>
{
public static readonly long[] Value=A219505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219505.Bytes);
public long this[int i]=>Value[i];

public static A219505Inst Instance=new A219505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219506
{
public static readonly BigInteger[] Value={ 3L,5L,51L,53L,140451L,140453L,2770663499604051L,2770663499604053L,BigInteger.Parse("21269209556953516583554114034636483645584976451"),BigInteger.Parse("21269209556953516583554114034636483645584976453") };
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
public class A219506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219506Inst Instance=new A219506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219507
{
public static readonly BigInteger[] Value={ 4L,6L,109L,111L,1330669L,1330671L,2356194280407770989L,2356194280407770991L,BigInteger.Parse("13080769480548649962914459850235688797656360638877986029"),BigInteger.Parse("13080769480548649962914459850235688797656360638877986031") };
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
public class A219507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219507Inst Instance=new A219507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219508
{
public static readonly BigInteger[] Value={ 1L,3L,16L,17L,72L,577L,2312L,665857L,2663432L,886731088897L,3546924355592L,BigInteger.Parse("1572584048032918633353217"),BigInteger.Parse("6290336192131674533412872"),BigInteger.Parse("4946041176255201878775086487573351061418968498177") };
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
public class A219508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219508Inst Instance=new A219508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219509
{
public static readonly BigInteger[] Value={ 1L,5L,24L,49L,200L,4801L,19208L,46099201L,184396808L,4250272665676801L,17001090662707208L,BigInteger.Parse("36129635465198759610694779187201"),BigInteger.Parse("144518541860795038442779116748808"),BigInteger.Parse("2610701117696295981568349760414651575095962187244375364404428801") };
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
public class A219509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219509Inst Instance=new A219509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219510
{
public static readonly BigInteger[] Value={ 1L,7L,32L,97L,392L,18817L,75272L,708158977L,2832635912L,1002978273411373057L,4011913093645492232L,BigInteger.Parse("2011930833870518011412817828051050497"),BigInteger.Parse("8047723335482072045651271312204201992") };
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
public class A219510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219510Inst Instance=new A219510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219511
{
public static readonly BigInteger[] Value={ 1L,9L,40L,161L,648L,51841L,207368L,5374978561L,21499914248L,BigInteger.Parse("57780789062419261441"),BigInteger.Parse("231123156249677045768"),BigInteger.Parse("6677239169351578707225356193679818792961"),BigInteger.Parse("26708956677406314828901424774719275171848") };
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
public class A219511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219511Inst Instance=new A219511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219512
{
public static readonly long[] Value={ 1L,1L,3L,1L,12L,15L,1L,33L,141L,105L,1L,78L,786L,1830L,945L,1L,171L,3450L,17538L,26685L,10395L,1L,360L,13257L,125352L,396495L,435960L,135135L,1L,741L,46971L,753291L,4238811L,9356175L,7921305L,2027025L,1L,1506L,157956L,4046526L,37013166L,140913270L,233216460L,158799690L,34459425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219512Inst : IEnumerable<long>
{
public static readonly long[] Value=A219512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219512.Bytes);
public long this[int i]=>Value[i];

public static A219512Inst Instance=new A219512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219513
{
public static readonly long[] Value={ 2L,3L,11L,68L,620L,9292L,241413L,12385870L,1316975534L,278163891037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219513Inst : IEnumerable<long>
{
public static readonly long[] Value=A219513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219513.Bytes);
public long this[int i]=>Value[i];

public static A219513Inst Instance=new A219513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219514
{
public static readonly long[] Value={ 3L,4L,11L,22L,42L,74L,124L,199L,307L,457L,659L,924L,1264L,1692L,2222L,2869L,3649L,4579L,5677L,6962L,8454L,10174L,12144L,14387L,16927L,19789L,22999L,26584L,30572L,34992L,39874L,45249L,51149L,57607L,64657L,72334L,80674L,89714L,99492L,110047L,121419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219514Inst : IEnumerable<long>
{
public static readonly long[] Value=A219514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219514.Bytes);
public long this[int i]=>Value[i];

public static A219514Inst Instance=new A219514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219515
{
public static readonly long[] Value={ 4L,5L,24L,68L,187L,465L,1090L,2430L,5181L,10575L,20714L,39046L,71023L,124990L,213360L,354136L,572847L,904971L,1398924L,2119700L,3153253L,4611718L,6639574L,9420858L,13187545L,18229215L,24904134L,33651882L,45007667L,59618470L,78261172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219515Inst : IEnumerable<long>
{
public static readonly long[] Value=A219515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219515.Bytes);
public long this[int i]=>Value[i];

public static A219515Inst Instance=new A219515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219516
{
public static readonly long[] Value={ 5L,6L,43L,166L,620L,2125L,6994L,22202L,67464L,195743L,543950L,1452673L,3737953L,9286352L,22316636L,51975268L,117526674L,258459526L,553680185L,1157120286L,2362356507L,4717471586L,9225257317L,17685766540L,33272247562L,61483526901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219516Inst : IEnumerable<long>
{
public static readonly long[] Value=A219516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219516.Bytes);
public long this[int i]=>Value[i];

public static A219516Inst Instance=new A219516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219517
{
public static readonly long[] Value={ 6L,7L,70L,380L,1961L,9292L,42906L,193830L,844076L,3502384L,13875479L,52704643L,192502374L,677308600L,2299354092L,7545224194L,23977606181L,73928754282L,221543426554L,646331532510L,1838498878117L,5106121007958L,13864227704969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219517Inst : IEnumerable<long>
{
public static readonly long[] Value=A219517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219517.Bytes);
public long this[int i]=>Value[i];

public static A219517Inst Instance=new A219517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219518
{
public static readonly long[] Value={ 7L,8L,111L,821L,5799L,37442L,241413L,1557761L,9826087L,59070992L,337978798L,1850253044L,9729774437L,49228958731L,239944892209L,1128409561360L,5129688218941L,22582954455191L,96444280283840L,400188527441697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219518Inst : IEnumerable<long>
{
public static readonly long[] Value=A219518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219518.Bytes);
public long this[int i]=>Value[i];

public static A219518Inst Instance=new A219518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219519
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,4L,4L,4L,6L,5L,5L,5L,11L,9L,6L,6L,6L,24L,22L,12L,7L,7L,7L,43L,68L,42L,15L,8L,8L,8L,70L,166L,187L,74L,18L,9L,9L,9L,111L,380L,620L,465L,124L,21L,10L,10L,10L,172L,821L,1961L,2125L,1090L,199L,24L,11L,11L,11L,260L,1700L,5799L,9292L,6994L,2430L,307L,27L,12L,12L,12L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219519Inst : IEnumerable<long>
{
public static readonly long[] Value=A219519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219519.Bytes);
public long this[int i]=>Value[i];

public static A219519Inst Instance=new A219519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219520
{
public static readonly long[] Value={ 4L,6L,11L,24L,43L,70L,111L,172L,260L,383L,550L,771L,1057L,1420L,1873L,2430L,3106L,3917L,4880L,6013L,7335L,8866L,10627L,12640L,14928L,17515L,20426L,23687L,27325L,31368L,35845L,40786L,46222L,52185L,58708L,65825L,73571L,81982L,91095L,100948L,111580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219520Inst : IEnumerable<long>
{
public static readonly long[] Value=A219520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219520.Bytes);
public long this[int i]=>Value[i];

public static A219520Inst Instance=new A219520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219521
{
public static readonly long[] Value={ 5L,9L,22L,68L,166L,380L,821L,1700L,3374L,6430L,11784L,20830L,35631L,59161L,95611L,150769L,232486L,351241L,520819L,759117L,1089094L,1539882L,2148076L,2959222L,4029523L,5427784L,7237618L,9559936L,12515745L,16249279L,20931489L,26763919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219521Inst : IEnumerable<long>
{
public static readonly long[] Value=A219521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219521.Bytes);
public long this[int i]=>Value[i];

public static A219521Inst Instance=new A219521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219522
{
public static readonly long[] Value={ 6L,12L,42L,187L,620L,1961L,5799L,16464L,45093L,118742L,300691L,732741L,1722676L,3918437L,8645952L,18545343L,38739703L,78930954L,157075640L,305697694L,582518911L,1088033189L,1994062088L,3589405583L,6351714734L,11059029166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219522Inst : IEnumerable<long>
{
public static readonly long[] Value=A219522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219522.Bytes);
public long this[int i]=>Value[i];

public static A219522Inst Instance=new A219522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219523
{
public static readonly long[] Value={ 7L,15L,74L,465L,2125L,9292L,37442L,146163L,554185L,2025086L,7113545L,23974181L,77690406L,242798386L,733943376L,2151321628L,6127503021L,16989704367L,45932207763L,121260063820L,313015935010L,791017133814L,1959057933111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219523Inst : IEnumerable<long>
{
public static readonly long[] Value=A219523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219523.Bytes);
public long this[int i]=>Value[i];

public static A219523Inst Instance=new A219523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219524
{
public static readonly long[] Value={ 8L,18L,124L,1090L,6994L,42906L,241413L,1327694L,7148589L,37181863L,185383785L,881615968L,4010119499L,17516997873L,73780512955L,300596497963L,1187489293042L,4557540770898L,17022492697401L,61969041626283L,220187547195208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219524Inst : IEnumerable<long>
{
public static readonly long[] Value=A219524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219524.Bytes);
public long this[int i]=>Value[i];

public static A219524Inst Instance=new A219524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219525
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,3L,4L,3L,3L,4L,4L,4L,9L,4L,4L,6L,4L,12L,12L,4L,6L,7L,6L,12L,16L,12L,6L,7L,7L,7L,18L,16L,16L,18L,7L,7L,9L,7L,21L,24L,16L,24L,21L,7L,9L,10L,9L,21L,28L,24L,24L,28L,21L,9L,10L,10L,10L,27L,28L,28L,36L,28L,28L,27L,10L,10L,12L,10L,30L,36L,28L,42L,42L,28L,36L,30L,10L,12L,13L,12L,30L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219525Inst : IEnumerable<long>
{
public static readonly long[] Value=A219525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219525.Bytes);
public long this[int i]=>Value[i];

public static A219525Inst Instance=new A219525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219526
{
public static readonly long[] Value={ 928L,4360L,3648L,2816L,2208L,2120L,1520L,0L,688L,768L,936L,560L,1112L,544L,80L,384L,624L,320L,1568L,120L,32L,0L,168L,56L,272L,160L,24L,168L,32L,72L,776L,440L,24L,208L,32L,0L,24L,224L,648L,680L,0L,152L,56L,24L,16L,0L,0L,0L,0L,0L,0L,24L,0L,184L,160L,16L,32L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219526Inst : IEnumerable<long>
{
public static readonly long[] Value=A219526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219526.Bytes);
public long this[int i]=>Value[i];

public static A219526Inst Instance=new A219526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219527
{
public static readonly long[] Value={ 1L,3L,11L,19L,37L,55L,87L,119L,169L,219L,291L,363L,461L,559L,687L,815L,977L,1139L,1339L,1539L,1781L,2023L,2311L,2599L,2937L,3275L,3667L,4059L,4509L,4959L,5471L,5983L,6561L,7139L,7787L,8435L,9157L,9879L,10679L,11479L,12361L,13243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219527Inst : IEnumerable<long>
{
public static readonly long[] Value=A219527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219527.Bytes);
public long this[int i]=>Value[i];

public static A219527Inst Instance=new A219527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219528
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,31L,37L,47L,53L,71L,73L,97L,107L,109L,127L,163L,191L,193L,257L,383L,431L,433L,487L,577L,647L,769L,863L,971L,1151L,1153L,1297L,1459L,2591L,2593L,2917L,3457L,3889L,4373L,6143L,6911L,8191L,8747L,10369L,12289L,13121L,15551L,17497L,18433L,23327L,27647L,39367L,52489L,62207L,65537L,73727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219528Inst : IEnumerable<long>
{
public static readonly long[] Value=A219528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219528.Bytes);
public long this[int i]=>Value[i];

public static A219528Inst Instance=new A219528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219529
{
public static readonly long[] Value={ 1L,5L,11L,16L,21L,27L,32L,37L,43L,48L,53L,59L,64L,69L,75L,80L,85L,91L,96L,101L,107L,112L,117L,123L,128L,133L,139L,144L,149L,155L,160L,165L,171L,176L,181L,187L,192L,197L,203L,208L,213L,219L,224L,229L,235L,240L,245L,251L,256L,261L,267L,272L,277L,283L,288L,293L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219529Inst : IEnumerable<long>
{
public static readonly long[] Value=A219529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219529.Bytes);
public long this[int i]=>Value[i];

public static A219529Inst Instance=new A219529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219530
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,195L,2046L,26752L,422546L,7849611L,167781117L,4054557471L,109246333917L,3245641491658L,105366022410057L,3709933487122164L,140791348680766521L,5728108758307500165L,BigInteger.Parse("248696925989154108462"),BigInteger.Parse("11476424805495560002162"),BigInteger.Parse("560894026563924188981599"),BigInteger.Parse("28941826672247857117927894") };
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
public class A219530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219530Inst Instance=new A219530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219531
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4095L,8178L,16278L,32192L,63019L,121670L,230964L,430104L,784626L,1401292L,2449868L,4194304L,7036530L,11576916L,18696432L,29666704L,46295513L,71116846L,107636402L,160645504L,236618693L,344212906L,494889092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219531Inst : IEnumerable<long>
{
public static readonly long[] Value=A219531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219531.Bytes);
public long this[int i]=>Value[i];

public static A219531Inst Instance=new A219531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219532
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,427L,9096L,248298L,8258552L,323891811L,14636853712L,749171687006L,42853503567480L,2710099789775566L,187811949192251632L,14156747168376595956UL,BigInteger.Parse("1153316446792123524144"),BigInteger.Parse("100995199848878125787555"),BigInteger.Parse("9461277820648354922926368"),BigInteger.Parse("944228520086488255850280918") };
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
public class A219532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219532Inst Instance=new A219532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219533
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,13L,19L,23L,29L,43L,37L,31L,41L,47L,67L,53L,61L,79L,71L,73L,83L,103L,59L,101L,97L,89L,157L,113L,107L,127L,109L,131L,139L,137L,167L,199L,179L,181L,151L,149L,163L,233L,191L,193L,173L,223L,197L,211L,227L,229L,239L,257L,241L,251L,271L,263L,277L,311L,307L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219533Inst : IEnumerable<long>
{
public static readonly long[] Value=A219533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219533.Bytes);
public long this[int i]=>Value[i];

public static A219533Inst Instance=new A219533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219534
{
public static readonly BigInteger[] Value={ 1L,2L,12L,100L,968L,10208L,113792L,1318832L,15732064L,191878592L,2381917824L,29995598208L,382257383168L,4920505410816L,63882881030656L,835554927932160L,10999486798112256L,145626782310460416L,1937772463214168064L,BigInteger.Parse("25901381584638605312"),BigInteger.Parse("347618773649248088064") };
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
public class A219534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219534Inst Instance=new A219534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219535
{
public static readonly BigInteger[] Value={ 1L,3L,21L,192L,2001L,22539L,267276L,3287496L,41556585L,536565225L,7046232285L,93820316412L,1263673602300L,17186898452772L,235709926636296L,3256050894487824L,45263067114496665L,632721425905230213L,8888476706476318047L,BigInteger.Parse("125418490224196533096"),BigInteger.Parse("1776734673565844413929") };
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
public class A219535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219535Inst Instance=new A219535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219536
{
public static readonly BigInteger[] Value={ 1L,3L,24L,255L,3102L,40854L,566934L,8164263L,120864390L,1827982362L,28122626760L,438720097638L,6923868098820L,110346550539780L,1773394661610258L,28707809007278775L,467677404522668742L,7661583171651546786L,BigInteger.Parse("126137791939032756960"),BigInteger.Parse("2085923447593966281378") };
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
public class A219536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219536Inst Instance=new A219536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219537
{
public static readonly long[] Value={ 1L,1L,3L,13L,66L,366L,2148L,13115L,82449L,530095L,3469401L,23037642L,154820262L,1050999343L,7196493255L,49644745965L,344704716018L,2407157839593L,16895247295947L,119121868831235L,843306880720218L,5992060655349521L,42718501097385207L,305476181765843358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219537Inst : IEnumerable<long>
{
public static readonly long[] Value=A219537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219537.Bytes);
public long this[int i]=>Value[i];

public static A219537Inst Instance=new A219537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219538
{
public static readonly BigInteger[] Value={ 1L,2L,12L,98L,924L,9468L,102432L,1151410L,13315692L,157406876L,1893480264L,23103024084L,285233168760L,3556744196000L,44730062281800L,566683825859730L,7225564521956940L,92653105887920556L,1194068058333608136L,15457771628663418748UL,BigInteger.Parse("200916876963088849992") };
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
public class A219538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219538Inst Instance=new A219538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219539
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,2L,1L,1L,4L,11L,19L,23L,19L,11L,4L,1L,1L,5L,17L,38L,61L,71L,61L,38L,17L,5L,1L,1L,7L,33L,107L,257L,471L,673L,757L,673L,471L,257L,107L,33L,7L,1L,1L,8L,43L,161L,451L,977L,1675L,2303L,2559L,2303L,1675L,977L,451L,161L,43L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219539Inst : IEnumerable<long>
{
public static readonly long[] Value=A219539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219539.Bytes);
public long this[int i]=>Value[i];

public static A219539Inst Instance=new A219539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219540
{
public static readonly long[] Value={ 0L,6L,0L,20L,0L,26L,0L,200L,567L,950L,0L,1276L,0L,2058L,2475L,784L,0L,3750L,0L,4932L,6615L,4114L,0L,2264L,13125L,3718L,13851L,588L,0L,8050L,0L,19488L,25047L,34102L,1225L,23700L,0L,38266L,41067L,18664L,0L,46622L,0L,53724L,44550L,34914L,0L,72496L,103243L,123750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219540Inst : IEnumerable<long>
{
public static readonly long[] Value=A219540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219540.Bytes);
public long this[int i]=>Value[i];

public static A219540Inst Instance=new A219540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219541
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,242L,4584L,124936L,4638360L,225037200L,13820428368L,1048006461024L,96171381464256L,10503700943629824L,1346451508974957696L,BigInteger.Parse("200184649396819872768"),BigInteger.Parse("34167655864475762390784"),BigInteger.Parse("6635466680845611611326464"),BigInteger.Parse("1454780635849943337186155520") };
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
public class A219541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219541Inst Instance=new A219541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219542
{
public static readonly long[] Value={ 12L,21L,37L,44L,107L,108L,120L,129L,191L,204L,209L,210L,223L,306L,315L,342L,343L,345L,370L,408L,413L,440L,501L,642L,696L,804L,955L,959L,982L,995L,1002L,1044L,1063L,1065L,1070L,1080L,1107L,1169L,1200L,1275L,1281L,1290L,1301L,1306L,1315L,1349L,1385L,1503L,1910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219542Inst : IEnumerable<long>
{
public static readonly long[] Value=A219542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219542.Bytes);
public long this[int i]=>Value[i];

public static A219542Inst Instance=new A219542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219543
{
public static readonly long[] Value={ 30L,66L,138L,282L,354L,498L,642L,1002L,1074L,1362L,1434L,1578L,2082L,2154L,2298L,2478L,2658L,2730L,2802L,2874L,3018L,3378L,3486L,3522L,3882L,3954L,4314L,4494L,4962L,5034L,5178L,5322L,5898L,6114L,7122L,7338L,7518L,7554L,7590L,7698L,7842L,7914L,8202L,8634L,8922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219543Inst : IEnumerable<long>
{
public static readonly long[] Value=A219543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219543.Bytes);
public long this[int i]=>Value[i];

public static A219543Inst Instance=new A219543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219544
{
public static readonly long[] Value={ 3L,14L,60L,248L,336L,4064L,15120L,16380L,261888L,1089270L,11784960L,16775168L,22766400L,71495424L,229909120L,689727360L,738152448L,4294934528L,7091219520L,15999197760L,21930739200L,25500590080L,33216860160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219544Inst : IEnumerable<long>
{
public static readonly long[] Value=A219544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219544.Bytes);
public long this[int i]=>Value[i];

public static A219544Inst Instance=new A219544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219545
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,3L,2L,3L,3L,2L,5L,5L,3L,2L,5L,5L,5L,5L,5L,5L,2L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,2L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,2L,5L,7L,2L,5L,5L,7L,5L,5L,5L,7L,7L,7L,7L,5L,5L,7L,7L,7L,7L,5L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219545Inst : IEnumerable<long>
{
public static readonly long[] Value=A219545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219545.Bytes);
public long this[int i]=>Value[i];

public static A219545Inst Instance=new A219545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219546
{
public static readonly long[] Value={ 5L,13L,23L,31L,37L,41L,43L,47L,53L,59L,61L,71L,79L,101L,103L,107L,109L,127L,137L,149L,157L,163L,173L,179L,181L,191L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219546Inst : IEnumerable<long>
{
public static readonly long[] Value=A219546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219546.Bytes);
public long this[int i]=>Value[i];

public static A219546Inst Instance=new A219546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219547
{
public static readonly long[] Value={ 8L,16L,32L,40L,48L,56L,64L,80L,88L,96L,104L,112L,128L,136L,152L,160L,176L,184L,192L,200L,208L,224L,232L,240L,248L,256L,272L,280L,296L,304L,320L,328L,336L,344L,352L,368L,376L,384L,392L,400L,416L,424L,440L,448L,464L,472L,480L,488L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219547Inst : IEnumerable<long>
{
public static readonly long[] Value=A219547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219547.Bytes);
public long this[int i]=>Value[i];

public static A219547Inst Instance=new A219547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219548
{
public static readonly long[] Value={ 257L,65537L,641L,257L,193L,257L,274177L,65537L,257L,641L,257L,449L,59649589127497217L,257L,257L,641L,65537L,257L,769L,257L,65537L,641L,257L,193L,257L,1238926361552897L,5441L,257L,257L,65537L,274177L,257L,193L,257L,641L,65537L,257L,59649589127497217L,257L,65537L,641L,257L,257L,274177L,65537L,257L,641L,257L,5953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219548Inst : IEnumerable<long>
{
public static readonly long[] Value=A219548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219548.Bytes);
public long this[int i]=>Value[i];

public static A219548Inst Instance=new A219548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219549
{
public static readonly long[] Value={ 257L,65537L,97L,641L,257L,193L,257L,274177L,97L,65537L,257L,641L,257L,449L,97L,59649589127497217L,257L,193L,257L,641L,97L,65537L,257L,769L,257L,65537L,97L,641L,257L,193L,257L,1238926361552897L,97L,5441L,257L,641L,257L,65537L,97L,274177L,257L,193L,257L,641L,97L,65537L,257L,59649589127497217L,257L,65537L,97L,641L,257L,193L,257L,274177L,97L,65537L,257L,641L,257L,5953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219549Inst : IEnumerable<long>
{
public static readonly long[] Value=A219549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219549.Bytes);
public long this[int i]=>Value[i];

public static A219549Inst Instance=new A219549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219550
{
public static readonly BigInteger[] Value={ 3L,260L,53823L,12942210875L,11901444483396L,BigInteger.Parse("25627001801054931008"),BigInteger.Parse("55413915436873048932459"),BigInteger.Parse("490667517005738962388828685983"),BigInteger.Parse("48588952813858892791005036793649985985124"),BigInteger.Parse("303307728036900627681487165427498812641117375"),BigInteger.Parse("158544898951978777519612048992784361843596346824881328548") };
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
public class A219550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219550Inst Instance=new A219550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219551
{
public static readonly long[] Value={ 0L,3L,0L,0L,0L,3L,0L,2L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219551Inst : IEnumerable<long>
{
public static readonly long[] Value=A219551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219551.Bytes);
public long this[int i]=>Value[i];

public static A219551Inst Instance=new A219551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219552
{
public static readonly long[] Value={ 6L,1L,3L,5L,5L,11L,12L,2L,12L,18L,56L,33L,2L,20L,3L,1L,28L,66L,26L,7L,10L,20L,3L,30L,105L,20L,5L,5L,7L,28L,15L,39L,26L,29L,41L,1L,6L,2L,31L,13L,5L,19L,45L,2L,15L,11L,5L,1L,71L,9L,35L,20L,13L,2L,36L,1L,15L,12L,17L,20L,14L,45L,4L,27L,12L,38L,30L,3L,25L,7L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219552Inst : IEnumerable<long>
{
public static readonly long[] Value=A219552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219552.Bytes);
public long this[int i]=>Value[i];

public static A219552Inst Instance=new A219552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219553
{
public static readonly long[] Value={ 6L,11L,12L,18L,56L,66L,105L,110L,130L,132L,139L,140L,185L,195L,197L,202L,261L,266L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219553Inst : IEnumerable<long>
{
public static readonly long[] Value=A219553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219553.Bytes);
public long this[int i]=>Value[i];

public static A219553Inst Instance=new A219553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219554
{
public static readonly long[] Value={ 1L,2L,5L,17L,46L,123L,323L,809L,1966L,4660L,10792L,24447L,54344L,118681L,254991L,539852L,1127279L,2323849L,4733680L,9535079L,19005282L,37507802L,73333494L,142112402L,273092320L,520612305L,984944052L,1849920722L,3450476080L,6393203741L,11770416313L,21538246251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219554Inst : IEnumerable<long>
{
public static readonly long[] Value=A219554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219554.Bytes);
public long this[int i]=>Value[i];

public static A219554Inst Instance=new A219554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219555
{
public static readonly long[] Value={ 1L,2L,4L,10L,19L,38L,73L,134L,242L,430L,749L,1282L,2171L,3622L,5979L,9770L,15802L,25334L,40288L,63560L,99554L,154884L,239397L,367800L,561846L,853584L,1290107L,1940304L,2904447L,4328184L,6422164L,9489940L,13967783L,20480534L,29920277L,43557272L,63194864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219555Inst : IEnumerable<long>
{
public static readonly long[] Value=A219555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219555.Bytes);
public long this[int i]=>Value[i];

public static A219555Inst Instance=new A219555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219556
{
public static readonly long[] Value={ 4L,9L,10L,15L,17L,25L,26L,28L,33L,35L,37L,49L,55L,65L,82L,95L,97L,129L,143L,145L,161L,163L,215L,217L,287L,289L,323L,325L,485L,487L,511L,513L,649L,767L,769L,865L,973L,1457L,1459L,1535L,1537L,1727L,1729L,1943L,1945L,2047L,2049L,2186L,2188L,2305L,3071L,3073L,3455L,3457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219556Inst : IEnumerable<long>
{
public static readonly long[] Value=A219556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219556.Bytes);
public long this[int i]=>Value[i];

public static A219556Inst Instance=new A219556Inst();

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