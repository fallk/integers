using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A224957
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,11L,19L,31L,54L,92L,154L,266L,454L,771L,1319L,2249L,3834L,6550L,11176L,19069L,32558L,55567L,94838L,161891L,276325L,471659L,805102L,1374234L,2345724L,4004031L,6834605L,11666260L,19913668L,33991462L,58021534L,99039592L,169055094L,288567886L,492569833L,840790082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224957Inst : IEnumerable<long>
{
public static readonly long[] Value=A224957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224957.Bytes);
public long this[int i]=>Value[i];

public static A224957Inst Instance=new A224957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224958
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,18L,29L,53L,91L,162L,277L,495L,855L,1508L,2625L,4618L,8049L,14130L,24675L,43255L,75621L,132475L,231697L,405751L,709887L,1242824L,2174763L,3806989L,6662291L,11661737L,20409409L,35723307L,62521919L,109431810L,191527623L,335225350L,586717615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224958Inst : IEnumerable<long>
{
public static readonly long[] Value=A224958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224958.Bytes);
public long this[int i]=>Value[i];

public static A224958Inst Instance=new A224958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224959
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,15L,29L,55L,105L,199L,378L,716L,1358L,2572L,4873L,9229L,17480L,33102L,62688L,118709L,224795L,425676L,806068L,1526371L,2890338L,5473125L,10363871L,19624925L,37161558L,70368705L,133249369L,252319408L,477788980L,904735349L,1713195705L,3244086145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224959Inst : IEnumerable<long>
{
public static readonly long[] Value=A224959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224959.Bytes);
public long this[int i]=>Value[i];

public static A224959Inst Instance=new A224959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224960
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,14L,26L,52L,101L,200L,396L,787L,1564L,3117L,6214L,12398L,24749L,49427L,98740L,197303L,394323L,788201L,1575695L,3150265L,6298732L,12594595L,25184598L,50361842L,100711888L,201404839L,402779246L,805509560L,1610940381L,3221753990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224960Inst : IEnumerable<long>
{
public static readonly long[] Value=A224960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224960.Bytes);
public long this[int i]=>Value[i];

public static A224960Inst Instance=new A224960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224961
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,2L,3L,3L,2L,1L,4L,0L,4L,4L,4L,5L,4L,4L,3L,2L,4L,4L,3L,5L,3L,4L,4L,6L,4L,7L,4L,4L,7L,5L,5L,6L,5L,6L,8L,5L,7L,7L,6L,3L,9L,5L,8L,5L,8L,7L,10L,9L,7L,8L,8L,5L,8L,8L,9L,8L,8L,10L,7L,11L,13L,8L,10L,10L,10L,11L,9L,12L,9L,13L,11L,9L,12L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224961Inst : IEnumerable<long>
{
public static readonly long[] Value=A224961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224961.Bytes);
public long this[int i]=>Value[i];

public static A224961Inst Instance=new A224961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224962
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,4L,4L,7L,3L,5L,6L,4L,7L,6L,8L,4L,5L,6L,2L,6L,10L,11L,8L,8L,5L,7L,10L,8L,5L,11L,8L,9L,14L,6L,6L,7L,11L,11L,14L,9L,12L,6L,13L,9L,10L,7L,16L,11L,11L,22L,9L,16L,17L,17L,21L,9L,4L,11L,6L,21L,10L,14L,13L,22L,10L,12L,21L,15L,20L,22L,13L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224962Inst : IEnumerable<long>
{
public static readonly long[] Value=A224962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224962.Bytes);
public long this[int i]=>Value[i];

public static A224962Inst Instance=new A224962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224963
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,1L,2L,2L,3L,2L,3L,1L,4L,2L,3L,5L,4L,3L,3L,5L,3L,6L,6L,4L,7L,3L,5L,5L,4L,5L,6L,4L,8L,4L,3L,4L,6L,6L,6L,3L,5L,5L,7L,6L,6L,2L,4L,6L,5L,2L,6L,5L,5L,5L,5L,3L,3L,8L,5L,4L,8L,4L,7L,4L,7L,7L,4L,7L,3L,5L,8L,9L,9L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224963Inst : IEnumerable<long>
{
public static readonly long[] Value=A224963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224963.Bytes);
public long this[int i]=>Value[i];

public static A224963Inst Instance=new A224963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224964
{
public static readonly long[] Value={ 2L,2L,2L,6L,2L,6L,2L,6L,15L,2L,6L,15L,2L,6L,15L,105L,2L,6L,15L,105L,2L,6L,15L,105L,105L,2L,6L,15L,105L,105L,2L,6L,15L,105L,105L,231L,2L,6L,15L,105L,105L,231L,2L,6L,15L,105L,105L,231L,15015L,2L,6L,15L,105L,105L,231L,15015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224964Inst : IEnumerable<long>
{
public static readonly long[] Value=A224964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224964.Bytes);
public long this[int i]=>Value[i];

public static A224964Inst Instance=new A224964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224965
{
public static readonly long[] Value={ 0L,0L,2L,3L,1L,2L,2L,2L,1L,2L,1L,1L,3L,2L,1L,1L,1L,3L,2L,2L,1L,3L,1L,0L,4L,0L,1L,2L,5L,0L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,4L,2L,1L,0L,2L,5L,1L,1L,3L,1L,3L,3L,3L,0L,1L,2L,4L,1L,4L,4L,2L,2L,2L,6L,2L,5L,2L,3L,3L,2L,4L,5L,3L,2L,1L,3L,1L,3L,3L,3L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224965Inst : IEnumerable<long>
{
public static readonly long[] Value=A224965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224965.Bytes);
public long this[int i]=>Value[i];

public static A224965Inst Instance=new A224965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224966
{
public static readonly long[] Value={ 1L,4L,10L,16L,31L,32L,40L,41L,43L,62L,71L,76L,94L,95L,97L,98L,121L,142L,158L,163L,164L,166L,179L,188L,208L,211L,214L,227L,229L,259L,260L,265L,284L,301L,313L,317L,320L,328L,331L,340L,352L,355L,356L,365L,380L,382L,386L,392L,397L,401L,418L,424L,425L,431L,436L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224966Inst : IEnumerable<long>
{
public static readonly long[] Value=A224966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224966.Bytes);
public long this[int i]=>Value[i];

public static A224966Inst Instance=new A224966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224967
{
public static readonly BigInteger[] Value={ 256L,11196L,1417535L,4560581070L,14139394308728L,848170732137764831L,BigInteger.Parse("48673249025229489837168"),BigInteger.Parse("50198078741040638898913117046"),BigInteger.Parse("52964434709981516539278316299135035") };
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
public class A224967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224967Inst Instance=new A224967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224968
{
public static readonly long[] Value={ 256L,912L,3067L,13654L,59330L,294349L,1450678L,7519806L,38907153L,204788176L,1077280478L,5698807413L,30141225914L,159706380100L,846175230733L,4485916253958L,23781297237114L,126096070580625L,668599352875654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224968Inst : IEnumerable<long>
{
public static readonly long[] Value=A224968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224968.Bytes);
public long this[int i]=>Value[i];

public static A224968Inst Instance=new A224968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224969
{
public static readonly BigInteger[] Value={ 912L,11196L,110253L,1777586L,26732072L,435788333L,6995454550L,113660299418L,1841286621939L,29886022842578L,484824378387720L,7867531917317145L,127659230961346958L,2071519909834937922L,BigInteger.Parse("33613909177507010389") };
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
public class A224969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224969Inst Instance=new A224969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224970
{
public static readonly BigInteger[] Value={ 3067L,110253L,1417535L,49673755L,946613919L,27297398415L,603337019865L,15860938451645L,372644358301661L,9417695286715489L,227009613149696909L,5642600777843854363L,BigInteger.Parse("137487699278896205027"),BigInteger.Parse("3393605739680529203023") };
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
public class A224970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224970.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224970Inst Instance=new A224970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224971
{
public static readonly BigInteger[] Value={ 13654L,1777586L,49673755L,4560581070L,226665118676L,16533408013041L,1006241870944880L,68438742000698746L,4427204400021885733L,BigInteger.Parse("295306872160490600016"),BigInteger.Parse("19431114846942603850790"),BigInteger.Parse("1289257317553885829439239") };
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
public class A224971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224971.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224971Inst Instance=new A224971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224972
{
public static readonly BigInteger[] Value={ 59330L,26732072L,946613919L,226665118676L,14139394308728L,2261199424343729L,186370133088417660L,BigInteger.Parse("24455901660390402808"),BigInteger.Parse("2314068149947986952369"),BigInteger.Parse("275508832757081318977764"),BigInteger.Parse("27911391659326611295287712") };
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
public class A224972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224972Inst Instance=new A224972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224973
{
public static readonly BigInteger[] Value={ 294349L,435788333L,27297398415L,16533408013041L,2261199424343729L,848170732137764831L,BigInteger.Parse("173223628709504650859"),BigInteger.Parse("53060397309690724953363"),BigInteger.Parse("12918833834664718161599715"),BigInteger.Parse("3660962109269297649761381309") };
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
public class A224973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224973.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224973Inst Instance=new A224973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224974
{
public static readonly BigInteger[] Value={ 1450678L,6995454550L,603337019865L,1006241870944880L,186370133088417660L,BigInteger.Parse("173223628709504650859"),BigInteger.Parse("48673249025229489837168"),BigInteger.Parse("33073672642593917370109600"),BigInteger.Parse("11681343800283731114751330797") };
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
public class A224974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224974Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224974.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224974.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224974Inst Instance=new A224974Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224975
{
public static readonly long[] Value={ 256L,912L,912L,3067L,11196L,3067L,13654L,110253L,110253L,13654L,59330L,1777586L,1417535L,1777586L,59330L,294349L,26732072L,49673755L,49673755L,26732072L,294349L,1450678L,435788333L,946613919L,4560581070L,946613919L,435788333L,1450678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224975Inst : IEnumerable<long>
{
public static readonly long[] Value=A224975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224975.Bytes);
public long this[int i]=>Value[i];

public static A224975Inst Instance=new A224975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224976
{
public static readonly long[] Value={ 1L,1L,-2L,1L,6L,-8L,8L,1L,-11L,6L,12L,-20L,14L,8L,-12L,1L,18L,-35L,20L,6L,-16L,12L,24L,-44L,31L,14L,-38L,8L,30L,-48L,32L,1L,-24L,18L,48L,-83L,38L,20L,-28L,6L,42L,-64L,44L,12L,-66L,24L,48L,-92L,57L,31L,-36L,14L,54L,-116L,72L,8L,-40L,30L,60L,-120L,62L,32L,-88L,1L,84L,-96L,68L,18L,-48L,48L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224976Inst : IEnumerable<long>
{
public static readonly long[] Value=A224976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224976.Bytes);
public long this[int i]=>Value[i];

public static A224976Inst Instance=new A224976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224977
{
public static readonly long[] Value={ 0L,0L,0L,0L,9L,18L,27L,36L,54L,72L,99L,117L,135L,153L,180L,216L,243L,270L,315L,351L,396L,432L,468L,513L,558L,612L,657L,711L,765L,828L,891L,945L,1017L,1071L,1143L,1215L,1278L,1350L,1431L,1512L,1593L,1665L,1746L,1827L,1917L,2016L,2106L,2196L,2295L,2394L,2493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224977Inst : IEnumerable<long>
{
public static readonly long[] Value=A224977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224977.Bytes);
public long this[int i]=>Value[i];

public static A224977Inst Instance=new A224977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224978
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,49L,227L,1354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224978Inst : IEnumerable<long>
{
public static readonly long[] Value=A224978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224978.Bytes);
public long this[int i]=>Value[i];

public static A224978Inst Instance=new A224978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224979
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,4L,6L,6L,4L,3L,8L,6L,10L,10L,12L,5L,4L,12L,9L,8L,16L,18L,6L,16L,10L,16L,12L,20L,6L,18L,16L,14L,24L,8L,9L,10L,26L,22L,28L,12L,22L,13L,26L,16L,12L,14L,24L,18L,30L,36L,16L,32L,28L,32L,38L,14L,13L,32L,16L,38L,16L,34L,17L,30L,12L,18L,32L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224979Inst : IEnumerable<long>
{
public static readonly long[] Value=A224979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224979.Bytes);
public long this[int i]=>Value[i];

public static A224979Inst Instance=new A224979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224980
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,4L,4L,5L,4L,6L,8L,6L,8L,7L,6L,7L,12L,12L,10L,12L,14L,9L,8L,14L,12L,16L,11L,16L,14L,20L,14L,10L,16L,10L,24L,22L,20L,11L,12L,13L,28L,16L,22L,18L,26L,38L,22L,13L,24L,14L,18L,36L,18L,16L,17L,18L,38L,32L,28L,32L,16L,30L,24L,34L,20L,48L,38L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224980Inst : IEnumerable<long>
{
public static readonly long[] Value=A224980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224980.Bytes);
public long this[int i]=>Value[i];

public static A224980Inst Instance=new A224980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224981
{
public static readonly long[] Value={ 91L,104L,115L,119L,124L,130L,131L,136L,139L,143L,146L,147L,151L,152L,154L,155L,156L,159L,160L,163L,164L,166L,167L,168L,169L,170L,171L,175L,176L,178L,179L,180L,181L,182L,184L,187L,188L,190L,191L,192L,194L,195L,196L,199L,200L,201L,202L,203L,204L,206L,207L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224981Inst : IEnumerable<long>
{
public static readonly long[] Value=A224981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224981.Bytes);
public long this[int i]=>Value[i];

public static A224981Inst Instance=new A224981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224982
{
public static readonly long[] Value={ 140L,155L,168L,172L,179L,185L,188L,191L,195L,196L,200L,203L,204L,205L,211L,212L,215L,217L,219L,220L,224L,225L,227L,230L,231L,232L,233L,235L,236L,239L,240L,243L,244L,245L,246L,247L,248L,251L,252L,254L,256L,257L,259L,260L,263L,264L,265L,267L,268L,269L,270L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224982Inst : IEnumerable<long>
{
public static readonly long[] Value=A224982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224982.Bytes);
public long this[int i]=>Value[i];

public static A224982Inst Instance=new A224982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224983
{
public static readonly long[] Value={ 204L,221L,236L,240L,249L,255L,260L,261L,268L,269L,272L,276L,279L,281L,284L,285L,288L,289L,293L,295L,296L,299L,300L,303L,305L,306L,309L,311L,312L,316L,317L,320L,321L,323L,324L,325L,326L,327L,329L,332L,333L,335L,336L,337L,338L,339L,340L,341L,344L,345L,347L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224983Inst : IEnumerable<long>
{
public static readonly long[] Value=A224983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224983.Bytes);
public long this[int i]=>Value[i];

public static A224983Inst Instance=new A224983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224984
{
public static readonly long[] Value={ 7L,13L,311L,1637L,4363L,10433L,41669L,45631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224984Inst : IEnumerable<long>
{
public static readonly long[] Value=A224984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224984.Bytes);
public long this[int i]=>Value[i];

public static A224984Inst Instance=new A224984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224985
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,4L,5L,7L,9L,10L,13L,15L,17L,20L,23L,25L,29L,33L,36L,40L,44L,48L,53L,58L,62L,67L,73L,77L,84L,89L,95L,102L,108L,114L,121L,128L,135L,143L,150L,157L,166L,174L,181L,190L,199L,207L,217L,226L,235L,245L,255L,265L,275L,286L,296L,307L,318L,329L,341L,352L,363L,376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224985Inst : IEnumerable<long>
{
public static readonly long[] Value=A224985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224985.Bytes);
public long this[int i]=>Value[i];

public static A224985Inst Instance=new A224985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224986
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,96L,8153726976L,BigInteger.Parse("320352637207127391364950814323398779319161580421120") };
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
public class A224986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224986.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224986Inst Instance=new A224986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224987
{
public static readonly long[] Value={ 1L,2L,3L,20L,21L,22L,23L,24L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,13092L,13093L,13094L,13095L,13096L,13097L,13098L,13099L,13100L,13101L,13102L,13103L,13104L,13105L,13106L,13107L,13232L,13233L,13234L,13235L,13239L,13240L,13241L,13242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224987Inst : IEnumerable<long>
{
public static readonly long[] Value=A224987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224987.Bytes);
public long this[int i]=>Value[i];

public static A224987Inst Instance=new A224987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224988
{
public static readonly long[] Value={ 2217231104L,6221622528L,9644780288L,12127073024L,15377570560L,15520617728L,22426778880L,25138541824L,34766068480L,43551357696L,49424655104L,56022543104L,67513462016L,84107119360L,84889511168L,90906475264L,107642993920L,156987452160L,174347951360L,175969792768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224988Inst : IEnumerable<long>
{
public static readonly long[] Value=A224988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224988.Bytes);
public long this[int i]=>Value[i];

public static A224988Inst Instance=new A224988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224989
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,3L,2L,4L,3L,2L,3L,4L,3L,5L,4L,5L,3L,3L,6L,5L,6L,6L,6L,3L,7L,5L,5L,6L,9L,4L,8L,3L,7L,7L,5L,6L,5L,7L,6L,8L,8L,9L,5L,10L,9L,12L,8L,6L,8L,9L,13L,10L,12L,9L,8L,12L,9L,7L,14L,9L,10L,8L,13L,9L,9L,11L,10L,6L,13L,12L,11L,8L,9L,17L,9L,12L,6L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224989Inst : IEnumerable<long>
{
public static readonly long[] Value=A224989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224989.Bytes);
public long this[int i]=>Value[i];

public static A224989Inst Instance=new A224989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224990
{
public static readonly long[] Value={ 3L,13L,157L,181L,739L,829L,937L,1009L,1093L,1483L,1621L,1879L,2311L,2503L,2647L,2719L,3079L,4969L,4999L,5209L,5431L,5569L,6163L,6961L,8161L,8329L,9349L,9631L,10399L,10459L,10531L,10657L,11131L,11953L,13063L,18523L,20149L,20731L,21391L,21589L,26317L,27481L,28111L,28351L,29023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224990Inst : IEnumerable<long>
{
public static readonly long[] Value=A224990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224990.Bytes);
public long this[int i]=>Value[i];

public static A224990Inst Instance=new A224990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224991
{
public static readonly long[] Value={ 181L,32341L,52021L,96907L,97171L,100981L,109507L,192601L,194671L,238237L,280627L,304651L,320911L,418321L,449971L,547537L,579961L,626191L,668611L,767857L,769807L,771091L,806107L,885097L,954157L,991381L,993247L,1028047L,1075357L,1259677L,1285021L,1368727L,1414837L,1415191L,1425007L,1449841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224991Inst : IEnumerable<long>
{
public static readonly long[] Value=A224991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224991.Bytes);
public long this[int i]=>Value[i];

public static A224991Inst Instance=new A224991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224992
{
public static readonly BigInteger[] Value={ 1L,3L,18L,144L,1368L,14400L,160992L,1861632L,21919104L,260508672L,3110985216L,37241118720L,446349219840L,5352925446144L,64215514275840L,770468624990208L,9244918222258176L,110934787001942016L,1331192054033547264L,15974152308466384896UL,BigInteger.Parse("191688913661984243712") };
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
public class A224992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224992Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224992.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224992.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224992Inst Instance=new A224992Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224993
{
public static readonly BigInteger[] Value={ 1L,4L,32L,352L,4736L,72832L,1226240L,21948928L,409192448L,7833143296L,152494727168L,3000118779904L,59406517698560L,1180988766453760L,23534128521936896L,469655122210324480L,9380774946206646272UL,BigInteger.Parse("187467580232576794624"),BigInteger.Parse("3747576648059504820224") };
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
public class A224993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A224993.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A224993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A224993Inst Instance=new A224993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224994
{
public static readonly long[] Value={ 1L,3L,5L,21L,13L,53L,67L,141L,93L,61L,37L,149L,101L,65L,261L,173L,693L,461L,305L,209L,813L,541L,2165L,1445L,961L,657L,2315L,1709L,1169L,4557L,3037L,2021L,3659L,5389L,3589L,2413L,5123L,2291L,4253L,2755L,7235L,7557L,5037L,3357L,10123L,8949L,5965L,3973L,15893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224994Inst : IEnumerable<long>
{
public static readonly long[] Value=A224994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224994.Bytes);
public long this[int i]=>Value[i];

public static A224994Inst Instance=new A224994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224995
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,14L,16L,19L,21L,24L,26L,29L,31L,34L,36L,38L,41L,43L,46L,48L,51L,53L,56L,58L,61L,63L,66L,68L,71L,73L,75L,78L,80L,83L,85L,88L,90L,93L,95L,98L,100L,103L,105L,108L,110L,112L,115L,117L,120L,122L,125L,127L,130L,132L,135L,137L,140L,142L,145L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224995Inst : IEnumerable<long>
{
public static readonly long[] Value=A224995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224995.Bytes);
public long this[int i]=>Value[i];

public static A224995Inst Instance=new A224995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224996
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,21L,22L,24L,25L,26L,28L,29L,31L,32L,34L,35L,37L,38L,39L,41L,42L,44L,45L,47L,48L,49L,51L,52L,54L,55L,57L,58L,60L,61L,62L,64L,65L,67L,68L,70L,71L,73L,74L,75L,77L,78L,80L,81L,83L,84L,86L,87L,88L,90L,91L,93L,94L,96L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224996Inst : IEnumerable<long>
{
public static readonly long[] Value=A224996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224996.Bytes);
public long this[int i]=>Value[i];

public static A224996Inst Instance=new A224996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224997
{
public static readonly long[] Value={ 8L,1L,32L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224997Inst : IEnumerable<long>
{
public static readonly long[] Value=A224997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224997.Bytes);
public long this[int i]=>Value[i];

public static A224997Inst Instance=new A224997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224998
{
public static readonly long[] Value={ 7L,1L,2L,3L,3L,4L,5L,6L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,16L,17L,18L,19L,20L,21L,22L,23L,23L,24L,25L,26L,27L,28L,29L,30L,30L,31L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,43L,44L,44L,45L,46L,47L,48L,49L,50L,51L,51L,52L,53L,54L,55L,56L,57L,58L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224998Inst : IEnumerable<long>
{
public static readonly long[] Value=A224998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224998.Bytes);
public long this[int i]=>Value[i];

public static A224998Inst Instance=new A224998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A224999
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,70L,71L,73L,74L,76L,77L,79L,80L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,97L,98L,100L,101L,103L,104L,106L,107L,109L,110L,112L,113L,115L,116L,118L,119L,121L,122L,124L,125L,127L,128L,130L,131L,133L,134L,136L,137L,139L,140L,142L,143L,145L,146L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A224999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A224999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A224999Inst : IEnumerable<long>
{
public static readonly long[] Value=A224999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A224999.Bytes);
public long this[int i]=>Value[i];

public static A224999Inst Instance=new A224999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225000
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,14L,17L,19L,22L,24L,27L,29L,32L,34L,37L,39L,42L,44L,47L,49L,52L,54L,57L,59L,62L,64L,67L,69L,72L,74L,77L,79L,82L,84L,87L,89L,92L,94L,97L,99L,102L,104L,107L,109L,112L,114L,117L,119L,122L,124L,127L,129L,132L,134L,137L,139L,142L,144L,147L,149L,152L,154L,157L,159L,162L,164L,167L,169L,172L,174L,177L,179L,182L,184L,187L,189L,192L,194L,197L,199L,202L,204L,207L,209L,212L,214L,217L,219L,222L,224L,227L,229L,232L,234L,237L,239L,242L,244L,247L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225000Inst : IEnumerable<long>
{
public static readonly long[] Value=A225000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225000.Bytes);
public long this[int i]=>Value[i];

public static A225000Inst Instance=new A225000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225001
{
public static readonly long[] Value={ 4L,2L,3L,4L,5L,7L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,62L,63L,64L,65L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225001Inst : IEnumerable<long>
{
public static readonly long[] Value=A225001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225001.Bytes);
public long this[int i]=>Value[i];

public static A225001Inst Instance=new A225001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225002
{
public static readonly long[] Value={ 1L,4L,6L,8L,11L,13L,15L,18L,20L,22L,25L,27L,29L,32L,34L,36L,39L,41L,43L,46L,48L,50L,53L,55L,57L,60L,62L,64L,67L,69L,71L,74L,76L,78L,81L,83L,85L,88L,90L,92L,95L,97L,99L,102L,104L,106L,109L,111L,113L,116L,118L,120L,123L,125L,127L,130L,132L,134L,137L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225002Inst : IEnumerable<long>
{
public static readonly long[] Value=A225002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225002.Bytes);
public long this[int i]=>Value[i];

public static A225002Inst Instance=new A225002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225003
{
public static readonly long[] Value={ 23L,2L,3L,5L,6L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,35L,37L,38L,40L,41L,42L,44L,45L,47L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,77L,79L,80L,82L,83L,84L,86L,87L,89L,90L,91L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225003Inst : IEnumerable<long>
{
public static readonly long[] Value=A225003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225003.Bytes);
public long this[int i]=>Value[i];

public static A225003Inst Instance=new A225003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225004
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,18L,49L,64L,81L,50L,121L,48L,169L,98L,75L,256L,289L,162L,361L,100L,147L,242L,529L,192L,625L,338L,729L,196L,841L,150L,961L,1024L,363L,578L,245L,324L,1369L,722L,507L,400L,1681L,294L,1849L,484L,405L,1058L,2209L,768L,2401L,1250L,867L,676L,2809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225004Inst : IEnumerable<long>
{
public static readonly long[] Value=A225004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225004.Bytes);
public long this[int i]=>Value[i];

public static A225004Inst Instance=new A225004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225005
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,5L,6L,9L,10L,15L,19L,23L,33L,45L,55L,69L,95L,130L,162L,214L,290L,375L,483L,656L,864L,1118L,1446L,1874L,2437L,3130L,4058L,5188L,6642L,8521L,11002L,14236L,18400L,23631L,30521L,39376L,50685L,65590L,84817L,109857L,141892L,183507L,237217L,307278L,398506L,517446L,672105L,873109L,1136472L,1479525L,1927138L,2513234L,3278553L,4279356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225005Inst : IEnumerable<long>
{
public static readonly long[] Value=A225005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225005.Bytes);
public long this[int i]=>Value[i];

public static A225005Inst Instance=new A225005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225006
{
public static readonly long[] Value={ 1L,2L,9L,50L,295L,1792L,11088L,69498L,439791L,2803658L,17978389L,115837592L,749321716L,4863369656L,31655226108L,206549749930L,1350638103791L,8848643946550L,58069093513635L,381650672631330L,2511733593767295L,16550500379912640L,109176697072162080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225006Inst : IEnumerable<long>
{
public static readonly long[] Value=A225006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225006.Bytes);
public long this[int i]=>Value[i];

public static A225006Inst Instance=new A225006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225007
{
public static readonly long[] Value={ 16L,86L,296L,791L,1792L,3612L,6672L,11517L,18832L,29458L,44408L,64883L,92288L,128248L,174624L,233529L,307344L,398734L,510664L,646415L,809600L,1004180L,1234480L,1505205L,1821456L,2188746L,2613016L,3100651L,3658496L,4293872L,5014592L,5828977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225007Inst : IEnumerable<long>
{
public static readonly long[] Value=A225007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225007.Bytes);
public long this[int i]=>Value[i];

public static A225007Inst Instance=new A225007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225008
{
public static readonly long[] Value={ 22L,148L,610L,1897L,4900L,11088L,22716L,43065L,76714L,129844L,210574L,329329L,499240L,736576L,1061208L,1497105L,2072862L,2822260L,3784858L,5006617L,6540556L,8447440L,10796500L,13666185L,17144946L,21332052L,26338438L,32287585L,39316432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225008Inst : IEnumerable<long>
{
public static readonly long[] Value=A225008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225008.Bytes);
public long this[int i]=>Value[i];

public static A225008Inst Instance=new A225008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225009
{
public static readonly long[] Value={ 29L,239L,1163L,4166L,12174L,30738L,69498L,144111L,278707L,508937L,885677L,1479452L,2385644L,3730548L,5678340L,8439021L,12277401L,17523187L,24582239L,33949058L,46220570L,62111270L,82469790L,108296955L,140765391L,181240749L,231304609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225009Inst : IEnumerable<long>
{
public static readonly long[] Value=A225009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225009.Bytes);
public long this[int i]=>Value[i];

public static A225009Inst Instance=new A225009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225010
{
public static readonly long[] Value={ 2L,4L,3L,7L,9L,4L,11L,22L,16L,5L,16L,46L,50L,25L,6L,22L,86L,130L,95L,36L,7L,29L,148L,296L,295L,161L,49L,8L,37L,239L,610L,791L,581L,252L,64L,9L,46L,367L,1163L,1897L,1792L,1036L,372L,81L,10L,56L,541L,2083L,4166L,4900L,3612L,1716L,525L,100L,11L,67L,771L,3544L,8518L,12174L,11088L,6672L,2685L,715L,121L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225010Inst : IEnumerable<long>
{
public static readonly long[] Value=A225010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225010.Bytes);
public long this[int i]=>Value[i];

public static A225010Inst Instance=new A225010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225011
{
public static readonly long[] Value={ 5L,25L,95L,295L,791L,1897L,4166L,8518L,16414L,30086L,52834L,89402L,146446L,233108L,361711L,548591L,815083L,1188679L,1704377L,2406241L,3349193L,4601059L,6244892L,8381596L,11132876L,14644540L,19090180L,24675260L,31641640L,40272566L,50898157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225011Inst : IEnumerable<long>
{
public static readonly long[] Value=A225011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225011.Bytes);
public long this[int i]=>Value[i];

public static A225011Inst Instance=new A225011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225012
{
public static readonly long[] Value={ 6L,36L,161L,581L,1792L,4900L,12174L,27966L,60172L,122464L,237590L,442118L,793092L,1377174L,2322967L,3817351L,6126818L,9624964L,14827487L,22436251L,33394208L,48953224L,70757132L,100942636L,142261016L,198223936L,273277036L,373005396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225012Inst : IEnumerable<long>
{
public static readonly long[] Value=A225012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225012.Bytes);
public long this[int i]=>Value[i];

public static A225012Inst Instance=new A225012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225013
{
public static readonly long[] Value={ 7L,49L,252L,1036L,3612L,11088L,30738L,78354L,186142L,416394L,884236L,1794196L,3497248L,6577474L,11980667L,21201211L,36548573L,61520899L,101320712L,163556776L,259187048L,403770544L,619111172L,935394436L,1393938716L,2050706932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225013Inst : IEnumerable<long>
{
public static readonly long[] Value=A225013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225013.Bytes);
public long this[int i]=>Value[i];

public static A225013Inst Instance=new A225013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225014
{
public static readonly long[] Value={ 8L,64L,372L,1716L,6672L,22716L,69498L,194634L,505912L,1233584L,2845492L,6251596L,13154948L,26635774L,52097267L,98759971L,181971248L,326703424L,572756312L,982365976L,1651162688L,2723729944L,4415408372L,7042481236L,11063492816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225014Inst : IEnumerable<long>
{
public static readonly long[] Value=A225014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225014.Bytes);
public long this[int i]=>Value[i];

public static A225014Inst Instance=new A225014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225015
{
public static readonly long[] Value={ 0L,1L,1L,5L,18L,66L,245L,918L,3465L,13156L,50193L,192270L,739024L,2848860L,11009778L,42642460L,165480975L,643281480L,2504501625L,9764299710L,38115568260L,148955040300L,582714871830L,2281745337300L,8942420595810L,35074414899576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225015Inst : IEnumerable<long>
{
public static readonly long[] Value=A225015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225015.Bytes);
public long this[int i]=>Value[i];

public static A225015Inst Instance=new A225015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225016
{
public static readonly long[] Value={ 3L,8L,7L,5L,7L,8L,4L,5L,8L,5L,0L,3L,7L,4L,7L,7L,5L,2L,1L,9L,3L,4L,5L,3L,9L,3L,8L,3L,3L,8L,7L,6L,7L,4L,4L,0L,0L,2L,7L,8L,1L,6L,1L,0L,7L,0L,7L,3L,5L,6L,3L,8L,4L,6L,1L,7L,6L,8L,0L,6L,7L,2L,6L,2L,9L,7L,5L,7L,9L,9L,3L,6L,4L,6L,8L,3L,2L,1L,3L,2L,5L,4L,6L,9L,5L,8L,3L,7L,6L,2L,9L,0L,7L,5L,3L,6L,0L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225016Inst : IEnumerable<long>
{
public static readonly long[] Value=A225016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225016.Bytes);
public long this[int i]=>Value[i];

public static A225016Inst Instance=new A225016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225017
{
public static readonly long[] Value={ 1L,1L,7L,1L,13L,11L,19L,23L,1L,13L,1L,19L,7L,23L,17L,11L,29L,7L,1L,59L,61L,31L,67L,37L,41L,77L,79L,89L,17L,83L,91L,13L,53L,89L,103L,23L,109L,13L,31L,67L,13L,137L,29L,149L,151L,29L,7L,1L,29L,79L,151L,19L,13L,119L,127L,167L,49L,43L,211L,191L,199L,97L,187L,17L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225017Inst : IEnumerable<long>
{
public static readonly long[] Value=A225017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225017.Bytes);
public long this[int i]=>Value[i];

public static A225017Inst Instance=new A225017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225018
{
public static readonly long[] Value={ 3L,30L,127L,301L,647L,1100L,1851L,2715L,4027L,5434L,7463L,9545L,12447L,15336L,19267L,23095L,28211L,33110L,39567L,45669L,53623L,61060L,70667L,79571L,90987L,101490L,114871L,127105L,142607L,156704L,174483L,190575L,210787L,229006L,251807L,272285L,297831L,320700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225018Inst : IEnumerable<long>
{
public static readonly long[] Value=A225018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225018.Bytes);
public long this[int i]=>Value[i];

public static A225018Inst Instance=new A225018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225019
{
public static readonly BigInteger[] Value={ 81L,1935L,117959L,68599847L,61256508583L,377600972329977L,3848918646053092273L,BigInteger.Parse("232902549373982083370091"),BigInteger.Parse("26631802795042217377560514459"),BigInteger.Parse("15822211869785345098476275119070159") };
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
public class A225019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225019Inst Instance=new A225019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225020
{
public static readonly long[] Value={ 81L,253L,759L,2653L,9273L,34545L,130067L,502563L,1957855L,7707477L,30479641L,121049341L,481805459L,1921111559L,7667874767L,30628405561L,122397615337L,489285404561L,1956323203363L,7823125185531L,31286692332191L,125131311950285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225020Inst : IEnumerable<long>
{
public static readonly long[] Value=A225020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225020.Bytes);
public long this[int i]=>Value[i];

public static A225020Inst Instance=new A225020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225021
{
public static readonly long[] Value={ 253L,1935L,12641L,113261L,979821L,9045373L,82894903L,768456167L,7112825923L,65968698193L,611639117173L,5672921683137L,52612656431953L,487979068798433L,4525916701502467L,41977528928082105L,389337361830188511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225021Inst : IEnumerable<long>
{
public static readonly long[] Value=A225021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225021.Bytes);
public long this[int i]=>Value[i];

public static A225021Inst Instance=new A225021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225022
{
public static readonly long[] Value={ 759L,12641L,117959L,1930229L,23865033L,356942157L,4807268289L,69047521033L,955759546369L,13524243825173L,188930469462525L,2659392660837205L,37267832167287375L,523625716790262929L,7345839047616799405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225022Inst : IEnumerable<long>
{
public static readonly long[] Value=A225022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225022.Bytes);
public long this[int i]=>Value[i];

public static A225022Inst Instance=new A225022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225023
{
public static readonly BigInteger[] Value={ 2653L,113261L,1930229L,68599847L,1695172731L,52562324371L,1457105103421L,43215008345605L,1240053913896303L,36294561965670221L,1052106584541296967L,BigInteger.Parse("30674878297649042749"),BigInteger.Parse("891844038980959163315"),BigInteger.Parse("25973093782593822861529") };
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
public class A225023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225023Inst Instance=new A225023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225024
{
public static readonly BigInteger[] Value={ 9273L,979821L,23865033L,1695172731L,61256508583L,3420719145421L,144661440731701L,7310039035972089L,329657881472577779L,15990423886532132411UL,BigInteger.Parse("740325485682134610189"),BigInteger.Parse("35313542543938503305813") };
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
public class A225024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225024Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225024.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225024.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225024Inst Instance=new A225024Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225025
{
public static readonly BigInteger[] Value={ 34545L,9045373L,356942157L,52562324371L,3420719145421L,377600972329977L,30374776273526073L,2996776449993067119L,BigInteger.Parse("262356224598904294079"),BigInteger.Parse("24807486322017404713095"),BigInteger.Parse("2243325257818680726558591") };
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
public class A225025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225025.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225025Inst Instance=new A225025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225026
{
public static readonly BigInteger[] Value={ 130067L,82894903L,4807268289L,1457105103421L,144661440731701L,30374776273526073L,3848918646053092273L,BigInteger.Parse("685519915895769188527"),BigInteger.Parse("97075380150037938324113"),BigInteger.Parse("16048326634902226961603885") };
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
public class A225026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225026Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225026.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225026Inst Instance=new A225026Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225027
{
public static readonly long[] Value={ 81L,253L,253L,759L,1935L,759L,2653L,12641L,12641L,2653L,9273L,113261L,117959L,113261L,9273L,34545L,979821L,1930229L,1930229L,979821L,34545L,130067L,9045373L,23865033L,68599847L,23865033L,9045373L,130067L,502563L,82894903L,356942157L,1695172731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225027Inst : IEnumerable<long>
{
public static readonly long[] Value=A225027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225027.Bytes);
public long this[int i]=>Value[i];

public static A225027Inst Instance=new A225027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225028
{
public static readonly long[] Value={ 36L,42L,50L,1316L,12540240L,29559057L,131080256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225028Inst : IEnumerable<long>
{
public static readonly long[] Value=A225028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225028.Bytes);
public long this[int i]=>Value[i];

public static A225028Inst Instance=new A225028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225029
{
public static readonly long[] Value={ 1L,4L,19L,103L,616L,3949L,26545L,184120L,1303135L,9341191L,67490044L,489978217L,3567727441L,26024391436L,190036459099L,1388593185079L,10150390743088L,74215146065461L,542704850311009L,3968914608295360L,29026988765886535L,212297824609934455L,1552734183515322436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225029Inst : IEnumerable<long>
{
public static readonly long[] Value=A225029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225029.Bytes);
public long this[int i]=>Value[i];

public static A225029Inst Instance=new A225029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225030
{
public static readonly ulong[] Value={ 1L,5L,29L,193L,1441L,11765L,102701L,941857L,8955937L,87439877L,870218525L,8780788513L,89476873345L,918150779957L,9467752541933L,97965021468865L,1016097175530433L,10556565963815045L,109802406545873309L,1143006276663287809L,11904902286515536609UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225030Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A225030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225030.Bytes);
public ulong this[int i]=>Value[i];

public static A225030Inst Instance=new A225030Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225031
{
public static readonly BigInteger[] Value={ 1L,6L,41L,321L,2846L,27961L,297681L,3371646L,40065361L,494281201L,6279901766L,81649478161L,1080910639201L,14511820543126L,196956264035481L,2695543342918241L,37127978351861646L,513895401953712521L,7139331902125917361L,BigInteger.Parse("99462520534916445006"),BigInteger.Parse("1388616983941077336321") };
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
public class A225031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225031Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225031.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225031.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225031Inst Instance=new A225031Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225032
{
public static readonly BigInteger[] Value={ 1L,7L,55L,493L,5029L,57379L,716443L,9604345L,136236937L,2022864031L,31180099711L,495615409957L,8079827006125L,134488017925243L,2276945808434659L,39088515241450609L,678651272689389073L,11890942901283331255UL,BigInteger.Parse("209891714523969067207"),BigInteger.Parse("3727004974842239659741") };
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
public class A225032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225032Inst Instance=new A225032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225033
{
public static readonly BigInteger[] Value={ 1L,8L,71L,715L,8212L,106205L,1514633L,23353828L,383455843L,6630981491L,119760987872L,2243989397161L,43378019032321L,861000869284928L,17476961860459151L,361541275664799595L,7599788958355060972L,BigInteger.Parse("161922899182197739685"),BigInteger.Parse("3489406153035009734633"),BigInteger.Parse("75917779229255330345308") };
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
public class A225033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225033Inst Instance=new A225033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225034
{
public static readonly long[] Value={ 1L,3L,7L,18L,48L,131L,363L,1017L,2873L,8169L,23349L,67024L,193086L,557949L,1616501L,4694034L,13657896L,39809649L,116218701L,339762942L,994553160L,2914608177L,8550424953L,25107964077L,73793368593L,217057617567L,638936722403L,1882096946232L,5547613247418L,16361808691243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225034Inst : IEnumerable<long>
{
public static readonly long[] Value=A225034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225034.Bytes);
public long this[int i]=>Value[i];

public static A225034Inst Instance=new A225034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225035
{
public static readonly long[] Value={ 13L,17L,31L,37L,71L,73L,79L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,239L,241L,251L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L,349L,359L,367L,373L,379L,389L,397L,401L,419L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225035Inst : IEnumerable<long>
{
public static readonly long[] Value=A225035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225035.Bytes);
public long this[int i]=>Value[i];

public static A225035Inst Instance=new A225035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225036
{
public static readonly long[] Value={ 5913774023L,9137740231L,7402314407L,4023144077L,8735261779L,4830981887L,8309818873L,3307626667L,8853659527L,6595276357L,5952763577L,7635775283L,3577528379L,3792268331L,9085975607L,9264752779L,6698082641L,8968771057L,1057327889L,5972589229L,4137067777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225036Inst : IEnumerable<long>
{
public static readonly long[] Value=A225036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225036.Bytes);
public long this[int i]=>Value[i];

public static A225036Inst Instance=new A225036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225037
{
public static readonly long[] Value={ 1L,6L,8L,7L,6L,3L,5L,2L,1L,5L,1L,1L,9L,1L,1L,2L,4L,6L,5L,5L,1L,8L,8L,9L,4L,9L,7L,2L,8L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225037Inst : IEnumerable<long>
{
public static readonly long[] Value=A225037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225037.Bytes);
public long this[int i]=>Value[i];

public static A225037Inst Instance=new A225037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225038
{
public static readonly long[] Value={ 1L,3L,7L,27L,31L,41L,47L,54L,55L,62L,63L,71L,73L,82L,83L,91L,94L,95L,6631675L,7460635L,319804831L,379027947L,426406441L,479707247L,568541921L,598957743L,639609662L,639609663L,719560871L,758055894L,758055895L,852812882L,852812883L,898436615L,959414494L,959414495L,1010741193L,1079341307L,1137083842L,1137083843L,1410123943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225038Inst : IEnumerable<long>
{
public static readonly long[] Value=A225038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225038.Bytes);
public long this[int i]=>Value[i];

public static A225038Inst Instance=new A225038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225039
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,11L,19L,23L,17L,29L,59L,61L,31L,67L,37L,41L,79L,89L,83L,53L,103L,109L,137L,149L,151L,127L,167L,43L,211L,191L,199L,97L,181L,197L,193L,241L,269L,113L,233L,257L,139L,311L,317L,293L,283L,263L,349L,409L,173L,47L,353L,419L,431L,389L,401L,439L,463L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225039Inst : IEnumerable<long>
{
public static readonly long[] Value=A225039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225039.Bytes);
public long this[int i]=>Value[i];

public static A225039Inst Instance=new A225039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225040
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,9L,7L,8L,10L,13L,15L,16L,28L,50L,20L,11L,12L,14L,69L,66L,17L,19L,18L,32L,86L,21L,64L,22L,38L,26L,74L,23L,41L,24L,25L,71L,89L,27L,49L,84L,33L,30L,35L,34L,31L,29L,175L,96L,60L,39L,181L,36L,110L,40L,46L,37L,68L,138L,119L,45L,44L,139L,42L,73L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225040Inst : IEnumerable<long>
{
public static readonly long[] Value=A225040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225040.Bytes);
public long this[int i]=>Value[i];

public static A225040Inst Instance=new A225040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225041
{
public static readonly long[] Value={ 1L,1L,3L,9L,35L,145L,659L,3137L,15619L,80177L,422595L,2273633L,12447667L,69138193L,388784259L,2209440945L,12671782579L,73260414481L,426545078627L,2499059841249L,14723542302627L,87181150961361L,518554078448339L,3097007445391441L,18565515801339827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225041Inst : IEnumerable<long>
{
public static readonly long[] Value=A225041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225041.Bytes);
public long this[int i]=>Value[i];

public static A225041Inst Instance=new A225041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225042
{
public static readonly BigInteger[] Value={ 1L,2L,8L,48L,360L,3088L,28928L,288208L,3003952L,32402384L,359019952L,4064452272L,46829600704L,547498996736L,6480275672192L,77511461858592L,935562094075392L,11381614588917296L,139425068741674448L,1718444636265140992L,BigInteger.Parse("21295889048851102176"),BigInteger.Parse("265200380258393530896") };
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
public class A225042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225042Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225042.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225042.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225042Inst Instance=new A225042Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225043
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,1L,4L,1L,1L,5L,4L,4L,5L,1L,1L,6L,1L,6L,1L,6L,1L,1L,7L,5L,3L,3L,5L,7L,1L,1L,8L,1L,2L,7L,2L,1L,8L,1L,1L,9L,6L,4L,6L,6L,4L,6L,9L,1L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,1L,11L,7L,9L,6L,6L,6L,6L,9L,7L,11L,1L,1L,12L,1L,12L,1L,12L,1L,12L,1L,12L,1L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225043Inst : IEnumerable<long>
{
public static readonly long[] Value=A225043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225043.Bytes);
public long this[int i]=>Value[i];

public static A225043Inst Instance=new A225043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225044
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,2L,2L,4L,4L,5L,6L,9L,10L,13L,14L,21L,22L,30L,32L,44L,48L,62L,69L,89L,100L,124L,141L,173L,198L,239L,274L,330L,377L,450L,514L,611L,697L,823L,939L,1104L,1258L,1470L,1676L,1950L,2220L,2572L,2927L,3381L,3841L,4420L,5019L,5759L,6529L,7470L,8460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225044Inst : IEnumerable<long>
{
public static readonly long[] Value=A225044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225044.Bytes);
public long this[int i]=>Value[i];

public static A225044Inst Instance=new A225044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225045
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,1L,3L,1L,4L,3L,5L,5L,5L,7L,7L,10L,10L,13L,13L,16L,18L,21L,25L,27L,32L,33L,41L,44L,53L,57L,65L,73L,81L,93L,102L,118L,128L,145L,159L,181L,200L,224L,246L,275L,304L,337L,375L,413L,460L,503L,559L,614L,679L,749L,821L,907L,991L,1096L,1197L,1319L,1442L,1582L,1733L,1893L,2076L,2265L,2482L,2702L,2956L,3220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225045Inst : IEnumerable<long>
{
public static readonly long[] Value=A225045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225045.Bytes);
public long this[int i]=>Value[i];

public static A225045Inst Instance=new A225045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225046
{
public static readonly long[] Value={ 2L,5L,4L,14L,6L,7L,16L,21L,23L,24L,57L,122L,32L,19L,20L,22L,186L,177L,26L,29L,27L,61L,236L,34L,160L,36L,78L,54L,194L,41L,87L,43L,44L,188L,253L,55L,118L,229L,66L,59L,70L,69L,60L,58L,569L,279L,147L,81L,610L,74L,325L,85L,101L,75L,179L,459L,369L,100L,97L,463L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225046Inst : IEnumerable<long>
{
public static readonly long[] Value=A225046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225046.Bytes);
public long this[int i]=>Value[i];

public static A225046Inst Instance=new A225046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225047
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,10L,12L,8L,13L,11L,16L,17L,19L,14L,20L,15L,23L,21L,24L,18L,28L,22L,27L,25L,31L,26L,36L,29L,32L,33L,35L,30L,40L,34L,39L,37L,43L,38L,44L,41L,47L,48L,50L,42L,54L,45L,51L,49L,55L,46L,58L,52L,59L,53L,62L,56L,63L,57L,66L,64L,67L,60L,71L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225047Inst : IEnumerable<long>
{
public static readonly long[] Value=A225047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225047.Bytes);
public long this[int i]=>Value[i];

public static A225047Inst Instance=new A225047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225048
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,10L,14L,15L,16L,18L,19L,21L,22L,25L,27L,28L,29L,32L,33L,34L,35L,37L,38L,40L,43L,46L,47L,48L,49L,50L,52L,55L,57L,60L,61L,63L,64L,65L,70L,71L,73L,74L,78L,79L,82L,84L,85L,88L,89L,91L,92L,93L,94L,97L,99L,100L,104L,106L,109L,110L,115L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225048Inst : IEnumerable<long>
{
public static readonly long[] Value=A225048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225048.Bytes);
public long this[int i]=>Value[i];

public static A225048Inst Instance=new A225048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225049
{
public static readonly long[] Value={ 30L,41L,56L,81L,95L,96L,98L,101L,112L,114L,121L,125L,131L,142L,146L,152L,157L,168L,173L,177L,182L,186L,191L,196L,197L,199L,206L,209L,213L,215L,216L,217L,227L,230L,232L,234L,240L,243L,245L,247L,248L,257L,260L,262L,266L,272L,276L,284L,285L,287L,292L,299L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225049Inst : IEnumerable<long>
{
public static readonly long[] Value=A225049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225049.Bytes);
public long this[int i]=>Value[i];

public static A225049Inst Instance=new A225049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225050
{
public static readonly long[] Value={ 1L,4L,24L,148L,920L,5754L,36204L,229128L,1458072L,9325030L,59905274L,386368008L,2500651244L,16234450288L,105680341560L,689579733648L,4509096746904L,29539804567230L,193843622021910L,1273932593379600L,8383551165082170L,55238332546851630L,364364231864557080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225050Inst : IEnumerable<long>
{
public static readonly long[] Value=A225050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225050.Bytes);
public long this[int i]=>Value[i];

public static A225050Inst Instance=new A225050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225051
{
public static readonly long[] Value={ 0L,2L,16L,54L,128L,250L,432L,686L,1024L,1458L,1001L,1333L,1737L,2225L,2809L,3501L,4313L,5257L,6345L,7589L,8008L,9270L,10664L,12202L,13896L,15758L,17800L,20034L,22472L,25126L,27027L,29819L,32803L,35991L,39395L,43027L,46899L,51023L,55411L,60075L,64064L,68986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225051Inst : IEnumerable<long>
{
public static readonly long[] Value=A225051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225051.Bytes);
public long this[int i]=>Value[i];

public static A225051Inst Instance=new A225051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225052
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,50L,426L,4606L,60418L,932282L,16547562L,332152614L,7439791314L,183964790514L,4977606096570L,146287199495310L,4640510332052370L,158035939351814250L,5750979655319685834L,BigInteger.Parse("222710142933114209526"),BigInteger.Parse("9144799526131421284434"),BigInteger.Parse("396863889188887568805282") };
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
public class A225052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225052Inst Instance=new A225052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225053
{
public static readonly long[] Value={ 1L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225053Inst : IEnumerable<long>
{
public static readonly long[] Value=A225053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225053.Bytes);
public long this[int i]=>Value[i];

public static A225053Inst Instance=new A225053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225054
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,1L,3L,2L,2L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,5L,3L,3L,5L,7L,1L,1L,7L,1L,7L,4L,7L,1L,7L,1L,1L,3L,0L,2L,4L,4L,2L,0L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,11L,9L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225054Inst : IEnumerable<long>
{
public static readonly long[] Value=A225054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225054.Bytes);
public long this[int i]=>Value[i];

public static A225054Inst Instance=new A225054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225055
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,12L,5L,10L,20L,7L,14L,28L,9L,18L,36L,11L,22L,44L,13L,26L,52L,15L,30L,60L,17L,34L,68L,19L,38L,76L,21L,42L,84L,23L,46L,92L,25L,50L,100L,27L,54L,108L,29L,58L,116L,31L,62L,124L,33L,66L,132L,35L,70L,140L,37L,74L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225055Inst : IEnumerable<long>
{
public static readonly long[] Value=A225055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225055.Bytes);
public long this[int i]=>Value[i];

public static A225055Inst Instance=new A225055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225056
{
public static readonly long[] Value={ 3199L,339L,1267L,258L,696L,209L,5514L,4043L,1773L,390L,4188L,21735L,4449L,426L,19410L,14681L,159L,23475L,1074L,36876L,1449L,349L,6525L,4725L,3141L,354L,2799L,16164L,369L,8751L,2385L,9534L,7973L,6045L,1644L,17377L,10574L,21060L,465L,7734L,24264L,9630L,43005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225056Inst : IEnumerable<long>
{
public static readonly long[] Value=A225056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225056.Bytes);
public long this[int i]=>Value[i];

public static A225056Inst Instance=new A225056Inst();

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