using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A059245
{
public static readonly long[] Value={ 53L,79L,131L,157L,313L,443L,521L,547L,599L,677L,859L,911L,937L,1093L,1171L,1223L,1249L,1301L,1327L,1483L,1613L,1847L,1873L,1951L,2003L,2029L,2081L,2237L,2341L,2393L,2549L,2731L,2861L,2887L,2939L,3121L,3251L,3329L,3407L,3433L,3511L,3719L,3797L,3823L,4057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059245Inst : IEnumerable<long>
{
public static readonly long[] Value=A059245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059245.Bytes);
public long this[int i]=>Value[i];

public static A059245Inst Instance=new A059245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059246
{
public static readonly long[] Value={ 1L,3L,5L,2L,2L,7L,16L,5L,23L,27L,29L,35L,37L,41L,3L,25L,52L,29L,60L,33L,10L,37L,76L,7L,87L,7L,95L,101L,103L,37L,113L,119L,41L,127L,131L,35L,142L,73L,50L,79L,160L,4L,170L,4L,182L,93L,4L,33L,201L,207L,211L,217L,219L,227L,21L,239L,81L,247L,249L,87L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059246Inst : IEnumerable<long>
{
public static readonly long[] Value=A059246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059246.Bytes);
public long this[int i]=>Value[i];

public static A059246Inst Instance=new A059246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059247
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,3L,7L,2L,9L,10L,11L,12L,13L,14L,1L,8L,17L,9L,19L,10L,3L,11L,23L,2L,25L,2L,27L,28L,29L,10L,31L,32L,11L,34L,35L,9L,37L,19L,13L,20L,41L,1L,43L,1L,45L,23L,1L,8L,49L,50L,51L,52L,53L,54L,5L,56L,19L,58L,59L,20L,61L,62L,3L,8L,65L,33L,67L,17L,69L,35L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059247Inst : IEnumerable<long>
{
public static readonly long[] Value=A059247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059247.Bytes);
public long this[int i]=>Value[i];

public static A059247Inst Instance=new A059247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059248
{
public static readonly BigInteger[] Value={ 1L,2L,5L,17L,91L,379L,5047L,35849L,614893L,6800951L,607326679L,3651532639L,851897554247L,24724573280923L,301787157353771L,14188276949397301L,BigInteger.Parse("22662903194758542865"),BigInteger.Parse("430644772287132696121"),BigInteger.Parse("1800653989272587268758525") };
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
public class A059248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059248Inst Instance=new A059248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059249
{
public static readonly long[] Value={ 1L,0L,5L,7L,6L,2L,4L,3L,17L,19L,18L,23L,25L,24L,20L,22L,21L,8L,10L,9L,14L,16L,15L,11L,13L,12L,53L,55L,54L,59L,61L,60L,56L,58L,57L,71L,73L,72L,77L,79L,78L,74L,76L,75L,62L,64L,63L,68L,70L,69L,65L,67L,66L,26L,28L,27L,32L,34L,33L,29L,31L,30L,44L,46L,45L,50L,52L,51L,47L,49L,48L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059249Inst : IEnumerable<long>
{
public static readonly long[] Value=A059249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059249.Bytes);
public long this[int i]=>Value[i];

public static A059249Inst Instance=new A059249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059250
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,2L,4L,6L,1L,2L,4L,8L,8L,1L,2L,4L,8L,14L,10L,1L,2L,4L,8L,16L,22L,12L,1L,2L,4L,8L,16L,30L,32L,14L,1L,2L,4L,8L,16L,32L,52L,44L,16L,1L,2L,4L,8L,16L,32L,62L,84L,58L,18L,1L,2L,4L,8L,16L,32L,64L,114L,128L,74L,20L,1L,2L,4L,8L,16L,32L,64L,126L,198L,186L,92L,22L,1L,2L,4L,8L,16L,32L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059250Inst : IEnumerable<long>
{
public static readonly long[] Value=A059250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059250.Bytes);
public long this[int i]=>Value[i];

public static A059250Inst Instance=new A059250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059251
{
public static readonly long[] Value={ 1L,1L,5L,15L,44L,99L,217L,429L,811L,1430L,2438L,3978L,6312L,9690L,14550L,21318L,30669L,43263L,60115L,82225L,111044L,148005L,195143L,254475L,328759L,420732L,534076L,672452L,840656L,1043460L,1287036L,1577532L,1922745L,2330445L,2810385L,3372291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059251Inst : IEnumerable<long>
{
public static readonly long[] Value=A059251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059251.Bytes);
public long this[int i]=>Value[i];

public static A059251Inst Instance=new A059251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059252
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,3L,2L,2L,3L,3L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,2L,2L,3L,3L,3L,2L,2L,3L,4L,5L,5L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,6L,6L,7L,7L,7L,6L,6L,5L,4L,4L,5L,5L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,8L,8L,8L,9L,9L,10L,10L,11L,11L,11L,10L,10L,11L,12L,12L,13L,13L,14L,15L,15L,14L,14L,15L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059252Inst : IEnumerable<long>
{
public static readonly long[] Value=A059252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059252.Bytes);
public long this[int i]=>Value[i];

public static A059252Inst Instance=new A059252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059253
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,1L,1L,2L,2L,3L,3L,3L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,6L,6L,7L,7L,6L,5L,5L,4L,4L,4L,4L,5L,5L,6L,7L,7L,6L,6L,7L,7L,6L,5L,5L,4L,4L,3L,2L,2L,3L,3L,3L,2L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,2L,3L,3L,2L,2L,3L,3L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,2L,2L,3L,3L,3L,2L,2L,3L,4L,5L,5L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059253Inst : IEnumerable<long>
{
public static readonly long[] Value=A059253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059253.Bytes);
public long this[int i]=>Value[i];

public static A059253Inst Instance=new A059253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059254
{
public static readonly long[] Value={ 2L,4L,6L,10L,14L,18L,22L,32L,42L,52L,66L,82L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059254Inst : IEnumerable<long>
{
public static readonly long[] Value=A059254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059254.Bytes);
public long this[int i]=>Value[i];

public static A059254Inst Instance=new A059254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059255
{
public static readonly long[] Value={ 0L,25L,365L,2030L,7230L,19855L,45955L,94220L,176460L,308085L,508585L,802010L,1217450L,1789515L,2558815L,3572440L,4884440L,6556305L,8657445L,11265670L,14467670L,18359495L,23047035L,28646500L,35284900L,43100525L,52243425L,62875890L,75172930L,89322755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059255Inst : IEnumerable<long>
{
public static readonly long[] Value=A059255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059255.Bytes);
public long this[int i]=>Value[i];

public static A059255Inst Instance=new A059255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059256
{
public static readonly long[] Value={ 59L,233L,349L,523L,929L,1103L,1277L,1451L,1567L,1741L,1973L,2089L,2437L,2843L,3307L,3539L,4003L,4177L,4409L,4583L,4931L,5279L,5569L,5743L,5801L,6091L,6323L,6961L,7019L,7193L,7309L,7541L,8179L,8237L,8353L,8527L,8933L,9049L,9281L,9397L,9629L,9803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059256Inst : IEnumerable<long>
{
public static readonly long[] Value=A059256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059256.Bytes);
public long this[int i]=>Value[i];

public static A059256Inst Instance=new A059256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059257
{
public static readonly long[] Value={ 283L,659L,941L,1129L,1223L,1693L,1787L,2069L,2351L,2539L,2633L,3761L,4231L,4513L,4889L,5077L,5171L,5641L,5923L,6299L,6581L,6863L,7333L,8179L,8273L,8461L,8837L,9871L,10247L,10529L,11093L,11657L,11939L,12409L,12503L,12973L,13537L,13913L,14759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059257Inst : IEnumerable<long>
{
public static readonly long[] Value=A059257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059257.Bytes);
public long this[int i]=>Value[i];

public static A059257Inst Instance=new A059257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059258
{
public static readonly long[] Value={ 107L,743L,1061L,1697L,2333L,2969L,3181L,3499L,3923L,4241L,4877L,5407L,6043L,6361L,6679L,6997L,7103L,7951L,8269L,8693L,9011L,9859L,10177L,10601L,11131L,12721L,13463L,13781L,14629L,14947L,15053L,15583L,15901L,16007L,17491L,17597L,18127L,18233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059258Inst : IEnumerable<long>
{
public static readonly long[] Value=A059258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059258.Bytes);
public long this[int i]=>Value[i];

public static A059258Inst Instance=new A059258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059259
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,2L,0L,1L,3L,4L,2L,1L,1L,4L,7L,6L,3L,0L,1L,5L,11L,13L,9L,3L,1L,1L,6L,16L,24L,22L,12L,4L,0L,1L,7L,22L,40L,46L,34L,16L,4L,1L,1L,8L,29L,62L,86L,80L,50L,20L,5L,0L,1L,9L,37L,91L,148L,166L,130L,70L,25L,5L,1L,1L,10L,46L,128L,239L,314L,296L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059259Inst : IEnumerable<long>
{
public static readonly long[] Value=A059259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059259.Bytes);
public long this[int i]=>Value[i];

public static A059259Inst Instance=new A059259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059260
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,2L,2L,1L,1L,2L,4L,3L,1L,0L,3L,6L,7L,4L,1L,1L,3L,9L,13L,11L,5L,1L,0L,4L,12L,22L,24L,16L,6L,1L,1L,4L,16L,34L,46L,40L,22L,7L,1L,0L,5L,20L,50L,80L,86L,62L,29L,8L,1L,1L,5L,25L,70L,130L,166L,148L,91L,37L,9L,1L,0L,6L,30L,95L,200L,296L,314L,239L,128L,46L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059260Inst : IEnumerable<long>
{
public static readonly long[] Value=A059260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059260.Bytes);
public long this[int i]=>Value[i];

public static A059260Inst Instance=new A059260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059261
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,4L,3L,4L,5L,6L,5L,4L,3L,2L,3L,4L,5L,6L,5L,6L,7L,8L,7L,8L,9L,10L,9L,8L,7L,6L,7L,8L,9L,10L,9L,10L,11L,12L,11L,12L,13L,14L,13L,12L,11L,10L,11L,10L,9L,8L,9L,8L,7L,6L,7L,6L,5L,4L,5L,6L,7L,8L,7L,8L,9L,10L,9L,10L,11L,12L,11L,12L,13L,14L,13L,12L,11L,10L,11L,12L,13L,14L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059261Inst : IEnumerable<long>
{
public static readonly long[] Value=A059261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059261.Bytes);
public long this[int i]=>Value[i];

public static A059261Inst Instance=new A059261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059262
{
public static readonly long[] Value={ 7L,13L,19L,37L,61L,67L,73L,79L,97L,103L,109L,139L,151L,163L,181L,193L,199L,211L,241L,271L,307L,313L,331L,337L,349L,367L,373L,379L,409L,421L,433L,463L,487L,523L,541L,547L,571L,577L,607L,613L,619L,631L,661L,673L,709L,739L,751L,757L,769L,787L,811L,823L,829L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059262Inst : IEnumerable<long>
{
public static readonly long[] Value=A059262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059262.Bytes);
public long this[int i]=>Value[i];

public static A059262Inst Instance=new A059262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059263
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,29L,31L,37L,41L,43L,53L,59L,61L,67L,71L,83L,101L,107L,109L,131L,139L,149L,157L,163L,173L,179L,181L,191L,197L,211L,227L,229L,251L,269L,271L,277L,281L,283L,293L,307L,311L,317L,331L,347L,349L,373L,379L,389L,397L,401L,419L,421L,443L,461L,467L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059263Inst : IEnumerable<long>
{
public static readonly long[] Value=A059263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059263.Bytes);
public long this[int i]=>Value[i];

public static A059263Inst Instance=new A059263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059264
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,37L,41L,43L,53L,59L,61L,67L,73L,79L,83L,97L,101L,103L,107L,109L,131L,137L,139L,149L,151L,157L,163L,173L,179L,181L,193L,197L,199L,211L,227L,229L,241L,251L,269L,271L,277L,283L,293L,307L,313L,317L,331L,337L,347L,349L,367L,373L,379L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059264Inst : IEnumerable<long>
{
public static readonly long[] Value=A059264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059264.Bytes);
public long this[int i]=>Value[i];

public static A059264Inst Instance=new A059264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059265
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,29L,37L,43L,53L,59L,61L,67L,71L,83L,101L,107L,109L,113L,127L,131L,139L,149L,157L,163L,173L,179L,181L,197L,211L,227L,229L,239L,251L,269L,277L,281L,283L,293L,307L,317L,331L,337L,347L,349L,373L,379L,389L,397L,419L,421L,443L,449L,461L,463L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059265Inst : IEnumerable<long>
{
public static readonly long[] Value=A059265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059265.Bytes);
public long this[int i]=>Value[i];

public static A059265Inst Instance=new A059265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059266
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,47L,58L,61L,75L,87L,133L,168L,226L,347L,425L,868L,1977L,2815L,3378L,4385L,5286L,7057L,7200L,8230L,8340L,13175L,17226L,18276L,25237L,33211L,58463L,59662L,94555L,120502L,177473L,197017L,351097L,375370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059266Inst : IEnumerable<long>
{
public static readonly long[] Value=A059266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059266.Bytes);
public long this[int i]=>Value[i];

public static A059266Inst Instance=new A059266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059267
{
public static readonly long[] Value={ 3L,4L,6L,8L,9L,12L,15L,16L,18L,20L,21L,24L,27L,28L,30L,32L,33L,35L,36L,39L,40L,42L,44L,45L,48L,51L,52L,54L,56L,57L,60L,63L,64L,66L,68L,69L,70L,72L,75L,76L,78L,80L,81L,84L,87L,88L,90L,92L,93L,96L,99L,100L,102L,104L,105L,108L,111L,112L,114L,116L,117L,120L,123L,124L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059267Inst : IEnumerable<long>
{
public static readonly long[] Value=A059267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059267.Bytes);
public long this[int i]=>Value[i];

public static A059267Inst Instance=new A059267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059268
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,2L,4L,8L,1L,2L,4L,8L,16L,1L,2L,4L,8L,16L,32L,1L,2L,4L,8L,16L,32L,64L,1L,2L,4L,8L,16L,32L,64L,128L,1L,2L,4L,8L,16L,32L,64L,128L,256L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,1L,2L,4L,8L,16L,32L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059268Inst : IEnumerable<long>
{
public static readonly long[] Value=A059268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059268.Bytes);
public long this[int i]=>Value[i];

public static A059268Inst Instance=new A059268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059269
{
public static readonly long[] Value={ 4L,9L,12L,18L,20L,25L,28L,32L,36L,44L,45L,49L,50L,52L,60L,63L,68L,72L,75L,76L,84L,90L,92L,96L,98L,99L,100L,108L,116L,117L,121L,124L,126L,132L,140L,144L,147L,148L,150L,153L,156L,160L,164L,169L,171L,172L,175L,180L,188L,196L,198L,200L,204L,207L,212L,220L,224L,225L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059269Inst : IEnumerable<long>
{
public static readonly long[] Value=A059269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059269.Bytes);
public long this[int i]=>Value[i];

public static A059269Inst Instance=new A059269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059270
{
public static readonly long[] Value={ 0L,3L,15L,42L,90L,165L,273L,420L,612L,855L,1155L,1518L,1950L,2457L,3045L,3720L,4488L,5355L,6327L,7410L,8610L,9933L,11385L,12972L,14700L,16575L,18603L,20790L,23142L,25665L,28365L,31248L,34320L,37587L,41055L,44730L,48618L,52725L,57057L,61620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059270Inst : IEnumerable<long>
{
public static readonly long[] Value=A059270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059270.Bytes);
public long this[int i]=>Value[i];

public static A059270Inst Instance=new A059270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059271
{
public static readonly long[] Value={ 0L,1L,3L,15L,82L,485L,3039L,19862L,133969L,925805L,6521690L,46658955L,338115321L,2476585674L,18306446887L,136384608971L,1023041170426L,7720127405881L,58567844563843L,446422706023630L,3417223098702669L,26257867836211825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059271Inst : IEnumerable<long>
{
public static readonly long[] Value=A059271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059271.Bytes);
public long this[int i]=>Value[i];

public static A059271Inst Instance=new A059271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059272
{
public static readonly long[] Value={ 0L,1L,2L,9L,47L,272L,1685L,10939L,73462L,506111L,3557109L,25404296L,183834627L,1344987117L,9932411282L,73937697965L,554234827675L,4179895359240L,31693701617841L,241467983156655L,1847602171074502L,14191725625366331L,109390959408760713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059272Inst : IEnumerable<long>
{
public static readonly long[] Value=A059272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059272.Bytes);
public long this[int i]=>Value[i];

public static A059272Inst Instance=new A059272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059273
{
public static readonly long[] Value={ 0L,0L,1L,5L,30L,186L,1197L,7953L,54233L,377697L,2676006L,19230738L,139850889L,1027326257L,7612046713L,56825410753L,426995181354L,3227048864886L,24513726327089L,187067287095441L,1433409279614225L,11024386107439141L,85075022074507194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059273Inst : IEnumerable<long>
{
public static readonly long[] Value=A059273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059273.Bytes);
public long this[int i]=>Value[i];

public static A059273Inst Instance=new A059273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059274
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,8L,1L,11L,28L,39L,1L,23L,80L,164L,214L,1L,47L,208L,548L,1010L,1274L,1L,95L,512L,1632L,3744L,6490L,8028L,1L,191L,1216L,4528L,12248L,25868L,43132L,52698L,1L,383L,2816L,11968L,37024L,90624L,181272L,294366L,356630L,1L,767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059274Inst : IEnumerable<long>
{
public static readonly long[] Value=A059274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059274.Bytes);
public long this[int i]=>Value[i];

public static A059274Inst Instance=new A059274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059275
{
public static readonly long[] Value={ 1L,2L,8L,39L,214L,1274L,8028L,52698L,356630L,2470848L,17440690L,124981126L,906887612L,6650054278L,49202240010L,366856871768L,2753772204894L,20793368929970L,157831516488476L,1203618076715682L,9217256564429454L,70852472349915280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059275Inst : IEnumerable<long>
{
public static readonly long[] Value=A059275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059275.Bytes);
public long this[int i]=>Value[i];

public static A059275Inst Instance=new A059275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059276
{
public static readonly long[] Value={ 1L,3L,14L,79L,482L,3088L,20502L,139882L,975084L,6915354L,49742974L,362054512L,2661657346L,19735338206L,147418892116L,1108339796742L,8380510594346L,63689530713888L,486218971691294L,3727035449588930L,28674306373680492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059276Inst : IEnumerable<long>
{
public static readonly long[] Value=A059276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059276.Bytes);
public long this[int i]=>Value[i];

public static A059276Inst Instance=new A059276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059277
{
public static readonly long[] Value={ 1L,33554432L,43046721L,162144L,625L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059277Inst : IEnumerable<long>
{
public static readonly long[] Value=A059277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059277.Bytes);
public long this[int i]=>Value[i];

public static A059277Inst Instance=new A059277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059278
{
public static readonly long[] Value={ 1L,1L,3L,11L,43L,175L,735L,3167L,13935L,62383L,283311L,1302271L,6047679L,28332991L,133752191L,635618431L,3038326911L,14599154431L,70474889471L,341624867071L,1662254107391L,8115717976831L,39747223425791L,195219110182911L,961330824858623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059278Inst : IEnumerable<long>
{
public static readonly long[] Value=A059278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059278.Bytes);
public long this[int i]=>Value[i];

public static A059278Inst Instance=new A059278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059279
{
public static readonly long[] Value={ 1L,2L,6L,20L,72L,276L,1112L,4656L,20080L,88608L,398144L,1815248L,8375904L,39037120L,183493440L,868853120L,4140414720L,19841656960L,95559048960L,462268075520L,2245165391360L,10943794652160L,53519094753280L,262510076263680L,1291131867203072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059279Inst : IEnumerable<long>
{
public static readonly long[] Value=A059279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059279.Bytes);
public long this[int i]=>Value[i];

public static A059279Inst Instance=new A059279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059280
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,169L,1881L,25051L,388123L,6854289L,135847729L,2984843251L,71990208291L,1890448291513L,53681369925769L,1638782161569099L,53515590723668011L,1861256728947455521L,BigInteger.Parse("68680836821259109473"),BigInteger.Parse("2679760172141508857059") };
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
public class A059280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059280Inst Instance=new A059280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059281
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,605L,7086L,98797L,1595924L,29284089L,601272730L,13651820561L,339496984872L,9174493428949L,267642371288774L,8381229378694005L,280370739660951676L,9976870946519220977UL,BigInteger.Parse("376253084610805878834"),BigInteger.Parse("14988616155347856524569") };
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
public class A059281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059281Inst Instance=new A059281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059282
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,3L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,2L,2L,0L,1L,1L,0L,1L,1L,3L,1L,0L,0L,2L,1L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,1L,1L,0L,0L,1L,0L,3L,0L,0L,6L,0L,0L,0L,0L,0L,0L,4L,0L,1L,0L,0L,3L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,3L,1L,3L,1L,3L,0L,0L,0L,0L,2L,0L,0L,3L,1L,0L,0L,1L,1L,0L,1L,4L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,2L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059282Inst : IEnumerable<long>
{
public static readonly long[] Value=A059282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059282.Bytes);
public long this[int i]=>Value[i];

public static A059282Inst Instance=new A059282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059283
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,3L,0L,2L,8L,11L,0L,2L,14L,36L,47L,0L,2L,20L,78L,172L,219L,0L,2L,26L,138L,424L,862L,1081L,0L,2L,32L,216L,856L,2314L,4476L,5557L,0L,2L,38L,312L,1522L,5116L,12768L,23882L,29439L,0L,2L,44L,426L,2476L,9970L,30168L,71294L,130172L,159611L,0L,2L,50L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059283Inst : IEnumerable<long>
{
public static readonly long[] Value=A059283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059283.Bytes);
public long this[int i]=>Value[i];

public static A059283Inst Instance=new A059283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059284
{
public static readonly long[] Value={ 1L,1L,3L,11L,47L,219L,1081L,5557L,29439L,159611L,881405L,4940385L,28035205L,160751005L,929923395L,5420717819L,31809479855L,187757573787L,1114012352029L,6640357243537L,39746256802185L,238796968208537L,1439587364576015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059284Inst : IEnumerable<long>
{
public static readonly long[] Value=A059284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059284.Bytes);
public long this[int i]=>Value[i];

public static A059284Inst Instance=new A059284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059285
{
public static readonly long[] Value={ 0L,1L,0L,-1L,-2L,-3L,-2L,-1L,0L,-1L,0L,1L,2L,1L,2L,3L,4L,3L,4L,5L,6L,7L,6L,5L,4L,5L,4L,3L,2L,3L,2L,1L,0L,-1L,0L,1L,2L,3L,2L,1L,0L,1L,0L,-1L,-2L,-1L,-2L,-3L,-4L,-5L,-4L,-3L,-2L,-1L,-2L,-3L,-4L,-3L,-4L,-5L,-6L,-5L,-6L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059285Inst : IEnumerable<long>
{
public static readonly long[] Value=A059285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059285.Bytes);
public long this[int i]=>Value[i];

public static A059285Inst Instance=new A059285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059286
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,2L,6L,0L,0L,0L,0L,12L,24L,0L,0L,0L,0L,6L,72L,120L,0L,0L,0L,0L,0L,72L,480L,720L,0L,0L,0L,0L,0L,24L,720L,3600L,5040L,0L,0L,0L,0L,0L,0L,480L,7200L,30240L,40320L,0L,0L,0L,0L,0L,0L,120L,7200L,75600L,282240L,362880L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059286Inst : IEnumerable<long>
{
public static readonly long[] Value=A059286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059286.Bytes);
public long this[int i]=>Value[i];

public static A059286Inst Instance=new A059286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059287
{
public static readonly long[] Value={ 1217L,1249L,1553L,1777L,2833L,4049L,4273L,4481L,4993L,5297L,6449L,6481L,6689L,7121L,8081L,8609L,9137L,9281L,9649L,10337L,10369L,10433L,11329L,11617L,11633L,12241L,12577L,13121L,13441L,13633L,14321L,14753L,15121L,15569L,16417L,16433L,16673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059287Inst : IEnumerable<long>
{
public static readonly long[] Value=A059287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059287.Bytes);
public long this[int i]=>Value[i];

public static A059287Inst Instance=new A059287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059288
{
public static readonly long[] Value={ 0L,0L,2L,2L,2L,0L,2L,6L,2L,6L,2L,4L,2L,6L,0L,6L,2L,6L,2L,0L,6L,6L,2L,12L,2L,6L,20L,0L,2L,4L,2L,6L,9L,6L,7L,16L,2L,6L,20L,20L,2L,0L,2L,4L,0L,6L,2L,12L,2L,6L,3L,44L,2L,6L,32L,32L,39L,6L,2L,36L,2L,6L,12L,6L,5L,0L,2L,36L,66L,40L,2L,36L,2L,6L,45L,32L,0L,66L,2L,20L,20L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059288Inst : IEnumerable<long>
{
public static readonly long[] Value=A059288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059288.Bytes);
public long this[int i]=>Value[i];

public static A059288Inst Instance=new A059288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059289
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,1L,3L,7L,3L,7L,3L,5L,3L,7L,1L,7L,3L,7L,3L,1L,7L,7L,3L,13L,3L,7L,21L,1L,3L,5L,3L,7L,10L,7L,8L,17L,3L,7L,21L,21L,3L,1L,3L,5L,1L,7L,3L,13L,3L,7L,4L,45L,3L,7L,33L,33L,40L,7L,3L,37L,3L,7L,13L,7L,6L,1L,3L,37L,67L,41L,3L,37L,3L,7L,46L,33L,1L,67L,3L,21L,21L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059289Inst : IEnumerable<long>
{
public static readonly long[] Value=A059289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059289.Bytes);
public long this[int i]=>Value[i];

public static A059289Inst Instance=new A059289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059290
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,5L,7L,9L,12L,15L,19L,23L,28L,34L,40L,47L,55L,64L,74L,84L,96L,108L,122L,136L,152L,169L,187L,206L,227L,249L,272L,297L,323L,351L,380L,411L,444L,478L,514L,551L,591L,632L,675L,720L,767L,816L,867L,920L,975L,1033L,1092L,1154L,1218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059290Inst : IEnumerable<long>
{
public static readonly long[] Value=A059290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059290.Bytes);
public long this[int i]=>Value[i];

public static A059290Inst Instance=new A059290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059291
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,4L,6L,8L,11L,14L,18L,22L,27L,33L,39L,46L,54L,63L,72L,83L,94L,107L,120L,135L,150L,167L,185L,204L,225L,247L,270L,295L,321L,349L,378L,409L,441L,475L,511L,549L,588L,629L,672L,717L,764L,813L,864L,917L,972L,1030L,1089L,1151L,1215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059291Inst : IEnumerable<long>
{
public static readonly long[] Value=A059291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059291.Bytes);
public long this[int i]=>Value[i];

public static A059291Inst Instance=new A059291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059292
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,4L,7L,6L,8L,8L,11L,8L,13L,12L,13L,13L,17L,14L,19L,16L,19L,20L,23L,18L,24L,24L,25L,24L,29L,24L,31L,28L,31L,32L,33L,29L,37L,36L,37L,34L,41L,36L,43L,40L,41L,44L,47L,40L,48L,46L,49L,48L,53L,48L,53L,50L,55L,56L,59L,50L,61L,60L,59L,59L,63L,60L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059292Inst : IEnumerable<long>
{
public static readonly long[] Value=A059292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059292.Bytes);
public long this[int i]=>Value[i];

public static A059292Inst Instance=new A059292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059293
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,6L,9L,13L,18L,24L,31L,39L,47L,56L,66L,77L,89L,102L,115L,129L,144L,160L,177L,195L,213L,232L,252L,273L,295L,318L,341L,365L,390L,416L,443L,471L,499L,528L,558L,589L,621L,654L,687L,721L,756L,792L,829L,867L,905L,944L,984L,1025L,1067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059293Inst : IEnumerable<long>
{
public static readonly long[] Value=A059293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059293.Bytes);
public long this[int i]=>Value[i];

public static A059293Inst Instance=new A059293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059294
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,13L,73L,505L,4143L,39313L,423401L,5101785L,67994611L,993048765L,15770916657L,270586214481L,4987678532991L,98297729816321L,2062591323728689L,45908909743929681L,1080350557160580163L,BigInteger.Parse("26800186367114537613"),BigInteger.Parse("698982753383076195897") };
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
public class A059294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059294Inst Instance=new A059294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059295
{
public static readonly BigInteger[] Value={ 1L,2L,5L,16L,69L,386L,2665L,21856L,207369L,2233346L,26910637L,358654640L,5238083085L,83187634306L,1427274447313L,26308754113344L,518495885082513L,10879652226044546L,242157991346605909L,5698578388375932368L,BigInteger.Parse("141364265347273219925"),BigInteger.Parse("3686958817004484491522") };
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
public class A059295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059295Inst Instance=new A059295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059296
{
public static readonly BigInteger[] Value={ 0L,1L,3L,7L,31L,173L,1199L,9831L,93303L,1004817L,12107795L,161367055L,2356740567L,37428107645L,642165083775L,11836940014639L,233283750994767L,4895016784086017L,108952695421053699L,2563927258693534391L,BigInteger.Parse("63603177623431960239"),BigInteger.Parse("1658851308207579983341") };
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
public class A059296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059296Inst Instance=new A059296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059297
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,3L,6L,1L,0L,4L,24L,12L,1L,0L,5L,80L,90L,20L,1L,0L,6L,240L,540L,240L,30L,1L,0L,7L,672L,2835L,2240L,525L,42L,1L,0L,8L,1792L,13608L,17920L,7000L,1008L,56L,1L,0L,9L,4608L,61236L,129024L,78750L,18144L,1764L,72L,1L,0L,10L,11520L,262440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059297Inst : IEnumerable<long>
{
public static readonly long[] Value=A059297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059297.Bytes);
public long this[int i]=>Value[i];

public static A059297Inst Instance=new A059297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059298
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,1L,4L,24L,12L,1L,5L,80L,90L,20L,1L,6L,240L,540L,240L,30L,1L,7L,672L,2835L,2240L,525L,42L,1L,8L,1792L,13608L,17920L,7000L,1008L,56L,1L,9L,4608L,61236L,129024L,78750L,18144L,1764L,72L,1L,10L,11520L,262440L,860160L,787500L,272160L,41160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059298Inst : IEnumerable<long>
{
public static readonly long[] Value=A059298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059298.Bytes);
public long this[int i]=>Value[i];

public static A059298Inst Instance=new A059298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059299
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,6L,3L,0L,1L,12L,24L,4L,0L,1L,20L,90L,80L,5L,0L,1L,30L,240L,540L,240L,6L,0L,1L,42L,525L,2240L,2835L,672L,7L,0L,1L,56L,1008L,7000L,17920L,13608L,1792L,8L,0L,1L,72L,1764L,18144L,78750L,129024L,61236L,4608L,9L,0L,1L,90L,2880L,41160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059299Inst : IEnumerable<long>
{
public static readonly long[] Value=A059299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059299.Bytes);
public long this[int i]=>Value[i];

public static A059299Inst Instance=new A059299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059300
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,3L,1L,12L,24L,4L,1L,20L,90L,80L,5L,1L,30L,240L,540L,240L,6L,1L,42L,525L,2240L,2835L,672L,7L,1L,56L,1008L,7000L,17920L,13608L,1792L,8L,1L,72L,1764L,18144L,78750L,129024L,61236L,4608L,9L,1L,90L,2880L,41160L,272160L,787500L,860160L,262440L,11520L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059300Inst : IEnumerable<long>
{
public static readonly long[] Value=A059300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059300.Bytes);
public long this[int i]=>Value[i];

public static A059300Inst Instance=new A059300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059301
{
public static readonly BigInteger[] Value={ 1L,5L,31L,569L,165211L,12885396101L,BigInteger.Parse("64563604303081738807"),BigInteger.Parse("1361129467683753854111752846879267953905"),BigInteger.Parse("521064401567922879406069432539095585345840013599959430520674634220747299433267") };
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
public class A059301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059301Inst Instance=new A059301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059302
{
public static readonly long[] Value={ -1L,-1L,5L,25L,70L,154L,294L,510L,825L,1265L,1859L,2639L,3640L,4900L,6460L,8364L,10659L,13395L,16625L,20405L,24794L,29854L,35650L,42250L,49725L,58149L,67599L,78155L,89900L,102920L,117304L,133144L,150535L,169575L,190365L,213009L,237614L,264290L,293150L,324310L,357889L,394009L,432795L,474375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059302Inst : IEnumerable<long>
{
public static readonly long[] Value=A059302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059302.Bytes);
public long this[int i]=>Value[i];

public static A059302Inst Instance=new A059302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059303
{
public static readonly long[] Value={ 0L,1L,5L,7L,10L,105L,22959L,34888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059303Inst : IEnumerable<long>
{
public static readonly long[] Value=A059303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059303.Bytes);
public long this[int i]=>Value[i];

public static A059303Inst Instance=new A059303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059304
{
public static readonly long[] Value={ 1L,4L,24L,160L,1120L,8064L,59136L,439296L,3294720L,24893440L,189190144L,1444724736L,11076222976L,85201715200L,657270374400L,5082890895360L,39392404439040L,305870434467840L,2378992268083200L,18531097667174400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059304Inst : IEnumerable<long>
{
public static readonly long[] Value=A059304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059304.Bytes);
public long this[int i]=>Value[i];

public static A059304Inst Instance=new A059304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059305
{
public static readonly long[] Value={ 2L,4L,11L,31L,1028L,12251L,43390L,105097565L,55890484045084135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059305Inst : IEnumerable<long>
{
public static readonly long[] Value=A059305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059305.Bytes);
public long this[int i]=>Value[i];

public static A059305Inst Instance=new A059305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059306
{
public static readonly long[] Value={ 1L,10L,31L,64L,113L,170L,255L,336L,449L,570L,719L,848L,1057L,1210L,1423L,1664L,1921L,2122L,2447L,2672L,3041L,3386L,3727L,4000L,4497L,4858L,5263L,5696L,6225L,6570L,7231L,7600L,8177L,8730L,9263L,9872L,10689L,11130L,11727L,12384L,13265L,13754L,14703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059306Inst : IEnumerable<long>
{
public static readonly long[] Value=A059306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059306.Bytes);
public long this[int i]=>Value[i];

public static A059306Inst Instance=new A059306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059307
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,22L,23L,26L,27L,28L,32L,33L,35L,37L,38L,52L,53L,55L,56L,57L,58L,62L,63L,65L,66L,67L,68L,72L,73L,75L,76L,77L,78L,82L,83L,85L,86L,87L,88L,222L,223L,226L,227L,228L,232L,233L,235L,237L,238L,262L,263L,265L,266L,267L,268L,272L,273L,275L,276L,277L,278L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059307Inst : IEnumerable<long>
{
public static readonly long[] Value=A059307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059307.Bytes);
public long this[int i]=>Value[i];

public static A059307Inst Instance=new A059307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059308
{
public static readonly long[] Value={ 7L,11L,13L,19L,31L,37L,41L,61L,67L,71L,73L,79L,97L,101L,103L,131L,139L,151L,163L,181L,191L,193L,199L,211L,241L,271L,281L,311L,313L,331L,337L,349L,367L,373L,379L,401L,409L,421L,461L,463L,487L,491L,521L,523L,541L,547L,571L,577L,601L,607L,613L,619L,631L,661L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059308Inst : IEnumerable<long>
{
public static readonly long[] Value=A059308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059308.Bytes);
public long this[int i]=>Value[i];

public static A059308Inst Instance=new A059308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059309
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,29L,31L,37L,41L,43L,53L,59L,61L,67L,71L,83L,97L,101L,107L,109L,131L,137L,139L,149L,157L,163L,173L,179L,181L,191L,193L,197L,211L,227L,229L,241L,251L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,347L,349L,373L,379L,389L,397L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059309Inst : IEnumerable<long>
{
public static readonly long[] Value=A059309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059309.Bytes);
public long this[int i]=>Value[i];

public static A059309Inst Instance=new A059309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059310
{
public static readonly long[] Value={ 7L,13L,19L,29L,37L,43L,61L,67L,71L,73L,79L,97L,103L,113L,127L,139L,151L,163L,181L,193L,197L,199L,211L,239L,241L,271L,281L,313L,331L,337L,349L,367L,373L,379L,409L,421L,449L,463L,487L,491L,523L,541L,547L,571L,577L,607L,613L,617L,619L,631L,659L,661L,673L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059310Inst : IEnumerable<long>
{
public static readonly long[] Value=A059310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059310.Bytes);
public long this[int i]=>Value[i];

public static A059310Inst Instance=new A059310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059311
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,23L,29L,37L,43L,53L,59L,61L,67L,83L,89L,101L,107L,109L,131L,139L,149L,157L,163L,173L,179L,181L,197L,199L,211L,227L,229L,251L,269L,277L,283L,293L,307L,317L,331L,347L,349L,353L,373L,379L,389L,397L,419L,421L,443L,461L,463L,467L,491L,499L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059311Inst : IEnumerable<long>
{
public static readonly long[] Value=A059311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059311.Bytes);
public long this[int i]=>Value[i];

public static A059311Inst Instance=new A059311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059312
{
public static readonly long[] Value={ 709L,827L,1063L,1181L,1889L,2243L,2833L,3187L,3541L,3659L,4013L,4603L,4721L,4957L,5783L,6373L,6491L,7789L,7907L,8969L,9323L,9677L,10267L,10739L,11093L,11329L,11801L,12037L,12391L,13099L,13217L,13807L,14633L,14869L,16993L,19471L,20297L,20533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059312Inst : IEnumerable<long>
{
public static readonly long[] Value=A059312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059312.Bytes);
public long this[int i]=>Value[i];

public static A059312Inst Instance=new A059312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059313
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,131L,151L,181L,191L,211L,251L,271L,281L,311L,331L,401L,421L,461L,491L,521L,541L,601L,631L,661L,691L,701L,751L,761L,811L,821L,881L,941L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1201L,1231L,1291L,1301L,1321L,1361L,1381L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059313Inst : IEnumerable<long>
{
public static readonly long[] Value=A059313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059313.Bytes);
public long this[int i]=>Value[i];

public static A059313Inst Instance=new A059313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059314
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,29L,37L,43L,53L,59L,61L,67L,79L,83L,101L,107L,109L,131L,139L,149L,157L,163L,173L,179L,181L,197L,211L,227L,229L,251L,269L,277L,283L,293L,307L,313L,317L,331L,347L,349L,373L,379L,389L,397L,419L,421L,443L,461L,467L,491L,499L,509L,521L,523L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059314Inst : IEnumerable<long>
{
public static readonly long[] Value=A059314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059314.Bytes);
public long this[int i]=>Value[i];

public static A059314Inst Instance=new A059314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059315
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,29L,37L,41L,43L,53L,59L,61L,67L,71L,83L,97L,101L,107L,109L,113L,127L,131L,137L,139L,149L,157L,163L,173L,179L,181L,193L,197L,211L,227L,229L,239L,241L,251L,269L,277L,281L,283L,293L,307L,313L,317L,331L,337L,347L,349L,373L,379L,389L,397L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059315Inst : IEnumerable<long>
{
public static readonly long[] Value=A059315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059315.Bytes);
public long this[int i]=>Value[i];

public static A059315Inst Instance=new A059315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059316
{
public static readonly long[] Value={ 1L,2L,7L,10L,16L,22L,27L,31L,36L,37L,51L,52L,55L,57L,70L,79L,87L,91L,96L,97L,100L,120L,121L,126L,135L,136L,142L,147L,157L,175L,177L,187L,190L,205L,210L,211L,217L,220L,222L,232L,246L,250L,255L,262L,289L,297L,300L,301L,304L,307L,310L,324L,327L,330L,331L,342L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059316Inst : IEnumerable<long>
{
public static readonly long[] Value=A059316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059316.Bytes);
public long this[int i]=>Value[i];

public static A059316Inst Instance=new A059316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059317
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,4L,2L,1L,1L,3L,8L,9L,8L,3L,1L,1L,4L,13L,22L,29L,22L,13L,4L,1L,1L,5L,19L,42L,72L,82L,72L,42L,19L,5L,1L,1L,6L,26L,70L,146L,218L,255L,218L,146L,70L,26L,6L,1L,1L,7L,34L,107L,261L,476L,691L,773L,691L,476L,261L,107L,34L,7L,1L,1L,8L,43L,154L,428L,914L,1574L,2158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059317Inst : IEnumerable<long>
{
public static readonly long[] Value=A059317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059317.Bytes);
public long this[int i]=>Value[i];

public static A059317Inst Instance=new A059317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059318
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059318Inst : IEnumerable<long>
{
public static readonly long[] Value=A059318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059318.Bytes);
public long this[int i]=>Value[i];

public static A059318Inst Instance=new A059318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059319
{
public static readonly long[] Value={ 1L,3L,2L,5L,5L,6L,3L,11L,4L,15L,7L,10L,9L,9L,8L,21L,11L,12L,15L,25L,16L,21L,9L,22L,7L,27L,12L,15L,17L,24L,13L,43L,14L,33L,19L,20L,23L,45L,14L,55L,17L,48L,29L,35L,24L,27L,19L,42L,21L,21L,28L,45L,27L,36L,15L,33L,14L,51L,25L,40L,37L,39L,30L,85L,33L,42L,43L,55L,34L,57L,19L,44L,23L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059319Inst : IEnumerable<long>
{
public static readonly long[] Value=A059319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059319.Bytes);
public long this[int i]=>Value[i];

public static A059319Inst Instance=new A059319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059320
{
public static readonly long[] Value={ 0L,0L,3L,2L,4L,5L,10L,4L,13L,4L,14L,13L,16L,18L,21L,10L,22L,23L,22L,14L,25L,22L,36L,25L,42L,24L,41L,40L,40L,35L,48L,20L,51L,34L,50L,51L,50L,30L,63L,24L,64L,35L,56L,52L,65L,64L,74L,53L,76L,78L,73L,58L,78L,71L,94L,78L,99L,64L,92L,79L,84L,84L,95L,42L,96L,89L,90L,80L,103L,82L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059320Inst : IEnumerable<long>
{
public static readonly long[] Value=A059320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059320.Bytes);
public long this[int i]=>Value[i];

public static A059320Inst Instance=new A059320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059321
{
public static readonly long[] Value={ 7L,70L,38L,41L,117L,378L,500L,682L,776L,3861L,4052L,515L,5744L,1710L,6613L,1744L,11018L,13241L,3458L,5099L,1393L,16610L,26884L,15006L,2072L,13637L,31361L,4443L,26508L,7850L,37520L,31152L,39922L,37107L,6072L,4005L,32491L,4030L,43211L,12238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059321Inst : IEnumerable<long>
{
public static readonly long[] Value=A059321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059321.Bytes);
public long this[int i]=>Value[i];

public static A059321Inst Instance=new A059321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059322
{
public static readonly long[] Value={ 2L,4L,12L,24L,12L,24L,24L,60L,12L,48L,36L,84L,12L,24L,84L,12L,24L,60L,24L,132L,120L,24L,24L,96L,36L,168L,96L,24L,12L,48L,72L,48L,36L,96L,204L,84L,120L,12L,24L,36L,108L,240L,12L,120L,240L,60L,24L,60L,36L,24L,96L,48L,36L,264L,156L,156L,24L,60L,84L,60L,72L,48L,12L,120L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059322Inst : IEnumerable<long>
{
public static readonly long[] Value=A059322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059322.Bytes);
public long this[int i]=>Value[i];

public static A059322Inst Instance=new A059322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059323
{
public static readonly long[] Value={ 11L,47L,167L,347L,467L,1307L,2027L,2447L,4127L,4787L,5087L,5387L,5927L,12527L,12647L,15287L,18947L,28307L,39107L,39827L,41507L,44687L,51827L,63587L,64007L,71987L,73847L,76367L,76907L,78467L,79967L,83207L,118787L,121547L,143687L,164987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059323Inst : IEnumerable<long>
{
public static readonly long[] Value=A059323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059323.Bytes);
public long this[int i]=>Value[i];

public static A059323Inst Instance=new A059323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059324
{
public static readonly long[] Value={ 5L,10L,12L,15L,19L,20L,23L,25L,26L,30L,33L,34L,35L,36L,40L,45L,47L,49L,50L,53L,54L,55L,56L,60L,61L,62L,65L,67L,68L,70L,72L,75L,78L,80L,82L,85L,87L,88L,89L,90L,91L,95L,96L,100L,101L,103L,104L,105L,110L,111L,114L,115L,117L,118L,120L,121L,122L,124L,125L,127L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059324Inst : IEnumerable<long>
{
public static readonly long[] Value=A059324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059324.Bytes);
public long this[int i]=>Value[i];

public static A059324Inst Instance=new A059324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059325
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,11L,13L,14L,16L,17L,18L,21L,22L,24L,27L,28L,29L,31L,32L,37L,38L,39L,41L,42L,43L,44L,46L,48L,51L,52L,57L,58L,59L,63L,64L,66L,69L,71L,73L,74L,76L,77L,79L,81L,83L,84L,86L,92L,93L,94L,97L,98L,99L,102L,106L,107L,108L,109L,112L,113L,116L,119L,123L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059325Inst : IEnumerable<long>
{
public static readonly long[] Value=A059325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059325.Bytes);
public long this[int i]=>Value[i];

public static A059325Inst Instance=new A059325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059326
{
public static readonly long[] Value={ 1L,3L,9L,11L,15L,17L,24L,41L,68L,72L,641L,716L,1139L,1200L,1661L,3339L,5181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059326Inst : IEnumerable<long>
{
public static readonly long[] Value=A059326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059326.Bytes);
public long this[int i]=>Value[i];

public static A059326Inst Instance=new A059326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059327
{
public static readonly long[] Value={ 11L,23L,227L,179L,107L,1367L,263L,887L,2099L,719L,587L,8819L,3467L,1019L,10163L,27827L,1619L,7823L,27299L,2207L,44267L,3203L,7247L,5099L,11807L,45887L,18119L,15803L,79559L,13163L,40127L,42839L,20663L,79979L,17483L,53267L,47963L,33863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059327Inst : IEnumerable<long>
{
public static readonly long[] Value=A059327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059327.Bytes);
public long this[int i]=>Value[i];

public static A059327Inst Instance=new A059327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059328
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,15L,63L,15L,1L,1L,31L,1023L,1023L,31L,1L,1L,63L,32767L,1048575L,32767L,63L,1L,1L,127L,2097151L,34359738367L,34359738367L,2097151L,127L,1L,1L,255L,268435455L,72057594037927935L,BigInteger.Parse("1180591620717411303423") };
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
public class A059328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059328Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059328.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059328.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059328Inst Instance=new A059328Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059329
{
public static readonly long[] Value={ 1L,2L,7L,12L,25L,38L,63L,88L,129L,170L,231L,292L,377L,462L,575L,688L,833L,978L,1159L,1340L,1561L,1782L,2047L,2312L,2625L,2938L,3303L,3668L,4089L,4510L,4991L,5472L,6017L,6562L,7175L,7788L,8473L,9158L,9919L,10680L,11521L,12362L,13287L,14212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059329Inst : IEnumerable<long>
{
public static readonly long[] Value=A059329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059329.Bytes);
public long this[int i]=>Value[i];

public static A059329Inst Instance=new A059329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059330
{
public static readonly long[] Value={ 269L,1609L,1877L,2011L,3083L,3217L,4021L,4289L,4423L,4691L,5227L,5897L,6299L,6701L,7103L,7237L,7639L,7907L,8443L,9649L,10453L,11257L,11927L,12329L,13267L,14071L,14741L,15277L,15679L,16349L,17957L,18493L,19163L,19699L,20101L,20369L,20771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059330Inst : IEnumerable<long>
{
public static readonly long[] Value=A059330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059330.Bytes);
public long this[int i]=>Value[i];

public static A059330Inst Instance=new A059330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059331
{
public static readonly long[] Value={ 113L,281L,353L,593L,617L,1049L,1097L,1193L,1481L,1601L,1753L,1889L,2129L,2273L,2281L,2393L,2689L,3089L,3137L,3761L,3833L,4001L,4153L,4217L,4289L,4457L,4657L,4817L,4937L,5113L,5393L,5569L,6521L,6569L,6761L,7481L,7577L,7793L,7817L,7841L,8273L,8369L,8537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059331Inst : IEnumerable<long>
{
public static readonly long[] Value=A059331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059331.Bytes);
public long this[int i]=>Value[i];

public static A059331Inst Instance=new A059331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059332
{
public static readonly BigInteger[] Value={ 1L,2L,24L,3456L,9953280L,859963392000L,3120635156889600000L,BigInteger.Parse("634153008009974906880000000"),BigInteger.Parse("9278496603801318870491332608000000000"),BigInteger.Parse("12218100099725239100847669366019325952000000000000") };
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
public class A059332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059332Inst Instance=new A059332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059333
{
public static readonly long[] Value={ 2L,1L,3L,23L,5L,2L,2L,73L,1L,2L,3L,52L,2L,1L,3L,227L,5L,14L,2L,44L,1L,5L,2L,232L,1L,2L,1L,4L,5L,66L,2L,1669L,1L,1L,7L,92L,2L,1L,3L,344L,4L,6L,3L,1L,11L,10L,2L,976L,3L,22L,9L,2L,2L,10L,11L,328L,1L,5L,3L,4L,9L,13L,9L,3581L,3L,6L,2L,4L,7L,10L,3L,952L,8L,2L,1L,4L,4L,3L,3L,944L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059333Inst : IEnumerable<long>
{
public static readonly long[] Value=A059333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059333.Bytes);
public long this[int i]=>Value[i];

public static A059333Inst Instance=new A059333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059334
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,29L,31L,37L,41L,43L,53L,59L,61L,67L,71L,73L,79L,83L,97L,101L,103L,107L,109L,131L,139L,149L,151L,157L,163L,173L,179L,181L,191L,193L,197L,199L,211L,227L,229L,241L,251L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L,349L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059334Inst : IEnumerable<long>
{
public static readonly long[] Value=A059334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059334.Bytes);
public long this[int i]=>Value[i];

public static A059334Inst Instance=new A059334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059335
{
public static readonly long[] Value={ 7L,13L,19L,23L,37L,61L,67L,73L,79L,89L,97L,103L,139L,151L,163L,181L,193L,199L,211L,241L,271L,313L,331L,337L,349L,353L,367L,373L,379L,397L,409L,419L,421L,463L,487L,523L,541L,547L,571L,577L,607L,613L,617L,619L,631L,661L,673L,683L,709L,727L,751L,757L,769L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059335Inst : IEnumerable<long>
{
public static readonly long[] Value=A059335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059335.Bytes);
public long this[int i]=>Value[i];

public static A059335Inst Instance=new A059335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059336
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,29L,37L,43L,53L,59L,61L,67L,83L,101L,103L,107L,109L,131L,137L,139L,149L,157L,163L,173L,179L,181L,197L,211L,227L,229L,239L,251L,269L,277L,283L,293L,307L,317L,331L,347L,349L,373L,379L,389L,397L,409L,419L,421L,443L,461L,467L,491L,499L,509L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059336Inst : IEnumerable<long>
{
public static readonly long[] Value=A059336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059336.Bytes);
public long this[int i]=>Value[i];

public static A059336Inst Instance=new A059336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059337
{
public static readonly long[] Value={ 11L,29L,31L,41L,43L,61L,71L,101L,113L,127L,131L,181L,191L,197L,211L,239L,271L,281L,311L,331L,337L,379L,401L,421L,449L,461L,463L,491L,521L,541L,547L,601L,617L,631L,659L,661L,691L,701L,743L,751L,757L,761L,811L,821L,827L,881L,883L,911L,941L,967L,991L,1009L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059337Inst : IEnumerable<long>
{
public static readonly long[] Value=A059337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059337.Bytes);
public long this[int i]=>Value[i];

public static A059337Inst Instance=new A059337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059338
{
public static readonly long[] Value={ 1L,34L,342L,2192L,11000L,47232L,181888L,646144L,2156544L,6848000L,20877824L,61526016L,176171008L,492126208L,1345536000L,3610247168L,9526771712L,24769069056L,63546720256L,161087488000L,403925630976L,1002841309184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059338Inst : IEnumerable<long>
{
public static readonly long[] Value=A059338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059338.Bytes);
public long this[int i]=>Value[i];

public static A059338Inst Instance=new A059338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059339
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,0L,1L,1L,3L,0L,2L,0L,2L,2L,1L,0L,1L,0L,2L,1L,4L,0L,2L,1L,4L,5L,6L,0L,1L,0L,2L,1L,5L,1L,3L,0L,2L,2L,4L,0L,3L,0L,5L,7L,4L,0L,3L,1L,4L,0L,7L,0L,3L,1L,5L,0L,5L,0L,6L,0L,3L,7L,4L,0L,4L,0L,10L,1L,6L,0L,4L,0L,5L,8L,10L,0L,5L,0L,6L,13L,5L,0L,7L,1L,6L,1L,8L,0L,6L,1L,11L,0L,6L,1L,7L,0L,13L,10L,11L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059339Inst : IEnumerable<long>
{
public static readonly long[] Value=A059339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059339.Bytes);
public long this[int i]=>Value[i];

public static A059339Inst Instance=new A059339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059340
{
public static readonly long[] Value={ 1L,2L,1L,5L,5L,1L,15L,23L,10L,1L,52L,109L,76L,19L,1L,203L,544L,531L,224L,36L,1L,877L,2876L,3641L,2204L,631L,69L,1L,4140L,16113L,25208L,20089L,8471L,1749L,134L,1L,21147L,95495L,178564L,177631L,100171L,31331L,4838L,263L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059340Inst : IEnumerable<long>
{
public static readonly long[] Value=A059340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059340.Bytes);
public long this[int i]=>Value[i];

public static A059340Inst Instance=new A059340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059341
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,0L,1L,-3L,0L,1L,1L,-2L,0L,1L,0L,1L,-5L,0L,5L,0L,-1L,1L,-3L,0L,5L,0L,-3L,0L,1L,-7L,0L,35L,0L,-21L,0L,17L,1L,-4L,0L,14L,0L,-28L,0L,17L,0L,1L,-9L,0L,21L,0L,-63L,0L,153L,0L,-31L,1L,-5L,0L,30L,0L,-126L,0L,255L,0L,-155L,0L,1L,-11L,0L,165L,0L,-231L,0L,2805L,0L,-1705L,0L,691L,1L,-6L,0L,55L,0L,-396L,0L,1683L,0L,-3410L,0L,2073L,0L,1L,-13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059341Inst : IEnumerable<long>
{
public static readonly long[] Value=A059341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059341.Bytes);
public long this[int i]=>Value[i];

public static A059341Inst Instance=new A059341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059342
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,2L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,4L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059342Inst : IEnumerable<long>
{
public static readonly long[] Value=A059342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059342.Bytes);
public long this[int i]=>Value[i];

public static A059342Inst Instance=new A059342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059343
{
public static readonly long[] Value={ 1L,2L,-2L,4L,-12L,8L,12L,-48L,16L,120L,-160L,32L,-120L,720L,-480L,64L,-1680L,3360L,-1344L,128L,1680L,-13440L,13440L,-3584L,256L,30240L,-80640L,48384L,-9216L,512L,-30240L,302400L,-403200L,161280L,-23040L,1024L,-665280L,2217600L,-1774080L,506880L,-56320L,2048L,665280L,-7983360L,13305600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059343Inst : IEnumerable<long>
{
public static readonly long[] Value=A059343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059343.Bytes);
public long this[int i]=>Value[i];

public static A059343Inst Instance=new A059343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059344
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,12L,12L,1L,20L,60L,1L,30L,180L,120L,1L,42L,420L,840L,1L,56L,840L,3360L,1680L,1L,72L,1512L,10080L,15120L,1L,90L,2520L,25200L,75600L,30240L,1L,110L,3960L,55440L,277200L,332640L,1L,132L,5940L,110880L,831600L,1995840L,665280L,1L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059344Inst : IEnumerable<long>
{
public static readonly long[] Value=A059344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059344.Bytes);
public long this[int i]=>Value[i];

public static A059344Inst Instance=new A059344Inst();

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