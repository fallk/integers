using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A066745
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,1L,0L,1L,3L,2L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066745Inst : IEnumerable<long>
{
public static readonly long[] Value=A066745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066745.Bytes);
public long this[int i]=>Value[i];

public static A066745Inst Instance=new A066745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066746
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,3L,-1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066746Inst : IEnumerable<long>
{
public static readonly long[] Value=A066746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066746.Bytes);
public long this[int i]=>Value[i];

public static A066746Inst Instance=new A066746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066747
{
public static readonly long[] Value={ 7L,3L,4L,1L,2L,1L,5L,1L,5L,4L,0L,8L,2L,8L,6L,1L,2L,0L,6L,0L,6L,2L,7L,8L,2L,8L,8L,4L,5L,7L,2L,3L,2L,1L,4L,9L,2L,2L,8L,5L,6L,5L,0L,4L,6L,6L,1L,1L,6L,1L,3L,9L,9L,1L,4L,0L,6L,6L,0L,3L,4L,1L,2L,5L,5L,5L,9L,5L,4L,0L,4L,5L,0L,4L,3L,7L,0L,0L,3L,1L,0L,8L,0L,6L,4L,3L,0L,6L,3L,4L,9L,2L,6L,9L,3L,2L,5L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066747Inst : IEnumerable<long>
{
public static readonly long[] Value=A066747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066747.Bytes);
public long this[int i]=>Value[i];

public static A066747Inst Instance=new A066747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066748
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,5L,2L,1L,2L,5L,5L,2L,19L,1L,2L,1L,2L,42L,2L,2L,2L,1L,2L,3L,1L,1L,26L,20L,8L,5L,1L,1L,1L,21L,9L,1L,1L,1L,6L,1L,5L,18L,3L,5L,3L,10L,1L,1L,8L,5L,2L,1L,2L,1L,3L,2L,1L,5L,2L,1L,1L,15L,3L,1L,4L,3L,2L,2L,2L,1L,3L,1L,275L,1L,2L,20L,120L,1L,12L,1L,9L,1424L,1L,2L,36L,1L,2L,2L,4L,1L,4L,1L,9L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066748Inst : IEnumerable<long>
{
public static readonly long[] Value=A066748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066748.Bytes);
public long this[int i]=>Value[i];

public static A066748Inst Instance=new A066748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066749
{
public static readonly BigInteger[] Value={ 2L,3L,7L,11L,71L,127L,463L,3433L,2704157L,20058301L,17672631901L,35345263801L,2104098963721L,16123801841551L,BigInteger.Parse("6892620648693261354601"),BigInteger.Parse("51913710643776705684835561"),BigInteger.Parse("410795449442059149332177041") };
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
public class A066749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066749Inst Instance=new A066749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066750
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,2L,3L,2L,1L,6L,1L,2L,9L,2L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,4L,1L,6L,1L,4L,9L,2L,1L,12L,1L,5L,3L,1L,1L,9L,5L,1L,3L,1L,1L,6L,1L,2L,9L,2L,1L,6L,1L,2L,3L,7L,1L,9L,1L,1L,3L,1L,7L,3L,1L,8L,9L,2L,1L,12L,1L,2L,3L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066750Inst : IEnumerable<long>
{
public static readonly long[] Value=A066750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066750.Bytes);
public long this[int i]=>Value[i];

public static A066750Inst Instance=new A066750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066751
{
public static readonly long[] Value={ 3L,91L,136L,325L,703L,1081L,1378L,1711L,3655L,11026L,11476L,13861L,18145L,18721L,36046L,70876L,75466L,76636L,79003L,92665L,99235L,107416L,108811L,110215L,118828L,123256L,130816L,137026L,140185L,158203L,166753L,173755L,186355L,303031L,310078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066751Inst : IEnumerable<long>
{
public static readonly long[] Value=A066751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066751.Bytes);
public long this[int i]=>Value[i];

public static A066751Inst Instance=new A066751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066752
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,7L,2L,1L,2L,1L,4L,1L,14L,1L,16L,1L,6L,1L,4L,3L,2L,1L,12L,5L,2L,3L,4L,1L,10L,1L,32L,33L,2L,35L,6L,1L,2L,1L,8L,1L,6L,1L,4L,1L,2L,1L,4L,7L,2L,1L,26L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,21L,4L,13L,2L,1L,4L,1L,2L,1L,6L,1L,2L,1L,76L,1L,78L,1L,2L,1L,2L,1L,12L,1L,2L,3L,2L,1L,6L,1L,4L,3L,2L,1L,4L,1L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066752Inst : IEnumerable<long>
{
public static readonly long[] Value=A066752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066752.Bytes);
public long this[int i]=>Value[i];

public static A066752Inst Instance=new A066752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066753
{
public static readonly long[] Value={ 1L,2L,1L,20L,1L,2L,3L,2L,1L,10L,1L,2L,3L,2L,1L,16L,1L,2L,3L,4L,1L,10L,17L,2L,5L,2L,1L,10L,1L,4L,3L,2L,3L,10L,1L,2L,3L,2L,1L,16L,1L,2L,3L,4L,1L,18L,17L,2L,3L,4L,1L,10L,41L,2L,5L,2L,1L,16L,1L,6L,3L,2L,3L,10L,1L,2L,9L,2L,1L,10L,1L,4L,3L,2L,5L,16L,1L,2L,3L,4L,1L,10L,17L,2L,5L,4L,1L,20L,43L,4L,3L,2L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066753Inst : IEnumerable<long>
{
public static readonly long[] Value=A066753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066753.Bytes);
public long this[int i]=>Value[i];

public static A066753Inst Instance=new A066753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066754
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,19L,42L,275L,1424L,2810L,46114L,79779L,208340L,226580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066754Inst : IEnumerable<long>
{
public static readonly long[] Value=A066754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066754.Bytes);
public long this[int i]=>Value[i];

public static A066754Inst Instance=new A066754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066755
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,16L,20L,24L,26L,34L,36L,40L,44L,46L,50L,54L,56L,60L,66L,70L,74L,76L,84L,86L,90L,94L,96L,100L,104L,110L,114L,116L,120L,124L,126L,130L,134L,136L,144L,146L,150L,156L,160L,164L,170L,176L,180L,184L,186L,190L,194L,196L,204L,206L,210L,214L,220L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066755Inst : IEnumerable<long>
{
public static readonly long[] Value=A066755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066755.Bytes);
public long this[int i]=>Value[i];

public static A066755Inst Instance=new A066755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066756
{
public static readonly long[] Value={ 1L,2L,6L,65L,673L,342L,2919L,129991L,1590511L,301695657L,1412987847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066756Inst : IEnumerable<long>
{
public static readonly long[] Value=A066756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066756.Bytes);
public long this[int i]=>Value[i];

public static A066756Inst Instance=new A066756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066757
{
public static readonly long[] Value={ 0L,1L,12L,51L,18426L,69876L,6168162L,12105501L,17759001L,3008521945L,100938635992L,826471253301L,3044088035830227L,5889438558016867L,55959294872171901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066757Inst : IEnumerable<long>
{
public static readonly long[] Value=A066757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066757.Bytes);
public long this[int i]=>Value[i];

public static A066757Inst Instance=new A066757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066758
{
public static readonly BigInteger[] Value={ 0L,1L,15L,21L,62481L,67896L,2618616L,10095771L,10550121L,5491258003L,103352174628L,299536839001L,7220385308804403L,7686108558349885L,10917127849295955L,BigInteger.Parse("724804915074540097006") };
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
public class A066758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066758Inst Instance=new A066758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066759
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,18L,10L,11L,12L,13L,14L,30L,16L,17L,18L,19L,20L,42L,22L,23L,24L,100L,52L,54L,28L,29L,30L,31L,32L,66L,68L,70L,36L,37L,38L,78L,40L,41L,42L,43L,44L,90L,46L,47L,48L,98L,100L,102L,52L,53L,54L,110L,112L,114L,58L,59L,60L,61L,62L,126L,128L,130L,66L,67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066759Inst : IEnumerable<long>
{
public static readonly long[] Value=A066759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066759.Bytes);
public long this[int i]=>Value[i];

public static A066759Inst Instance=new A066759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066760
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,0L,6L,6L,18L,0L,27L,0L,40L,37L,42L,0L,79L,0L,89L,74L,108L,0L,145L,45L,154L,96L,183L,0L,274L,0L,210L,184L,270L,163L,360L,0L,340L,257L,411L,0L,556L,0L,467L,418L,504L,0L,669L,140L,683L,439L,657L,0L,880L,369L,805L,548L,810L,0L,1183L,0L,928L,779L,930L,502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066760Inst : IEnumerable<long>
{
public static readonly long[] Value=A066760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066760.Bytes);
public long this[int i]=>Value[i];

public static A066760Inst Instance=new A066760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066761
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,3L,4L,5L,2L,7L,2L,5L,7L,4L,2L,8L,2L,7L,8L,5L,2L,10L,4L,5L,6L,7L,2L,15L,2L,5L,8L,5L,7L,13L,2L,5L,8L,10L,2L,15L,2L,8L,12L,5L,2L,13L,4L,9L,8L,8L,2L,12L,8L,10L,8L,5L,2L,23L,2L,5L,13L,6L,8L,15L,2L,8L,8L,16L,2L,17L,2L,5L,13L,8L,7L,16L,2L,13L,8L,5L,2L,23L,8L,5L,8L,10L,2L,26L,7L,8L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066761Inst : IEnumerable<long>
{
public static readonly long[] Value=A066761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066761.Bytes);
public long this[int i]=>Value[i];

public static A066761Inst Instance=new A066761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066762
{
public static readonly long[] Value={ 2L,6L,8L,10L,22L,46L,58L,82L,106L,166L,178L,188L,226L,262L,285L,346L,358L,382L,466L,478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066762Inst : IEnumerable<long>
{
public static readonly long[] Value=A066762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066762.Bytes);
public long this[int i]=>Value[i];

public static A066762Inst Instance=new A066762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066763
{
public static readonly long[] Value={ 15L,45L,70L,75L,135L,140L,225L,280L,350L,375L,377L,405L,490L,560L,627L,665L,675L,700L,980L,1120L,1125L,1215L,1400L,1750L,1875L,1881L,1960L,2025L,2240L,2450L,2800L,3325L,3375L,3430L,3500L,3645L,3655L,3920L,4480L,4655L,4900L,4901L,5600L,5625L,5643L,6075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066763Inst : IEnumerable<long>
{
public static readonly long[] Value=A066763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066763.Bytes);
public long this[int i]=>Value[i];

public static A066763Inst Instance=new A066763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066764
{
public static readonly long[] Value={ 3L,8L,30L,140L,315L,319L,460L,840L,864L,936L,1040L,1287L,1836L,2480L,2600L,6076L,6200L,7788L,11398L,12035L,12415L,12584L,13260L,13734L,15886L,18480L,26078L,33820L,40640L,42665L,46200L,55860L,68352L,70266L,70645L,75330L,78939L,81740L,98230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066764Inst : IEnumerable<long>
{
public static readonly long[] Value=A066764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066764.Bytes);
public long this[int i]=>Value[i];

public static A066764Inst Instance=new A066764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066765
{
public static readonly long[] Value={ 30030L,39270L,43890L,46410L,51870L,53130L,60060L,78540L,87780L,90090L,92820L,103740L,106260L,117810L,120120L,131670L,139230L,150150L,155610L,157080L,159390L,175560L,180180L,185640L,196350L,207480L,210210L,212520L,219450L,232050L,235620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066765Inst : IEnumerable<long>
{
public static readonly long[] Value=A066765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066765.Bytes);
public long this[int i]=>Value[i];

public static A066765Inst Instance=new A066765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066766
{
public static readonly long[] Value={ 2L,7L,4L,4L,0L,3L,3L,8L,8L,8L,7L,5L,9L,4L,8L,8L,3L,6L,0L,4L,8L,0L,2L,1L,4L,8L,9L,1L,4L,9L,2L,2L,7L,2L,1L,6L,4L,3L,1L,1L,4L,2L,8L,9L,8L,1L,3L,1L,9L,6L,3L,9L,3L,1L,7L,8L,4L,8L,5L,2L,8L,8L,8L,4L,7L,3L,7L,9L,1L,2L,2L,8L,3L,2L,6L,3L,8L,9L,5L,6L,8L,8L,5L,6L,6L,2L,5L,2L,3L,1L,0L,7L,1L,2L,5L,0L,6L,8L,8L,7L,7L,3L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066766Inst : IEnumerable<long>
{
public static readonly long[] Value=A066766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066766.Bytes);
public long this[int i]=>Value[i];

public static A066766Inst Instance=new A066766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066767
{
public static readonly long[] Value={ 1L,5L,14L,35L,76L,164L,336L,687L,1387L,2792L,5596L,11220L,22454L,44932L,89888L,179807L,359632L,719303L,1438626L,2877294L,5754620L,11509276L,23018576L,46037212L,92074455L,184148952L,368297944L,736595944L,1473191918L,2946383908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066767Inst : IEnumerable<long>
{
public static readonly long[] Value=A066767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066767.Bytes);
public long this[int i]=>Value[i];

public static A066767Inst Instance=new A066767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066768
{
public static readonly long[] Value={ 1L,3L,7L,23L,71L,261L,925L,3455L,12877L,48693L,184757L,705713L,2704157L,10401527L,40116677L,155120975L,601080391L,2333619351L,9075135301L,35345312513L,137846529751L,538258059199L,2104098963721L,8233431436745L,32247603683171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066768Inst : IEnumerable<long>
{
public static readonly long[] Value=A066768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066768.Bytes);
public long this[int i]=>Value[i];

public static A066768Inst Instance=new A066768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066769
{
public static readonly long[] Value={ 1L,3L,5L,9L,10L,21L,20L,39L,49L,80L,100L,195L,246L,424L,650L,1065L,1614L,2715L,4200L,6940L,11020L,17922L,28680L,46821L,75075L,121898L,196565L,318680L,514258L,833560L,1346300L,2180439L,3524900L,5706132L,9227600L,14936241L,24157854L,39096588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066769Inst : IEnumerable<long>
{
public static readonly long[] Value=A066769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066769.Bytes);
public long this[int i]=>Value[i];

public static A066769Inst Instance=new A066769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066770
{
public static readonly long[] Value={ 4L,24L,44L,-336L,-3116L,-10296L,16124L,354144L,1721764L,1476984L,-34182196L,-242017776L,-597551756L,2465133864L,29729597084L,116749235904L,-42744511676L,-3175197967656L,-17982575014036L,-28515500892816L,278471369994004L,2383715742284424L,7340510203856444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066770Inst : IEnumerable<long>
{
public static readonly long[] Value=A066770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066770.Bytes);
public long this[int i]=>Value[i];

public static A066770Inst Instance=new A066770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066771
{
public static readonly long[] Value={ 1L,3L,-7L,-117L,-527L,-237L,11753L,76443L,164833L,-922077L,-9653287L,-34867797L,32125393L,1064447283L,5583548873L,6890111163L,-98248054847L,-761741108157L,-2114245277767L,6358056037323L,91004468168113L,387075408075603L,47340744250793L,-9392840736385317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066771Inst : IEnumerable<long>
{
public static readonly long[] Value=A066771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066771.Bytes);
public long this[int i]=>Value[i];

public static A066771Inst Instance=new A066771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066772
{
public static readonly long[] Value={ 2L,1L,2L,1L,9L,1L,2L,1L,1L,1L,5L,8L,1L,3L,2L,3L,2L,2L,2L,2L,1L,3L,3L,4L,12L,1L,1L,1L,11L,4L,15L,6L,3L,3L,2L,1L,20L,4L,4L,1L,4L,1L,2L,1L,2L,6L,1L,2L,1L,28L,107L,1L,4L,4L,3L,1L,2L,2L,4L,2L,3L,51L,1L,1L,1L,4L,2L,4L,1L,20L,20L,1L,14L,3L,27L,1L,4L,3L,14L,329L,1L,1L,1L,111L,2L,3L,1L,2L,1L,4L,1L,6L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066772Inst : IEnumerable<long>
{
public static readonly long[] Value=A066772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066772.Bytes);
public long this[int i]=>Value[i];

public static A066772Inst Instance=new A066772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066773
{
public static readonly long[] Value={ 1L,2L,16L,12L,7L,98L,153L,169L,673L,350L,107L,129L,649L,2110L,4763L,6919L,6943L,158299L,71310L,724686L,845223L,665215L,2157291L,4468260L,5978623L,34385063L,21015006L,301695657L,489853918L,568097511L,418606034L,1208474114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066773Inst : IEnumerable<long>
{
public static readonly long[] Value=A066773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066773.Bytes);
public long this[int i]=>Value[i];

public static A066773Inst Instance=new A066773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066774
{
public static readonly long[] Value={ 4L,13L,15L,19L,21L,27L,31L,35L,37L,39L,51L,53L,57L,65L,67L,69L,77L,83L,87L,89L,95L,109L,111L,113L,125L,127L,129L,131L,139L,155L,157L,161L,177L,181L,199L,209L,211L,221L,233L,237L,249L,251L,257L,263L,267L,291L,293L,305L,307L,309L,317L,329L,335L,337L,353L,365L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066774Inst : IEnumerable<long>
{
public static readonly long[] Value=A066774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066774.Bytes);
public long this[int i]=>Value[i];

public static A066774Inst Instance=new A066774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066775
{
public static readonly long[] Value={ 19L,53L,61L,101L,107L,251L,269L,311L,347L,419L,499L,521L,547L,563L,587L,673L,677L,691L,877L,937L,953L,1031L,1061L,1087L,1229L,1249L,1259L,1427L,1433L,1693L,1733L,1753L,1777L,1831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066775Inst : IEnumerable<long>
{
public static readonly long[] Value=A066775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066775.Bytes);
public long this[int i]=>Value[i];

public static A066775Inst Instance=new A066775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066776
{
public static readonly long[] Value={ 1L,2L,3L,4L,69L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066776Inst : IEnumerable<long>
{
public static readonly long[] Value=A066776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066776.Bytes);
public long this[int i]=>Value[i];

public static A066776Inst Instance=new A066776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066777
{
public static readonly long[] Value={ 0L,1L,1L,3L,5L,9L,20L,37L,71L,137L,285L,550L,1080L,2123L,4175L,8498L,16711L,33137L,65724L,130368L,258613L,521549L,1034600L,2060702L,4104693L,8176249L,16286774L,32443180L,65149296L,129777043L,259032537L,517030474L,1032000246L,2059895799L,4111615349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066777Inst : IEnumerable<long>
{
public static readonly long[] Value=A066777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066777.Bytes);
public long this[int i]=>Value[i];

public static A066777Inst Instance=new A066777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066778
{
public static readonly long[] Value={ 1L,3L,6L,11L,18L,29L,46L,71L,109L,166L,252L,381L,575L,866L,1303L,1959L,2944L,4421L,6637L,9962L,14949L,22430L,33652L,50486L,75737L,113613L,170428L,255650L,383484L,575235L,862861L,1294300L,1941459L,2912198L,4368307L,6552471L,9828717L,14743086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066778Inst : IEnumerable<long>
{
public static readonly long[] Value=A066778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066778.Bytes);
public long this[int i]=>Value[i];

public static A066778Inst Instance=new A066778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066779
{
public static readonly long[] Value={ 1L,3L,6L,6L,11L,17L,24L,24L,24L,34L,45L,45L,58L,72L,87L,87L,104L,104L,123L,123L,144L,166L,189L,189L,189L,215L,215L,215L,244L,274L,305L,305L,338L,372L,407L,407L,444L,482L,521L,521L,562L,604L,647L,647L,647L,693L,740L,740L,740L,740L,791L,791L,844L,844L,899L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066779Inst : IEnumerable<long>
{
public static readonly long[] Value=A066779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066779.Bytes);
public long this[int i]=>Value[i];

public static A066779Inst Instance=new A066779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066780
{
public static readonly BigInteger[] Value={ 1L,3L,12L,84L,504L,6048L,48384L,725760L,9434880L,169827840L,2037934080L,57062154240L,798870159360L,19172883824640L,460149211791360L,14264625565532160L,256763260179578880L,10013767147003576320UL,BigInteger.Parse("200275342940071526400"),BigInteger.Parse("8411564403483004108800") };
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
public class A066780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066780Inst Instance=new A066780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066781
{
public static readonly long[] Value={ 2L,2L,4L,4L,16L,4L,64L,16L,64L,16L,1024L,16L,4096L,64L,256L,256L,65536L,64L,262144L,256L,4096L,1024L,4194304L,256L,1048576L,4096L,262144L,4096L,268435456L,256L,1073741824L,65536L,1048576L,65536L,16777216L,4096L,68719476736L,262144L,16777216L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066781Inst : IEnumerable<long>
{
public static readonly long[] Value=A066781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066781.Bytes);
public long this[int i]=>Value[i];

public static A066781Inst Instance=new A066781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066782
{
public static readonly long[] Value={ 1L,5L,13L,25L,34L,41L,61L,68L,113L,125L,136L,169L,181L,219L,222L,272L,313L,390L,421L,444L,482L,544L,578L,613L,625L,657L,666L,761L,780L,888L,964L,979L,1013L,1088L,1156L,1170L,1201L,1301L,1332L,1560L,1681L,1741L,1776L,1861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066782Inst : IEnumerable<long>
{
public static readonly long[] Value=A066782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066782.Bytes);
public long this[int i]=>Value[i];

public static A066782Inst Instance=new A066782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066783
{
public static readonly long[] Value={ 3L,4L,3L,4L,3L,7L,3L,5L,4L,6L,9L,8L,9L,7L,14L,10L,14L,11L,15L,19L,12L,6L,16L,20L,23L,10L,10L,8L,28L,8L,14L,22L,16L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066783Inst : IEnumerable<long>
{
public static readonly long[] Value=A066783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066783.Bytes);
public long this[int i]=>Value[i];

public static A066783Inst Instance=new A066783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066784
{
public static readonly long[] Value={ 1L,90L,392448L,411264L,804384L,871416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066784Inst : IEnumerable<long>
{
public static readonly long[] Value=A066784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066784.Bytes);
public long this[int i]=>Value[i];

public static A066784Inst Instance=new A066784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066785
{
public static readonly long[] Value={ 603L,1414L,1444L,2093L,7434L,12822L,66584L,66960L,91000L,138645L,160130L,167400L,169212L,210476L,218592L,229026L,236572L,265977L,304128L,344790L,493722L,618570L,754110L,950158L,1091385L,1113480L,1760616L,1761409L,2116116L,2733131L,2776928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066785Inst : IEnumerable<long>
{
public static readonly long[] Value=A066785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066785.Bytes);
public long this[int i]=>Value[i];

public static A066785Inst Instance=new A066785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066786
{
public static readonly long[] Value={ 1L,12L,1L,2L,3L,3L,2L,2L,5L,2L,3L,3L,3L,4L,1L,4L,15L,8L,8L,4L,3L,48L,23L,6L,5L,2L,8L,8L,5L,24L,8L,2L,11L,6L,4L,6L,20L,16L,6L,8L,7L,32L,6L,6L,6L,33L,8L,7L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066786Inst : IEnumerable<long>
{
public static readonly long[] Value=A066786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066786.Bytes);
public long this[int i]=>Value[i];

public static A066786Inst Instance=new A066786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066787
{
public static readonly long[] Value={ 1L,5L,1L,17L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,65L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,41L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,29L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,565L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066787Inst : IEnumerable<long>
{
public static readonly long[] Value=A066787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066787.Bytes);
public long this[int i]=>Value[i];

public static A066787Inst Instance=new A066787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066788
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,5L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,10L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,5L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066788Inst : IEnumerable<long>
{
public static readonly long[] Value=A066788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066788.Bytes);
public long this[int i]=>Value[i];

public static A066788Inst Instance=new A066788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066789
{
public static readonly BigInteger[] Value={ 1L,70L,4686825L,488526937079580L,BigInteger.Parse("130054841538480192455912505"),BigInteger.Parse("134084922435426494254000700271928170048684"),BigInteger.Parse("759782631286509488749614088922952734321921774350851547360350") };
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
public class A066789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066789Inst Instance=new A066789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066790
{
public static readonly long[] Value={ 113520L,8L,99585L,44L,5L,5L,48L,10L,280L,3L,45L,3L,2808L,1L,6L,9L,16L,4L,66L,6L,6L,133L,10L,9L,11L,14L,6L,11L,11L,16L,45L,1188L,2L,19L,12L,448L,56L,9L,12L,5L,8L,20L,102L,21L,24L,5L,72L,15L,4L,104L,4L,6L,288L,2L,7L,10L,12L,31L,35L,10L,165L,7L,6L,105L,13L,4L,138L,14L,8L,15L,72L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066790Inst : IEnumerable<long>
{
public static readonly long[] Value=A066790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066790.Bytes);
public long this[int i]=>Value[i];

public static A066790Inst Instance=new A066790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066791
{
public static readonly long[] Value={ 2L,6L,12L,12L,30L,42L,36L,72L,72L,72L,108L,156L,120L,210L,240L,144L,306L,294L,252L,420L,462L,312L,468L,600L,360L,648L,756L,540L,792L,756L,660L,900L,1122L,792L,1152L,1260L,792L,1482L,1332L,1092L,1722L,1656L,1260L,1692L,1944L,1224L,2160L,2160L,1512L,2550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066791Inst : IEnumerable<long>
{
public static readonly long[] Value=A066791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066791.Bytes);
public long this[int i]=>Value[i];

public static A066791Inst Instance=new A066791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066792
{
public static readonly long[] Value={ 1L,2L,8L,16L,64L,48L,216L,160L,288L,320L,1000L,480L,1344L,768L,1568L,1792L,4096L,1344L,4320L,2880L,4800L,3840L,8448L,3328L,11520L,7488L,12168L,6912L,17472L,6720L,24960L,13824L,16000L,13824L,25344L,14688L,46656L,19584L,26112L,24320L,64000L,19488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066792Inst : IEnumerable<long>
{
public static readonly long[] Value=A066792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066792.Bytes);
public long this[int i]=>Value[i];

public static A066792Inst Instance=new A066792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066793
{
public static readonly long[] Value={ 1L,9L,14L,33L,54L,140L,213L,1934L,35811L,38405L,200938L,389409L,1792209L,5606457L,8405437L,68780189L,880346227L,85910903650L,87635944146L,284340107954L,2195312273836L,2864568747364L,3155591650029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066793Inst : IEnumerable<long>
{
public static readonly long[] Value=A066793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066793.Bytes);
public long this[int i]=>Value[i];

public static A066793Inst Instance=new A066793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066794
{
public static readonly long[] Value={ 2L,11L,17L,27L,170L,279L,428L,5879L,13871L,41233L,171707L,1004646L,1633357L,5460156L,11902755L,21627159L,38821328L,41983357L,179376463L,130292951546L,393142151459L,2100234982892L,5942636062287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066794Inst : IEnumerable<long>
{
public static readonly long[] Value=A066794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066794.Bytes);
public long this[int i]=>Value[i];

public static A066794Inst Instance=new A066794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066795
{
public static readonly long[] Value={ 11L,2L,-11L,-3L,4L,-7L,-28L,7L,-12L,-3L,-3L,-4L,-3L,5L,3L,8L,-3L,26L,-8L,4L,-7L,15L,6L,8L,-4L,5L,4L,-4L,-3L,-347L,2L,4L,-3L,-3L,12L,3L,-3L,-5L,3L,-6L,-3L,9L,-3L,-3L,8L,-4L,-95L,2L,2L,-13L,-4L,3L,2L,-3L,-5L,180L,-3L,18L,24L,-11L,-3L,3L,5L,2L,-4L,-4L,2L,-8L,10L,2L,-8L,4L,-3L,-9L,3L,2L,-3L,-3L,-3L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066795Inst : IEnumerable<long>
{
public static readonly long[] Value=A066795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066795.Bytes);
public long this[int i]=>Value[i];

public static A066795Inst Instance=new A066795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066796
{
public static readonly long[] Value={ 2L,8L,28L,98L,350L,1274L,4706L,17576L,66196L,250952L,956384L,3660540L,14061140L,54177740L,209295260L,810375650L,3143981870L,12219117170L,47564380970L,185410909790L,723668784230L,2827767747950L,11061198475550L,43308802158650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066796Inst : IEnumerable<long>
{
public static readonly long[] Value=A066796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066796.Bytes);
public long this[int i]=>Value[i];

public static A066796Inst Instance=new A066796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066797
{
public static readonly long[] Value={ 6L,76L,1000L,13870L,198626L,2902782L,43019382L,644099772L,9719235072L,147565763892L,2251664727612L,34499268410712L,530417801358816L,8179108402119256L,126443689966980680L,1959067830909571214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066797Inst : IEnumerable<long>
{
public static readonly long[] Value=A066797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066797.Bytes);
public long this[int i]=>Value[i];

public static A066797Inst Instance=new A066797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066798
{
public static readonly BigInteger[] Value={ 20L,944L,49564L,2753720L,157871240L,9233006540L,547490880980L,32795094564080L,1979734520212192L,120244316085073616L,7339672750101339356L,BigInteger.Parse("449852213026938118560"),BigInteger.Parse("27666867082225970134160") };
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
public class A066798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066798Inst Instance=new A066798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066799
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,1L,1L,1L,2L,1L,4L,2L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,6L,1L,1L,1L,1L,2L,2L,1L,2L,3L,2L,6L,1L,1L,1L,1L,1L,4L,1L,6L,1L,1L,4L,1L,1L,1L,1L,1L,4L,1L,2L,2L,3L,4L,10L,1L,1L,1L,2L,1L,2L,2L,1L,1L,6L,2L,5L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,5L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066799Inst : IEnumerable<long>
{
public static readonly long[] Value=A066799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066799.Bytes);
public long this[int i]=>Value[i];

public static A066799Inst Instance=new A066799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066800
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,6L,4L,3L,3L,5L,4L,6L,3L,4L,4L,4L,2L,6L,6L,6L,4L,6L,3L,8L,4L,4L,5L,6L,4L,9L,6L,6L,3L,8L,4L,8L,4L,6L,4L,4L,3L,8L,6L,5L,6L,6L,6L,6L,4L,6L,6L,4L,3L,12L,8L,4L,5L,6L,4L,8L,5L,4L,6L,8L,4L,12L,9L,6L,6L,8L,6L,8L,3L,8L,8L,4L,4L,5L,8L,6L,4L,8L,6L,6L,4L,8L,4L,9L,4L,12L,8L,8L,6L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066800Inst : IEnumerable<long>
{
public static readonly long[] Value=A066800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066800.Bytes);
public long this[int i]=>Value[i];

public static A066800Inst Instance=new A066800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066801
{
public static readonly long[] Value={ 333L,735L,772L,219L,337L,333L,733L,377L,331L,329L,331L,747L,331L,338L,333L,121L,313L,333L,711L,113L,133L,337L,337L,911L,371L,933L,733L,791L,175L,333L,117L,337L,113L,557L,333L,733L,133L,371L,135L,573L,337L,733L,719L,753L,333L,531L,913L,377L,337L,193L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066801Inst : IEnumerable<long>
{
public static readonly long[] Value=A066801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066801.Bytes);
public long this[int i]=>Value[i];

public static A066801Inst Instance=new A066801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066802
{
public static readonly BigInteger[] Value={ 1L,20L,924L,48620L,2704156L,155117520L,9075135300L,538257874440L,32247603683100L,1946939425648112L,118264581564861424L,7219428434016265740L,BigInteger.Parse("442512540276836779204"),BigInteger.Parse("27217014869199032015600") };
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
public class A066802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066802Inst Instance=new A066802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066803
{
public static readonly long[] Value={ 1L,5L,1L,1L,1L,5L,1L,1L,19L,25L,1L,1L,1L,145L,1L,1L,1L,5L,1L,1L,43L,5L,1L,97L,1L,265L,19L,1L,1L,25L,1L,1L,67L,5L,1L,1L,1L,5L,1L,1L,1L,145L,1L,1L,19L,5L,1L,1L,1L,12625L,307L,1L,1L,5L,1L,1L,1L,5L,1L,241L,1L,5L,817L,1L,1L,5L,1L,1L,139L,725L,1L,55969L,1L,745L,1L,1L,1L,265L,1L,1L,3097L,5L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066803Inst : IEnumerable<long>
{
public static readonly long[] Value=A066803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066803.Bytes);
public long this[int i]=>Value[i];

public static A066803Inst Instance=new A066803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066804
{
public static readonly long[] Value={ 1L,8L,34L,100L,235L,476L,868L,1464L,2325L,3520L,5126L,7228L,9919L,13300L,17480L,22576L,28713L,36024L,44650L,54740L,66451L,79948L,95404L,113000L,132925L,155376L,180558L,208684L,239975L,274660L,312976L,355168L,401489L,452200L,507570L,567876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066804Inst : IEnumerable<long>
{
public static readonly long[] Value=A066804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066804.Bytes);
public long this[int i]=>Value[i];

public static A066804Inst Instance=new A066804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066805
{
public static readonly long[] Value={ 1L,1L,5L,1L,6L,1L,8L,2L,5L,1L,7L,1L,5L,2L,5L,1L,7L,1L,5L,3L,6L,1L,6L,2L,5L,2L,13L,1L,6L,1L,5L,2L,5L,4L,6L,1L,8L,2L,5L,1L,6L,1L,5L,10L,5L,1L,7L,2L,8L,3L,5L,1L,7L,2L,5L,2L,7L,1L,6L,1L,5L,2L,6L,4L,6L,1L,8L,2L,5L,1L,6L,1L,5L,2L,5L,27L,7L,1L,5L,11L,5L,1L,15L,2L,5L,3L,7L,1L,6L,3L,19L,2L,6L,4L,14L,1L,13L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066805Inst : IEnumerable<long>
{
public static readonly long[] Value=A066805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066805.Bytes);
public long this[int i]=>Value[i];

public static A066805Inst Instance=new A066805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066806
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,16L,21L,27L,38L,49L,63L,84L,109L,138L,180L,228L,289L,369L,463L,578L,732L,911L,1128L,1407L,1741L,2140L,2646L,3243L,3968L,4862L,5925L,7198L,8770L,10620L,12833L,15524L,18718L,22502L,27075L,32467L,38873L,46537L,55565L,66220L,78946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066806Inst : IEnumerable<long>
{
public static readonly long[] Value=A066806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066806.Bytes);
public long this[int i]=>Value[i];

public static A066806Inst Instance=new A066806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066807
{
public static readonly BigInteger[] Value={ 3L,3L,57L,4971027L,BigInteger.Parse("29850020237398251227313"),BigInteger.Parse("17503832475167772961878049926333027042428946479619"),BigInteger.Parse("58167804601757508792865761341330650726830745576152064464908846133090363") };
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
public class A066807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066807Inst Instance=new A066807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066808
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,16L,4L,1L,256L,16L,4L,4081L,4L,16L,256L,1L,4L,261121L,4L,65536L,256L,16L,4L,65536L,33554305L,16L,67108864L,65536L,4L,16L,4L,1L,256L,16L,262144L,68451041281L,4L,16L,256L,65536L,4L,4398042316801L,4L,65536L,35184371957761L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066808Inst : IEnumerable<long>
{
public static readonly long[] Value=A066808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066808.Bytes);
public long this[int i]=>Value[i];

public static A066808Inst Instance=new A066808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066809
{
public static readonly long[] Value={ 1L,3L,8L,13L,27L,34L,61L,76L,111L,136L,201L,213L,303L,354L,439L,490L,642L,682L,871L,935L,1107L,1234L,1509L,1535L,1834L,2011L,2298L,2438L,2872L,2937L,3432L,3619L,4049L,4350L,4905L,4956L,5658L,6033L,6634L,6844L,7704L,7871L,8816L,9180L,9874L,10421L,11548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066809Inst : IEnumerable<long>
{
public static readonly long[] Value=A066809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066809.Bytes);
public long this[int i]=>Value[i];

public static A066809Inst Instance=new A066809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066810
{
public static readonly long[] Value={ 0L,0L,1L,7L,33L,131L,473L,1611L,5281L,16867L,52905L,163835L,502769L,1532883L,4651897L,14070379L,42456897L,127894979L,384799049L,1156756443L,3475250065L,10436235955L,31330727961L,94038321227L,282211432673L,846835624611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066810Inst : IEnumerable<long>
{
public static readonly long[] Value=A066810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066810.Bytes);
public long this[int i]=>Value[i];

public static A066810Inst Instance=new A066810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066811
{
public static readonly long[] Value={ 3L,19L,31L,67L,97L,5139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066811Inst : IEnumerable<long>
{
public static readonly long[] Value=A066811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066811.Bytes);
public long this[int i]=>Value[i];

public static A066811Inst Instance=new A066811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066812
{
public static readonly long[] Value={ 5L,8L,9L,11L,27L,33L,71L,75L,123L,147L,309L,315L,387L,513L,555L,573L,627L,636L,729L,795L,843L,911L,915L,1016L,1083L,1227L,1323L,1331L,1347L,1467L,1515L,1609L,1755L,1995L,2133L,2171L,2187L,2307L,2403L,2427L,2475L,2591L,2643L,2696L,2763L,2907L,3243L,3315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066812Inst : IEnumerable<long>
{
public static readonly long[] Value=A066812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066812.Bytes);
public long this[int i]=>Value[i];

public static A066812Inst Instance=new A066812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066813
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,12L,12L,12L,20L,20L,12L,12L,24L,8L,16L,48L,18L,72L,24L,60L,110L,88L,40L,60L,36L,36L,84L,56L,120L,240L,80L,80L,48L,24L,36L,36L,72L,48L,80L,120L,84L,420L,120L,264L,506L,368L,336L,420L,160L,96L,312L,468L,360L,120L,72L,252L,812L,464L,240L,60L,180L,288L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066813Inst : IEnumerable<long>
{
public static readonly long[] Value=A066813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066813.Bytes);
public long this[int i]=>Value[i];

public static A066813Inst Instance=new A066813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066814
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,13L,0L,31L,37L,113L,0L,61L,0L,193L,401L,211L,65537L,181L,0L,241L,577L,13313L,0L,421L,1297L,12289L,4357L,2113L,0L,1009L,0L,1321L,25601L,2424833L,752734097L,1801L,0L,786433L,495617L,2161L,0L,4801L,0L,15361L,7057L,155189249L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066814Inst : IEnumerable<long>
{
public static readonly long[] Value=A066814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066814.Bytes);
public long this[int i]=>Value[i];

public static A066814Inst Instance=new A066814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066815
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,14L,19L,33L,45L,69L,94L,148L,197L,289L,390L,575L,762L,1086L,1439L,2040L,2687L,3712L,4874L,6749L,8792L,11918L,15526L,20998L,27164L,36277L,46820L,62367L,80146L,105569L,135326L,177979L,227139L,296027L,377142L,490554L,622526L,804158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066815Inst : IEnumerable<long>
{
public static readonly long[] Value=A066815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066815.Bytes);
public long this[int i]=>Value[i];

public static A066815Inst Instance=new A066815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066816
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,10L,15L,20L,25L,36L,46L,58L,78L,95L,120L,160L,198L,249L,318L,392L,485L,608L,745L,914L,1140L,1390L,1692L,2092L,2528L,3032L,3709L,4468L,5364L,6494L,7770L,9279L,11161L,13347L,15824L,18920L,22465L,26539L,31607L,37345L,43994L,52016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066816Inst : IEnumerable<long>
{
public static readonly long[] Value=A066816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066816.Bytes);
public long this[int i]=>Value[i];

public static A066816Inst Instance=new A066816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066817
{
public static readonly BigInteger[] Value={ 0L,2131L,23L,3224591L,0L,0L,0L,0L,0L,0L,2251L,0L,0L,0L,3224591L,BigInteger.Parse("314313643123658229739531"),0L,0L,46747167851021731L,3224591L,3141114911731L,5171L,0L,21191L,3311531L,2351L,0L,22111L,3251L,32831437931L,0L,0L,0L };
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
public class A066817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066817Inst Instance=new A066817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066818
{
public static readonly long[] Value={ 1L,2L,1L,12L,1L,2L,3L,2L,1L,4L,1L,2L,3L,2L,1L,4L,1L,2L,3L,4L,1L,4L,5L,2L,7L,2L,1L,6L,1L,6L,3L,2L,3L,6L,1L,2L,3L,2L,1L,4L,1L,2L,3L,8L,1L,4L,11L,2L,3L,4L,1L,4L,7L,2L,13L,2L,1L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066818Inst : IEnumerable<long>
{
public static readonly long[] Value=A066818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066818.Bytes);
public long this[int i]=>Value[i];

public static A066818Inst Instance=new A066818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066819
{
public static readonly long[] Value={ 2L,5L,10L,21L,44L,73L,114L,167L,250L,339L,452L,583L,756L,935L,1126L,1359L,1598L,1849L,2130L,2423L,2782L,3201L,3632L,4075L,4566L,5075L,5668L,6309L,6962L,7621L,8304L,9023L,9766L,10527L,11336L,12247L,13200L,14213L,15232L,16263L,17312L,18415L,19638L,20867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066819Inst : IEnumerable<long>
{
public static readonly long[] Value=A066819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066819.Bytes);
public long this[int i]=>Value[i];

public static A066819Inst Instance=new A066819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066820
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,10L,14L,16L,20L,24L,26L,25L,36L,40L,48L,54L,56L,60L,66L,74L,84L,90L,94L,110L,116L,120L,124L,126L,98L,130L,134L,146L,150L,156L,160L,170L,176L,180L,184L,150L,204L,206L,210L,192L,224L,230L,236L,240L,250L,256L,260L,264L,270L,280L,284L,300L,306L,314L,326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066820Inst : IEnumerable<long>
{
public static readonly long[] Value=A066820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066820.Bytes);
public long this[int i]=>Value[i];

public static A066820Inst Instance=new A066820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066821
{
public static readonly long[] Value={ 2L,3L,5L,9L,13L,17L,21L,25L,33L,37L,45L,55L,57L,61L,65L,73L,76L,81L,85L,93L,97L,105L,117L,121L,129L,133L,141L,145L,157L,165L,177L,193L,201L,205L,213L,217L,225L,244L,253L,257L,261L,273L,277L,297L,298L,301L,313L,325L,333L,345L,357L,361L,381L,385L,393L,397L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066821Inst : IEnumerable<long>
{
public static readonly long[] Value=A066821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066821.Bytes);
public long this[int i]=>Value[i];

public static A066821Inst Instance=new A066821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066822
{
public static readonly long[] Value={ 1L,5L,20L,71L,238L,770L,2436L,7590L,23397L,71566L,217646L,659022L,1988805L,5986176L,17980968L,53922096L,161492571L,483149385L,1444245936L,4314214443L,12880107548L,38436170366L,114657076900L,341926185770L,1019435748435L,3038815305981L,9056974493700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066822Inst : IEnumerable<long>
{
public static readonly long[] Value=A066822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066822.Bytes);
public long this[int i]=>Value[i];

public static A066822Inst Instance=new A066822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066823
{
public static readonly BigInteger[] Value={ 157L,6011L,55717L,74636904300223L,BigInteger.Parse("1524920857037139836753"),BigInteger.Parse("533561095785570791522387803"),BigInteger.Parse("960826779344998235261901369163166807780807") };
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
public class A066823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066823Inst Instance=new A066823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066824
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,15L,19L,24L,30L,39L,48L,58L,69L,84L,100L,120L,142L,171L,200L,237L,275L,323L,372L,437L,505L,589L,678L,787L,904L,1042L,1189L,1365L,1557L,1785L,2031L,2327L,2638L,3009L,3405L,3875L,4376L,4970L,5610L,6356L,7166L,8081L,9082L,10225L,11469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066824Inst : IEnumerable<long>
{
public static readonly long[] Value=A066824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066824.Bytes);
public long this[int i]=>Value[i];

public static A066824Inst Instance=new A066824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066825
{
public static readonly long[] Value={ 1L,4L,13L,14L,31L,36L,54L,96L,113L,311L,487L,854L,1036L,1277L,1646L,3214L,3267L,3723L,4047L,4554L,4896L,5376L,10136L,13147L,13268L,16549L,20513L,21877L,25279L,26152L,27209L,28582L,31723L,32043L,32286L,33144L,35172L,35337L,35757L,35853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066825Inst : IEnumerable<long>
{
public static readonly long[] Value=A066825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066825.Bytes);
public long this[int i]=>Value[i];

public static A066825Inst Instance=new A066825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066826
{
public static readonly long[] Value={ 6L,13L,14L,15L,74L,190L,6456L,40082L,251735L,251736L,251738L,637325L,637326L,637342L,637343L,4124456L,4124458L,10553425L,10553433L,10553818L,27067038L,27067053L,69709872L,69709877L,69709945L,69709954L,179992917L,179992920L,179993011L,179993025L,179993170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066826Inst : IEnumerable<long>
{
public static readonly long[] Value=A066826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066826.Bytes);
public long this[int i]=>Value[i];

public static A066826Inst Instance=new A066826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066827
{
public static readonly long[] Value={ 3L,1L,1L,1L,33L,1L,1L,1L,513L,1L,1L,1L,8193L,1L,1L,1L,131073L,1L,1L,1L,2097153L,1L,1L,1L,33554433L,1L,1L,1L,536870913L,1L,1L,1L,8589934593L,1L,1L,1L,137438953473L,1L,1L,1L,2199023255553L,1L,1L,1L,35184372088833L,1L,1L,1L,562949953421313L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066827Inst : IEnumerable<long>
{
public static readonly long[] Value=A066827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066827.Bytes);
public long this[int i]=>Value[i];

public static A066827Inst Instance=new A066827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066828
{
public static readonly long[] Value={ 4L,5L,11L,12L,70L,72L,1053L,6459L,6460L,40083L,251742L,637320L,637322L,637330L,10553828L,69709721L,179992913L,179992922L,465769813L,1208198617L,1208198629L,3140421742L,3140421769L,3140421866L,8179002192L,8179002205L,8179002209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066828Inst : IEnumerable<long>
{
public static readonly long[] Value=A066828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066828.Bytes);
public long this[int i]=>Value[i];

public static A066828Inst Instance=new A066828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066829
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066829Inst : IEnumerable<long>
{
public static readonly long[] Value=A066829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066829.Bytes);
public long this[int i]=>Value[i];

public static A066829Inst Instance=new A066829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066830
{
public static readonly long[] Value={ 0L,3L,4L,15L,12L,35L,24L,63L,40L,99L,60L,143L,84L,195L,112L,255L,144L,323L,180L,399L,220L,483L,264L,575L,312L,675L,364L,783L,420L,899L,480L,1023L,544L,1155L,612L,1295L,684L,1443L,760L,1599L,840L,1763L,924L,1935L,1012L,2115L,1104L,2303L,1200L,2499L,1300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066830Inst : IEnumerable<long>
{
public static readonly long[] Value=A066830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066830.Bytes);
public long this[int i]=>Value[i];

public static A066830Inst Instance=new A066830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066831
{
public static readonly long[] Value={ 1L,13L,71L,87L,89L,181L,203L,305L,319L,362L,667L,899L,1257L,1363L,1421L,1525L,1711L,1798L,1889L,2407L,2501L,2933L,3103L,4609L,4615L,4687L,4843L,5002L,5191L,6583L,7123L,7625L,7627L,9374L,9947L,10063L,10411L,10991L,11107L,12989L,13543L,13891L,14587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066831Inst : IEnumerable<long>
{
public static readonly long[] Value=A066831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066831.Bytes);
public long this[int i]=>Value[i];

public static A066831Inst Instance=new A066831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066832
{
public static readonly long[] Value={ 1L,3L,15L,6L,8L,10L,8L,18L,13L,15L,5L,13L,12L,0L,24L,0L,28L,0L,17L,0L,37L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066832Inst : IEnumerable<long>
{
public static readonly long[] Value=A066832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066832.Bytes);
public long this[int i]=>Value[i];

public static A066832Inst Instance=new A066832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066833
{
public static readonly long[] Value={ 0L,1L,5L,1L,33L,49L,2L,1L,3L,2L,2L,2L,8L,1L,1L,28L,1L,7L,1L,1L,34L,2L,2L,2L,10L,2L,1L,9L,1L,1L,8L,2L,3L,16L,5L,7L,2L,14L,4L,2L,3L,4L,1L,3L,2L,3L,1L,8L,6L,2L,1L,32L,1L,10L,1L,3L,11L,2L,6L,6L,2L,1L,42L,1L,1L,2L,1L,2L,5L,1L,3L,4L,1L,1L,2L,1L,2L,5L,1L,1L,1L,15L,1L,2L,1L,4L,1L,1L,2L,6L,4L,15L,1L,1L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066833Inst : IEnumerable<long>
{
public static readonly long[] Value=A066833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066833.Bytes);
public long this[int i]=>Value[i];

public static A066833Inst Instance=new A066833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066834
{
public static readonly long[] Value={ 0L,1L,13L,1L,1L,4L,1L,1L,1L,3L,16L,16L,1L,11L,1L,1L,1L,1L,9L,13L,1L,5L,22L,4L,2L,6L,1L,1L,1L,39L,1L,1L,3L,1L,12L,4L,1L,106L,15L,19L,7L,7L,4L,1L,5L,1L,2L,1L,1L,2L,4L,3L,1L,10L,1L,1L,1L,1L,2L,3L,1L,6L,7L,8L,1L,7L,5L,1L,2L,44L,2L,1L,5L,1L,4L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,20L,8L,2L,3L,1L,1L,1L,4L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066834Inst : IEnumerable<long>
{
public static readonly long[] Value=A066834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066834.Bytes);
public long this[int i]=>Value[i];

public static A066834Inst Instance=new A066834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066835
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,5L,6L,3L,2L,5L,6L,7L,3L,3L,4L,4L,4L,5L,5L,7L,6L,3L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066835Inst : IEnumerable<long>
{
public static readonly long[] Value=A066835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066835.Bytes);
public long this[int i]=>Value[i];

public static A066835Inst Instance=new A066835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066836
{
public static readonly long[] Value={ 1L,4L,4L,28L,12L,11L,10L,30L,27L,26L,27L,27L,78L,25L,24L,20L,21L,25L,177L,73L,68L,72L,72L,178L,71L,72L,69L,70L,181L,176L,69L,68L,66L,66L,65L,175L,429L,61L,40L,448L,44L,45L,51L,47L,420L,426L,173L,427L,425L,1062L,1072L,429L,428L,1071L,1067L,430L,165L,164L,426L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066836Inst : IEnumerable<long>
{
public static readonly long[] Value=A066836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066836.Bytes);
public long this[int i]=>Value[i];

public static A066836Inst Instance=new A066836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066837
{
public static readonly long[] Value={ 1L,4L,2700L,3L,69L,29L,68L,185L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066837Inst : IEnumerable<long>
{
public static readonly long[] Value=A066837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066837.Bytes);
public long this[int i]=>Value[i];

public static A066837Inst Instance=new A066837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066838
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,5L,30L,105L,70L,21L,210L,385L,2310L,2145L,2002L,15015L,30030L,85085L,510510L,969969L,461890L,440895L,9699690L,37182145L,44618574L,8580495L,74364290L,15935205L,223092870L,215656441L,6469693230L,100280245065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066838Inst : IEnumerable<long>
{
public static readonly long[] Value=A066838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066838.Bytes);
public long this[int i]=>Value[i];

public static A066838Inst Instance=new A066838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066839
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,3L,1L,3L,4L,3L,1L,6L,1L,3L,4L,7L,1L,6L,1L,7L,4L,3L,1L,10L,6L,3L,4L,7L,1L,11L,1L,7L,4L,3L,6L,16L,1L,3L,4L,12L,1L,12L,1L,7L,9L,3L,1L,16L,8L,8L,4L,7L,1L,12L,6L,14L,4L,3L,1L,21L,1L,3L,11L,15L,6L,12L,1L,7L,4L,15L,1L,24L,1L,3L,9L,7L,8L,12L,1L,20L,13L,3L,1L,23L,6L,3L,4L,15L,1L,26L,8L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066839Inst : IEnumerable<long>
{
public static readonly long[] Value=A066839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066839.Bytes);
public long this[int i]=>Value[i];

public static A066839Inst Instance=new A066839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066840
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,6L,4L,7L,4L,15L,6L,21L,9L,14L,16L,36L,13L,45L,20L,30L,25L,66L,24L,63L,36L,61L,42L,105L,32L,120L,64L,80L,64L,102L,54L,171L,81L,114L,80L,210L,66L,231L,110L,134L,121L,276L,96L,258L,124L,200L,156L,351L,121L,270L,168L,252L,196L,435L,120L,465L,225L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066840Inst : IEnumerable<long>
{
public static readonly long[] Value=A066840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066840.Bytes);
public long this[int i]=>Value[i];

public static A066840Inst Instance=new A066840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066841
{
public static readonly BigInteger[] Value={ 1L,2L,3L,16L,5L,432L,7L,2048L,243L,8000L,11L,143327232L,13L,87808L,455625L,67108864L,17L,117546246144L,19L,1310720000000L,15752961L,5451776L,23L,BigInteger.Parse("252428641478023053312"),78125L,35995648L,387420489L,3537090251849728L,29L };
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
public class A066841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066841Inst Instance=new A066841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066842
{
public static readonly BigInteger[] Value={ 1L,4L,27L,1024L,3125L,5038848L,823543L,17179869184L,10460353203L,125000000000000L,285311670611L,BigInteger.Parse("11501279977342425366528"),302875106592253L,BigInteger.Parse("36604861748562100682752"),BigInteger.Parse("36947297000885009765625") };
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
public class A066842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066842Inst Instance=new A066842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066843
{
public static readonly long[] Value={ 1L,2L,4L,12L,24L,96L,192L,768L,2304L,9216L,18432L,110592L,221184L,884736L,3538944L,17694720L,35389440L,212336640L,424673280L,2548039680L,10192158720L,40768634880L,81537269760L,652298158080L,1956894474240L,7827577896960L,31310311587840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066843Inst : IEnumerable<long>
{
public static readonly long[] Value=A066843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066843.Bytes);
public long this[int i]=>Value[i];

public static A066843Inst Instance=new A066843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066844
{
public static readonly long[] Value={ 25L,40L,50L,64L,80L,100L,125L,160L,200L,250L,320L,400L,500L,640L,800L,1000L,1250L,1600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066844Inst : IEnumerable<long>
{
public static readonly long[] Value=A066844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066844.Bytes);
public long this[int i]=>Value[i];

public static A066844Inst Instance=new A066844Inst();

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