using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275868
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275868Inst : IEnumerable<long>
{
public static readonly long[] Value=A275868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275868.Bytes);
public long this[int i]=>Value[i];

public static A275868Inst Instance=new A275868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275869
{
public static readonly BigInteger[] Value={ 2L,2L,11L,51L,922L,25618L,1597350L,169413040L,33716225195L,11838480390673L,7588965091313449L,8705702554970941096L,BigInteger.Parse("18079208010076976255573"),BigInteger.Parse("67519585404524909086260614"),BigInteger.Parse("455193583190737164106702088892"),BigInteger.Parse("5527752160260327852724215089473548") };
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
public class A275869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275869Inst Instance=new A275869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275870
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,7L,2L,10L,5L,9L,2L,34L,2L,11L,10L,36L,2L,64L,2L,60L,12L,15L,2L,320L,7L,17L,23L,94L,2L,297L,2L,202L,16L,21L,14L,1488L,2L,23L,18L,776L,2L,610L,2L,186L,148L,27L,2L,6978L,9L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275870Inst : IEnumerable<long>
{
public static readonly long[] Value=A275870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275870.Bytes);
public long this[int i]=>Value[i];

public static A275870Inst Instance=new A275870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275871
{
public static readonly long[] Value={ 1L,1L,4L,15L,61L,272L,1317L,6865L,38278L,227093L,1426921L,9457918L,65898275L,481177881L,3672102116L,29218285875L,241873478425L,2079079678176L,18524191138689L,170803860905237L,1627465240969382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275871Inst : IEnumerable<long>
{
public static readonly long[] Value=A275871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275871.Bytes);
public long this[int i]=>Value[i];

public static A275871Inst Instance=new A275871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275872
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,6L,18L,54L,173L,605L,2274L,9020L,37486L,163128L,743101L,3535765L,17518018L,90126158L,480514430L,2650912738L,15112253425L,88903779401L,539003066674L,3363608949132L,21581457167994L,142227480847092L,961868098767105L,6669657795455817L,47380035801732034L,344555811578909254L,2563218995058696890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275872Inst : IEnumerable<long>
{
public static readonly long[] Value=A275872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275872.Bytes);
public long this[int i]=>Value[i];

public static A275872Inst Instance=new A275872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275873
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,14L,34L,81L,193L,461L,1101L,2631L,6288L,15029L,35921L,85856L,205208L,490477L,1172311L,2801993L,6697170L,16007210L,38259559L,91445908L,218569015L,522411722L,1248639967L,2984431055L,7133224115L,17049442704L,40750646810L,97399970443L,232800089935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275873Inst : IEnumerable<long>
{
public static readonly long[] Value=A275873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275873.Bytes);
public long this[int i]=>Value[i];

public static A275873Inst Instance=new A275873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275874
{
public static readonly long[] Value={ 0L,8L,21L,40L,66L,100L,143L,196L,260L,336L,425L,528L,646L,780L,931L,1100L,1288L,1496L,1725L,1976L,2250L,2548L,2871L,3220L,3596L,4000L,4433L,4896L,5390L,5916L,6475L,7068L,7696L,8360L,9061L,9800L,10578L,11396L,12255L,13156L,14100L,15088L,16121L,17200L,18326L,19500L,20723L,21996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275874Inst : IEnumerable<long>
{
public static readonly long[] Value=A275874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275874.Bytes);
public long this[int i]=>Value[i];

public static A275874Inst Instance=new A275874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275875
{
public static readonly long[] Value={ 2L,1L,3L,1L,2L,3L,1L,1L,2L,4L,1L,1L,2L,2L,4L,1L,1L,1L,2L,3L,4L,1L,1L,1L,2L,2L,3L,4L,1L,1L,1L,1L,2L,2L,3L,5L,1L,1L,1L,1L,2L,2L,2L,3L,5L,1L,1L,1L,1L,1L,2L,2L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275875Inst : IEnumerable<long>
{
public static readonly long[] Value=A275875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275875.Bytes);
public long this[int i]=>Value[i];

public static A275875Inst Instance=new A275875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275924
{
public static readonly long[] Value={ 1L,1L,1L,6L,112L,15502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275924Inst : IEnumerable<long>
{
public static readonly long[] Value=A275924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275924.Bytes);
public long this[int i]=>Value[i];

public static A275924Inst Instance=new A275924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275925
{
public static readonly long[] Value={ 3L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,5L,6L,3L,6L,5L,6L,6L,5L,6L,3L,6L,5L,6L,5L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275925Inst : IEnumerable<long>
{
public static readonly long[] Value=A275925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275925.Bytes);
public long this[int i]=>Value[i];

public static A275925Inst Instance=new A275925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275926
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275926Inst : IEnumerable<long>
{
public static readonly long[] Value=A275926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275926.Bytes);
public long this[int i]=>Value[i];

public static A275926Inst Instance=new A275926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275927
{
public static readonly long[] Value={ 4L,2L,5L,1L,5L,1L,10L,3L,4L,2L,4L,2L,5L,1L,6L,1L,5L,1L,10L,2L,5L,1L,5L,2L,5L,1L,5L,1L,10L,3L,4L,2L,4L,2L,5L,1L,12L,1L,10L,2L,5L,1L,5L,2L,5L,1L,3L,3L,4L,2L,4L,2L,5L,2L,5L,1L,5L,1L,10L,3L,4L,2L,4L,2L,5L,1L,5L,1L,6L,1L,3L,3L,4L,2L,4L,2L,5L,2L,5L,1L,5L,1L,10L,2L,5L,2L,4L,2L,5L,1L,12L,1L,10L,2L,5L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275927Inst : IEnumerable<long>
{
public static readonly long[] Value=A275927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275927.Bytes);
public long this[int i]=>Value[i];

public static A275927Inst Instance=new A275927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275928
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,8L,8L,4L,12L,18L,8L,8L,4L,12L,32L,8L,4L,24L,12L,16L,128L,64L,32L,16L,96L,144L,32L,64L,12L,256L,16L,16L,16L,384L,128L,48L,6L,48L,64L,128L,8L,64L,32L,64L,384L,144L,16L,128L,12L,144L,768L,64L,32L,2048L,128L,256L,256L,1536L,32L,64L,128L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275928Inst : IEnumerable<long>
{
public static readonly long[] Value=A275928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275928.Bytes);
public long this[int i]=>Value[i];

public static A275928Inst Instance=new A275928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275929
{
public static readonly BigInteger[] Value={ 4L,5L,8L,17L,54L,247L,1448L,10089L,80650L,725771L,7257612L,79833613L,958003214L,12454041615L,174356582416L,2615348736017L,41845579776018L,711374856192019L,12804747411456020L,243290200817664021L,4865804016353280022L,BigInteger.Parse("102181884343418880023"),BigInteger.Parse("2248001455555215360024") };
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
public class A275929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275929Inst Instance=new A275929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275930
{
public static readonly BigInteger[] Value={ 5L,256L,3159L,65625L,1114112L,20421115L,363484989L,6542701056L,117265259375L,2105190412273L,37769592176640L,677792498259891L,12162186734914229L,218243684178400000L,3916209628945328967L,BigInteger.Parse("70273629018014076105"),BigInteger.Parse("1261008431526362415104"),BigInteger.Parse("22627882807257322061611"),BigInteger.Parse("406040850098667041878125") };
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
public class A275930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275930Inst Instance=new A275930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275931
{
public static readonly BigInteger[] Value={ 2L,40L,1625L,74698L,3498056L,164257777L,7716095570L,362488657000L,17029226266313L,800010977816986L,37583485579350152L,1765623803357209825L,BigInteger.Parse("82946735218100281250"),BigInteger.Parse("3896730931076485826728"),BigInteger.Parse("183063407022834751530041"),BigInteger.Parse("8600083399124733831953002"),BigInteger.Parse("404020856351720236303380680") };
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
public class A275931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275931.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275931Inst Instance=new A275931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275932
{
public static readonly BigInteger[] Value={ 8L,567L,28160L,1333584L,62723375L,2947166208L,138457523672L,6504579992295L,305576963500544L,14355613810692000L,674408279720748383L,BigInteger.Parse("31682833585030397952"),BigInteger.Parse("1488418770572887642280"),BigInteger.Parse("69923999385781980681879"),BigInteger.Parse("3284939552377913067968000"),BigInteger.Parse("154322234962490820966855408") };
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
public class A275932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275932.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275932Inst Instance=new A275932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275933
{
public static readonly long[] Value={ 1L,0L,6L,0L,5L,2L,3L,8L,2L,9L,1L,0L,2L,6L,6L,3L,6L,1L,2L,0L,7L,9L,7L,2L,6L,9L,6L,3L,7L,5L,6L,3L,3L,5L,5L,7L,7L,4L,3L,2L,2L,9L,4L,2L,8L,3L,3L,5L,9L,4L,7L,4L,4L,6L,1L,0L,8L,1L,7L,8L,8L,3L,9L,9L,3L,8L,7L,4L,9L,4L,7L,0L,1L,4L,1L,0L,1L,8L,4L,7L,0L,1L,0L,1L,8L,5L,6L,2L,2L,0L,8L,7L,4L,3L,7L,0L,3L,9L,2L,9L,3L,3L,5L,0L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275933Inst : IEnumerable<long>
{
public static readonly long[] Value=A275933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275933.Bytes);
public long this[int i]=>Value[i];

public static A275933Inst Instance=new A275933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275934
{
public static readonly ulong[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,4L,10L,20L,36L,68L,166L,540L,1961L,7012L,23878L,78004L,250311L,815196L,2787806L,10232556L,40266382L,166608080L,708407020L,3046352440L,13161936881L,57188405288L,251328286460L,1125890398160L,5177570523461L,24539362719532L,119861818560962L,601299401594540L,3082695751138656L,16075855888601716L,85005009812011810L,455172001509369028L,2468935975119176601L,13584735197391443020UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275934Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A275934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275934.Bytes);
public ulong this[int i]=>Value[i];

public static A275934Inst Instance=new A275934Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275935
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,5L,15L,35L,70L,127L,225L,455L,1260L,4555L,17760L,67265L,241015L,818705L,2666400L,8464210L,26791045L,87104270L,300213875L,1119214050L,4500888827L,19104042345L,83376236115L,366831787085L,1609394914730L,7015234913278L,30426949154855L,131992116224295L,577090099245575L,2565792536742865L,11698401074992087L,55012217948708040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275935Inst : IEnumerable<long>
{
public static readonly long[] Value=A275935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275935.Bytes);
public long this[int i]=>Value[i];

public static A275935Inst Instance=new A275935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275936
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,6L,21L,56L,126L,252L,463L,810L,1464L,3262L,10269L,40404L,165635L,653580L,2439069L,8626470L,29121393L,94647798L,299273206L,933818700L,2935248294L,9557815564L,33225405312L,125646127446L,514785555355L,2232901148760L,9976014439674L,44944467146100L,201608952292578L,895062795448170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275936Inst : IEnumerable<long>
{
public static readonly long[] Value=A275936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275936.Bytes);
public long this[int i]=>Value[i];

public static A275936Inst Instance=new A275936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275937
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,1L,4L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275937Inst : IEnumerable<long>
{
public static readonly long[] Value=A275937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275937.Bytes);
public long this[int i]=>Value[i];

public static A275937Inst Instance=new A275937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275938
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,81L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275938Inst : IEnumerable<long>
{
public static readonly long[] Value=A275938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275938.Bytes);
public long this[int i]=>Value[i];

public static A275938Inst Instance=new A275938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275939
{
public static readonly long[] Value={ 3L,608981813029L,26861L,11L,608981813017L,71L,192252423729713L,37L,11L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275939Inst : IEnumerable<long>
{
public static readonly long[] Value=A275939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275939.Bytes);
public long this[int i]=>Value[i];

public static A275939Inst Instance=new A275939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277028
{
public static readonly long[] Value={ 0L,1L,3L,7L,31L,255L,32767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277028Inst : IEnumerable<long>
{
public static readonly long[] Value=A277028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277028.Bytes);
public long this[int i]=>Value[i];

public static A277028Inst Instance=new A277028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277029
{
public static readonly long[] Value={ 0L,1L,4L,8L,16L,25L,42L,61L,90L,130L,178L,242L,332L,436L,566L,747L,952L,1210L,1540L,1926L,2400L,2994L,3674L,4506L,5526L,6708L,8108L,9808L,11768L,14080L,16850L,20022L,23738L,28128L,33152L,39015L,45854L,53662L,62696L,73166L,85118L,98826L,114636L,132586L,153102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277029Inst : IEnumerable<long>
{
public static readonly long[] Value=A277029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277029.Bytes);
public long this[int i]=>Value[i];

public static A277029Inst Instance=new A277029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277030
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,2L,12L,6L,4L,4L,16L,6L,18L,4L,6L,10L,22L,4L,20L,12L,18L,6L,28L,4L,30L,8L,10L,16L,12L,6L,36L,18L,12L,4L,40L,6L,42L,10L,12L,22L,46L,4L,42L,20L,16L,12L,52L,18L,20L,6L,18L,28L,58L,4L,60L,30L,6L,16L,12L,10L,66L,16L,22L,12L,70L,6L,72L,36L,20L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277030Inst : IEnumerable<long>
{
public static readonly long[] Value=A277030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277030.Bytes);
public long this[int i]=>Value[i];

public static A277030Inst Instance=new A277030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277031
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,5L,0L,1L,0L,20L,3L,0L,1L,0L,109L,10L,0L,0L,1L,0L,668L,44L,7L,0L,0L,1L,0L,4801L,210L,28L,0L,0L,0L,1L,0L,38894L,1320L,90L,15L,0L,0L,0L,1L,0L,353811L,8439L,554L,75L,0L,0L,0L,0L,1L,0L,3561512L,63404L,3542L,310L,31L,0L,0L,0L,0L,1L,0L,39374609L,517418L,23298L,1276L,198L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277031Inst : IEnumerable<long>
{
public static readonly long[] Value=A277031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277031.Bytes);
public long this[int i]=>Value[i];

public static A277031Inst Instance=new A277031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277032
{
public static readonly BigInteger[] Value={ 1L,1L,5L,20L,109L,668L,4801L,38894L,353811L,3561512L,39374609L,474132730L,6179650125L,86676293916L,1301952953989L,20852719565694L,354771488612075L,6389625786835184L,121456993304945749L,2429966790591643402L,BigInteger.Parse("51042656559451380013"),BigInteger.Parse("1123165278137918510772") };
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
public class A277032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277032Inst Instance=new A277032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277033
{
public static readonly BigInteger[] Value={ 1L,2L,4L,18L,76L,420L,2248L,14410L,89676L,642764L,4487896L,35282228L,271094936L,2310824808L,19309255952L,177093587874L,1596354765308L,15664040851996L,151403517122328L,1582290415072396L,16319413287176584L,180949924453071544L,1983128441367699632L,BigInteger.Parse("23249895784026465044"),BigInteger.Parse("269763155110100504568"),BigInteger.Parse("3333619355332522429656") };
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
public class A277033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277033Inst Instance=new A277033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277034
{
public static readonly BigInteger[] Value={ 1L,2L,4L,50L,268L,3780L,28872L,438410L,4087180L,65365260L,697738072L,11624944660L,137432369816L,2371412517480L,30441246407440L,542177876315970L,7460629909188796L,136882304192481020L,2001263659780301080L,BigInteger.Parse("37777108180867675020"),BigInteger.Parse("583057080531893501960"),BigInteger.Parse("11314432259935102732856"),BigInteger.Parse("183452721005994056356272") };
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
public class A277034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277034Inst Instance=new A277034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277035
{
public static readonly BigInteger[] Value={ 1L,2L,14L,320L,21036L,4248736L,2753284608L,5889659239296L,42571528094271584L,BigInteger.Parse("1060699597956427433984"),BigInteger.Parse("92622122614950875482410496"),BigInteger.Parse("28732153964162783015337150191616"),BigInteger.Parse("32013867511269166370870196132112760832"),BigInteger.Parse("129287051721999031624124705228031781712207872"),BigInteger.Parse("1906782843976072893849368486957954962408685271556096") };
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
public class A277035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277035Inst Instance=new A277035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277036
{
public static readonly BigInteger[] Value={ 1L,2L,16L,640L,102656L,63897600L,154597064704L,1463095704682496L,BigInteger.Parse("54479037904873062400"),BigInteger.Parse("8016231806154061580861440"),BigInteger.Parse("4675328432258454936484990418944"),BigInteger.Parse("10830326782491721013522399339743281152"),BigInteger.Parse("99782643106894570834269165391541758337220608"),BigInteger.Parse("3659836060539105945122413831815090863199825623515136"),BigInteger.Parse("534751190090057629985959636400471838795213939324687126364160") };
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
public class A277036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277036Inst Instance=new A277036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277037
{
public static readonly BigInteger[] Value={ 1L,2L,18L,484L,54630L,26638924L,53843811956L,442942117297000L,14725418961500037126UL,BigInteger.Parse("1971239927985067569365772"),BigInteger.Parse("1060292226589575099894174194524"),BigInteger.Parse("2288290973515256950275126683431946552"),BigInteger.Parse("19795837218795604674370624304477542380054748"),BigInteger.Parse("685985356865646724678258830150265065104998427771576"),BigInteger.Parse("95174256167264272421248219248338459257647770713814222870312") };
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
public class A277037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277037Inst Instance=new A277037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277038
{
public static readonly BigInteger[] Value={ 1L,1L,-4L,56L,-1452L,58368L,-3339220L,257978168L,-25928865116L,3293850854208L,-516648260338724L,98140914400430840L,BigInteger.Parse("-22212891796114092556"),BigInteger.Parse("5908226316995291448256"),BigInteger.Parse("-1824964039545848666778100"),BigInteger.Parse("647939176919565713349368184"),BigInteger.Parse("-262058639306505158896089030332"),BigInteger.Parse("119788326167873858048176581362560"),BigInteger.Parse("-61452317226714509108846922021817924") };
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
public class A277038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277038.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277038Inst Instance=new A277038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277039
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,14L,79L,758L,16865L,191965L,4642399L,86248902L,3501670714L,115114996057L,8565607353234L,490214100103707L,84938404987634353L,3664613039216888961L,BigInteger.Parse("479579554530728437490"),BigInteger.Parse("35532408630828993454198"),BigInteger.Parse("8604356703941292707727453"),BigInteger.Parse("611094051996156994790949416"),BigInteger.Parse("149400677551660775985467062785"),BigInteger.Parse("19315916074995756159830225305613") };
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
public class A277039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277039.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277039Inst Instance=new A277039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277040
{
public static readonly long[] Value={ 1L,2L,3L,8L,25L,66L,357L,1968L,8073L,135260L,1271941L,7376172L,113614228L,1258281038L,8941092630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277040Inst : IEnumerable<long>
{
public static readonly long[] Value=A277040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277040.Bytes);
public long this[int i]=>Value[i];

public static A277040Inst Instance=new A277040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277041
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,11L,51L,246L,897L,13526L,115631L,614681L,8739556L,89877217L,596072842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277041Inst : IEnumerable<long>
{
public static readonly long[] Value=A277041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277041.Bytes);
public long this[int i]=>Value[i];

public static A277041Inst Instance=new A277041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277042
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,27L,0L,0L,10666L,0L,0L,6174792L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277042Inst : IEnumerable<long>
{
public static readonly long[] Value=A277042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277042.Bytes);
public long this[int i]=>Value[i];

public static A277042Inst Instance=new A277042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277043
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,30L,0L,0L,10921L,0L,0L,6308995L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277043Inst : IEnumerable<long>
{
public static readonly long[] Value=A277043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277043.Bytes);
public long this[int i]=>Value[i];

public static A277043Inst Instance=new A277043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277076
{
public static readonly long[] Value={ 1L,232L,260L,-5760L,6890L,7744L,33176L,-115200L,14035L,60320L,1508L,449280L,-380770L,-599040L,7640L,599040L,-755943L,1598480L,1843200L,-2620800L,-988858L,-2995712L,3857360L,-1497600L,-2004730L,7696832L,2699684L,1670400L,-7188480L,-11980800L,1791400L,10736640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277076Inst : IEnumerable<long>
{
public static readonly long[] Value=A277076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277076.Bytes);
public long this[int i]=>Value[i];

public static A277076Inst Instance=new A277076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277077
{
public static readonly long[] Value={ 7L,6L,8L,1L,6L,9L,1L,5L,6L,7L,3L,6L,7L,9L,5L,9L,7L,7L,4L,6L,2L,0L,8L,6L,2L,3L,9L,5L,5L,8L,6L,5L,6L,4L,1L,8L,1L,3L,2L,0L,8L,7L,3L,1L,2L,1L,8L,2L,7L,3L,7L,1L,8L,5L,6L,9L,1L,8L,6L,7L,1L,5L,0L,6L,2L,1L,1L,5L,7L,6L,5L,9L,6L,4L,2L,0L,4L,8L,9L,1L,2L,2L,2L,4L,4L,8L,8L,1L,9L,5L,1L,7L,8L,0L,7L,8L,8L,3L,8L,9L,0L,1L,9L,2L,9L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277077Inst : IEnumerable<long>
{
public static readonly long[] Value=A277077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277077.Bytes);
public long this[int i]=>Value[i];

public static A277077Inst Instance=new A277077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277078
{
public static readonly long[] Value={ 2L,1L,0L,1L,-2L,2L,1L,-3L,3L,0L,1L,-4L,6L,-4L,2L,1L,-5L,10L,-10L,5L,0L,1L,-6L,15L,-20L,15L,-6L,2L,1L,-7L,21L,-35L,35L,-21L,7L,0L,1L,-8L,28L,-56L,70L,-56L,28L,-8L,2L,1L,-9L,36L,-84L,126L,-126L,84L,-36L,9L,0L,1L,-10L,45L,-120L,210L,-252L,210L,-120L,45L,-10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277078Inst : IEnumerable<long>
{
public static readonly long[] Value=A277078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277078.Bytes);
public long this[int i]=>Value[i];

public static A277078Inst Instance=new A277078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277079
{
public static readonly long[] Value={ 1L,35L,7L,61L,5L,6L,3L,7L,5L,10L,11L,15L,6L,36L,7L,16L,17L,33L,16L,44L,6L,48L,36L,3L,5L,9L,31L,8L,32L,69L,8L,5L,8L,5L,2L,2L,9L,8L,6L,6L,5L,8L,7L,6L,6L,9L,8L,6L,2L,7L,2L,8L,6L,5L,5L,5L,3L,8L,9L,6L,4L,3L,6L,6L,6L,25L,5L,6L,3L,6L,3L,3L,2L,6L,5L,6L,3L,7L,8L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277079Inst : IEnumerable<long>
{
public static readonly long[] Value=A277079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277079.Bytes);
public long this[int i]=>Value[i];

public static A277079Inst Instance=new A277079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277080
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,0L,3L,0L,3L,0L,1L,1L,0L,12L,0L,66L,0L,220L,0L,495L,0L,792L,0L,924L,0L,792L,0L,495L,0L,220L,0L,66L,0L,12L,0L,1L,1L,0L,60L,0L,1770L,0L,34220L,0L,487635L,0L,5461512L,0L,50063860L,0L,386206920L,0L,2558620845L,0L,14783142660L,0L,75394027566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277080Inst : IEnumerable<long>
{
public static readonly long[] Value=A277080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277080.Bytes);
public long this[int i]=>Value[i];

public static A277080Inst Instance=new A277080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277081
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,4L,7L,8L,7L,4L,1L,1L,10L,52L,190L,546L,1302L,2660L,4754L,7535L,10692L,13672L,15820L,16604L,15820L,13672L,10692L,7535L,4754L,2660L,1302L,546L,190L,52L,10L,1L,1L,26L,372L,3822L,31306L,216086L,1300420L,6981650L,33992275L,151945820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277081Inst : IEnumerable<long>
{
public static readonly long[] Value=A277081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277081.Bytes);
public long this[int i]=>Value[i];

public static A277081Inst Instance=new A277081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277082
{
public static readonly long[] Value={ 0L,1L,12L,15L,37L,42L,75L,82L,126L,135L,190L,201L,267L,280L,357L,372L,460L,477L,576L,595L,705L,726L,847L,870L,1002L,1027L,1170L,1197L,1351L,1380L,1545L,1576L,1752L,1785L,1972L,2007L,2205L,2242L,2451L,2490L,2710L,2751L,2982L,3025L,3267L,3312L,3565L,3612L,3876L,3925L,4200L,4251L,4537L,4590L,4887L,4942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277082Inst : IEnumerable<long>
{
public static readonly long[] Value=A277082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277082.Bytes);
public long this[int i]=>Value[i];

public static A277082Inst Instance=new A277082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277083
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,4L,3L,2L,1L,1L,8L,36L,120L,322L,728L,1428L,2472L,3823L,5328L,6728L,7728L,8092L,7728L,6728L,5328L,3823L,2472L,1428L,728L,322L,120L,36L,8L,1L,1L,8L,84L,504L,3178L,15512L,74788L,311144L,1252819L,4577328L,16087512L,52691408L,165911284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277083Inst : IEnumerable<long>
{
public static readonly long[] Value=A277083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277083.Bytes);
public long this[int i]=>Value[i];

public static A277083Inst Instance=new A277083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277084
{
public static readonly long[] Value={ 4L,14L,49L,172L,604L,2122L,7456L,26198L,92052L,323444L,1136489L,3993295L,14031289L,49301911L,173232725L,608689936L,2138761243L,7514991434L,26405516950L,92781386582L,326007088306L,1145495077635L,4024940008834L,14142480741305L,49692606865991L,174605518105877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277084Inst : IEnumerable<long>
{
public static readonly long[] Value=A277084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277084.Bytes);
public long this[int i]=>Value[i];

public static A277084Inst Instance=new A277084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277085
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,2L,4L,6L,10L,14L,20L,26L,31L,36L,40L,44L,44L,44L,40L,36L,31L,26L,20L,14L,10L,6L,4L,2L,1L,1L,2L,4L,6L,34L,62L,116L,170L,547L,924L,1624L,2324L,5572L,8820L,14616L,20412L,40509L,60606L,95004L,129402L,224406L,319410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277085Inst : IEnumerable<long>
{
public static readonly long[] Value=A277085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277085.Bytes);
public long this[int i]=>Value[i];

public static A277085Inst Instance=new A277085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277086
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,5L,5L,5L,2L,1L,1L,7L,56L,317L,1524L,5733L,17728L,44767L,94427L,166786L,249624L,316950L,343424L,316950L,249624L,166786L,94427L,44767L,17728L,5733L,1524L,317L,56L,7L,1L,1L,23L,1012L,36125L,1035496L,23878229L,456936220L,7437730463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277086Inst : IEnumerable<long>
{
public static readonly long[] Value=A277086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277086.Bytes);
public long this[int i]=>Value[i];

public static A277086Inst Instance=new A277086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277087
{
public static readonly long[] Value={ 1L,2L,10L,14L,10L,22L,910L,2L,170L,266L,110L,46L,910L,2L,290L,4774L,170L,2L,639730L,2L,4510L,602L,230L,94L,15470L,22L,530L,266L,290L,118L,18928910L,2L,170L,21574L,10L,1562L,46700290L,2L,10L,1106L,76670L,166L,1134770L,2L,20470L,90706L,470L,2L,1500590L,2L,11110L,1442L,530L,214L,69730570L,506L,557090L,14L,590L,2L,776085310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277087Inst : IEnumerable<long>
{
public static readonly long[] Value=A277087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277087.Bytes);
public long this[int i]=>Value[i];

public static A277087Inst Instance=new A277087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277088
{
public static readonly long[] Value={ 5L,12L,29L,71L,174L,427L,1048L,2573L,6318L,15514L,38095L,93544L,229702L,564045L,1385042L,3401044L,8351444L,20507414L,50357044L,123654396L,303639937L,745603993L,1830870208L,4495799044L,11039673351L,27108504296L,66566372193L,163457262657L,401377990645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277088Inst : IEnumerable<long>
{
public static readonly long[] Value=A277088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277088.Bytes);
public long this[int i]=>Value[i];

public static A277088Inst Instance=new A277088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277089
{
public static readonly long[] Value={ 6L,15L,38L,97L,248L,635L,1626L,4164L,10664L,27311L,69945L,179134L,458775L,1174956L,3009148L,7706648L,19737289L,50548641L,129458768L,331553377L,849132458L,2174690356L,5569541124L,14264002343L,36531153701L,93558957622L,239611336203L,613662164440L,1571633704952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277089Inst : IEnumerable<long>
{
public static readonly long[] Value=A277089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277089.Bytes);
public long this[int i]=>Value[i];

public static A277089Inst Instance=new A277089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277090
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,4L,4L,4L,4L,4L,4L,4L,5L,6L,7L,7L,7L,7L,7L,7L,8L,10L,11L,12L,12L,12L,12L,12L,13L,15L,17L,18L,19L,19L,19L,19L,20L,23L,26L,28L,29L,30L,30L,30L,31L,34L,38L,41L,43L,44L,45L,45L,46L,50L,55L,60L,63L,65L,66L,67L,68L,72L,79L,85L,90L,93L,95L,96L,98L,103L,111L,120L,127L,132L,135L,137L,139L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277090Inst : IEnumerable<long>
{
public static readonly long[] Value=A277090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277090.Bytes);
public long this[int i]=>Value[i];

public static A277090Inst Instance=new A277090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277091
{
public static readonly long[] Value={ 0L,2L,4L,36L,128L,760L,3312L,17264L,80896L,403488L,1939520L,9527872L,46209024L,225808256L,1098542848L,5358401280L,26096402432L,127210422784L,619770479616L,3020486878208L,14717760471040L,71722337236992L,349493321068544L,1703099363454976L,8299105221869568L,40441601532108800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277091Inst : IEnumerable<long>
{
public static readonly long[] Value=A277091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277091.Bytes);
public long this[int i]=>Value[i];

public static A277091Inst Instance=new A277091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277124
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,11L,13L,14L,20L,21L,26L,29L,30L,33L,35L,36L,39L,41L,43L,49L,54L,55L,62L,68L,69L,75L,76L,79L,81L,89L,90L,105L,110L,113L,117L,119L,126L,134L,141L,146L,154L,162L,174L,176L,178L,179L,186L,191L,195L,207L,209L,215L,216L,222L,225L,227L,230L,231L,234L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277124Inst : IEnumerable<long>
{
public static readonly long[] Value=A277124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277124.Bytes);
public long this[int i]=>Value[i];

public static A277124Inst Instance=new A277124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277125
{
public static readonly long[] Value={ -13L,-5L,1L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277125Inst : IEnumerable<long>
{
public static readonly long[] Value=A277125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277125.Bytes);
public long this[int i]=>Value[i];

public static A277125Inst Instance=new A277125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277126
{
public static readonly long[] Value={ 1L,2L,295L,883438L,252027511L,7469046275L,26782373099L,53191768475L,55246802458L,819613658855L,893727887879978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277126Inst : IEnumerable<long>
{
public static readonly long[] Value=A277126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277126.Bytes);
public long this[int i]=>Value[i];

public static A277126Inst Instance=new A277126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277127
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,1L,6L,3L,6L,1L,10L,1L,8L,11L,12L,1L,12L,1L,16L,15L,12L,1L,22L,5L,14L,9L,22L,1L,26L,1L,24L,23L,18L,23L,30L,1L,20L,27L,36L,1L,36L,1L,34L,33L,24L,1L,44L,7L,30L,35L,40L,1L,36L,35L,50L,39L,30L,1L,56L,1L,32L,57L,48L,53L,56L,1L,52L,47L,58L,1L,66L,1L,38L,55L,58L,47L,66L,1L,76L,27L,42L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277127Inst : IEnumerable<long>
{
public static readonly long[] Value=A277127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277127.Bytes);
public long this[int i]=>Value[i];

public static A277127Inst Instance=new A277127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277128
{
public static readonly long[] Value={ 1L,8L,16L,32L,64L,81L,128L,243L,256L,384L,512L,729L,768L,1024L,1152L,1536L,2048L,2187L,2304L,3072L,3456L,4096L,4374L,4608L,6144L,6561L,6912L,8192L,8748L,9216L,10240L,10368L,12288L,13122L,13824L,15625L,16384L,17496L,18432L,19683L,20480L,20736L,24576L,26244L,27648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277128Inst : IEnumerable<long>
{
public static readonly long[] Value=A277128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277128.Bytes);
public long this[int i]=>Value[i];

public static A277128Inst Instance=new A277128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277129
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,4L,4L,7L,3L,6L,1L,10L,1L,11L,11L,15L,9L,12L,1L,16L,15L,12L,12L,22L,5L,14L,9L,25L,1L,26L,26L,31L,23L,26L,23L,30L,1L,20L,27L,36L,21L,36L,29L,34L,33L,35L,24L,46L,28L,30L,43L,40L,1L,36L,35L,53L,39L,30L,1L,56L,1L,57L,57L,63L,53L,56L,1L,60L,47L,58L,36L,66L,64L,38L,55L,58L,47L,66L,40L,76L,27L,62L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277129Inst : IEnumerable<long>
{
public static readonly long[] Value=A277129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277129.Bytes);
public long this[int i]=>Value[i];

public static A277129Inst Instance=new A277129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277130
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,6L,2L,3L,1L,14L,1L,3L,3L,24L,1L,14L,1L,14L,3L,3L,1L,78L,2L,3L,6L,14L,1L,25L,1L,112L,3L,3L,3L,110L,1L,3L,3L,78L,1L,25L,1L,14L,14L,3L,1L,464L,2L,14L,3L,14L,1L,78L,3L,78L,3L,3L,1L,206L,1L,3L,14L,568L,3L,25L,1L,14L,3L,25L,1L,850L,1L,3L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277130Inst : IEnumerable<long>
{
public static readonly long[] Value=A277130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277130.Bytes);
public long this[int i]=>Value[i];

public static A277130Inst Instance=new A277130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277131
{
public static readonly long[] Value={ 45L,127L,279L,521L,873L,1355L,1987L,2789L,3781L,4983L,6415L,8097L,10049L,12291L,14843L,17725L,20957L,24559L,28551L,32953L,37785L,43067L,48819L,55061L,61813L,69095L,76927L,85329L,94321L,103923L,114155L,125037L,136589L,148831L,161783L,175465L,189897L,205099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277131Inst : IEnumerable<long>
{
public static readonly long[] Value=A277131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277131.Bytes);
public long this[int i]=>Value[i];

public static A277131Inst Instance=new A277131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277132
{
public static readonly BigInteger[] Value={ 1L,3L,14L,78L,508L,3796L,32048L,301872L,3139680L,35746080L,442258560L,5909028480L,84802072320L,1301090515200L,21253339699200L,368281038182400L,6747621163315200L,130338926671564800L,2647326900234240000L,BigInteger.Parse("56404832240977920000") };
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
public class A277132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277132Inst Instance=new A277132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277133
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,7L,7L,11L,11L,17L,17L,25L,25L,35L,35L,48L,48L,65L,65L,86L,86L,113L,113L,143L,143L,180L,180L,227L,227L,284L,284L,346L,346L,421L,421L,508L,508L,610L,610L,726L,726L,861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277133Inst : IEnumerable<long>
{
public static readonly long[] Value=A277133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277133.Bytes);
public long this[int i]=>Value[i];

public static A277133Inst Instance=new A277133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277134
{
public static readonly BigInteger[] Value={ 1L,2L,14L,496L,64902L,33480816L,68683762160L,562879053495808L,18446172258948389894UL,BigInteger.Parse("2417833047807055774900336"),BigInteger.Parse("1267648177654223684013845739628"),BigInteger.Parse("2658454721440933587372867150275542528") };
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
public class A277134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277134Inst Instance=new A277134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277135
{
public static readonly long[] Value={ 0L,0L,6L,7L,3L,1L,6L,7L,0L,7L,8L,9L,3L,1L,7L,4L,1L,6L,9L,8L,8L,2L,9L,5L,2L,1L,7L,2L,6L,7L,9L,6L,4L,4L,4L,6L,4L,8L,9L,0L,1L,4L,3L,6L,5L,5L,4L,1L,8L,1L,2L,3L,3L,8L,0L,0L,3L,5L,0L,1L,6L,7L,5L,5L,0L,7L,3L,1L,5L,7L,7L,3L,6L,0L,1L,7L,3L,3L,9L,0L,2L,3L,0L,4L,5L,3L,0L,9L,0L,8L,2L,6L,5L,2L,2L,4L,0L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277135Inst : IEnumerable<long>
{
public static readonly long[] Value=A277135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277135.Bytes);
public long this[int i]=>Value[i];

public static A277135Inst Instance=new A277135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277136
{
public static readonly long[] Value={ 5L,11L,12L,18L,24L,30L,37L,43L,49L,55L,56L,62L,68L,74L,81L,87L,93L,99L,100L,106L,112L,118L,125L,131L,137L,143L,144L,150L,156L,162L,169L,175L,181L,187L,188L,194L,200L,206L,213L,219L,225L,231L,232L,238L,244L,250L,257L,263L,269L,275L,276L,282L,288L,294L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277136Inst : IEnumerable<long>
{
public static readonly long[] Value=A277136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277136.Bytes);
public long this[int i]=>Value[i];

public static A277136Inst Instance=new A277136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277137
{
public static readonly long[] Value={ 1L,6L,7L,13L,14L,19L,20L,25L,26L,31L,32L,38L,39L,44L,45L,50L,51L,57L,58L,63L,64L,69L,70L,75L,76L,82L,83L,88L,89L,94L,95L,101L,102L,107L,108L,113L,114L,119L,120L,126L,127L,132L,133L,138L,139L,145L,146L,151L,152L,157L,158L,163L,164L,170L,171L,176L,177L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277137Inst : IEnumerable<long>
{
public static readonly long[] Value=A277137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277137.Bytes);
public long this[int i]=>Value[i];

public static A277137Inst Instance=new A277137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277138
{
public static readonly long[] Value={ 3L,4L,9L,10L,16L,17L,22L,23L,28L,29L,35L,36L,41L,42L,47L,48L,53L,54L,60L,61L,66L,67L,72L,73L,79L,80L,85L,86L,91L,92L,97L,98L,104L,105L,110L,111L,116L,117L,123L,124L,129L,130L,135L,136L,141L,142L,148L,149L,154L,155L,160L,161L,167L,168L,173L,174L,179L,180L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277138Inst : IEnumerable<long>
{
public static readonly long[] Value=A277138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277138.Bytes);
public long this[int i]=>Value[i];

public static A277138Inst Instance=new A277138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277139
{
public static readonly long[] Value={ 2L,8L,15L,21L,27L,33L,34L,40L,46L,52L,59L,65L,71L,77L,78L,84L,90L,96L,103L,109L,115L,121L,122L,128L,134L,140L,147L,153L,159L,165L,166L,172L,178L,184L,191L,197L,203L,209L,210L,216L,222L,228L,235L,241L,247L,253L,254L,260L,266L,272L,279L,285L,291L,297L,298L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277139Inst : IEnumerable<long>
{
public static readonly long[] Value=A277139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277139.Bytes);
public long this[int i]=>Value[i];

public static A277139Inst Instance=new A277139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277172
{
public static readonly long[] Value={ 1L,511L,713L,11023L,15553L,43873L,81079L,323593L,27923663L,125093857L,466572127L,1108378657L,2214217703L,2871002911L,3501195817L,4107455887L,4609840831L,5066719081L,5488711231L,6331291231L,9396536737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277172Inst : IEnumerable<long>
{
public static readonly long[] Value=A277172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277172.Bytes);
public long this[int i]=>Value[i];

public static A277172Inst Instance=new A277172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277173
{
public static readonly long[] Value={ 1L,2L,6L,12L,24L,60L,120L,126L,240L,420L,480L,504L,672L,780L,1248L,1260L,2340L,2520L,3360L,4680L,5040L,5460L,6240L,6552L,8160L,8736L,9360L,10080L,11424L,16380L,21216L,26208L,27360L,32760L,38304L,43680L,57120L,65520L,71136L,74592L,106080L,131040L,147168L,148512L,171360L,191520L,202464L,325920L,355680L,372960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277173Inst : IEnumerable<long>
{
public static readonly long[] Value=A277173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277173.Bytes);
public long this[int i]=>Value[i];

public static A277173Inst Instance=new A277173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277174
{
public static readonly BigInteger[] Value={ 1L,1L,4L,36L,288L,7200L,259200L,12700800L,203212800L,5486745600L,548674560000L,66389621760000L,4780052766720000L,807828917575680000L,BigInteger.Parse("158334467844833280000"),BigInteger.Parse("35625255265087488000000"),BigInteger.Parse("1140008168482799616000000"),BigInteger.Parse("329462360691529089024000000") };
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
public class A277174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277174Inst Instance=new A277174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277175
{
public static readonly BigInteger[] Value={ 1L,2L,5L,15L,53L,222L,1120L,6849L,50111L,427510L,4142900L,44693782L,529276962L,6813205468L,94642629984L,1410507388421L,22445134308123L,379776665469030L,6808016435182620L,128886547350655050L,2569493300908367550L,BigInteger.Parse("53805226930896987540"),BigInteger.Parse("1180673761078007109840") };
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
public class A277175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277175Inst Instance=new A277175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277176
{
public static readonly BigInteger[] Value={ 1L,2L,6L,23L,106L,572L,3564L,25377L,204446L,1844876L,18465556L,203179902L,2438366836L,31699511768L,443795839192L,6656947282725L,106511191881270L,1810690391626380L,32592427526913540L,619256124778620450L,12385122502136529420UL,BigInteger.Parse("260087572569333384840") };
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
public class A277176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277176Inst Instance=new A277176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277177
{
public static readonly BigInteger[] Value={ 1L,3L,-24L,784L,-46896L,4317456L,-562745520L,98690557584L,-22460740839216L,6450171240032784L,-2284564885046722992L,BigInteger.Parse("979187134208612772240"),BigInteger.Parse("-499793632523433181810736"),BigInteger.Parse("299667123722863936449037584"),BigInteger.Parse("-208593901698504257051080848048"),BigInteger.Parse("166857381492340592665576625921168"),BigInteger.Parse("-152017413229327953521998890673326384"),BigInteger.Parse("156505079591897717881208227590259134480") };
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
public class A277177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277177Inst Instance=new A277177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277178
{
public static readonly long[] Value={ 0L,1L,7L,37L,177L,807L,3579L,15591L,67071L,285861L,1209641L,5089517L,21314453L,88918353L,369734553L,1533115953L,6341759073L,26177411943L,107853629643L,443633635743L,1822098923943L,7473806605563L,30618895206483L,125303348573883L,512274592771083L,2092407173242983L,8539348101568335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277178Inst : IEnumerable<long>
{
public static readonly long[] Value=A277178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277178.Bytes);
public long this[int i]=>Value[i];

public static A277178Inst Instance=new A277178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277179
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,59L,365L,3088L,38996L,740467L,19758435L,690334227L,30150545092L,1599014847188L,100918669227260L,7463532377496184L,638749818745548988L,BigInteger.Parse("62599568958563222499"),BigInteger.Parse("6962493257384838286351"),BigInteger.Parse("872012649206880910980233"),BigInteger.Parse("122142967347570710975572644"),BigInteger.Parse("19017873674952442001496543299"),BigInteger.Parse("3273737565549680748476297065053"),BigInteger.Parse("619999424134642103881677814415308"),BigInteger.Parse("128612434698134902683744004202176480") };
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
public class A277179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277179Inst Instance=new A277179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277180
{
public static readonly BigInteger[] Value={ 1L,2L,9L,100L,1205L,18006L,350077L,8088536L,211371561L,6176234890L,200898827921L,7219180413732L,284177412817597L,12162803253287246L,562046000617917285L,BigInteger.Parse("27867599169654763696"),BigInteger.Parse("1475047571057004959057"),BigInteger.Parse("83000104748219010488850"),BigInteger.Parse("4947512767013757600177049"),BigInteger.Parse("311464596400042198210554620"),BigInteger.Parse("20652342444419128752639269541"),BigInteger.Parse("1438800618216725748602640496342") };
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
public class A277180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277180Inst Instance=new A277180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277181
{
public static readonly BigInteger[] Value={ 1L,2L,9L,76L,605L,7326L,97237L,1414904L,24130521L,467773210L,9636459041L,215484787332L,5351427245749L,141098897750006L,3995090542811565L,120415709525270896L,3833710980240095537L,BigInteger.Parse("130061101059127375794"),BigInteger.Parse("4649348119132468282681"),BigInteger.Parse("174231442774945244111420"),BigInteger.Parse("6859230825811289134828941"),BigInteger.Parse("282654139723294546295799502"),BigInteger.Parse("12162998707984268597918477189"),BigInteger.Parse("546138551651775603897277518696") };
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
public class A277181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277181Inst Instance=new A277181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277182
{
public static readonly BigInteger[] Value={ 1L,2L,18L,144L,1660L,27480L,548394L,12402992L,316789848L,9158652720L,296955697390L,10666960742328L,420121365404052L,17973670280757464L,828915057583647090L,BigInteger.Parse("40974375613614916320"),BigInteger.Parse("2161181874390019883056"),BigInteger.Parse("121176506157487442355168"),BigInteger.Parse("7199219738147125437960534"),BigInteger.Parse("451879288812982893026999720"),BigInteger.Parse("29885088906978769868636730540") };
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
public class A277182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277182Inst Instance=new A277182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277183
{
public static readonly BigInteger[] Value={ 1L,2L,12L,48L,540L,5040L,53760L,745920L,12897360L,206236800L,3682657440L,83366236800L,1849952744640L,45496897205760L,1176291493977600L,32097739145472000L,983522184476832000L,BigInteger.Parse("31186123650255974400"),BigInteger.Parse("1021800029809932172800"),BigInteger.Parse("35859334900163943168000"),BigInteger.Parse("1320567044275182140236800"),BigInteger.Parse("50849016060752080883712000"),BigInteger.Parse("2063131407115000462188748800"),BigInteger.Parse("86946484539570696351914803200") };
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
public class A277183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277183Inst Instance=new A277183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277184
{
public static readonly BigInteger[] Value={ 1L,4L,33L,424L,7505L,170496L,4744873L,156529024L,5974216641L,258970009600L,12566664261041L,674795685758976L,39720422453156497L,2543022838953017344L,BigInteger.Parse("175923061842374645625"),BigInteger.Parse("13076498369827187163136"),BigInteger.Parse("1039320236257785348449537"),BigInteger.Parse("87954586779787961844105216"),BigInteger.Parse("7895887532418683295505005121"),BigInteger.Parse("749448035808323155802521600000"),BigInteger.Parse("74989090946223628553344278643281"),BigInteger.Parse("7888932153987131087072869161631744") };
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
public class A277184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277184Inst Instance=new A277184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277185
{
public static readonly long[] Value={ 1L,729L,85766121L,1340095640625L,151939915084881L,413976684737889L,2070185663499849L,4034942722397601L,12696463968316569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277185Inst : IEnumerable<long>
{
public static readonly long[] Value=A277185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277185.Bytes);
public long this[int i]=>Value[i];

public static A277185Inst Instance=new A277185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277186
{
public static readonly long[] Value={ 5L,10L,17L,26L,31L,67L,83L,83L,119L,139L,161L,228L,281L,281L,341L,408L,474L,553L,546L,635L,635L,780L,824L,1092L,954L,1008L,1008L,1139L,1197L,1336L,1621L,1687L,1650L,1823L,1854L,1854L,2238L,2634L,2507L,2587L,2450L,2673L,3223L,3223L,3403L,3403L,3591L,4054L,4054L,4331L,4535L,4535L,4828L,4444L,4666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277186Inst : IEnumerable<long>
{
public static readonly long[] Value=A277186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277186.Bytes);
public long this[int i]=>Value[i];

public static A277186Inst Instance=new A277186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277187
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,17L,19L,23L,25L,27L,29L,31L,36L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,125L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277187Inst : IEnumerable<long>
{
public static readonly long[] Value=A277187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277187.Bytes);
public long this[int i]=>Value[i];

public static A277187Inst Instance=new A277187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277220
{
public static readonly long[] Value={ 0L,1L,3L,11L,43L,180L,790L,3590L,16745L,79705L,385615L,1890747L,9375216L,46931897L,236873261L,1204089630L,6159064015L,31678706490L,163739008070L,850051218980L,4430529313065L,23175017046351L,121617754070653L,640122809255716L,3378402106118508L,17875011275340275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277220Inst : IEnumerable<long>
{
public static readonly long[] Value=A277220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277220.Bytes);
public long this[int i]=>Value[i];

public static A277220Inst Instance=new A277220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277221
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,78L,297L,1143L,4419L,17119L,66386L,257621L,1000407L,3887666L,15119991L,58856167L,229312425L,894263633L,3490636794L,13637575699L,53327459013L,208703945330L,817447047177L,3204204114421L,12568821046236L,49336156718513L,193783005926727L,761604774463568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277221Inst : IEnumerable<long>
{
public static readonly long[] Value=A277221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277221.Bytes);
public long this[int i]=>Value[i];

public static A277221Inst Instance=new A277221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277222
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,86L,343L,1374L,5497L,21926L,87176L,345612L,1366960L,5396604L,21275618L,83793268L,329791425L,1297428774L,5103039279L,20069815052L,78936685887L,310509337760L,1221686293926L,4807894697586L,18926706307263L,74529761736076L,293579002631157L,1156815016422286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277222Inst : IEnumerable<long>
{
public static readonly long[] Value=A277222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277222.Bytes);
public long this[int i]=>Value[i];

public static A277222Inst Instance=new A277222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277223
{
public static readonly long[] Value={ 9L,9L,9L,12L,9L,9L,12L,9L,9L,9L,18L,9L,15L,9L,9L,18L,9L,9L,21L,9L,18L,18L,9L,9L,15L,18L,18L,21L,9L,9L,18L,18L,18L,12L,9L,18L,27L,18L,9L,12L,18L,18L,18L,18L,9L,21L,18L,18L,18L,9L,18L,18L,18L,18L,18L,9L,9L,15L,9L,9L,18L,0L,0L,17L,0L,18L,12L,9L,9L,12L,18L,18L,26L,27L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277223Inst : IEnumerable<long>
{
public static readonly long[] Value=A277223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277223.Bytes);
public long this[int i]=>Value[i];

public static A277223Inst Instance=new A277223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277224
{
public static readonly long[] Value={ 1L,3L,8L,15L,32L,63L,130L,257L,520L,1029L,2060L,4113L,8240L,16477L,32958L,65915L,131836L,263633L,527280L,1054553L,2109130L,4218257L,8436528L,16873045L,33746094L,67492171L,134984390L,269968777L,539937558L,1079875091L,2159750220L,4319500381L,8639000780L,17278001533L,34556003072L,69112006095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277224Inst : IEnumerable<long>
{
public static readonly long[] Value=A277224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277224.Bytes);
public long this[int i]=>Value[i];

public static A277224Inst Instance=new A277224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277225
{
public static readonly long[] Value={ 1L,16L,97L,241L,3302449L,123402049L,2163898897L,4168758049L,10062413521L,18006326449L,21376916449L,55487798449L,77248867921L,108396336049L,141466251697L,183357512449L,198504183697L,200642120449L,278584843921L,282955076449L,341261911249L,723039200449L,770057874097L,847823354449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277225Inst : IEnumerable<long>
{
public static readonly long[] Value=A277225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277225.Bytes);
public long this[int i]=>Value[i];

public static A277225Inst Instance=new A277225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277226
{
public static readonly long[] Value={ 1L,34L,464L,3182L,14769L,53044L,158976L,416140L,980625L,2124310L,4295376L,8199674L,14907809L,25992232L,43700224L,71167704L,112680801L,173990730L,262690000L,388656070L,564571601L,806527964L,1134722304L,1574255332L,2156041329L,2917838014L,3905408976L,5173826770L,6788930625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277226Inst : IEnumerable<long>
{
public static readonly long[] Value=A277226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277226.Bytes);
public long this[int i]=>Value[i];

public static A277226Inst Instance=new A277226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277227
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,2L,4L,1L,5L,5L,5L,5L,1L,6L,3L,2L,3L,6L,1L,7L,7L,7L,7L,7L,7L,1L,8L,4L,8L,2L,8L,4L,8L,1L,9L,9L,3L,9L,9L,3L,9L,9L,1L,10L,5L,10L,5L,2L,5L,10L,5L,10L,1L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,1L,12L,6L,4L,3L,12L,2L,12L,3L,4L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277227Inst : IEnumerable<long>
{
public static readonly long[] Value=A277227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277227.Bytes);
public long this[int i]=>Value[i];

public static A277227Inst Instance=new A277227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277228
{
public static readonly long[] Value={ 0L,0L,3L,22L,88L,258L,623L,1316L,2520L,4476L,7491L,11946L,18304L,27118L,39039L,54824L,75344L,101592L,134691L,175902L,226632L,288442L,363055L,452364L,558440L,683540L,830115L,1000818L,1198512L,1426278L,1687423L,1985488L,2324256L,2707760L,3140291L,3626406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277228Inst : IEnumerable<long>
{
public static readonly long[] Value=A277228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277228.Bytes);
public long this[int i]=>Value[i];

public static A277228Inst Instance=new A277228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277229
{
public static readonly long[] Value={ 0L,1L,10L,48L,158L,413L,924L,1848L,3396L,5841L,9526L,14872L,22386L,32669L,46424L,64464L,87720L,117249L,154242L,200032L,256102L,324093L,405812L,503240L,618540L,754065L,912366L,1096200L,1308538L,1552573L,1831728L,2149664L,2510288L,2917761L,3376506L,3891216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277229Inst : IEnumerable<long>
{
public static readonly long[] Value=A277229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277229.Bytes);
public long this[int i]=>Value[i];

public static A277229Inst Instance=new A277229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277230
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,5L,1L,2L,6L,1L,2L,1L,7L,1L,2L,3L,1L,8L,1L,2L,3L,1L,1L,9L,1L,2L,3L,4L,1L,1L,2L,10L,1L,2L,3L,4L,1L,1L,1L,2L,1L,11L,1L,2L,3L,4L,5L,1L,1L,1L,2L,2L,1L,12L,1L,2L,3L,4L,5L,1L,1L,1L,1L,2L,2L,3L,1L,1L,13L,1L,2L,3L,4L,5L,6L,1L,1L,1L,1L,2L,2L,2L,3L,1L,1L,1L,14L,1L,2L,3L,4L,5L,6L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,1L,1L,1L,1L,2L,15L,1L,2L,3L,4L,5L,6L,7L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277230Inst : IEnumerable<long>
{
public static readonly long[] Value=A277230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277230.Bytes);
public long this[int i]=>Value[i];

public static A277230Inst Instance=new A277230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277231
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277231Inst : IEnumerable<long>
{
public static readonly long[] Value=A277231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277231.Bytes);
public long this[int i]=>Value[i];

public static A277231Inst Instance=new A277231Inst();

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