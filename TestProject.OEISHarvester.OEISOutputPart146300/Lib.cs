using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A175605
{
public static readonly long[] Value={ 11L,88L,2727L,6464L,125125L,216216L,343343L,512512L,729729L,10001000L,13311331L,17281728L,21972197L,27442744L,33753375L,40964096L,49134913L,58325832L,68596859L,80008000L,92619261L,1064810648L,1216712167L,1382413824L,1562515625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175605Inst : IEnumerable<long>
{
public static readonly long[] Value=A175605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175605.Bytes);
public long this[int i]=>Value[i];

public static A175605Inst Instance=new A175605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175606
{
public static readonly long[] Value={ 1151L,1451L,1667L,3251L,3851L,4019L,5651L,6359L,6551L,6959L,7547L,11351L,11831L,12251L,13691L,15731L,15887L,16451L,17987L,18131L,18251L,19751L,20231L,22091L,26951L,27539L,28751L,30851L,31151L,32831L,35051L,37571L,38651L,38711L,40151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175606Inst : IEnumerable<long>
{
public static readonly long[] Value=A175606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175606.Bytes);
public long this[int i]=>Value[i];

public static A175606Inst Instance=new A175606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175607
{
public static readonly BigInteger[] Value={ 3L,17L,161L,8749L,19601L,246401L,672281L,23718421L,10285001L,354365441L,3222617399L,9447152318L,127855050751L,842277599279L,2218993446251L,2907159732049L,41257182408961L,63774701665793L,25640240468751L,238178082107393L,4573663454608289L,BigInteger.Parse("19182937474703818751"),34903240221563713L,332110803172167361L,99913980938200001L };
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
public class A175607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175607Inst Instance=new A175607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175608
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175608Inst : IEnumerable<long>
{
public static readonly long[] Value=A175608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175608.Bytes);
public long this[int i]=>Value[i];

public static A175608Inst Instance=new A175608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175609
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,2L,2L,0L,1L,1L,1L,3L,1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,1L,1L,1L,2L,0L,4L,2L,2L,1L,2L,2L,2L,2L,1L,1L,1L,5L,4L,2L,1L,1L,4L,1L,2L,2L,3L,3L,4L,6L,4L,3L,3L,2L,2L,2L,1L,1L,2L,2L,3L,1L,2L,1L,2L,3L,2L,3L,2L,3L,6L,3L,2L,2L,1L,2L,1L,3L,2L,2L,2L,4L,2L,2L,2L,2L,4L,2L,3L,3L,4L,6L,4L,4L,3L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175609Inst : IEnumerable<long>
{
public static readonly long[] Value=A175609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175609.Bytes);
public long this[int i]=>Value[i];

public static A175609Inst Instance=new A175609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175610
{
public static readonly long[] Value={ 0L,422481L,844962L,1267443L,1689924L,2112405L,2534886L,2813001L,2957367L,3379848L,3802329L,4224810L,4647291L,5069772L,5492253L,5626002L,5914734L,6337215L,6759696L,7182177L,7604658L,8027139L,8439003L,8449620L,8707481L,8872101L,9294582L,9717063L,10139544L,10562025L,10984506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175610Inst : IEnumerable<long>
{
public static readonly long[] Value=A175610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175610.Bytes);
public long this[int i]=>Value[i];

public static A175610Inst Instance=new A175610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175611
{
public static readonly BigInteger[] Value={ 2L,3L,5L,7L,31L,127L,8191L,131071L,524287L,2147483647L,2305843009213693951L,BigInteger.Parse("618970019642690137449562111"),BigInteger.Parse("162259276829213363391578010288127"),BigInteger.Parse("170141183460469231731687303715884105727") };
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
public class A175611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175611Inst Instance=new A175611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175612
{
public static readonly long[] Value={ 6L,10L,10L,14L,21L,25L,22L,26L,34L,38L,35L,39L,51L,55L,58L,62L,65L,69L,82L,86L,87L,91L,91L,95L,111L,115L,115L,119L,118L,122L,119L,123L,129L,133L,141L,145L,142L,146L,155L,159L,183L,187L,201L,205L,202L,206L,205L,209L,209L,213L,213L,217L,214L,218L,215L,219L,217L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175612Inst : IEnumerable<long>
{
public static readonly long[] Value=A175612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175612.Bytes);
public long this[int i]=>Value[i];

public static A175612Inst Instance=new A175612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175613
{
public static readonly long[] Value={ 1L,2L,10L,42L,589L,2186L,30253L,113307L,1608668L,88157689L,336717854L,19015826478L,282528883551L,1091574618496L,16360940729894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175613Inst : IEnumerable<long>
{
public static readonly long[] Value=A175613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175613.Bytes);
public long this[int i]=>Value[i];

public static A175613Inst Instance=new A175613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175614
{
public static readonly long[] Value={ 1L,5L,5L,17L,9L,31L,13L,47L,17L,67L,21L,83L,25L,103L,29L,127L,33L,149L,37L,167L,41L,191L,45L,211L,49L,233L,53L,257L,57L,277L,61L,307L,65L,331L,69L,353L,73L,379L,77L,401L,81L,431L,85L,449L,89L,467L,93L,499L,97L,523L,101L,563L,105L,587L,109L,607L,113L,631L,117L,653L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175614Inst : IEnumerable<long>
{
public static readonly long[] Value=A175614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175614.Bytes);
public long this[int i]=>Value[i];

public static A175614Inst Instance=new A175614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175615
{
public static readonly long[] Value={ 9L,1L,9L,0L,1L,9L,4L,7L,7L,5L,9L,3L,7L,4L,4L,4L,3L,0L,1L,7L,3L,9L,2L,4L,3L,7L,3L,0L,0L,7L,0L,6L,5L,1L,6L,6L,6L,2L,6L,7L,8L,9L,0L,8L,6L,7L,0L,6L,9L,0L,7L,5L,6L,9L,3L,6L,9L,5L,0L,0L,8L,9L,8L,3L,8L,9L,3L,6L,1L,8L,3L,1L,0L,2L,7L,7L,5L,5L,5L,1L,8L,3L,0L,3L,3L,1L,3L,9L,8L,1L,6L,4L,7L,5L,8L,0L,7L,5L,5L,8L,8L,2L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175615Inst : IEnumerable<long>
{
public static readonly long[] Value=A175615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175615.Bytes);
public long this[int i]=>Value[i];

public static A175615Inst Instance=new A175615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175616
{
public static readonly long[] Value={ 9L,6L,3L,2L,5L,6L,5L,6L,1L,7L,5L,7L,5L,5L,9L,0L,9L,7L,3L,7L,3L,0L,4L,6L,0L,3L,4L,8L,8L,3L,9L,7L,5L,1L,9L,5L,5L,4L,3L,5L,2L,0L,7L,5L,7L,8L,5L,3L,4L,2L,2L,6L,3L,7L,3L,9L,5L,1L,6L,8L,8L,5L,0L,4L,2L,7L,6L,9L,4L,4L,2L,1L,8L,8L,7L,6L,7L,8L,1L,3L,0L,4L,6L,3L,6L,3L,5L,8L,0L,4L,6L,8L,6L,0L,9L,7L,9L,6L,9L,8L,7L,0L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175616Inst : IEnumerable<long>
{
public static readonly long[] Value=A175616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175616.Bytes);
public long this[int i]=>Value[i];

public static A175616Inst Instance=new A175616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175617
{
public static readonly long[] Value={ 9L,8L,2L,6L,8L,4L,2L,7L,7L,7L,4L,2L,1L,9L,2L,5L,1L,8L,3L,2L,4L,4L,7L,5L,9L,1L,6L,2L,5L,7L,1L,3L,6L,3L,7L,3L,5L,1L,4L,8L,2L,8L,9L,9L,8L,4L,4L,9L,1L,9L,5L,5L,5L,1L,7L,9L,1L,6L,9L,3L,3L,9L,6L,5L,4L,4L,3L,7L,8L,7L,1L,0L,9L,0L,0L,3L,7L,0L,0L,8L,6L,2L,3L,6L,1L,8L,4L,8L,6L,6L,9L,9L,8L,0L,0L,7L,8L,4L,7L,5L,6L,1L,5L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175617Inst : IEnumerable<long>
{
public static readonly long[] Value=A175617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175617.Bytes);
public long this[int i]=>Value[i];

public static A175617Inst Instance=new A175617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175618
{
public static readonly long[] Value={ 9L,9L,1L,6L,5L,4L,9L,5L,3L,4L,7L,2L,8L,3L,4L,4L,5L,7L,4L,0L,1L,3L,2L,3L,3L,7L,0L,5L,6L,9L,0L,2L,7L,4L,2L,5L,8L,6L,4L,2L,6L,8L,0L,8L,3L,5L,4L,1L,0L,3L,8L,5L,0L,3L,4L,9L,7L,6L,6L,3L,4L,9L,2L,1L,4L,1L,7L,0L,5L,1L,4L,3L,6L,3L,2L,8L,4L,3L,1L,9L,7L,1L,1L,8L,0L,2L,3L,9L,5L,0L,3L,8L,3L,0L,4L,3L,7L,9L,5L,5L,2L,1L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175618Inst : IEnumerable<long>
{
public static readonly long[] Value=A175618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175618.Bytes);
public long this[int i]=>Value[i];

public static A175618Inst Instance=new A175618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175619
{
public static readonly long[] Value={ 9L,9L,5L,9L,2L,3L,3L,1L,5L,0L,7L,7L,7L,8L,3L,6L,7L,1L,2L,0L,4L,1L,0L,6L,7L,4L,7L,3L,0L,8L,6L,0L,6L,6L,6L,7L,0L,6L,6L,2L,3L,0L,0L,1L,7L,2L,9L,6L,3L,3L,6L,3L,7L,2L,3L,9L,9L,8L,3L,3L,6L,3L,3L,0L,0L,2L,6L,0L,0L,0L,3L,1L,6L,8L,3L,0L,3L,1L,1L,9L,4L,0L,8L,9L,6L,9L,0L,7L,2L,9L,7L,6L,1L,2L,9L,0L,8L,5L,3L,2L,6L,4L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175619Inst : IEnumerable<long>
{
public static readonly long[] Value=A175619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175619.Bytes);
public long this[int i]=>Value[i];

public static A175619Inst Instance=new A175619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175620
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,0L,0L,0L,0L,2L,1L,3L,4L,2L,2L,4L,2L,4L,2L,4L,1L,4L,2L,1L,4L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,8L,4L,2L,1L,5L,7L,8L,4L,2L,8L,4L,2L,6L,8L,4L,2L,6L,8L,4L,6L,3L,7L,9L,10L,5L,8L,4L,2L,1L,6L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,2L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175620Inst : IEnumerable<long>
{
public static readonly long[] Value=A175620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175620.Bytes);
public long this[int i]=>Value[i];

public static A175620Inst Instance=new A175620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175621
{
public static readonly long[] Value={ 1L,4L,0L,5L,4L,4L,2L,8L,0L,4L,16L,11L,14L,16L,2L,10L,5L,8L,4L,0L,17L,30L,23L,4L,24L,20L,16L,4L,12L,32L,6L,16L,8L,14L,26L,40L,22L,13L,16L,29L,22L,16L,8L,32L,0L,2L,4L,52L,35L,64L,40L,28L,23L,20L,30L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175621Inst : IEnumerable<long>
{
public static readonly long[] Value=A175621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175621.Bytes);
public long this[int i]=>Value[i];

public static A175621Inst Instance=new A175621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175622
{
public static readonly long[] Value={ 1L,4L,5L,4L,2L,8L,11L,14L,2L,10L,17L,30L,23L,24L,20L,6L,8L,26L,13L,29L,22L,8L,2L,35L,28L,30L,72L,2L,54L,44L,8L,47L,12L,78L,40L,56L,48L,74L,93L,7L,46L,62L,65L,8L,84L,71L,18L,50L,2L,128L,33L,20L,80L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175622Inst : IEnumerable<long>
{
public static readonly long[] Value=A175622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175622.Bytes);
public long this[int i]=>Value[i];

public static A175622Inst Instance=new A175622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175623
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,0L,3L,1L,3L,1L,1L,0L,1L,1L,2L,3L,5L,1L,5L,1L,1L,1L,1L,0L,1L,1L,1L,0L,3L,5L,7L,3L,5L,1L,3L,4L,0L,7L,4L,4L,7L,1L,1L,7L,2L,3L,5L,7L,1L,3L,7L,9L,3L,9L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,8L,3L,5L,7L,11L,1L,5L,7L,11L,5L,7L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175623Inst : IEnumerable<long>
{
public static readonly long[] Value=A175623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175623.Bytes);
public long this[int i]=>Value[i];

public static A175623Inst Instance=new A175623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175624
{
public static readonly long[] Value={ 1L,2L,6L,24L,50L,48L,0L,0L,210L,120L,352L,168L,0L,0L,800L,288L,1122L,360L,0L,0L,2002L,528L,0L,0L,0L,0L,4032L,840L,4930L,960L,0L,0L,0L,0L,8400L,1368L,0L,0L,11440L,1680L,13202L,1848L,0L,0L,17250L,2208L,0L,0L,0L,0L,24752L,2808L,0L,0L,0L,0L,34162L,3480L,37760L,3720L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175624Inst : IEnumerable<long>
{
public static readonly long[] Value=A175624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175624.Bytes);
public long this[int i]=>Value[i];

public static A175624Inst Instance=new A175624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175625
{
public static readonly long[] Value={ 7L,11L,23L,31L,47L,59L,83L,107L,167L,179L,227L,263L,347L,359L,383L,467L,479L,503L,563L,587L,683L,719L,839L,863L,887L,983L,1019L,1123L,1187L,1283L,1291L,1307L,1319L,1367L,1439L,1487L,1523L,1619L,1823L,1907L,2027L,2039L,2063L,2099L,2207L,2447L,2459L,2543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175625Inst : IEnumerable<long>
{
public static readonly long[] Value=A175625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175625.Bytes);
public long this[int i]=>Value[i];

public static A175625Inst Instance=new A175625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175626
{
public static readonly long[] Value={ 9L,15L,21L,33L,35L,39L,49L,51L,55L,57L,69L,77L,87L,93L,111L,115L,123L,129L,141L,159L,177L,183L,201L,203L,213L,219L,237L,249L,267L,291L,295L,303L,309L,321L,327L,329L,339L,361L,377L,381L,393L,411L,417L,437L,447L,451L,453L,471L,473L,489L,501L,515L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175626Inst : IEnumerable<long>
{
public static readonly long[] Value=A175626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175626.Bytes);
public long this[int i]=>Value[i];

public static A175626Inst Instance=new A175626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175627
{
public static readonly long[] Value={ 1L,4L,9L,25L,64L,144L,289L,625L,1296L,2601L,5329L,10816L,21904L,44100L,88209L,177241L,355216L,710649L,1423249L,2849344L,5702544L,11410884L,22829284L,45670564L,91355364L,182736324L,365497924L,730999369L,1462068169L,2924213776L,5848578576L,11697287716L,23394620209L,46789583481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175627Inst : IEnumerable<long>
{
public static readonly long[] Value=A175627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175627.Bytes);
public long this[int i]=>Value[i];

public static A175627Inst Instance=new A175627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175628
{
public static readonly long[] Value={ 0L,0L,3L,5L,8L,3L,15L,21L,24L,2L,35L,45L,48L,15L,63L,77L,80L,6L,99L,117L,120L,35L,143L,165L,168L,12L,195L,221L,224L,63L,255L,285L,288L,20L,323L,357L,360L,99L,399L,437L,440L,30L,483L,525L,528L,143L,575L,621L,624L,42L,675L,725L,728L,195L,783L,837L,840L,56L,899L,957L,960L,255L,1023L,1085L,1088L,72L,1155L,1221L,1224L,323L,1295L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175628Inst : IEnumerable<long>
{
public static readonly long[] Value=A175628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175628.Bytes);
public long this[int i]=>Value[i];

public static A175628Inst Instance=new A175628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175629
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175629Inst : IEnumerable<long>
{
public static readonly long[] Value=A175629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175629.Bytes);
public long this[int i]=>Value[i];

public static A175629Inst Instance=new A175629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175630
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,0L,3L,7L,2L,7L,1L,7L,0L,7L,15L,7L,16L,7L,17L,7L,18L,7L,19L,7L,20L,7L,21L,7L,22L,7L,23L,7L,24L,7L,25L,7L,26L,7L,27L,7L,28L,7L,29L,7L,30L,7L,31L,7L,32L,7L,33L,7L,34L,7L,35L,7L,36L,7L,37L,7L,38L,7L,39L,7L,40L,7L,41L,7L,42L,7L,43L,7L,44L,7L,45L,7L,46L,7L,47L,7L,48L,7L,49L,7L,50L,7L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175630Inst : IEnumerable<long>
{
public static readonly long[] Value=A175630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175630.Bytes);
public long this[int i]=>Value[i];

public static A175630Inst Instance=new A175630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175631
{
public static readonly long[] Value={ 0L,2L,0L,2L,5L,9L,14L,20L,27L,35L,44L,54L,65L,77L,90L,104L,119L,135L,152L,170L,189L,209L,230L,252L,275L,299L,324L,350L,377L,405L,434L,464L,495L,527L,560L,594L,629L,665L,702L,740L,779L,819L,860L,902L,945L,989L,1034L,1080L,1127L,1175L,1224L,1274L,1325L,1377L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175631Inst : IEnumerable<long>
{
public static readonly long[] Value=A175631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175631.Bytes);
public long this[int i]=>Value[i];

public static A175631Inst Instance=new A175631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175632
{
public static readonly long[] Value={ 1L,3L,2L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175632Inst : IEnumerable<long>
{
public static readonly long[] Value=A175632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175632.Bytes);
public long this[int i]=>Value[i];

public static A175632Inst Instance=new A175632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175633
{
public static readonly BigInteger[] Value={ 1L,127L,32257L,8193151L,2081028097L,528572943487L,134255446617601L,34100354867927167L,8661355881006882817L,BigInteger.Parse("2199950293420880308351"),BigInteger.Parse("558778713173022591438337"),BigInteger.Parse("141927593195654317345029247") };
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
public class A175633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175633Inst Instance=new A175633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175634
{
public static readonly long[] Value={ 6L,9L,10L,15L,21L,22L,25L,33L,34L,35L,39L,49L,51L,55L,57L,58L,65L,69L,82L,85L,87L,91L,93L,111L,115L,118L,119L,123L,129L,133L,141L,142L,145L,155L,159L,169L,177L,183L,187L,201L,202L,205L,209L,213L,214L,215L,217L,219L,235L,237L,247L,249L,253L,259L,265L,267L,274L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175634Inst : IEnumerable<long>
{
public static readonly long[] Value=A175634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175634.Bytes);
public long this[int i]=>Value[i];

public static A175634Inst Instance=new A175634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175635
{
public static readonly long[] Value={ 0L,11L,149L,1156L,2538L,22925L,163284L,2116076L,9321378L,31622764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175635Inst : IEnumerable<long>
{
public static readonly long[] Value=A175635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175635.Bytes);
public long this[int i]=>Value[i];

public static A175635Inst Instance=new A175635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175636
{
public static readonly long[] Value={ 1L,3L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,3L,1L,1L,1L,4L,2L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,6L,2L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,5L,1L,2L,3L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,4L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,7L,1L,3L,1L,1L,1L,1L,3L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175636Inst : IEnumerable<long>
{
public static readonly long[] Value=A175636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175636.Bytes);
public long this[int i]=>Value[i];

public static A175636Inst Instance=new A175636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175637
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,77L,111L,707L,777L,909L,1111L,7777L,11111L,70707L,77777L,90909L,111111L,777777L,1111111L,7070707L,7777777L,9090909L,11111111L,77777777L,111111111L,707070707L,777777777L,909090909L,1111111111L,7777777777L,11111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175637Inst : IEnumerable<long>
{
public static readonly long[] Value=A175637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175637.Bytes);
public long this[int i]=>Value[i];

public static A175637Inst Instance=new A175637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175638
{
public static readonly long[] Value={ 7L,9L,1L,2L,2L,6L,5L,7L,1L,0L,4L,7L,6L,6L,6L,2L,4L,3L,4L,3L,5L,6L,9L,7L,3L,1L,7L,6L,8L,0L,1L,1L,6L,7L,7L,1L,0L,7L,8L,6L,4L,6L,1L,5L,5L,3L,3L,7L,8L,5L,4L,0L,7L,3L,0L,7L,5L,0L,5L,2L,4L,5L,3L,9L,4L,3L,1L,7L,2L,1L,3L,6L,7L,6L,6L,3L,9L,0L,8L,9L,9L,6L,3L,5L,6L,1L,0L,9L,7L,4L,2L,8L,6L,1L,6L,1L,3L,6L,3L,8L,5L,4L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175638Inst : IEnumerable<long>
{
public static readonly long[] Value=A175638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175638.Bytes);
public long this[int i]=>Value[i];

public static A175638Inst Instance=new A175638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175639
{
public static readonly long[] Value={ 6L,7L,8L,2L,3L,4L,4L,9L,1L,9L,1L,7L,3L,9L,1L,9L,7L,8L,0L,3L,5L,5L,3L,8L,2L,7L,9L,4L,8L,2L,8L,9L,4L,8L,1L,4L,0L,9L,6L,3L,3L,2L,2L,3L,9L,1L,8L,9L,4L,4L,0L,1L,0L,3L,0L,3L,6L,4L,6L,0L,4L,1L,5L,9L,6L,4L,9L,8L,3L,3L,7L,0L,7L,4L,0L,1L,2L,3L,2L,3L,3L,2L,1L,3L,7L,6L,2L,1L,2L,2L,9L,3L,3L,4L,8L,4L,6L,1L,6L,8L,8L,8L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175639Inst : IEnumerable<long>
{
public static readonly long[] Value=A175639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175639.Bytes);
public long this[int i]=>Value[i];

public static A175639Inst Instance=new A175639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175640
{
public static readonly long[] Value={ 2L,5L,9L,6L,5L,3L,6L,2L,9L,0L,4L,5L,0L,5L,4L,2L,0L,7L,3L,6L,3L,2L,7L,4L,0L,6L,5L,6L,6L,6L,9L,5L,1L,6L,1L,4L,2L,3L,7L,3L,9L,4L,6L,3L,0L,5L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175640Inst : IEnumerable<long>
{
public static readonly long[] Value=A175640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175640.Bytes);
public long this[int i]=>Value[i];

public static A175640Inst Instance=new A175640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175641
{
public static readonly long[] Value={ 2L,7L,4L,7L,0L,5L,2L,0L,8L,2L,8L,5L,5L,1L,8L,4L,8L,6L,2L,8L,9L,5L,7L,7L,8L,9L,8L,1L,6L,0L,8L,6L,0L,6L,3L,0L,0L,9L,9L,9L,4L,5L,0L,9L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175641Inst : IEnumerable<long>
{
public static readonly long[] Value=A175641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175641.Bytes);
public long this[int i]=>Value[i];

public static A175641Inst Instance=new A175641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175642
{
public static readonly long[] Value={ 1L,0L,0L,7L,9L,9L,6L,5L,4L,7L,9L,3L,9L,8L,6L,1L,1L,7L,2L,2L,6L,1L,6L,6L,6L,0L,7L,5L,5L,1L,2L,6L,7L,8L,5L,6L,6L,9L,9L,9L,0L,3L,1L,9L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175642Inst : IEnumerable<long>
{
public static readonly long[] Value=A175642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175642.Bytes);
public long this[int i]=>Value[i];

public static A175642Inst Instance=new A175642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175643
{
public static readonly long[] Value={ 1L,4L,1L,9L,4L,4L,8L,3L,8L,5L,3L,3L,1L,9L,5L,7L,0L,8L,6L,6L,1L,3L,9L,2L,6L,3L,9L,7L,2L,1L,7L,3L,4L,3L,1L,6L,6L,7L,5L,4L,1L,1L,0L,4L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175643Inst : IEnumerable<long>
{
public static readonly long[] Value=A175643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175643.Bytes);
public long this[int i]=>Value[i];

public static A175643Inst Instance=new A175643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175644
{
public static readonly long[] Value={ 0L,3L,3L,2L,1L,5L,5L,5L,0L,3L,2L,2L,2L,1L,7L,9L,5L,0L,5L,5L,2L,9L,2L,7L,1L,7L,7L,7L,8L,0L,1L,3L,8L,0L,9L,6L,4L,8L,1L,0L,8L,7L,5L,6L,6L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175644Inst : IEnumerable<long>
{
public static readonly long[] Value=A175644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175644.Bytes);
public long this[int i]=>Value[i];

public static A175644Inst Instance=new A175644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175645
{
public static readonly long[] Value={ 0L,0L,3L,6L,0L,0L,4L,2L,3L,3L,4L,6L,9L,4L,2L,9L,5L,8L,9L,5L,7L,4L,7L,6L,9L,4L,7L,6L,2L,9L,2L,3L,8L,4L,6L,4L,9L,4L,2L,4L,9L,5L,1L,6L,5L,1L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175645Inst : IEnumerable<long>
{
public static readonly long[] Value=A175645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175645.Bytes);
public long this[int i]=>Value[i];

public static A175645Inst Instance=new A175645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175646
{
public static readonly long[] Value={ 1L,0L,3L,4L,0L,1L,4L,8L,7L,5L,4L,1L,4L,3L,4L,1L,8L,8L,0L,5L,3L,9L,0L,3L,0L,6L,4L,4L,4L,1L,3L,0L,4L,7L,6L,2L,8L,5L,7L,8L,9L,6L,5L,4L,2L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175646Inst : IEnumerable<long>
{
public static readonly long[] Value=A175646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175646.Bytes);
public long this[int i]=>Value[i];

public static A175646Inst Instance=new A175646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175647
{
public static readonly long[] Value={ 1L,0L,5L,6L,1L,8L,2L,1L,2L,1L,7L,2L,6L,8L,1L,6L,1L,4L,1L,7L,3L,7L,9L,3L,0L,7L,6L,5L,3L,1L,6L,2L,1L,9L,8L,9L,0L,5L,8L,7L,5L,8L,0L,4L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175647Inst : IEnumerable<long>
{
public static readonly long[] Value=A175647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175647.Bytes);
public long this[int i]=>Value[i];

public static A175647Inst Instance=new A175647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175648
{
public static readonly long[] Value={ 6L,10L,21L,22L,34L,35L,51L,58L,65L,82L,87L,91L,111L,115L,118L,119L,129L,141L,142L,155L,183L,201L,202L,205L,209L,213L,214L,215L,217L,249L,274L,287L,291L,295L,298L,299L,301L,305L,319L,323L,335L,358L,361L,377L,382L,391L,394L,403L,407L,411L,413L,447L,454L,469L,478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175648Inst : IEnumerable<long>
{
public static readonly long[] Value=A175648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175648.Bytes);
public long this[int i]=>Value[i];

public static A175648Inst Instance=new A175648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175649
{
public static readonly long[] Value={ 2L,5L,5L,7L,10L,12L,9L,5L,10L,18L,16L,18L,22L,17L,10L,19L,22L,24L,26L,17L,23L,36L,28L,10L,20L,18L,12L,38L,39L,41L,33L,16L,33L,31L,17L,42L,58L,37L,23L,48L,53L,55L,56L,21L,33L,72L,52L,12L,14L,27L,35L,68L,58L,21L,25L,31L,53L,90L,69L,71L,94L,43L,12L,20L,34L,83L,86L,45L,40L,85L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175649Inst : IEnumerable<long>
{
public static readonly long[] Value=A175649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175649.Bytes);
public long this[int i]=>Value[i];

public static A175649Inst Instance=new A175649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175650
{
public static readonly long[] Value={ 3L,6L,5L,7L,9L,7L,12L,10L,15L,14L,18L,11L,13L,24L,21L,13L,27L,20L,11L,30L,21L,28L,25L,36L,45L,19L,26L,48L,35L,42L,26L,35L,33L,19L,54L,40L,22L,49L,60L,19L,17L,56L,33L,50L,39L,72L,49L,75L,63L,23L,81L,23L,90L,38L,52L,63L,96L,70L,84L,52L,66L,38L,108L,31L,80L,34L,44L,98L,120L,51L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175650Inst : IEnumerable<long>
{
public static readonly long[] Value=A175650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175650.Bytes);
public long this[int i]=>Value[i];

public static A175650Inst Instance=new A175650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175651
{
public static readonly long[] Value={ 7L,11L,22L,32L,55L,77L,111L,140L,147L,168L,175L,186L,189L,191L,242L,259L,284L,309L,363L,364L,365L,382L,391L,395L,399L,426L,455L,461L,519L,527L,538L,554L,604L,620L,639L,692L,719L,728L,745L,748L,805L,813L,861L,862L,873L,958L,964L,988L,991L,1037L,1109L,1122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175651Inst : IEnumerable<long>
{
public static readonly long[] Value=A175651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175651.Bytes);
public long this[int i]=>Value[i];

public static A175651Inst Instance=new A175651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175652
{
public static readonly long[] Value={ 9L,16L,36L,16L,25L,36L,49L,64L,49L,25L,25L,64L,36L,196L,16L,64L,100L,144L,36L,100L,144L,576L,49L,100L,36L,144L,49L,484L,196L,64L,289L,324L,169L,64L,81L,196L,729L,25L,529L,144L,81L,324L,484L,1296L,144L,625L,441L,100L,1024L,256L,1156L,1156L,1156L,121L,64L,144L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175652Inst : IEnumerable<long>
{
public static readonly long[] Value=A175652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175652.Bytes);
public long this[int i]=>Value[i];

public static A175652Inst Instance=new A175652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175653
{
public static readonly long[] Value={ 3L,4L,6L,4L,5L,6L,7L,8L,7L,5L,5L,8L,6L,14L,4L,8L,10L,12L,6L,10L,12L,24L,7L,10L,6L,12L,7L,22L,14L,8L,17L,18L,13L,8L,9L,14L,27L,5L,23L,12L,9L,18L,22L,36L,12L,25L,21L,10L,32L,16L,34L,34L,34L,11L,8L,12L,12L,37L,18L,10L,21L,22L,10L,12L,9L,8L,8L,41L,12L,13L,30L,43L,9L,30L,33L,10L,26L,8L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175653Inst : IEnumerable<long>
{
public static readonly long[] Value=A175653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175653.Bytes);
public long this[int i]=>Value[i];

public static A175653Inst Instance=new A175653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175654
{
public static readonly long[] Value={ 1L,2L,6L,14L,36L,86L,210L,500L,1194L,2822L,6660L,15638L,36642L,85604L,199626L,464630L,1079892L,2506550L,5811762L,13462484L,31159914L,72071654L,166599972L,384912086L,888906306L,2052031172L,4735527306L,10925175254L,25198866036L,58108609526L,133973643090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175654Inst : IEnumerable<long>
{
public static readonly long[] Value=A175654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175654.Bytes);
public long this[int i]=>Value[i];

public static A175654Inst Instance=new A175654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175655
{
public static readonly long[] Value={ 1L,4L,8L,22L,50L,124L,290L,694L,1628L,3838L,8978L,21004L,48962L,114022L,265004L,615262L,1426658L,3305212L,7650722L,17697430L,40911740L,94528318L,218312114L,503994220L,1163124866L,2683496134L,6189647948L,14273690782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175655Inst : IEnumerable<long>
{
public static readonly long[] Value=A175655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175655.Bytes);
public long this[int i]=>Value[i];

public static A175655Inst Instance=new A175655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175656
{
public static readonly long[] Value={ 1L,3L,6L,14L,30L,66L,142L,306L,654L,1394L,2958L,6258L,13198L,27762L,58254L,121970L,254862L,531570L,1106830L,2301042L,4776846L,9903218L,20505486L,42409074L,87614350L,180821106L,372827022L,768023666L,1580786574L,3251051634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175656Inst : IEnumerable<long>
{
public static readonly long[] Value=A175656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175656.Bytes);
public long this[int i]=>Value[i];

public static A175656Inst Instance=new A175656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175657
{
public static readonly long[] Value={ 1L,4L,8L,18L,38L,80L,166L,342L,700L,1426L,2894L,5856L,11822L,23822L,47932L,96330L,193414L,388048L,778070L,1559334L,3123836L,6256034L,12525598L,25073088L,50181598L,100420510L,200933756L,402017562L,804277910L,1608948656L,3218532934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175657Inst : IEnumerable<long>
{
public static readonly long[] Value=A175657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175657.Bytes);
public long this[int i]=>Value[i];

public static A175657Inst Instance=new A175657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175658
{
public static readonly long[] Value={ 1L,4L,10L,26L,66L,166L,414L,1026L,2530L,6214L,15214L,37154L,90546L,220294L,535230L,1298946L,3149506L,7630726L,18476494L,44714786L,108168210L,261575494L,632367774L,1528408194L,3693378466L,8923553734L,21557263150L,52071634466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175658Inst : IEnumerable<long>
{
public static readonly long[] Value=A175658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175658.Bytes);
public long this[int i]=>Value[i];

public static A175658Inst Instance=new A175658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175659
{
public static readonly long[] Value={ 1L,6L,16L,52L,156L,476L,1436L,4332L,13036L,39196L,117756L,353612L,1061516L,3185916L,9560476L,28686892L,86071596L,258236636L,774753596L,2324348172L,6973219276L,20920007356L,62760721116L,188283561452L,564853480556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175659Inst : IEnumerable<long>
{
public static readonly long[] Value=A175659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175659.Bytes);
public long this[int i]=>Value[i];

public static A175659Inst Instance=new A175659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175660
{
public static readonly long[] Value={ 1L,2L,7L,17L,40L,89L,193L,410L,859L,1781L,3664L,7493L,15253L,30938L,62575L,126281L,254392L,511745L,1028281L,2064314L,4141171L,8302637L,16638112L,33329357L,66744685L,133628474L,267482023L,535328225L,1071245704L,2143444841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175660Inst : IEnumerable<long>
{
public static readonly long[] Value=A175660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175660.Bytes);
public long this[int i]=>Value[i];

public static A175660Inst Instance=new A175660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175661
{
public static readonly long[] Value={ 1L,5L,10L,23L,49L,104L,217L,449L,922L,1883L,3829L,7760L,15685L,31637L,63706L,128111L,257353L,516536L,1036033L,2076857L,4161466L,8335475L,16691245L,33415328L,66883789L,133853549L,267846202L,535917479L,1072199137L,2144987528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175661Inst : IEnumerable<long>
{
public static readonly long[] Value=A175661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175661.Bytes);
public long this[int i]=>Value[i];

public static A175661Inst Instance=new A175661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175662
{
public static readonly long[] Value={ 83L,1493L,8598L,123195L,193812L,1156479L,1326972L,5453537L,22783052L,14120477L,78914972L,98903830L,69672945L,194745797L,483371646L,825367975L,382036554L,1550852585L,1492923061L,891424555L,3529278157L,3176100712L,6359190073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175662Inst : IEnumerable<long>
{
public static readonly long[] Value=A175662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175662.Bytes);
public long this[int i]=>Value[i];

public static A175662Inst Instance=new A175662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175663
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,1L,0L,0L,0L,4L,0L,1L,0L,0L,0L,5L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,9L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,6L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175663Inst : IEnumerable<long>
{
public static readonly long[] Value=A175663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175663.Bytes);
public long this[int i]=>Value[i];

public static A175663Inst Instance=new A175663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175664
{
public static readonly long[] Value={ 10L,14L,25L,26L,38L,39L,55L,62L,69L,86L,91L,95L,115L,119L,122L,123L,133L,145L,146L,159L,187L,205L,206L,209L,213L,217L,218L,219L,221L,253L,278L,291L,295L,299L,302L,303L,305L,309L,323L,327L,339L,362L,365L,381L,386L,395L,398L,407L,411L,415L,417L,451L,458L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175664Inst : IEnumerable<long>
{
public static readonly long[] Value=A175664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175664.Bytes);
public long this[int i]=>Value[i];

public static A175664Inst Instance=new A175664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175665
{
public static readonly long[] Value={ 1L,1L,4L,2L,1L,2L,9L,3L,2L,1L,2L,4L,2L,3L,16L,4L,3L,2L,2L,2L,1L,2L,3L,6L,2L,2L,2L,6L,3L,4L,25L,5L,4L,3L,3L,2L,2L,2L,3L,3L,2L,1L,2L,2L,2L,3L,4L,8L,3L,2L,4L,2L,2L,2L,3L,9L,3L,3L,3L,8L,4L,5L,36L,6L,5L,4L,4L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,3L,4L,4L,3L,2L,2L,2L,1L,2L,3L,3L,2L,2L,2L,3L,3L,4L,5L,10L,4L,3L,6L,2L,2L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175665Inst : IEnumerable<long>
{
public static readonly long[] Value=A175665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175665.Bytes);
public long this[int i]=>Value[i];

public static A175665Inst Instance=new A175665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175666
{
public static readonly long[] Value={ 7L,10L,16L,34L,70L,88L,124L,160L,250L,268L,340L,394L,520L,538L,574L,700L,718L,754L,844L,880L,1078L,1258L,1294L,1330L,1474L,1528L,1780L,1924L,1960L,1978L,2050L,2158L,2230L,2284L,2428L,2734L,2860L,3040L,3058L,3094L,3148L,3310L,3670L,3688L,3868L,4228L,4318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175666Inst : IEnumerable<long>
{
public static readonly long[] Value=A175666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175666.Bytes);
public long this[int i]=>Value[i];

public static A175666Inst Instance=new A175666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175667
{
public static readonly long[] Value={ 1L,5L,7L,34L,11L,13L,58L,17L,19L,55L,23L,65L,106L,29L,31L,85L,0L,37L,0L,41L,43L,115L,47L,119L,125L,53L,133L,145L,59L,61L,0L,388L,67L,274L,71L,73L,298L,0L,79L,187L,83L,203L,346L,89L,209L,235L,0L,97L,394L,101L,103L,169L,107L,109L,253L,113L,458L,295L,0L,287L,0L,0L,127L,514L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175667Inst : IEnumerable<long>
{
public static readonly long[] Value=A175667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175667.Bytes);
public long this[int i]=>Value[i];

public static A175667Inst Instance=new A175667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175668
{
public static readonly long[] Value={ 4L,11L,1L,12L,1L,16L,7L,7L,17L,5L,4L,20L,4L,3L,1L,10L,12L,1L,13L,28L,18L,1L,3L,4L,4L,1L,1L,2L,32L,25L,13L,4L,4L,3L,1L,2L,4L,14L,4L,12L,23L,3L,16L,5L,9L,3L,9L,4L,4L,2L,34L,7L,15L,9L,3L,4L,4L,4L,4L,4L,10L,4L,14L,4L,5L,24L,17L,43L,7L,38L,14L,4L,9L,1L,4L,4L,10L,4L,28L,4L,14L,4L,14L,4L,4L,10L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175668Inst : IEnumerable<long>
{
public static readonly long[] Value=A175668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175668.Bytes);
public long this[int i]=>Value[i];

public static A175668Inst Instance=new A175668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175669
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,20L,96L,155L,90L,5L,-6L,0L,280L,2772L,10518L,18711L,14385L,1323L,-2863L,-126L,360L,0L,2800L,47040L,323336L,1157760L,2238855L,2050020L,207158L,-810600L,-58505L,322740L,7956L,-45360L,0L,12320L,314160L,3409472L,20401128L,72418826L,150057435L,154651321L,12413874L,-101524412L,-6408765L,82588957L,3394248L,-37374084L,-546480L,5443200L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175669Inst : IEnumerable<long>
{
public static readonly long[] Value=A175669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175669.Bytes);
public long this[int i]=>Value[i];

public static A175669Inst Instance=new A175669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175670
{
public static readonly long[] Value={ 4L,8L,12L,16L,32L,48L,64L,128L,192L,256L,448L,512L,768L,1024L,2048L,3072L,4096L,8192L,12288L,16384L,28672L,32768L,49152L,65536L,131072L,196608L,262144L,524288L,786432L,1048576L,1835008L,2097152L,3145728L,4194304L,4980736L,8388608L,11534336L,12582912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175670Inst : IEnumerable<long>
{
public static readonly long[] Value=A175670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175670.Bytes);
public long this[int i]=>Value[i];

public static A175670Inst Instance=new A175670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175671
{
public static readonly BigInteger[] Value={ 1L,6L,20L,567L,3240L,155925L,8292375L,147349125L,312615903600L,103180488035625L,769328200265625L,316985199315159375L,8682638068197843750L,BigInteger.Parse("165206922515800790625"),BigInteger.Parse("527010082825404522093750"),BigInteger.Parse("39040543480476432234965625"),BigInteger.Parse("33712429605969723121012500000"),BigInteger.Parse("1968441947987203748028891796875") };
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
public class A175671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175671Inst Instance=new A175671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175672
{
public static readonly BigInteger[] Value={ 0L,24L,6096L,1548360L,393277344L,99890897016L,25371894564720L,6444361328541864L,1636842405555068736L,BigInteger.Parse("415751526649658917080"),BigInteger.Parse("105599250926607809869584"),BigInteger.Parse("26821793983831734047957256") };
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
public class A175672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175672Inst Instance=new A175672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175673
{
public static readonly long[] Value={ 0L,9L,36L,84L,126L,126L,84L,36L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175673Inst : IEnumerable<long>
{
public static readonly long[] Value=A175673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175673.Bytes);
public long this[int i]=>Value[i];

public static A175673Inst Instance=new A175673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175674
{
public static readonly long[] Value={ 19L,9L,8L,7L,6L,5L,4L,3L,2L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,0L,7L,6L,5L,4L,3L,2L,1L,0L,0L,0L,6L,5L,4L,3L,2L,1L,0L,0L,0L,0L,5L,4L,3L,2L,1L,0L,0L,0L,0L,0L,4L,3L,2L,1L,0L,0L,0L,0L,0L,0L,3L,2L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,8L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175674Inst : IEnumerable<long>
{
public static readonly long[] Value=A175674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175674.Bytes);
public long this[int i]=>Value[i];

public static A175674Inst Instance=new A175674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175675
{
public static readonly long[] Value={ 19L,9L,8L,7L,6L,5L,6L,7L,8L,9L,18L,17L,16L,15L,14L,15L,16L,17L,18L,19L,26L,25L,24L,23L,24L,25L,26L,27L,28L,29L,34L,33L,32L,33L,34L,35L,36L,37L,38L,39L,42L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175675Inst : IEnumerable<long>
{
public static readonly long[] Value=A175675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175675.Bytes);
public long this[int i]=>Value[i];

public static A175675Inst Instance=new A175675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175676
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,3L,0L,0L,4L,0L,0L,5L,0L,0L,6L,0L,0L,7L,0L,0L,8L,0L,0L,9L,0L,0L,10L,0L,0L,11L,0L,0L,12L,0L,0L,13L,0L,0L,14L,0L,0L,15L,0L,0L,16L,0L,0L,17L,0L,0L,18L,0L,0L,19L,0L,0L,20L,0L,0L,21L,0L,0L,22L,0L,0L,23L,0L,0L,24L,0L,0L,25L,0L,0L,26L,0L,0L,27L,0L,0L,28L,0L,0L,29L,0L,0L,30L,0L,0L,31L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175676Inst : IEnumerable<long>
{
public static readonly long[] Value=A175676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175676.Bytes);
public long this[int i]=>Value[i];

public static A175676Inst Instance=new A175676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175677
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,0L,6L,0L,0L,0L,3L,0L,7L,0L,12L,0L,0L,0L,5L,0L,11L,0L,18L,0L,0L,0L,7L,0L,15L,0L,24L,0L,0L,0L,9L,0L,19L,0L,30L,0L,0L,0L,11L,0L,23L,0L,36L,0L,0L,0L,13L,0L,27L,0L,42L,0L,0L,0L,15L,0L,31L,0L,48L,0L,0L,0L,17L,0L,35L,0L,54L,0L,0L,0L,19L,0L,39L,0L,60L,0L,0L,0L,21L,0L,43L,0L,66L,0L,0L,0L,23L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175677Inst : IEnumerable<long>
{
public static readonly long[] Value=A175677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175677.Bytes);
public long this[int i]=>Value[i];

public static A175677Inst Instance=new A175677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175678
{
public static readonly long[] Value={ 1L,6L,14L,20L,22L,30L,38L,42L,44L,46L,54L,56L,60L,62L,66L,68L,70L,78L,86L,92L,94L,96L,102L,110L,114L,116L,118L,126L,132L,134L,138L,140L,142L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175678Inst : IEnumerable<long>
{
public static readonly long[] Value=A175678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175678.Bytes);
public long this[int i]=>Value[i];

public static A175678Inst Instance=new A175678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175679
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,15L,17L,19L,21L,23L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,65L,67L,69L,71L,73L,77L,79L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,119L,123L,125L,127L,129L,131L,133L,135L,137L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175679Inst : IEnumerable<long>
{
public static readonly long[] Value=A175679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175679.Bytes);
public long this[int i]=>Value[i];

public static A175679Inst Instance=new A175679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175680
{
public static readonly long[] Value={ 4L,14L,26L,38L,46L,62L,74L,77L,86L,94L,95L,106L,121L,122L,134L,143L,146L,158L,161L,166L,178L,185L,194L,203L,206L,218L,221L,226L,254L,262L,278L,302L,314L,321L,326L,329L,334L,339L,341L,346L,362L,365L,371L,381L,386L,395L,398L,422L,437L,446L,451L,458L,466L,471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175680Inst : IEnumerable<long>
{
public static readonly long[] Value=A175680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175680.Bytes);
public long this[int i]=>Value[i];

public static A175680Inst Instance=new A175680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175681
{
public static readonly long[] Value={ 2L,2L,4L,3L,2L,3L,6L,4L,3L,2L,3L,4L,3L,4L,8L,5L,4L,3L,3L,3L,2L,3L,4L,5L,3L,3L,3L,5L,4L,5L,10L,6L,5L,4L,4L,3L,3L,3L,4L,4L,3L,2L,3L,3L,3L,4L,5L,6L,4L,3L,4L,3L,3L,3L,4L,6L,4L,4L,4L,6L,5L,6L,12L,7L,6L,5L,5L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,4L,5L,5L,4L,3L,3L,3L,2L,3L,4L,4L,3L,3L,3L,4L,4L,5L,6L,7L,5L,4L,5L,3L,3L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175681Inst : IEnumerable<long>
{
public static readonly long[] Value=A175681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175681.Bytes);
public long this[int i]=>Value[i];

public static A175681Inst Instance=new A175681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175682
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,4L,0L,0L,0L,4L,0L,3L,0L,0L,0L,5L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,9L,0L,4L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,6L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175682Inst : IEnumerable<long>
{
public static readonly long[] Value=A175682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175682.Bytes);
public long this[int i]=>Value[i];

public static A175682Inst Instance=new A175682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175683
{
public static readonly long[] Value={ 1L,43L,141L,720L,3038L,3466L,3772L,4068L,7896L,11402L,14070L,17499L,18683L,20887L,25166L,26586L,30311L,33237L,44072L,49791L,56629L,58268L,58764L,71483L,71953L,74284L,79939L,86022L,87199L,88941L,91951L,92273L,100176L,102019L,107505L,109438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175683Inst : IEnumerable<long>
{
public static readonly long[] Value=A175683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175683.Bytes);
public long this[int i]=>Value[i];

public static A175683Inst Instance=new A175683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175684
{
public static readonly long[] Value={ 11L,113L,13L,131L,31L,311L,1117L,17L,173L,73L,733L,331L,313L,137L,37L,373L,739L,397L,97L,971L,71L,719L,19L,191L,911L,1123L,23L,233L,337L,379L,79L,797L,977L,773L,7321L,211L,1129L,29L,293L,937L,3719L,193L,9311L,1151L,5113L,139L,3911L,1153L,53L,5323L,239L,3917L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175684Inst : IEnumerable<long>
{
public static readonly long[] Value=A175684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175684.Bytes);
public long this[int i]=>Value[i];

public static A175684Inst Instance=new A175684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175685
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,3L,2L,1L,1L,3L,4L,3L,2L,1L,1L,1L,7L,5L,3L,2L,1L,1L,4L,7L,8L,5L,3L,2L,1L,1L,1L,14L,12L,8L,5L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175685Inst : IEnumerable<long>
{
public static readonly long[] Value=A175685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175685.Bytes);
public long this[int i]=>Value[i];

public static A175685Inst Instance=new A175685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175686
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,7L,7L,14L,11L,25L,16L,41L,22L,63L,29L,92L,37L,129L,46L,175L,56L,231L,67L,298L,79L,377L,92L,469L,106L,575L,121L,696L,137L,833L,154L,987L,172L,1159L,191L,1350L,211L,1561L,232L,1793L,254L,2047L,277L,2324L,301L,2625L,326L,2951L,352L,3303L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175686Inst : IEnumerable<long>
{
public static readonly long[] Value=A175686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175686.Bytes);
public long this[int i]=>Value[i];

public static A175686Inst Instance=new A175686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175687
{
public static readonly long[] Value={ 113L,11311L,311L,3119L,1193L,193L,1931L,9311L,31121L,1213L,2131L,131L,1319L,3191L,191L,1913L,9133L,13309L,30911L,911L,91121L,1217L,2179L,179L,17903L,90313L,313L,3137L,137L,1373L,373L,3733L,733L,7331L,331L,3313L,31307L,307L,30703L,70309L,30931L,9319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175687Inst : IEnumerable<long>
{
public static readonly long[] Value=A175687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175687.Bytes);
public long this[int i]=>Value[i];

public static A175687Inst Instance=new A175687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175688
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,102L,111L,120L,123L,132L,135L,147L,153L,159L,174L,195L,201L,204L,210L,213L,222L,231L,234L,240L,243L,246L,258L,264L,285L,306L,312L,315L,321L,324L,333L,342L,345L,351L,354L,357L,360L,369L,375L,396L,402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175688Inst : IEnumerable<long>
{
public static readonly long[] Value=A175688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175688.Bytes);
public long this[int i]=>Value[i];

public static A175688Inst Instance=new A175688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175689
{
public static readonly long[] Value={ 16L,25L,36L,49L,256L,64L,576L,81L,196L,100L,2116L,121L,3136L,144L,1156L,169L,50176L,5184L,196L,2209L,9216L,225L,11236L,3249L,256L,43264L,30276L,289L,1296L,2304L,21316L,324L,24336L,35344L,4356L,361L,15376L,16384L,7396L,400L,38416L,17424L,42436L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175689Inst : IEnumerable<long>
{
public static readonly long[] Value=A175689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175689.Bytes);
public long this[int i]=>Value[i];

public static A175689Inst Instance=new A175689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175690
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,91L,0L,76L,901L,451L,61L,226L,901L,51L,901L,496L,901L,451L,3601L,826L,397L,1801L,701L,676L,2701L,3331L,18901L,12151L,0L,5851L,8281L,2776L,2701L,12601L,5101L,49996L,72901L,70951L,69301L,22726L,22221L,102151L,101701L,62476L,61201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175690Inst : IEnumerable<long>
{
public static readonly long[] Value=A175690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175690.Bytes);
public long this[int i]=>Value[i];

public static A175690Inst Instance=new A175690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175691
{
public static readonly long[] Value={ 125874L,1L,1782L,62937L,5436L,5175L,774L,891L,9L,512874L,74L,693L,6417L,5844L,54L,507069L,5295L,5445L,5015799L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175691Inst : IEnumerable<long>
{
public static readonly long[] Value=A175691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175691.Bytes);
public long this[int i]=>Value[i];

public static A175691Inst Instance=new A175691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175692
{
public static readonly long[] Value={ 1035L,1782L,1L,54L,36L,41958L,45L,9L,345L,351L,621L,594L,63L,693L,47619L,432L,495L,462L,369L,3582L,453L,35964L,33957L,37989L,36405L,349299L,363L,343224L,33382899L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175692Inst : IEnumerable<long>
{
public static readonly long[] Value=A175692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175692.Bytes);
public long this[int i]=>Value[i];

public static A175692Inst Instance=new A175692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175693
{
public static readonly long[] Value={ 1782L,62937L,54L,1L,2826L,891L,3L,269631L,324L,2718L,4311L,3681L,37L,387L,25974L,4401L,477L,45L,48L,256437L,3393L,37L,26523L,3465L,3252L,3699L,34623L,2922L,27972L,27L,271L,284787L,27324L,25971L,263223L,26973L,25974L,2579247L,2514744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175693Inst : IEnumerable<long>
{
public static readonly long[] Value=A175693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175693.Bytes);
public long this[int i]=>Value[i];

public static A175693Inst Instance=new A175693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175694
{
public static readonly long[] Value={ 142857L,5436L,36L,2826L,1L,9L,279L,252L,2439L,214857L,552L,3348L,27L,37L,207L,3573L,3L,3384L,27L,3564L,2439L,25371L,37L,2538L,34857L,2085L,2115L,31968L,21207L,2772L,2295L,2516L,24975L,237681L,2718L,212535L,21663L,21645L,2439L,227934L,2199L,219465L,2049768L,20478L,2178L,2002185L,208596L,2043792L,2031939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175694Inst : IEnumerable<long>
{
public static readonly long[] Value=A175694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175694.Bytes);
public long this[int i]=>Value[i];

public static A175694Inst Instance=new A175694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175695
{
public static readonly long[] Value={ 1386L,5175L,41958L,891L,9L,1L,693L,27L,594L,18L,594L,20979L,6183L,225L,1812L,45L,36L,1725L,2439L,1755L,258L,1728L,27L,297L,3933L,315L,3L,3078L,19359L,170958L,17424L,216L,248L,2475L,17586L,231L,2133L,1845L,2139L,1791L,198L,1948L,18981L,17982L,18L,17748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175695Inst : IEnumerable<long>
{
public static readonly long[] Value=A175695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175695.Bytes);
public long this[int i]=>Value[i];

public static A175695Inst Instance=new A175695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175696
{
public static readonly long[] Value={ 1359L,774L,45L,3L,279L,693L,1L,315L,18L,15L,261L,18L,495L,17982L,2475L,37L,189L,3519L,249L,3861L,3393L,42L,225L,4113L,37L,22581L,234L,2826L,2385L,2439L,165L,1791L,27L,15L,24975L,17838L,1668L,2556L,15129L,1728L,146655L,198L,14928L,162081L,146952L,17829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175696Inst : IEnumerable<long>
{
public static readonly long[] Value=A175696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175696.Bytes);
public long this[int i]=>Value[i];

public static A175696Inst Instance=new A175696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175697
{
public static readonly long[] Value={ 113967L,891L,9L,269631L,252L,27L,315L,1L,297L,1413L,147L,2259L,1386L,3L,288L,157338L,37L,162L,4491L,1359L,198L,17937L,18L,17307L,369L,37L,15858L,1935L,1428L,12987L,2349L,2229L,216L,2385L,1348L,225L,2241L,24L,2439L,196281L,21L,16965L,198L,185L,134262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175697Inst : IEnumerable<long>
{
public static readonly long[] Value=A175697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175697.Bytes);
public long this[int i]=>Value[i];

public static A175697Inst Instance=new A175697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175698
{
public static readonly long[] Value={ 1089L,9L,345L,324L,2439L,594L,18L,297L,1L,45L,198L,18L,11619L,2664L,12L,27L,1188L,13986L,423L,1557L,15L,15327L,30969L,3L,16245L,1215L,115L,1476L,2871L,117L,1197L,162L,207L,18L,17289L,198L,2466L,13455L,21L,1278L,1251L,231L,117L,198L,15873L,12285L,14094L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175698Inst : IEnumerable<long>
{
public static readonly long[] Value=A175698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175698.Bytes);
public long this[int i]=>Value[i];

public static A175698Inst Instance=new A175698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175699
{
public static readonly BigInteger[] Value={ 1L,2L,3L,16L,25L,1296L,49L,262144L,6561L,1000000L,14641L,61917364224L,28561L,56693912375296L,11390625L,4294967296L,6975757441L,BigInteger.Parse("121439531096594251776"),47045881L };
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
public class A175699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175699Inst Instance=new A175699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175700
{
public static readonly BigInteger[] Value={ 1L,4L,9L,256L,25L,46656L,2401L,262144L,6561L,10000000000L,14641L,8916100448256L,4826809L,1475789056L,2562890625L,BigInteger.Parse("18446744073709551616"),24137569L,BigInteger.Parse("39346408075296537575424"),16983563041L };
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
public class A175700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175700Inst Instance=new A175700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175701
{
public static readonly BigInteger[] Value={ 1L,4L,27L,64L,3125L,216L,823543L,32768L,4782969L,100000L,285311670611L,248832L,302875106592253L,105413504L,38443359375L,68719476736L,BigInteger.Parse("827240261886336764177"),612220032L,BigInteger.Parse("1978419655660313589123979") };
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
public class A175701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175701Inst Instance=new A175701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175702
{
public static readonly long[] Value={ 1L,-2L,-1L,4L,-3L,2L,-1L,-4L,9L,-2L,-5L,0L,1L,6L,3L,-8L,-3L,2L,7L,-4L,1L,-2L,-1L,12L,1L,-10L,-5L,-8L,13L,10L,-1L,-12L,1L,6L,3L,0L,-7L,6L,11L,-8L,-3L,-6L,-1L,-4L,-3L,2L,7L,12L,21L,-14L,-5L,-16L,-7L,22L,-5L,-8L,-3L,2L,19L,16L,-7L,-10L,7L,-4L,-3L,-22L,-9L,-12L,13L,10L,7L,12L,5L,10L,-9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175702Inst : IEnumerable<long>
{
public static readonly long[] Value=A175702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175702.Bytes);
public long this[int i]=>Value[i];

public static A175702Inst Instance=new A175702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175703
{
public static readonly long[] Value={ 1L,4L,10L,16L,27L,44L,72L,88L,105L,132L,194L,232L,259L,324L,464L,544L,593L,636L,862L,904L,999L,1092L,1500L,1576L,1689L,1852L,2210L,2192L,2307L,2460L,3184L,3256L,3613L,3596L,4830L,4304L,4455L,4860L,6220L,6264L,6193L,7372L,8314L,8560L,8047L,8724L,11076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175703Inst : IEnumerable<long>
{
public static readonly long[] Value=A175703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175703.Bytes);
public long this[int i]=>Value[i];

public static A175703Inst Instance=new A175703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175704
{
public static readonly long[] Value={ 0L,0L,4L,12L,17L,32L,54L,78L,95L,102L,149L,188L,213L,254L,360L,408L,463L,488L,617L,636L,769L,784L,1111L,1060L,1231L,1172L,1505L,1408L,1756L,1574L,1990L,2060L,2451L,2096L,3099L,2500L,2729L,2862L,3683L,3368L,4166L,3902L,4523L,4396L,4987L,4424L,6579L,5228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175704Inst : IEnumerable<long>
{
public static readonly long[] Value=A175704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175704.Bytes);
public long this[int i]=>Value[i];

public static A175704Inst Instance=new A175704Inst();

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