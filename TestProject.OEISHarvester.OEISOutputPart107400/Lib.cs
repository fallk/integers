using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A135313
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,1L,12L,13L,0L,1L,61L,106L,75L,0L,1L,310L,1105L,1035L,541L,0L,1L,1821L,12075L,16025L,11301L,4683L,0L,1L,11592L,141533L,267715L,239379L,137774L,47293L,0L,1L,80963L,1812216L,4798983L,5287506L,3794378L,1863044L,545835L,0L,1L,608832L,25188019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135313Inst : IEnumerable<long>
{
public static readonly long[] Value=A135313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135313.Bytes);
public long this[int i]=>Value[i];

public static A135313Inst Instance=new A135313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135314
{
public static readonly BigInteger[] Value={ 1L,42L,63504L,3456649728L,6773484887801856L,BigInteger.Parse("477827850919028491026432"),BigInteger.Parse("1213481763117613016471583634489344"),BigInteger.Parse("110942398014527364799038852663129544775958528") };
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
public class A135314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135314Inst Instance=new A135314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135315
{
public static readonly BigInteger[] Value={ 1L,56L,153664L,20661046784L,136122083613085696L,BigInteger.Parse("43944136529148801869643776"),BigInteger.Parse("695135330857032999706040305346412544"),BigInteger.Parse("538807794445443668301287736683760181725850763264") };
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
public class A135315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135315Inst Instance=new A135315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135316
{
public static readonly long[] Value={ 691L,887L,1997L,3583L,3673L,3853L,3943L,4079L,4259L,4349L,4799L,4889L,5581L,5851L,6257L,6977L,8089L,8179L,8269L,8539L,8629L,8719L,10663L,10883L,11777L,11833L,11867L,11923L,11953L,11959L,12097L,12763L,12823L,13397L,13523L,13553L,13597L,13633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135316Inst : IEnumerable<long>
{
public static readonly long[] Value=A135316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135316.Bytes);
public long this[int i]=>Value[i];

public static A135316Inst Instance=new A135316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135317
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,3L,4L,0L,3L,4L,5L,1L,2L,3L,6L,0L,1L,4L,5L,6L,2L,5L,6L,7L,8L,0L,7L,8L,9L,3L,4L,5L,1L,2L,3L,6L,7L,10L,4L,7L,8L,0L,1L,2L,9L,10L,11L,5L,8L,9L,12L,6L,7L,10L,11L,12L,8L,9L,10L,0L,3L,4L,13L,1L,2L,5L,6L,11L,3L,4L,9L,14L,0L,1L,10L,11L,12L,2L,7L,8L,13L,5L,6L,9L,12L,13L,7L,10L,11L,14L,15L,16L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135317Inst : IEnumerable<long>
{
public static readonly long[] Value=A135317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135317.Bytes);
public long this[int i]=>Value[i];

public static A135317Inst Instance=new A135317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135318
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,8L,11L,16L,21L,32L,43L,64L,85L,128L,171L,256L,341L,512L,683L,1024L,1365L,2048L,2731L,4096L,5461L,8192L,10923L,16384L,21845L,32768L,43691L,65536L,87381L,131072L,174763L,262144L,349525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135318Inst : IEnumerable<long>
{
public static readonly long[] Value=A135318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135318.Bytes);
public long this[int i]=>Value[i];

public static A135318Inst Instance=new A135318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135319
{
public static readonly long[] Value={ 0L,3L,4L,6L,6L,7L,8L,9L,9L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135319Inst : IEnumerable<long>
{
public static readonly long[] Value=A135319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135319.Bytes);
public long this[int i]=>Value[i];

public static A135319Inst Instance=new A135319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135352
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L,1L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135352Inst : IEnumerable<long>
{
public static readonly long[] Value=A135352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135352.Bytes);
public long this[int i]=>Value[i];

public static A135352Inst Instance=new A135352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135353
{
public static readonly long[] Value={ 2L,-3L,3L,22L,51L,93L,170L,333L,675L,1366L,2739L,5469L,10922L,21837L,43683L,87382L,174771L,349533L,699050L,1398093L,2796195L,5592406L,11184819L,22369629L,44739242L,89478477L,178956963L,357913942L,715827891L,1431655773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135353Inst : IEnumerable<long>
{
public static readonly long[] Value=A135353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135353.Bytes);
public long this[int i]=>Value[i];

public static A135353Inst Instance=new A135353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135354
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,16L,315L,128L,2835L,256L,155925L,1024L,6081075L,2048L,638512875L,32768L,10854718875L,65536L,1856156927625L,262144L,194896477400625L,524288L,49308808782358125L,4194304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135354Inst : IEnumerable<long>
{
public static readonly long[] Value=A135354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135354.Bytes);
public long this[int i]=>Value[i];

public static A135354Inst Instance=new A135354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135355
{
public static readonly long[] Value={ 4L,6L,9L,14L,15L,25L,26L,34L,35L,38L,39L,46L,49L,57L,58L,69L,123L,129L,134L,145L,146L,158L,159L,169L,178L,235L,237L,247L,249L,259L,267L,278L,289L,346L,358L,458L,469L,478L,489L,579L,589L,679L,689L,789L,1234L,1238L,1247L,1257L,1267L,1345L,1346L,1347L,1349L,1357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135355Inst : IEnumerable<long>
{
public static readonly long[] Value=A135355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135355.Bytes);
public long this[int i]=>Value[i];

public static A135355Inst Instance=new A135355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135356
{
public static readonly long[] Value={ 2L,2L,0L,3L,-3L,2L,4L,-6L,4L,0L,5L,-10L,10L,-5L,2L,6L,-15L,20L,-15L,6L,0L,7L,-21L,35L,-35L,21L,-7L,2L,8L,-28L,56L,-70L,56L,-28L,8L,0L,9L,-36L,84L,-126L,126L,-84L,36L,-9L,2L,10L,-45L,120L,-210L,252L,-210L,120L,-45L,10L,0L,11L,-55L,165L,-330L,462L,-462L,330L,-165L,55L,-11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135356Inst : IEnumerable<long>
{
public static readonly long[] Value=A135356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135356.Bytes);
public long this[int i]=>Value[i];

public static A135356Inst Instance=new A135356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135357
{
public static readonly long[] Value={ 6L,6L,6L,8L,6L,6L,6L,8L,6L,6L,6L,8L,8L,10L,8L,10L,6L,6L,6L,8L,6L,6L,6L,8L,6L,6L,6L,8L,8L,10L,8L,10L,6L,6L,6L,8L,6L,6L,6L,8L,6L,6L,6L,8L,8L,10L,8L,10L,8L,10L,8L,10L,10L,12L,10L,12L,8L,10L,8L,10L,10L,12L,10L,12L,8L,10L,8L,10L,10L,12L,10L,12L,8L,10L,8L,10L,10L,12L,10L,12L,10L,12L,10L,12L,12L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135357Inst : IEnumerable<long>
{
public static readonly long[] Value=A135357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135357.Bytes);
public long this[int i]=>Value[i];

public static A135357Inst Instance=new A135357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135358
{
public static readonly long[] Value={ 6L,12L,19L,25L,32L,38L,45L,51L,58L,64L,71L,77L,83L,90L,96L,103L,109L,116L,122L,129L,135L,142L,148L,154L,161L,167L,174L,180L,187L,193L,200L,206L,213L,219L,225L,232L,238L,245L,251L,258L,264L,271L,277L,284L,290L,296L,303L,309L,316L,322L,329L,335L,342L,348L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135358Inst : IEnumerable<long>
{
public static readonly long[] Value=A135358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135358.Bytes);
public long this[int i]=>Value[i];

public static A135358Inst Instance=new A135358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135359
{
public static readonly long[] Value={ 0L,2L,4L,4L,3L,4L,11L,8L,5L,14L,7L,4L,10L,16L,16L,16L,30L,16L,30L,16L,11L,58L,75L,16L,34L,10L,5L,16L,6L,16L,8L,32L,58L,30L,16L,16L,58L,30L,10L,16L,33L,16L,54L,92L,16L,118L,224L,16L,36L,34L,59L,16L,36L,34L,63L,16L,130L,6L,64L,16L,43L,8L,16L,64L,16L,58L,210L,84L,118L,16L,43L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135359Inst : IEnumerable<long>
{
public static readonly long[] Value=A135359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135359.Bytes);
public long this[int i]=>Value[i];

public static A135359Inst Instance=new A135359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135360
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,22L,44L,92L,192L,392L,784L,1552L,3072L,6112L,12224L,24512L,49152L,98432L,196864L,393472L,786432L,1572352L,3144704L,6290432L,12582912L,25167872L,50335744L,100667392L,201326592L,402644992L,805289984L,1610596352L,3221225472L,6442483712L,12884967424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135360Inst : IEnumerable<long>
{
public static readonly long[] Value=A135360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135360.Bytes);
public long this[int i]=>Value[i];

public static A135360Inst Instance=new A135360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135361
{
public static readonly BigInteger[] Value={ 0L,1L,2L,9L,730L,389017001L,BigInteger.Parse("58871587162270593034051002"),BigInteger.Parse("204040901322752673844230437877671861543858084850895762746141813554591014612009") };
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
public class A135361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135361Inst Instance=new A135361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135362
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,4L,1L,1L,1L,2L,1L,1L,1L,8L,1L,1L,1L,16L,1L,4L,1L,8L,1L,1L,9L,1L,1L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135362Inst : IEnumerable<long>
{
public static readonly long[] Value=A135362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135362.Bytes);
public long this[int i]=>Value[i];

public static A135362Inst Instance=new A135362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135363
{
public static readonly long[] Value={ 10L,15L,19L,24L,25L,29L,33L,36L,39L,43L,47L,48L,50L,51L,54L,58L,59L,60L,67L,68L,69L,72L,73L,75L,77L,79L,82L,83L,84L,85L,91L,93L,94L,95L,97L,100L,101L,102L,106L,107L,109L,112L,115L,116L,118L,120L,122L,123L,126L,127L,128L,133L,134L,140L,142L,143L,146L,148L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135363Inst : IEnumerable<long>
{
public static readonly long[] Value=A135363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135363.Bytes);
public long this[int i]=>Value[i];

public static A135363Inst Instance=new A135363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135364
{
public static readonly long[] Value={ 1L,2L,3L,7L,17L,40L,93L,216L,502L,1167L,2713L,6307L,14662L,34085L,79238L,184206L,428227L,995507L,2314273L,5380032L,12507057L,29075380L,67592058L,157132471L,365288677L,849193147L,1974134558L,4589306057L,10668842202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135364Inst : IEnumerable<long>
{
public static readonly long[] Value=A135364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135364.Bytes);
public long this[int i]=>Value[i];

public static A135364Inst Instance=new A135364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135365
{
public static readonly long[] Value={ 1L,3L,9L,11L,33L,99L,313L,939L,2817L,8435L,25305L,75915L,227761L,683283L,2049849L,6149531L,18448593L,55345779L,166037353L,498112059L,1494336177L,4483008515L,13449025545L,40347076635L,121041229921L,363123689763L,1089371069289L,3268113207851L,9804339623553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135365Inst : IEnumerable<long>
{
public static readonly long[] Value=A135365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135365.Bytes);
public long this[int i]=>Value[i];

public static A135365Inst Instance=new A135365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135366
{
public static readonly long[] Value={ 0L,2L,1L,4L,4L,2L,6L,8L,7L,4L,3L,8L,12L,6L,7L,16L,16L,14L,18L,4L,19L,8L,22L,8L,33L,12L,7L,40L,11L,26L,23L,32L,8L,16L,6L,32L,5L,18L,37L,24L,40L,38L,42L,8L,7L,22L,10L,32L,61L,84L,38L,12L,35L,32L,46L,40L,32L,28L,24L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135366Inst : IEnumerable<long>
{
public static readonly long[] Value=A135366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135366.Bytes);
public long this[int i]=>Value[i];

public static A135366Inst Instance=new A135366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135367
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,15L,23L,31L,87L,111L,119L,167L,335L,1391L,1455L,1607L,1679L,1991L,25887L,26375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135367Inst : IEnumerable<long>
{
public static readonly long[] Value=A135367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135367.Bytes);
public long this[int i]=>Value[i];

public static A135367Inst Instance=new A135367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135576
{
public static readonly long[] Value={ 1L,7L,21L,73L,273L,1057L,4161L,16513L,65793L,262657L,1049601L,4196353L,16781313L,67117057L,268451841L,1073774593L,4295032833L,17180000257L,68719738881L,274878431233L,1099512676353L,4398048608257L,17592190238721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135576Inst : IEnumerable<long>
{
public static readonly long[] Value=A135576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135576.Bytes);
public long this[int i]=>Value[i];

public static A135576Inst Instance=new A135576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135577
{
public static readonly BigInteger[] Value={ 1L,111L,10101L,1001001L,100010001L,10000100001L,1000001000001L,100000010000001L,10000000100000001L,1000000001000000001L,BigInteger.Parse("100000000010000000001"),BigInteger.Parse("10000000000100000000001") };
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
public class A135577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135577Inst Instance=new A135577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135578
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,15L,16L,17L,19L,20L,22L,23L,24L,27L,31L,43L,55L,87L,96L,102L,103L,111L,119L,167L,223L,335L,1391L,1455L,1607L,1679L,1775L,1991L,25887L,26375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135578Inst : IEnumerable<long>
{
public static readonly long[] Value=A135578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135578.Bytes);
public long this[int i]=>Value[i];

public static A135578Inst Instance=new A135578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135579
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,30L,31L,32L,34L,35L,36L,41L,43L,46L,54L,55L,58L,59L,64L,86L,87L,91L,96L,102L,103L,111L,118L,119L,128L,130L,147L,151L,167L,223L,335L,1391L,1455L,1607L,1679L,1775L,1991L,25887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135579Inst : IEnumerable<long>
{
public static readonly long[] Value=A135579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135579.Bytes);
public long this[int i]=>Value[i];

public static A135579Inst Instance=new A135579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135580
{
public static readonly long[] Value={ 3L,13L,23L,3L,43L,53L,3L,73L,83L,3L,103L,113L,23L,13L,43L,53L,163L,173L,83L,193L,3L,13L,223L,233L,43L,53L,263L,73L,283L,293L,3L,313L,23L,3L,43L,353L,3L,373L,383L,3L,3L,41L,23L,433L,443L,53L,463L,73L,83L,3L,503L,13L,523L,53L,43L,53L,563L,73L,83L,593L,3L,613L,23L,3L,643L,653L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135580Inst : IEnumerable<long>
{
public static readonly long[] Value=A135580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135580.Bytes);
public long this[int i]=>Value[i];

public static A135580Inst Instance=new A135580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135581
{
public static readonly long[] Value={ 6L,8L,8L,15L,21L,11L,13L,27L,16L,35L,16L,27L,16L,27L,55L,27L,16L,16L,16L,65L,27L,16L,77L,16L,85L,16L,29L,91L,31L,16L,95L,16L,37L,115L,16L,119L,16L,41L,43L,133L,16L,47L,16L,143L,125L,16L,125L,16L,53L,161L,16L,59L,16L,61L,125L,187L,16L,67L,16L,203L,125L,16L,209L,71L,16L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135581Inst : IEnumerable<long>
{
public static readonly long[] Value=A135581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135581.Bytes);
public long this[int i]=>Value[i];

public static A135581Inst Instance=new A135581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135582
{
public static readonly long[] Value={ 1L,1L,4L,7L,18L,39L,95L,232L,606L,1663L,4839L,14807L,47330L,156611L,532308L,1846622L,6507103L,23210020L,83590477L,303425693L,1108650850L,4073443378L,15039391464L,55763147423L,207543422052L,775082175863L,2903508757053L,10907257755616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135582Inst : IEnumerable<long>
{
public static readonly long[] Value=A135582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135582.Bytes);
public long this[int i]=>Value[i];

public static A135582Inst Instance=new A135582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135583
{
public static readonly long[] Value={ 3L,8L,28L,108L,428L,1708L,6828L,27308L,109228L,436908L,1747628L,6990508L,27962028L,111848108L,447392428L,1789569708L,7158278828L,28633115308L,114532461228L,458129844908L,1832519379628L,7330077518508L,29320310074028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135583Inst : IEnumerable<long>
{
public static readonly long[] Value=A135583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135583.Bytes);
public long this[int i]=>Value[i];

public static A135583Inst Instance=new A135583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135584
{
public static readonly long[] Value={ 3L,3L,3L,59L,11L,17L,29L,11L,71L,71L,23L,11L,29L,29L,11L,83L,3L,11L,281L,11L,101L,71L,23L,257L,401L,293L,107L,293L,53L,11L,113L,251L,47L,587L,23L,179L,389L,59L,173L,17L,1427L,83L,431L,53L,563L,593L,41L,47L,239L,383L,431L,1181L,701L,971L,149L,593L,569L,149L,191L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135584Inst : IEnumerable<long>
{
public static readonly long[] Value=A135584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135584.Bytes);
public long this[int i]=>Value[i];

public static A135584Inst Instance=new A135584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135585
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,4L,5L,5L,5L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,16L,16L,16L,17L,17L,18L,19L,20L,20L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,41L,41L,41L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135585Inst : IEnumerable<long>
{
public static readonly long[] Value=A135585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135585.Bytes);
public long this[int i]=>Value[i];

public static A135585Inst Instance=new A135585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135586
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,5L,10L,3L,6L,7L,14L,8L,16L,17L,34L,4L,8L,9L,18L,10L,20L,21L,42L,11L,22L,23L,46L,24L,48L,49L,98L,5L,10L,11L,22L,12L,24L,25L,50L,13L,26L,27L,54L,28L,56L,57L,114L,14L,28L,29L,58L,30L,60L,61L,122L,31L,62L,63L,126L,64L,128L,129L,258L,6L,12L,13L,26L,14L,28L,29L,58L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135586Inst : IEnumerable<long>
{
public static readonly long[] Value=A135586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135586.Bytes);
public long this[int i]=>Value[i];

public static A135586Inst Instance=new A135586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135587
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,8L,17L,4L,9L,10L,21L,11L,23L,24L,49L,5L,11L,12L,25L,13L,27L,28L,57L,14L,29L,30L,61L,31L,63L,64L,129L,6L,13L,14L,29L,15L,31L,32L,65L,16L,33L,34L,69L,35L,71L,72L,145L,17L,35L,36L,73L,37L,75L,76L,153L,38L,77L,78L,157L,79L,159L,160L,321L,7L,15L,16L,33L,17L,35L,36L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135587Inst : IEnumerable<long>
{
public static readonly long[] Value=A135587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135587.Bytes);
public long this[int i]=>Value[i];

public static A135587Inst Instance=new A135587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135588
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,74L,302L,1314L,6122L,29982L,154718L,831986L,4667070L,27118610L,163264862L,1013640242L,6488705638L,42687497378L,288492113950L,1998190669298L,14177192483742L,102856494496050L,762657487965086L,5771613810502002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135588Inst : IEnumerable<long>
{
public static readonly long[] Value=A135588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135588.Bytes);
public long this[int i]=>Value[i];

public static A135588Inst Instance=new A135588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135589
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,2L,4L,0L,0L,1L,9L,10L,0L,0L,0L,12L,36L,26L,0L,0L,0L,10L,76L,140L,76L,0L,0L,0L,6L,116L,420L,540L,232L,0L,0L,0L,3L,138L,915L,2160L,2142L,764L,0L,0L,0L,1L,136L,1605L,6230L,10766L,8624L,2620L,0L,0L,0L,0L,116L,2372L,14436L,39130L,53312L,35856L,9496L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135589Inst : IEnumerable<long>
{
public static readonly long[] Value=A135589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135589.Bytes);
public long this[int i]=>Value[i];

public static A135589Inst Instance=new A135589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135590
{
public static readonly long[] Value={ 216L,948L,1560L,4872L,8208L,9828L,18200L,29640L,37024L,65536L,89550L,283800L,535920L,592956L,649800L,825930L,1042320L,1382400L,1536220L,3688230L,4215120L,4321800L,5103210L,19078930L,21415680L,24471720L,214067490L,435457620L,535019100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135590Inst : IEnumerable<long>
{
public static readonly long[] Value=A135590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135590.Bytes);
public long this[int i]=>Value[i];

public static A135590Inst Instance=new A135590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135591
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,1L,1L,1L,7L,0L,7L,1L,1L,1L,10L,0L,10L,0L,1L,1L,12L,2L,2L,1L,1L,0L,14L,2L,14L,0L,1L,1L,1L,0L,17L,1L,1L,2L,19L,2L,19L,0L,0L,1L,20L,0L,6L,0L,1L,0L,21L,2L,1L,2L,1L,1L,24L,0L,24L,1L,0L,1L,1L,2L,27L,0L,1L,2L,28L,0L,28L,1L,0L,0L,1L,2L,30L,0L,1L,1L,32L,0L,1L,1L,1L,2L,35L,0L,1L,0L,1L,1L,1L,0L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135591Inst : IEnumerable<long>
{
public static readonly long[] Value=A135591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135591.Bytes);
public long this[int i]=>Value[i];

public static A135591Inst Instance=new A135591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135672
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,25L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,33L,34L,35L,36L,37L,38L,38L,39L,40L,41L,42L,43L,43L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135672Inst : IEnumerable<long>
{
public static readonly long[] Value=A135672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135672.Bytes);
public long this[int i]=>Value[i];

public static A135672Inst Instance=new A135672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135673
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,10L,11L,12L,14L,15L,16L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135673Inst : IEnumerable<long>
{
public static readonly long[] Value=A135673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135673.Bytes);
public long this[int i]=>Value[i];

public static A135673Inst Instance=new A135673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135674
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135674Inst : IEnumerable<long>
{
public static readonly long[] Value=A135674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135674.Bytes);
public long this[int i]=>Value[i];

public static A135674Inst Instance=new A135674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135675
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,18L,20L,22L,25L,27L,30L,32L,35L,37L,40L,43L,46L,49L,52L,54L,58L,61L,64L,67L,70L,73L,77L,80L,83L,87L,90L,94L,97L,101L,104L,108L,112L,116L,119L,123L,127L,131L,135L,139L,143L,147L,151L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135675Inst : IEnumerable<long>
{
public static readonly long[] Value=A135675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135675.Bytes);
public long this[int i]=>Value[i];

public static A135675Inst Instance=new A135675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135676
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,6L,8L,9L,11L,13L,15L,17L,19L,21L,24L,26L,29L,31L,34L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,76L,79L,82L,86L,89L,93L,96L,100L,103L,107L,111L,115L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135676Inst : IEnumerable<long>
{
public static readonly long[] Value=A135676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135676.Bytes);
public long this[int i]=>Value[i];

public static A135676Inst Instance=new A135676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135677
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,21L,24L,28L,32L,36L,40L,44L,48L,52L,57L,61L,66L,70L,75L,79L,84L,89L,94L,99L,104L,108L,114L,119L,124L,129L,134L,139L,145L,150L,155L,161L,166L,172L,177L,183L,188L,194L,200L,206L,211L,217L,223L,229L,235L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135677Inst : IEnumerable<long>
{
public static readonly long[] Value=A135677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135677.Bytes);
public long this[int i]=>Value[i];

public static A135677Inst Instance=new A135677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135678
{
public static readonly long[] Value={ 2L,4L,7L,10L,13L,16L,20L,24L,27L,31L,35L,39L,43L,47L,51L,56L,60L,65L,69L,74L,78L,83L,88L,93L,98L,103L,108L,113L,118L,123L,128L,133L,138L,144L,149L,154L,160L,165L,171L,176L,182L,187L,193L,199L,205L,210L,216L,222L,228L,234L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135678Inst : IEnumerable<long>
{
public static readonly long[] Value=A135678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135678.Bytes);
public long this[int i]=>Value[i];

public static A135678Inst Instance=new A135678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135679
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,2L,11L,2L,13L,2L,3L,2L,17L,2L,19L,2L,3L,2L,23L,2L,3L,2L,3L,2L,29L,2L,31L,2L,3L,2L,3L,2L,37L,2L,3L,2L,41L,2L,43L,2L,3L,2L,47L,2L,3L,2L,3L,2L,53L,2L,3L,2L,3L,2L,59L,2L,61L,2L,3L,2L,3L,2L,67L,2L,3L,2L,71L,2L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135679Inst : IEnumerable<long>
{
public static readonly long[] Value=A135679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135679.Bytes);
public long this[int i]=>Value[i];

public static A135679Inst Instance=new A135679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135680
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,7L,4L,5L,4L,11L,4L,13L,4L,5L,4L,17L,4L,19L,4L,5L,4L,23L,4L,5L,4L,5L,4L,29L,4L,31L,4L,5L,4L,5L,4L,37L,4L,5L,4L,41L,4L,43L,4L,5L,4L,47L,4L,5L,4L,5L,4L,53L,4L,5L,4L,5L,4L,59L,4L,61L,4L,5L,4L,5L,4L,67L,4L,5L,4L,71L,4L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135680Inst : IEnumerable<long>
{
public static readonly long[] Value=A135680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135680.Bytes);
public long this[int i]=>Value[i];

public static A135680Inst Instance=new A135680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135681
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,7L,4L,1L,4L,11L,4L,13L,4L,1L,4L,17L,4L,19L,4L,1L,4L,23L,4L,1L,4L,1L,4L,29L,4L,31L,4L,1L,4L,1L,4L,37L,4L,1L,4L,41L,4L,43L,4L,1L,4L,47L,4L,1L,4L,1L,4L,53L,4L,1L,4L,1L,4L,59L,4L,61L,4L,1L,4L,1L,4L,67L,4L,1L,4L,71L,4L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135681Inst : IEnumerable<long>
{
public static readonly long[] Value=A135681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135681.Bytes);
public long this[int i]=>Value[i];

public static A135681Inst Instance=new A135681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135682
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,7L,4L,7L,4L,11L,4L,13L,4L,7L,4L,17L,4L,19L,4L,7L,4L,23L,4L,7L,4L,7L,4L,29L,4L,31L,4L,7L,4L,7L,4L,37L,4L,7L,4L,41L,4L,43L,4L,7L,4L,47L,4L,7L,4L,7L,4L,53L,4L,7L,4L,7L,4L,59L,4L,61L,4L,7L,4L,7L,4L,67L,4L,7L,4L,71L,4L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135682Inst : IEnumerable<long>
{
public static readonly long[] Value=A135682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135682.Bytes);
public long this[int i]=>Value[i];

public static A135682Inst Instance=new A135682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135683
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,6L,1L,8L,9L,10L,1L,12L,1L,14L,15L,16L,1L,18L,1L,20L,21L,22L,1L,24L,25L,26L,27L,28L,1L,30L,1L,32L,33L,34L,35L,36L,1L,38L,39L,40L,1L,42L,1L,44L,45L,46L,1L,48L,49L,50L,51L,52L,1L,54L,55L,56L,57L,58L,1L,60L,1L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135683Inst : IEnumerable<long>
{
public static readonly long[] Value=A135683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135683.Bytes);
public long this[int i]=>Value[i];

public static A135683Inst Instance=new A135683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135684
{
public static readonly long[] Value={ 1L,11L,11L,4L,11L,6L,11L,8L,9L,10L,11L,12L,11L,14L,15L,16L,11L,18L,11L,20L,21L,22L,11L,24L,25L,26L,27L,28L,11L,30L,11L,32L,33L,34L,35L,36L,11L,38L,39L,40L,11L,42L,11L,44L,45L,46L,11L,48L,49L,50L,51L,52L,11L,54L,55L,56L,57L,58L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135684Inst : IEnumerable<long>
{
public static readonly long[] Value=A135684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135684.Bytes);
public long this[int i]=>Value[i];

public static A135684Inst Instance=new A135684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135685
{
public static readonly long[] Value={ 0L,0L,1L,0L,-2L,0L,-3L,0L,1L,0L,4L,0L,-4L,0L,5L,0L,-10L,0L,1L,0L,-6L,0L,20L,0L,-6L,0L,-7L,0L,35L,0L,-21L,0L,1L,0L,8L,0L,-56L,0L,56L,0L,-8L,0L,9L,0L,-84L,0L,126L,0L,-36L,0L,1L,0L,-10L,0L,120L,0L,-252L,0L,120L,0L,-10L,0L,-11L,0L,165L,0L,-462L,0L,330L,0L,-55L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135685Inst : IEnumerable<long>
{
public static readonly long[] Value=A135685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135685.Bytes);
public long this[int i]=>Value[i];

public static A135685Inst Instance=new A135685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135686
{
public static readonly BigInteger[] Value={ 1L,1L,3L,6L,21L,69L,342L,1791L,13419L,111924L,1306215L,17423271L,321771366L,6890344533L,203170877793L,7003940931864L,331467832767285L,18429651200703861L,1404296660000722446L,BigInteger.Parse("126080887032762342111"),BigInteger.Parse("15497512127400670236027"),BigInteger.Parse("2248516102364654511363948") };
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
public class A135686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135686Inst Instance=new A135686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135687
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,0L,12L,12L,-36L,-96L,120L,792L,-48L,-6384L,-6000L,45072L,93072L,-312576L,-1243296L,2195040L,17114592L,-9225888L,-231715584L,-102553152L,3141465024L,4679762304L,-42442213056L,-112638647616L,566436761280L,2368655123136L,-6694333057344L,-44592815027520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135687Inst : IEnumerable<long>
{
public static readonly long[] Value=A135687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135687.Bytes);
public long this[int i]=>Value[i];

public static A135687Inst Instance=new A135687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135784
{
public static readonly long[] Value={ 4L,25L,64L,100L,169L,289L,324L,400L,625L,676L,841L,1024L,1156L,1369L,1600L,1681L,2025L,2500L,2704L,2809L,3364L,3721L,4225L,4624L,5184L,5329L,5476L,6400L,6724L,7225L,7921L,8100L,9409L,9604L,10000L,10201L,10816L,11236L,11881L,12769L,13456L,13689L,14884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135784Inst : IEnumerable<long>
{
public static readonly long[] Value=A135784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135784.Bytes);
public long this[int i]=>Value[i];

public static A135784Inst Instance=new A135784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135785
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,11L,13L,15L,17L,19L,23L,25L,29L,31L,35L,37L,41L,43L,49L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135785Inst : IEnumerable<long>
{
public static readonly long[] Value=A135785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135785.Bytes);
public long this[int i]=>Value[i];

public static A135785Inst Instance=new A135785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135786
{
public static readonly long[] Value={ 16L,625L,4096L,10000L,28561L,83521L,104976L,160000L,390625L,456976L,707281L,1048576L,1336336L,1874161L,2560000L,2825761L,4100625L,6250000L,7311616L,7890481L,11316496L,13845841L,17850625L,21381376L,26873856L,28398241L,29986576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135786Inst : IEnumerable<long>
{
public static readonly long[] Value=A135786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135786.Bytes);
public long this[int i]=>Value[i];

public static A135786Inst Instance=new A135786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135787
{
public static readonly long[] Value={ 32L,3125L,32768L,100000L,371293L,1419857L,1889568L,3200000L,9765625L,11881376L,20511149L,33554432L,45435424L,69343957L,102400000L,115856201L,184528125L,312500000L,380204032L,418195493L,656356768L,844596301L,1160290625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135787Inst : IEnumerable<long>
{
public static readonly long[] Value=A135787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135787.Bytes);
public long this[int i]=>Value[i];

public static A135787Inst Instance=new A135787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135788
{
public static readonly long[] Value={ 64L,15625L,262144L,1000000L,4826809L,24137569L,34012224L,64000000L,244140625L,308915776L,594823321L,1073741824L,1544804416L,2565726409L,4096000000L,4750104241L,8303765625L,15625000000L,19770609664L,22164361129L,38068692544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135788Inst : IEnumerable<long>
{
public static readonly long[] Value=A135788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135788.Bytes);
public long this[int i]=>Value[i];

public static A135788Inst Instance=new A135788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135789
{
public static readonly long[] Value={ 28L,41L,161L,448L,476L,656L,721L,956L,1081L,1241L,1393L,2108L,2268L,2576L,3281L,3321L,3713L,3836L,4633L,4681L,5593L,6076L,7168L,7616L,8188L,9401L,9641L,10496L,11536L,11753L,12121L,12593L,13041L,13916L,15296L,16828L,17296L,17500L,19516L,19856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135789Inst : IEnumerable<long>
{
public static readonly long[] Value=A135789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135789.Bytes);
public long this[int i]=>Value[i];

public static A135789Inst Instance=new A135789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135790
{
public static readonly long[] Value={ 4L,7L,64L,112L,119L,164L,239L,324L,527L,567L,644L,959L,1024L,1519L,1792L,1904L,2047L,2500L,2624L,2884L,3479L,3824L,4207L,4324L,4375L,4879L,4964L,5184L,5572L,6647L,6887L,7327L,8119L,8432L,9072L,9604L,9639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135790Inst : IEnumerable<long>
{
public static readonly long[] Value=A135790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135790.Bytes);
public long this[int i]=>Value[i];

public static A135790Inst Instance=new A135790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135791
{
public static readonly long[] Value={ 404L,1900L,3647L,5646L,12928L,13412L,14050L,27688L,30609L,36413L,45716L,51804L,60800L,74576L,90050L,98172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135791Inst : IEnumerable<long>
{
public static readonly long[] Value=A135791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135791.Bytes);
public long this[int i]=>Value[i];

public static A135791Inst Instance=new A135791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135792
{
public static readonly long[] Value={ 41L,122L,316L,1121L,1312L,1900L,2868L,2876L,3904L,4282L,6121L,9963L,10112L,11516L,17684L,19841L,20122L,23028L,23807L,25525L,29646L,31996L,35872L,41984L,44403L,49001L,59162L,60800L,65900L,71996L,76453L,76788L,80404L,91776L,92032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135792Inst : IEnumerable<long>
{
public static readonly long[] Value=A135792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135792.Bytes);
public long this[int i]=>Value[i];

public static A135792Inst Instance=new A135792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135793
{
public static readonly long[] Value={ 41L,122L,316L,404L,1121L,1312L,1900L,2868L,2876L,3647L,3904L,4282L,5646L,6121L,9963L,10112L,11516L,12928L,13412L,14050L,17684L,19841L,20122L,23028L,23807L,25525L,27688L,29646L,30609L,31996L,35872L,36413L,41984L,44403L,45716L,49001L,51804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135793Inst : IEnumerable<long>
{
public static readonly long[] Value=A135793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135793.Bytes);
public long this[int i]=>Value[i];

public static A135793Inst Instance=new A135793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135794
{
public static readonly long[] Value={ 16L,121L,122L,496L,512L,528L,1441L,1562L,1563L,1684L,3376L,3872L,3888L,3904L,4400L,6841L,8282L,8403L,8404L,8525L,9966L,12496L,15872L,16368L,16384L,16400L,16896L,20272L,21121L,27962L,29403L,29524L,29525L,29646L,31087L,33616L,37928L,46112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135794Inst : IEnumerable<long>
{
public static readonly long[] Value=A135794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135794.Bytes);
public long this[int i]=>Value[i];

public static A135794Inst Instance=new A135794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135795
{
public static readonly long[] Value={ 1768L,1796L,1808L,1836L,1864L,1892L,1904L,1932L,1960L,1988L,2016L,2044L,2072L,2112L,2140L,2168L,2196L,2208L,2236L,2264L,2292L,2304L,2332L,2360L,2388L,2416L,2444L,2472L,2512L,2540L,2568L,2596L,2608L,2636L,2664L,2692L,2704L,2732L,2760L,2788L,2816L,2844L,2872L,2912L,2940L,2968L,2996L,3008L,3036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135795Inst : IEnumerable<long>
{
public static readonly long[] Value=A135795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135795.Bytes);
public long this[int i]=>Value[i];

public static A135795Inst Instance=new A135795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135796
{
public static readonly long[] Value={ 8L,40L,120L,128L,272L,312L,520L,640L,648L,888L,1160L,1200L,1400L,1920L,2040L,2048L,2080L,2952L,2968L,3240L,3280L,4040L,4352L,4872L,4992L,5000L,5368L,6120L,6960L,7008L,7280L,7320L,8320L,8840L,9720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135796Inst : IEnumerable<long>
{
public static readonly long[] Value=A135796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135796.Bytes);
public long this[int i]=>Value[i];

public static A135796Inst Instance=new A135796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135797
{
public static readonly long[] Value={ 8L,41L,128L,136L,313L,353L,648L,656L,776L,1201L,1241L,1513L,2048L,2056L,2176L,2696L,3281L,3321L,3593L,4481L,5000L,5008L,5128L,5648L,7048L,7321L,7361L,7633L,8521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135797Inst : IEnumerable<long>
{
public static readonly long[] Value=A135797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135797.Bytes);
public long this[int i]=>Value[i];

public static A135797Inst Instance=new A135797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135798
{
public static readonly long[] Value={ 0L,0L,4L,6L,7L,1L,7L,1L,6L,3L,5L,2L,1L,7L,9L,1L,0L,3L,8L,6L,6L,4L,9L,1L,6L,8L,2L,4L,3L,6L,0L,6L,7L,5L,6L,1L,3L,1L,5L,3L,0L,7L,7L,2L,9L,8L,1L,2L,2L,2L,2L,8L,8L,0L,2L,5L,7L,5L,4L,2L,1L,2L,5L,1L,3L,4L,8L,4L,9L,0L,8L,9L,0L,8L,4L,6L,9L,8L,0L,7L,7L,3L,0L,3L,4L,9L,8L,8L,9L,5L,7L,4L,2L,7L,7L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135798Inst : IEnumerable<long>
{
public static readonly long[] Value=A135798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135798.Bytes);
public long this[int i]=>Value[i];

public static A135798Inst Instance=new A135798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135799
{
public static readonly long[] Value={ 1L,0L,0L,4L,5L,48L,252L,1832L,14625L,132080L,1323168L,14576076L,175108661L,2278429216L,31920719820L,479088848976L,7669098865441L,130426934203296L,2348478878321248L,44633950190867220L,892899715052136645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135799Inst : IEnumerable<long>
{
public static readonly long[] Value=A135799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135799.Bytes);
public long this[int i]=>Value[i];

public static A135799Inst Instance=new A135799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135848
{
public static readonly long[] Value={ 40L,154L,638L,3194L,19130L,133836L,1070550L,9634750L,96347210L,1059818936L,12717826742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135848Inst : IEnumerable<long>
{
public static readonly long[] Value=A135848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135848.Bytes);
public long this[int i]=>Value[i];

public static A135848Inst Instance=new A135848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135849
{
public static readonly long[] Value={ 1L,5L,39L,297L,2259L,17181L,130671L,993825L,7558587L,57487221L,437222007L,3325314393L,25290849123L,192350849805L,1462934251071L,11126421459153L,84622568920011L,643601286982629L,4894942589100999L,37228736851860105L,283145067047577843L,2153474325825042429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135849Inst : IEnumerable<long>
{
public static readonly long[] Value=A135849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135849.Bytes);
public long this[int i]=>Value[i];

public static A135849Inst Instance=new A135849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135850
{
public static readonly long[] Value={ 42L,78L,110L,114L,147L,186L,222L,225L,258L,310L,366L,402L,406L,410L,438L,474L,506L,507L,525L,582L,602L,610L,618L,654L,710L,735L,762L,834L,906L,942L,975L,978L,994L,1010L,1083L,1086L,1089L,1158L,1194L,1266L,1310L,1338L,1374L,1378L,1425L,1446L,1474L,1510L,1582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135850Inst : IEnumerable<long>
{
public static readonly long[] Value=A135850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135850.Bytes);
public long this[int i]=>Value[i];

public static A135850Inst Instance=new A135850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135851
{
public static readonly long[] Value={ -1L,0L,1L,0L,0L,1L,1L,1L,2L,3L,4L,6L,9L,13L,19L,28L,41L,60L,88L,129L,189L,277L,406L,595L,872L,1278L,1873L,2745L,4023L,5896L,8641L,12664L,18560L,27201L,39865L,58425L,85626L,125491L,183916L,269542L,395033L,578949L,848491L,1243524L,1822473L,2670964L,3914488L,5736961L,8407925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135851Inst : IEnumerable<long>
{
public static readonly long[] Value=A135851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135851.Bytes);
public long this[int i]=>Value[i];

public static A135851Inst Instance=new A135851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135852
{
public static readonly long[] Value={ 1L,3L,2L,8L,4L,3L,20L,6L,9L,4L,48L,8L,18L,16L,5L,112L,10L,30L,40L,25L,6L,256L,12L,45L,80L,75L,36L,7L,576L,14L,63L,140L,175L,126L,49L,8L,1280L,16L,84L,224L,350L,336L,196L,64L,9L,2816L,18L,108L,336L,630L,756L,588L,288L,81L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135852Inst : IEnumerable<long>
{
public static readonly long[] Value=A135852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135852.Bytes);
public long this[int i]=>Value[i];

public static A135852Inst Instance=new A135852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135853
{
public static readonly long[] Value={ 1L,4L,2L,6L,6L,3L,8L,12L,12L,4L,10L,20L,30L,20L,5L,12L,30L,60L,60L,30L,6L,14L,42L,105L,140L,105L,42L,7L,16L,56L,168L,280L,280L,168L,56L,8L,18L,72L,252L,504L,630L,504L,252L,72L,9L,20L,90L,360L,840L,1260L,1260L,840L,360L,90L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135853Inst : IEnumerable<long>
{
public static readonly long[] Value=A135853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135853.Bytes);
public long this[int i]=>Value[i];

public static A135853Inst Instance=new A135853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135854
{
public static readonly long[] Value={ 1L,6L,15L,36L,85L,198L,455L,1032L,2313L,5130L,11275L,24588L,53261L,114702L,245775L,524304L,1114129L,2359314L,4980755L,10485780L,22020117L,46137366L,96469015L,201326616L,419430425L,872415258L,1811939355L,3758096412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135854Inst : IEnumerable<long>
{
public static readonly long[] Value=A135854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135854.Bytes);
public long this[int i]=>Value[i];

public static A135854Inst Instance=new A135854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135855
{
public static readonly long[] Value={ 1L,5L,1L,10L,6L,1L,16L,16L,7L,1L,23L,32L,23L,8L,1L,31L,55L,55L,31L,9L,1L,40L,86L,110L,86L,40L,10L,1L,50L,126L,196L,196L,126L,50L,11L,1L,61L,176L,322L,392L,322L,176L,61L,12L,1L,73L,237L,498L,714L,714L,498L,237L,73L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135855Inst : IEnumerable<long>
{
public static readonly long[] Value=A135855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135855.Bytes);
public long this[int i]=>Value[i];

public static A135855Inst Instance=new A135855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135856
{
public static readonly long[] Value={ 1L,5L,1L,9L,6L,1L,13L,15L,7L,1L,17L,28L,22L,8L,1L,21L,45L,50L,30L,9L,1L,25L,66L,95L,80L,39L,10L,1L,29L,91L,161L,175L,119L,49L,11L,1L,33L,120L,252L,336L,294L,168L,60L,12L,1L,37L,153L,372L,588L,630L,462L,228L,72L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135856Inst : IEnumerable<long>
{
public static readonly long[] Value=A135856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135856.Bytes);
public long this[int i]=>Value[i];

public static A135856Inst Instance=new A135856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135857
{
public static readonly long[] Value={ 1L,4L,1L,7L,5L,1L,10L,12L,6L,1L,13L,22L,18L,7L,1L,16L,35L,40L,25L,8L,1L,19L,51L,75L,65L,33L,9L,1L,22L,70L,126L,140L,98L,42L,10L,1L,25L,92L,196L,266L,238L,140L,52L,11L,1L,28L,117L,288L,462L,504L,378L,192L,63L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135857Inst : IEnumerable<long>
{
public static readonly long[] Value=A135857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135857.Bytes);
public long this[int i]=>Value[i];

public static A135857Inst Instance=new A135857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135858
{
public static readonly long[] Value={ 1L,3L,1L,7L,5L,1L,13L,13L,7L,1L,21L,21L,21L,9L,1L,31L,31L,31L,31L,11L,1L,43L,43L,43L,43L,43L,13L,1L,57L,57L,57L,57L,57L,57L,15L,1L,73L,73L,73L,73L,73L,73L,73L,17L,1L,91L,91L,91L,91L,91L,91L,91L,91L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135858Inst : IEnumerable<long>
{
public static readonly long[] Value=A135858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135858.Bytes);
public long this[int i]=>Value[i];

public static A135858Inst Instance=new A135858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135859
{
public static readonly long[] Value={ 1L,4L,13L,34L,73L,136L,229L,358L,529L,748L,1021L,1354L,1753L,2224L,2773L,3406L,4129L,4948L,5869L,6898L,8041L,9304L,10693L,12214L,13873L,15676L,17629L,19738L,22009L,24448L,27061L,29854L,32833L,36004L,39373L,42946L,46729L,50728L,54949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135859Inst : IEnumerable<long>
{
public static readonly long[] Value=A135859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135859.Bytes);
public long this[int i]=>Value[i];

public static A135859Inst Instance=new A135859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135860
{
public static readonly BigInteger[] Value={ 1L,2L,15L,220L,4845L,142506L,5245786L,231917400L,11969016345L,706252528630L,46897636623981L,3461014728350400L,281014969393251275L,BigInteger.Parse("24894763097057357700"),BigInteger.Parse("2389461906843449885700"),BigInteger.Parse("247012484980695576597296"),BigInteger.Parse("27361230617617949782033713") };
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
public class A135860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135860Inst Instance=new A135860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135861
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,969L,23751L,749398L,28989675L,1329890705L,70625252863L,4263421511271L,288417894029200L,21616536107173175L,1778197364075525550L,BigInteger.Parse("159297460456229992380"),BigInteger.Parse("15438280311293473537331") };
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
public class A135861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135861Inst Instance=new A135861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135862
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,285L,5481L,141778L,4638348L,184138713L,8612835715L,464333035881L,28368973183200L,1938034271677595L,146439782923866810L,12129248258088578100UL,BigInteger.Parse("1092975597259714940696"),BigInteger.Parse("106463932364272178140209"),BigInteger.Parse("11148388021809242372111895"),BigInteger.Parse("1248977393391271550436645787") };
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
public class A135862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135862Inst Instance=new A135862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135863
{
public static readonly long[] Value={ 1L,4L,8L,8L,0L,-8L,0L,16L,0L,-40L,0L,112L,0L,-336L,0L,1056L,0L,-3432L,0L,11440L,0L,-38896L,0L,134368L,0L,-470288L,0L,1664096L,0L,-5943200L,0L,21395520L,0L,-77558760L,0L,282861360L,0L,-1037158320L,0L,3821109600L,0L,-14138105520L,0L,52512963360L,0L,-195730136160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135863Inst : IEnumerable<long>
{
public static readonly long[] Value=A135863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135863.Bytes);
public long this[int i]=>Value[i];

public static A135863Inst Instance=new A135863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135864
{
public static readonly long[] Value={ 1L,9L,27L,0L,-81L,243L,0L,-2916L,10935L,0L,-168399L,682344L,0L,-11711385L,49364964L,0L,-900438201L,3887490915L,0L,-73729998576L,323480165085L,0L,-6303914878248L,27978933759300L,0L,-556251967191492L,2490404893915293L,0L,-50276620111538700L,226626845346291663L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135864Inst : IEnumerable<long>
{
public static readonly long[] Value=A135864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135864.Bytes);
public long this[int i]=>Value[i];

public static A135864Inst Instance=new A135864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135865
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,420L,52822L,26933340L,55104785932L,451307797531080L,14787550509729279590UL,BigInteger.Parse("1938204238967340827449260"),BigInteger.Parse("1016173347424012723201485482596"),BigInteger.Parse("2131067935523127187022102005624003320") };
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
public class A135865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135865Inst Instance=new A135865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135866
{
public static readonly BigInteger[] Value={ 1L,1L,3L,72L,17055L,37191123L,731807102304L,129633035920625844L,BigInteger.Parse("206676152816612330273175"),BigInteger.Parse("2965575655806580962693168234624"),BigInteger.Parse("382974905786208201171725242242120141033") };
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
public class A135866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135866Inst Instance=new A135866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135867
{
public static readonly BigInteger[] Value={ 1L,1L,4L,36L,640L,21888L,1451008L,188941312L,48768745472L,25069815595008L,25722272102744064L,BigInteger.Parse("52730972085034156032"),BigInteger.Parse("216091838647321476726784"),BigInteger.Parse("1770657164881170759078117376"),BigInteger.Parse("29013990909330956353981535748096") };
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
public class A135867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135867Inst Instance=new A135867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135868
{
public static readonly BigInteger[] Value={ 1L,2L,9L,80L,1368L,45344L,2952208L,381005824L,97928967168L,50238812700672L,51495089926791168L,BigInteger.Parse("105513593089512439808"),BigInteger.Parse("432289346894817079853056"),BigInteger.Parse("3541746937174189008054386688"),BigInteger.Parse("58031524865557213409213540204544") };
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
public class A135868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135868Inst Instance=new A135868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135869
{
public static readonly BigInteger[] Value={ 1L,1L,6L,117L,6642L,1097874L,537135948L,784812995973L,3435153688724346L,BigInteger.Parse("45086429284345043334"),BigInteger.Parse("1775007791598340247784372"),BigInteger.Parse("209630197234751724563143145346"),BigInteger.Parse("74271350069687203431923556331222068") };
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
public class A135869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135869Inst Instance=new A135869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135870
{
public static readonly BigInteger[] Value={ 1L,2L,13L,246L,13554L,2210436L,1076561037L,1570714992558L,6871883750090694L,BigInteger.Parse("90179738434097457084"),BigInteger.Parse("3550105797469080332658354"),BigInteger.Parse("419263945026939228053105930844"),BigInteger.Parse("148543119421079567735277052592081220") };
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
public class A135870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A135870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A135870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A135870Inst Instance=new A135870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135871
{
public static readonly long[] Value={ 1L,0L,3L,-1L,0L,9L,0L,-6L,0L,27L,1L,0L,-27L,0L,81L,0L,9L,0L,-108L,0L,243L,-1L,0L,54L,0L,-405L,0L,729L,0L,-12L,0L,270L,0L,-1458L,0L,2187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135871Inst : IEnumerable<long>
{
public static readonly long[] Value=A135871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135871.Bytes);
public long this[int i]=>Value[i];

public static A135871Inst Instance=new A135871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135872
{
public static readonly long[] Value={ 1L,3L,8L,15L,6L,35L,24L,15L,40L,21L,24L,35L,24L,15L,56L,105L,24L,35L,24L,21L,40L,105L,24L,35L,144L,105L,40L,135L,120L,77L,120L,105L,40L,105L,144L,385L,120L,105L,40L,189L,120L,55L,120L,105L,56L,105L,120L,385L,120L,189L,280L,105L,120L,385L,144L,135L,280L,105L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135872Inst : IEnumerable<long>
{
public static readonly long[] Value=A135872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135872.Bytes);
public long this[int i]=>Value[i];

public static A135872Inst Instance=new A135872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135873
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,3L,8L,3L,6L,5L,6L,3L,8L,15L,6L,5L,6L,3L,8L,15L,6L,5L,24L,15L,8L,15L,24L,7L,24L,15L,8L,15L,24L,35L,24L,15L,8L,21L,24L,5L,24L,15L,8L,15L,24L,35L,24L,21L,40L,15L,24L,35L,24L,15L,40L,15L,24L,7L,24L,15L,40L,15L,24L,35L,24L,15L,40L,27L,24L,35L,24L,15L,56L,15L,24L,35L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135873Inst : IEnumerable<long>
{
public static readonly long[] Value=A135873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135873.Bytes);
public long this[int i]=>Value[i];

public static A135873Inst Instance=new A135873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135874
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,7L,8L,27L,10L,11L,24L,13L,14L,15L,64L,17L,36L,19L,40L,21L,22L,23L,24L,125L,26L,27L,56L,29L,30L,31L,64L,33L,34L,35L,144L,37L,38L,39L,40L,41L,252L,43L,88L,135L,46L,47L,144L,343L,100L,51L,104L,53L,324L,55L,56L,57L,58L,59L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135874Inst : IEnumerable<long>
{
public static readonly long[] Value=A135874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135874.Bytes);
public long this[int i]=>Value[i];

public static A135874Inst Instance=new A135874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135875
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,8L,3L,10L,11L,6L,13L,14L,15L,8L,17L,6L,19L,8L,21L,22L,23L,24L,5L,26L,27L,8L,29L,30L,31L,8L,33L,34L,35L,24L,37L,38L,39L,40L,41L,36L,43L,8L,15L,46L,47L,24L,7L,10L,51L,8L,53L,36L,55L,56L,57L,58L,59L,24L,61L,62L,21L,64L,65L,36L,67L,8L,69L,70L,71L,24L,73L,74L,15L,8L,77L,36L,79L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135875Inst : IEnumerable<long>
{
public static readonly long[] Value=A135875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135875.Bytes);
public long this[int i]=>Value[i];

public static A135875Inst Instance=new A135875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135876
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,15L,8L,3L,1L,105L,48L,15L,4L,1L,945L,384L,105L,23L,5L,1L,10395L,3840L,945L,176L,33L,6L,1L,135135L,46080L,10395L,1689L,279L,44L,7L,1L,2027025L,645120L,135135L,19524L,2895L,400L,57L,8L,1L,34459425L,10321920L,2027025L,264207L,35685L,4384L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135876Inst : IEnumerable<long>
{
public static readonly long[] Value=A135876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135876.Bytes);
public long this[int i]=>Value[i];

public static A135876Inst Instance=new A135876Inst();

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