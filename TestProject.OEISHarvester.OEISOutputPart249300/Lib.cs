using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A076899
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,3L,1L,2L,2L,1L,5L,5L,1L,3L,3L,1L,8L,8L,1L,5L,5L,1L,13L,13L,1L,8L,8L,1L,21L,21L,1L,13L,13L,1L,34L,34L,1L,21L,21L,1L,55L,55L,1L,34L,34L,1L,89L,89L,1L,55L,55L,1L,144L,144L,1L,89L,89L,1L,233L,233L,1L,144L,144L,1L,377L,377L,1L,233L,233L,1L,610L,610L,1L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076899Inst : IEnumerable<long>
{
public static readonly long[] Value=A076899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076899.Bytes);
public long this[int i]=>Value[i];

public static A076899Inst Instance=new A076899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076948
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,5L,0L,0L,0L,0L,5L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,10L,0L,0L,0L,0L,5L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,10L,13L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076948Inst : IEnumerable<long>
{
public static readonly long[] Value=A076948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076948.Bytes);
public long this[int i]=>Value[i];

public static A076948Inst Instance=new A076948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076949
{
public static readonly long[] Value={ 1L,2L,2L,5L,9L,0L,2L,4L,4L,3L,5L,2L,8L,7L,4L,8L,5L,3L,8L,6L,2L,7L,9L,4L,7L,4L,9L,5L,9L,1L,3L,0L,0L,8L,5L,2L,1L,3L,2L,1L,2L,2L,9L,3L,2L,0L,9L,6L,9L,6L,6L,1L,2L,8L,2L,3L,1L,7L,7L,0L,0L,9L,0L,7L,2L,5L,5L,2L,3L,3L,9L,9L,7L,5L,2L,6L,5L,7L,3L,8L,0L,2L,1L,6L,7L,9L,1L,5L,4L,5L,2L,0L,4L,9L,9L,2L,8L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076949Inst : IEnumerable<long>
{
public static readonly long[] Value=A076949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076949.Bytes);
public long this[int i]=>Value[i];

public static A076949Inst Instance=new A076949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076950
{
public static readonly long[] Value={ 1L,1L,3L,7L,13L,21L,4L,43L,1L,73L,91L,111L,5L,2L,183211L,241L,7L,27L,343L,6L,421L,463L,507L,553L,189L,19L,1L,757L,813L,7L,931L,993L,1057L,196L,37L,36L,518L,126L,1483L,1561L,3L,8L,1807L,61L,1981L,2071L,2163L,140L,2353L,2451L,234L,2653L,91L,2863L,532L,9L,3193L,3307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076950Inst : IEnumerable<long>
{
public static readonly long[] Value=A076950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076950.Bytes);
public long this[int i]=>Value[i];

public static A076950Inst Instance=new A076950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076951
{
public static readonly BigInteger[] Value={ 1L,1L,3L,0L,205L,0L,39991L,0L,57L,5905L,9090909091L,0L,8230246567621L,0L,10371206370520815L,0L,17361641481138401521UL,0L,BigInteger.Parse("37275544492386193492507"),0L,22706531343006L,0L,BigInteger.Parse("326583187044036098379401213863"),0L,45035996273705L };
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
public class A076951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076951Inst Instance=new A076951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076952
{
public static readonly BigInteger[] Value={ 0L,1L,8L,0L,1024L,0L,279936L,0L,512L,59049L,100000000000L,0L,106993205379072L,0L,155568095557812224L,0L,BigInteger.Parse("295147905179352825856"),0L,BigInteger.Parse("708235345355337676357632"),0L,476837158203125L,0L,BigInteger.Parse("7511413302012830262726227918848"),0L,1125899906842624L };
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
public class A076952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076952Inst Instance=new A076952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076953
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,4L,0L,4L,4L,4L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,6L,8L,0L,8L,0L,8L,6L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,8L,0L,8L,6L,8L,0L,8L,0L,4L,0L,0L,0L,4L,0L,4L,6L,0L,0L,6L,4L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076953Inst : IEnumerable<long>
{
public static readonly long[] Value=A076953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076953.Bytes);
public long this[int i]=>Value[i];

public static A076953Inst Instance=new A076953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076954
{
public static readonly BigInteger[] Value={ 1L,2L,18L,2250L,5402250L,870037764750L,4199506113235182750L,BigInteger.Parse("1723219765760312626547490750"),BigInteger.Parse("29266411525287522788837599332989370750"),BigInteger.Parse("52713275010243038997421106186697438702252144407250"),BigInteger.Parse("22176856087751973465466098269669474342964368337745368642450857250") };
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
public class A076954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076954Inst Instance=new A076954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076955
{
public static readonly BigInteger[] Value={ 1L,8L,1944L,31850496L,1555200000000000L,BigInteger.Parse("20311991333683200000000000"),BigInteger.Parse("4725188984058417024032990822400000000000"),BigInteger.Parse("680971499131541103151460312870118086801149132800000000000") };
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
public class A076955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076955Inst Instance=new A076955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076956
{
public static readonly long[] Value={ 1L,16L,36L,100L,225L,256L,625L,576L,961L,1521L,1444L,2025L,4096L,2304L,2704L,3249L,5625L,6724L,6561L,4900L,5776L,6241L,11236L,12544L,21025L,12321L,14641L,13689L,15129L,17956L,20736L,19321L,21316L,23716L,26569L,36864L,28561L,30976L,32041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076956Inst : IEnumerable<long>
{
public static readonly long[] Value=A076956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076956.Bytes);
public long this[int i]=>Value[i];

public static A076956Inst Instance=new A076956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076957
{
public static readonly long[] Value={ 1L,4L,6L,10L,15L,16L,25L,24L,31L,39L,38L,45L,64L,48L,52L,57L,75L,82L,81L,70L,76L,79L,106L,112L,145L,111L,121L,117L,123L,134L,144L,139L,146L,154L,163L,192L,169L,176L,179L,193L,202L,218L,204L,226L,223L,240L,233L,238L,243L,259L,291L,256L,286L,309L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076957Inst : IEnumerable<long>
{
public static readonly long[] Value=A076957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076957.Bytes);
public long this[int i]=>Value[i];

public static A076957Inst Instance=new A076957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076958
{
public static readonly long[] Value={ 0L,2L,5L,16L,42L,111L,296L,793L,2130L,5796L,15788L,43370L,119711L,332449L,927748L,2600623L,7319908L,20677806L,58604898L,166595953L,474868192L,1356904893L,3885983995L,11151740822L,32062866197L,92345080709L,266390632933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076958Inst : IEnumerable<long>
{
public static readonly long[] Value=A076958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076958.Bytes);
public long this[int i]=>Value[i];

public static A076958Inst Instance=new A076958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076959
{
public static readonly long[] Value={ 0L,2L,9L,32L,119L,435L,1573L,5695L,20773L,76057L,279850L,1033937L,3837070L,14296494L,53468768L,200673056L,755606952L,2853697709L,10807617884L,41036410818L,156186010430L,595759180892L,2277112205791L,8720036044777L,33451314673521L,128533154571957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076959Inst : IEnumerable<long>
{
public static readonly long[] Value=A076959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076959.Bytes);
public long this[int i]=>Value[i];

public static A076959Inst Instance=new A076959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076960
{
public static readonly long[] Value={ 0L,8L,125L,4222L,258659L,25306159L,3610490130L,706003793908L,181035032176791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076960Inst : IEnumerable<long>
{
public static readonly long[] Value=A076960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076960.Bytes);
public long this[int i]=>Value[i];

public static A076960Inst Instance=new A076960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076961
{
public static readonly BigInteger[] Value={ 2L,4L,81L,64L,9765625L,0L,33232930569601L,262144L,31381059609L,0L,BigInteger.Parse("17449402268886407318558803753801"),0L,BigInteger.Parse("361188648084531445929920877641340156544317601"),0L,0L,4503599627370496L };
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
public class A076961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076961Inst Instance=new A076961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076962
{
public static readonly BigInteger[] Value={ 0L,3L,25L,14L,14641L,52L,24137569L,114L,2116L,464L,819628286980801L,444L,BigInteger.Parse("22563490300366186081"),2752L,35344L,1272L,BigInteger.Parse("21559177407076402401757871041"),2196L,BigInteger.Parse("740195513856780056217081017732809"),3408L,341056L,80896L,BigInteger.Parse("1658509762573818415340429240403156732495289"),5340L };
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
public class A076962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076962Inst Instance=new A076962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076963
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,21L,22L,27L,28L,45L,52L,63L,64L,105L,128L,135L,136L,165L,182L,225L,256L,315L,352L,525L,544L,585L,608L,675L,704L,945L,1144L,1575L,2288L,2835L,2992L,4095L,5984L,5985L,7072L,7245L,7904L,8085L,9568L,9765L,10208L,11025L,11968L,12285L,23936L,25935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076963Inst : IEnumerable<long>
{
public static readonly long[] Value=A076963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076963.Bytes);
public long this[int i]=>Value[i];

public static A076963Inst Instance=new A076963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076980
{
public static readonly long[] Value={ 3L,8L,17L,32L,54L,57L,100L,145L,177L,320L,368L,512L,593L,945L,1124L,1649L,2169L,2530L,4240L,5392L,6250L,7073L,8361L,16580L,18785L,20412L,23401L,32993L,60049L,65792L,69632L,93312L,94932L,131361L,178478L,262468L,268705L,397585L,423393L,524649L,533169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076980Inst : IEnumerable<long>
{
public static readonly long[] Value=A076980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076980.Bytes);
public long this[int i]=>Value[i];

public static A076980Inst Instance=new A076980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076981
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,4L,3L,6L,5L,4L,4L,10L,9L,12L,11L,10L,9L,16L,15L,18L,17L,16L,15L,22L,21L,20L,19L,18L,17L,28L,27L,30L,29L,28L,27L,26L,25L,36L,35L,34L,33L,40L,39L,42L,41L,40L,39L,46L,45L,44L,43L,42L,41L,52L,51L,50L,49L,48L,47L,58L,57L,60L,59L,58L,57L,56L,55L,66L,65L,64L,63L,70L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076981Inst : IEnumerable<long>
{
public static readonly long[] Value=A076981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076981.Bytes);
public long this[int i]=>Value[i];

public static A076981Inst Instance=new A076981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076982
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,2L,4L,4L,2L,4L,4L,2L,5L,6L,2L,3L,3L,3L,8L,4L,2L,4L,6L,2L,3L,5L,2L,4L,4L,2L,5L,3L,2L,10L,4L,2L,3L,7L,3L,4L,4L,2L,9L,5L,2L,4L,6L,2L,4L,5L,2L,3L,6L,5L,6L,3L,2L,6L,6L,2L,4L,7L,3L,5L,3L,2L,4L,6L,2L,5L,5L,2L,4L,7L,2L,6L,3L,3L,9L,3L,2L,5L,10L,2L,3L,5L,2L,5L,8L,3L,4L,3L,2L,8L,4L,2L,5L,10L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076982Inst : IEnumerable<long>
{
public static readonly long[] Value=A076982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076982.Bytes);
public long this[int i]=>Value[i];

public static A076982Inst Instance=new A076982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076983
{
public static readonly long[] Value={ 1L,3L,6L,36L,105L,120L,780L,210L,990L,630L,19110L,7140L,5460L,176715L,25200L,73920L,103740L,145530L,97020L,157080L,4744740L,2386020L,1185030L,2031120L,3483480L,13857480L,8817900L,118572300L,88438350L,39209940L,286071240L,2162160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076983Inst : IEnumerable<long>
{
public static readonly long[] Value=A076983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076983.Bytes);
public long this[int i]=>Value[i];

public static A076983Inst Instance=new A076983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076984
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,3L,3L,3L,2L,5L,2L,3L,4L,4L,2L,5L,2L,5L,4L,3L,2L,7L,3L,3L,4L,5L,2L,7L,2L,5L,4L,3L,4L,8L,2L,3L,4L,7L,2L,7L,2L,5L,6L,3L,2L,9L,3L,5L,4L,5L,2L,7L,4L,7L,4L,3L,2L,11L,2L,3L,6L,6L,4L,7L,2L,5L,4L,7L,2L,11L,2L,3L,6L,5L,4L,7L,2L,9L,5L,3L,2L,11L,4L,3L,4L,7L,2L,11L,4L,5L,4L,3L,4L,11L,2L,5L,6L,8L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076984Inst : IEnumerable<long>
{
public static readonly long[] Value=A076984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076984.Bytes);
public long this[int i]=>Value[i];

public static A076984Inst Instance=new A076984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076985
{
public static readonly BigInteger[] Value={ 1L,2L,8L,610L,144L,1134903170L,46368L,14930352L,4807526976L,BigInteger.Parse("195213253247748995819462552458453873038805359382500103059256395691957239"),2152809678530L,1548008755920L,BigInteger.Parse("303124944601307480151388995590175408058857436768033423077509087810") };
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
public class A076985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076985Inst Instance=new A076985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076986
{
public static readonly long[] Value={ 2L,3L,7L,5L,6L,7L,15L,17L,10L,11L,23L,13L,14L,15L,31L,17L,35L,19L,39L,21L,22L,23L,47L,73L,26L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076986Inst : IEnumerable<long>
{
public static readonly long[] Value=A076986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076986.Bytes);
public long this[int i]=>Value[i];

public static A076986Inst Instance=new A076986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076987
{
public static readonly long[] Value={ 3L,3L,10L,21L,6L,55L,15L,105L,10L,21L,45L,253L,66L,15L,91L,465L,120L,55L,153L,21L,190L,45L,231L,1081L,276L,105L,28L,253L,378L,91L,435L,1953L,496L,171L,36L,253L,630L,153L,703L,561L,780L,253L,861L,45L,91L,231L,1035L,4465L,1128L,351L,1225L,105L,1326L,55L,276L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076987Inst : IEnumerable<long>
{
public static readonly long[] Value=A076987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076987.Bytes);
public long this[int i]=>Value[i];

public static A076987Inst Instance=new A076987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076988
{
public static readonly long[] Value={ 2L,3L,13L,5L,21L,13L,8L,89L,55L,21L,34L,13L,144L,1597L,63245986L,28657L,987L,55L,1597L,21L,610L,89L,17711L,28657L,4807526976L,514229L,55L,1597L,233L,165580141L,514229L,2971215073L,34L,987L,17711L,28657L,14930352L,1597L,139583862445L,956722026041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076988Inst : IEnumerable<long>
{
public static readonly long[] Value=A076988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076988.Bytes);
public long this[int i]=>Value[i];

public static A076988Inst Instance=new A076988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076989
{
public static readonly long[] Value={ 8L,27L,64L,125L,216L,343L,8L,729L,64L,1331L,1728L,2197L,27L,729L,4096L,4913L,5832L,343L,343L,9261L,64L,12167L,13824L,15625L,17576L,27L,1000L,729L,27000L,29791L,125L,35937L,39304L,42875L,1331L,2197L,1000L,343L,4096L,68921L,74088L,15625L,216L,91125L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076989Inst : IEnumerable<long>
{
public static readonly long[] Value=A076989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076989.Bytes);
public long this[int i]=>Value[i];

public static A076989Inst Instance=new A076989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076990
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,6L,3L,10L,16L,11L,14L,12L,15L,20L,18L,9L,26L,24L,17L,30L,32L,21L,36L,22L,13L,38L,28L,7L,44L,46L,19L,42L,40L,25L,48L,34L,27L,52L,58L,29L,50L,60L,39L,64L,54L,31L,66L,70L,37L,56L,74L,33L,72L,62L,23L,78L,80L,35L,76L,68L,47L,82L,94L,51L,84L,88L,55L,86L,92L,45L,90L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076990Inst : IEnumerable<long>
{
public static readonly long[] Value=A076990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076990.Bytes);
public long this[int i]=>Value[i];

public static A076990Inst Instance=new A076990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076991
{
public static readonly long[] Value={ 1L,2L,6L,8L,11L,17L,21L,26L,34L,4L,43L,53L,25L,3L,36L,10L,18L,72L,31L,41L,9L,14L,13L,22L,29L,30L,5L,46L,49L,74L,73L,78L,45L,102L,109L,113L,67L,16L,38L,27L,35L,19L,90L,12L,42L,115L,39L,15L,142L,68L,79L,177L,33L,114L,214L,156L,71L,62L,63L,44L,37L,40L,23L,58L,88L,50L,87L,7L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076991Inst : IEnumerable<long>
{
public static readonly long[] Value=A076991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076991.Bytes);
public long this[int i]=>Value[i];

public static A076991Inst Instance=new A076991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076992
{
public static readonly long[] Value={ 1L,2L,7L,3L,17L,4L,57L,5L,160L,6L,497L,8L,1454L,9L,4422L,10L,13117L,11L,39515L,12L,118092L,13L,354778L,14L,1062876L,15L,3190085L,16L,9565931L,18L,28702218L,19L,86093433L,20L,258293423L,21L,774840968L,22L,2324562427L,23L,6973568791L,24L,20920824474L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076992Inst : IEnumerable<long>
{
public static readonly long[] Value=A076992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076992.Bytes);
public long this[int i]=>Value[i];

public static A076992Inst Instance=new A076992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076993
{
public static readonly long[] Value={ 2L,3L,7L,15L,31L,94L,95L,191L,383L,767L,1535L,3071L,6143L,12287L,36862L,36863L,73727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076993Inst : IEnumerable<long>
{
public static readonly long[] Value=A076993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076993.Bytes);
public long this[int i]=>Value[i];

public static A076993Inst Instance=new A076993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076994
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,23L,43L,85L,167L,331L,661L,1321L,2641L,5281L,10561L,21121L,42241L,84481L,168961L,337921L,675841L,1351681L,2703361L,5406721L,10813441L,21626881L,43253761L,86507521L,173015041L,346030081L,692060161L,1384120321L,2768240641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076994Inst : IEnumerable<long>
{
public static readonly long[] Value=A076994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076994.Bytes);
public long this[int i]=>Value[i];

public static A076994Inst Instance=new A076994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076995
{
public static readonly long[] Value={ 4L,6L,10L,18L,35L,69L,136L,270L,539L,1077L,2152L,4303L,8605L,17208L,34415L,68829L,137657L,275313L,550625L,1101249L,2202497L,4404993L,8809985L,17619969L,35239936L,70479871L,140959741L,281919481L,563838961L,1127677921L,2255355841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076995Inst : IEnumerable<long>
{
public static readonly long[] Value=A076995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076995.Bytes);
public long this[int i]=>Value[i];

public static A076995Inst Instance=new A076995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077044
{
public static readonly long[] Value={ 0L,1L,10L,51L,155L,381L,780L,1451L,2460L,3951L,6000L,8801L,12435L,17151L,23030L,30381L,39280L,50101L,62910L,78151L,95875L,116601L,140360L,167751L,198780L,234131L,273780L,318501L,368235L,423851L,485250L,553401L,628160L,710601L,800530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077044Inst : IEnumerable<long>
{
public static readonly long[] Value=A077044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077044.Bytes);
public long this[int i]=>Value[i];

public static A077044Inst Instance=new A077044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077045
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,44L,381L,4332L,60691L,1012664L,19610233L,432457640L,10701243741L,293661065788L,8851373201919L,290711372717976L,10334165623697259L,395320344293410544L,16192709833199300337UL,BigInteger.Parse("707125993042984343136"),BigInteger.Parse("32795665902734099555845"),BigInteger.Parse("1609908874238209683872480") };
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
public class A077045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077045Inst Instance=new A077045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077046
{
public static readonly BigInteger[] Value={ 0L,1L,3L,19L,155L,1751L,24017L,398567L,7635987L,167729959L,4123838279L,112835748609L,3386455204288L,110976634957761L,3932912125462725L,150186639579545295L,6137695417757646851L,BigInteger.Parse("267654541150392845543"),BigInteger.Parse("12391407810082341898091"),BigInteger.Parse("607584722159224093306229") };
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
public class A077046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077046Inst Instance=new A077046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077047
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,85L,780L,9331L,134512L,2306025L,45433800L,1018872811L,25506741084L,707972099627L,21518492021208L,712601187601395L,25491847538274240L,981272544393935569L,BigInteger.Parse("40392787067756440272"),BigInteger.Parse("1772592132899627652691") };
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
public class A077047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077047Inst Instance=new A077047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077048
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,44L,350L,4292L,57036L,996088L,18661152L,424241102L,10266964015L,287927722315L,8541887839459L,285144784116376L,10016752944160536L,388044155110294856L,15749295719801313452UL,BigInteger.Parse("694726457246902921502") };
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
public class A077048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077048Inst Instance=new A077048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077049
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077049Inst : IEnumerable<long>
{
public static readonly long[] Value=A077049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077049.Bytes);
public long this[int i]=>Value[i];

public static A077049Inst Instance=new A077049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077050
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,-1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077050Inst : IEnumerable<long>
{
public static readonly long[] Value=A077050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077050.Bytes);
public long this[int i]=>Value[i];

public static A077050Inst Instance=new A077050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077051
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077051Inst : IEnumerable<long>
{
public static readonly long[] Value=A077051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077051.Bytes);
public long this[int i]=>Value[i];

public static A077051Inst Instance=new A077051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077052
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,-1L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077052Inst : IEnumerable<long>
{
public static readonly long[] Value=A077052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077052.Bytes);
public long this[int i]=>Value[i];

public static A077052Inst Instance=new A077052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077053
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,1L,4L,1L,1L,1L,1L,2L,1L,1L,2L,1L,4L,1L,1L,3L,1L,4L,1L,1L,1L,1L,1L,1L,8L,1L,4L,5L,1L,8L,4L,1L,1L,1L,1L,1L,8L,2L,1L,1L,1L,6L,1L,8L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,4L,2L,2L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077053Inst : IEnumerable<long>
{
public static readonly long[] Value=A077053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077053.Bytes);
public long this[int i]=>Value[i];

public static A077053Inst Instance=new A077053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077054
{
public static readonly long[] Value={ 1L,1L,3L,14L,81L,538L,3926L,30694L,252939L,2172830L,19304190L,176343390L,1649008456L,15730575554L,152663683494L,1503962954930L,15012865733351L,151622652413194L,1547365078534578L,15939972379349178L,165597452660771610L,1733609081727968492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077054Inst : IEnumerable<long>
{
public static readonly long[] Value=A077054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077054.Bytes);
public long this[int i]=>Value[i];

public static A077054Inst Instance=new A077054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077055
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,8L,13L,42L,72L,273L,475L,1970L,3506L,15368L,27888L,126510L,233809L,1086546L,2039564L,9652364L,18360296L,88172609L,169610371L,824506191L,1601297937L,7865294687L,15401847339L,76331857094L,150547538649L,751981532942L,1492452957398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077055Inst : IEnumerable<long>
{
public static readonly long[] Value=A077055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077055.Bytes);
public long this[int i]=>Value[i];

public static A077055Inst Instance=new A077055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077056
{
public static readonly long[] Value={ 1L,1L,4L,22L,140L,992L,7584L,61420L,520320L,4570292L,41354416L,383609434L,3634231140L,35059333218L,343580813492L,3413862553800L,34336784362232L,349131316634164L,3584622273967324L,37128374058146138L,387630493693010928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077056Inst : IEnumerable<long>
{
public static readonly long[] Value=A077056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077056.Bytes);
public long this[int i]=>Value[i];

public static A077056Inst Instance=new A077056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077057
{
public static readonly long[] Value={ 1L,2L,5L,3L,3L,27L,7L,37L,4L,4L,171L,22L,9L,14L,1193L,5L,5L,553L,16L,6173L,11L,45L,143L,849L,6L,6L,18339L,94L,1893L,103L,13L,33L,2353L,115L,12703L,7L,7L,67115L,701L,73L,59L,1891117L,15L,551427L,23L,49771L,39L,4105015L,8L,8L,24673L,41L,75585293L,25L,9095891L,989L,17L,386L,6445L,87L,771L,1385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077057Inst : IEnumerable<long>
{
public static readonly long[] Value=A077057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077057.Bytes);
public long this[int i]=>Value[i];

public static A077057Inst Instance=new A077057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077058
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,8L,2L,10L,1L,1L,40L,5L,2L,3L,250L,1L,1L,106L,3L,1138L,2L,8L,25L,146L,1L,1L,2968L,15L,298L,16L,2L,5L,352L,17L,1856L,1L,1L,9384L,97L,10L,8L,253970L,2L,72664L,3L,6440L,5L,521904L,1L,1L,3034L,5L,9148450L,3L,1084152L,117L,2L,45L,746L,10L,88L,157L,126890L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077058Inst : IEnumerable<long>
{
public static readonly long[] Value=A077058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077058.Bytes);
public long this[int i]=>Value[i];

public static A077058Inst Instance=new A077058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077059
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,10L,16L,17L,18L,26L,30L,35L,36L,37L,38L,40L,44L,47L,50L,51L,54L,56L,58L,60L,65L,72L,73L,74L,75L,80L,82L,88L,95L,97L,101L,102L,106L,107L,115L,122L,128L,130L,135L,136L,140L,142L,143L,144L,145L,146L,150L,154L,164L,170L,182L,187L,189L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077059Inst : IEnumerable<long>
{
public static readonly long[] Value=A077059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077059.Bytes);
public long this[int i]=>Value[i];

public static A077059Inst Instance=new A077059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077124
{
public static readonly long[] Value={ 1L,2L,9L,5L,5L,5L,3L,5L,3L,6L,1L,8L,6L,5L,3L,2L,5L,4L,1L,3L,9L,8L,1L,5L,5L,9L,7L,0L,0L,5L,9L,3L,3L,5L,3L,9L,4L,7L,7L,6L,8L,6L,5L,3L,6L,0L,0L,1L,5L,4L,4L,6L,2L,6L,4L,9L,8L,1L,8L,7L,0L,1L,0L,3L,4L,9L,7L,3L,6L,8L,9L,3L,9L,5L,4L,5L,4L,0L,5L,6L,4L,6L,4L,5L,4L,9L,3L,9L,1L,3L,4L,1L,1L,1L,2L,3L,7L,0L,7L,2L,1L,2L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077124Inst : IEnumerable<long>
{
public static readonly long[] Value=A077124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077124.Bytes);
public long this[int i]=>Value[i];

public static A077124Inst Instance=new A077124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077125
{
public static readonly long[] Value={ 1L,5L,9L,7L,9L,1L,0L,2L,1L,8L,0L,3L,1L,8L,7L,3L,1L,7L,8L,3L,3L,8L,0L,7L,0L,1L,1L,8L,1L,5L,7L,4L,5L,5L,3L,1L,2L,3L,6L,2L,2L,2L,4L,9L,5L,3L,1L,8L,2L,1L,1L,4L,1L,9L,6L,5L,9L,1L,3L,9L,3L,0L,9L,4L,2L,2L,9L,6L,1L,6L,1L,9L,5L,6L,2L,2L,7L,9L,4L,9L,6L,8L,7L,6L,1L,1L,4L,7L,0L,6L,2L,8L,1L,9L,6L,3L,5L,1L,8L,2L,5L,0L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077125Inst : IEnumerable<long>
{
public static readonly long[] Value=A077125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077125.Bytes);
public long this[int i]=>Value[i];

public static A077125Inst Instance=new A077125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077126
{
public static readonly long[] Value={ 3L,10L,23L,42L,71L,108L,151L,204L,265L,336L,415L,504L,605L,712L,825L,956L,1095L,1246L,1409L,1582L,1763L,1956L,2155L,2378L,2607L,2846L,3097L,3360L,3631L,3912L,4205L,4516L,4833L,5170L,5519L,5878L,6251L,6634L,7031L,7440L,7861L,8294L,8737L,9194L,9657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077126Inst : IEnumerable<long>
{
public static readonly long[] Value=A077126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077126.Bytes);
public long this[int i]=>Value[i];

public static A077126Inst Instance=new A077126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077127
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,3L,14L,12L,15L,5L,22L,9L,26L,7L,18L,20L,34L,16L,38L,24L,27L,11L,46L,21L,30L,13L,33L,32L,58L,25L,62L,28L,36L,17L,40L,39L,74L,19L,42L,35L,82L,44L,86L,48L,50L,23L,94L,45L,56L,52L,54L,60L,106L,51L,65L,49L,63L,29L,118L,55L,122L,31L,57L,66L,70L,64L,134L,72L,75L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077127Inst : IEnumerable<long>
{
public static readonly long[] Value=A077127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077127.Bytes);
public long this[int i]=>Value[i];

public static A077127Inst Instance=new A077127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077128
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,23L,29L,37L,47L,59L,67L,79L,97L,107L,127L,137L,157L,173L,191L,211L,233L,257L,277L,307L,331L,353L,379L,409L,439L,467L,499L,541L,563L,599L,631L,673L,709L,743L,787L,821L,863L,907L,947L,991L,1039L,1087L,1129L,1181L,1229L,1277L,1327L,1381L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077128Inst : IEnumerable<long>
{
public static readonly long[] Value=A077128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077128.Bytes);
public long this[int i]=>Value[i];

public static A077128Inst Instance=new A077128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077129
{
public static readonly long[] Value={ 3L,5L,7L,5L,11L,5L,13L,11L,7L,13L,7L,5L,7L,11L,13L,7L,17L,11L,5L,17L,7L,13L,11L,13L,5L,11L,5L,13L,37L,7L,13L,5L,17L,7L,23L,11L,7L,11L,13L,7L,29L,5L,11L,5L,31L,19L,11L,5L,13L,11L,7L,17L,13L,11L,13L,7L,19L,11L,5L,23L,29L,13L,5L,11L,31L,11L,29L,5L,17L,11L,17L,11L,19L,7L,13L,19L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077129Inst : IEnumerable<long>
{
public static readonly long[] Value=A077129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077129.Bytes);
public long this[int i]=>Value[i];

public static A077129Inst Instance=new A077129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077130
{
public static readonly long[] Value={ 5L,11L,17L,13L,19L,17L,23L,29L,37L,31L,29L,43L,41L,47L,37L,59L,41L,53L,59L,79L,61L,53L,73L,71L,89L,61L,79L,71L,83L,89L,79L,73L,83L,103L,101L,107L,97L,103L,89L,113L,127L,103L,97L,107L,101L,131L,137L,127L,109L,131L,113L,149L,127L,179L,131L,149L,179L,167L,139L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077130Inst : IEnumerable<long>
{
public static readonly long[] Value=A077130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077130.Bytes);
public long this[int i]=>Value[i];

public static A077130Inst Instance=new A077130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077131
{
public static readonly long[] Value={ 2L,7L,18L,35L,58L,89L,130L,177L,236L,303L,376L,459L,556L,659L,768L,895L,1032L,1181L,1338L,1505L,1684L,1875L,2072L,2283L,2510L,2743L,2984L,3241L,3510L,3787L,4070L,4377L,4690L,5021L,5368L,5721L,6088L,6467L,6856L,7257L,7676L,8107L,8546L,8995L,9456L,9923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077131Inst : IEnumerable<long>
{
public static readonly long[] Value=A077131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077131.Bytes);
public long this[int i]=>Value[i];

public static A077131Inst Instance=new A077131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077132
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,31L,53L,73L,89L,359L,139L,401L,181L,113L,211L,293L,661L,863L,773L,523L,1933L,1831L,1069L,1381L,887L,1637L,1129L,1669L,1951L,4027L,3469L,4177L,6397L,2477L,2971L,5531L,1327L,4297L,4831L,5351L,5591L,9973L,11743L,13187L,8467L,27851L,18803L,39047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077132Inst : IEnumerable<long>
{
public static readonly long[] Value=A077132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077132.Bytes);
public long this[int i]=>Value[i];

public static A077132Inst Instance=new A077132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077133
{
public static readonly long[] Value={ 1L,3L,5L,7L,13L,19L,21L,27L,29L,33L,39L,45L,49L,53L,57L,61L,63L,65L,71L,77L,79L,81L,83L,95L,97L,103L,113L,119L,121L,125L,135L,139L,143L,149L,151L,157L,163L,167L,175L,183L,185L,187L,191L,199L,201L,213L,217L,221L,233L,251L,261L,267L,273L,279L,281L,287L,289L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077133Inst : IEnumerable<long>
{
public static readonly long[] Value=A077133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077133.Bytes);
public long this[int i]=>Value[i];

public static A077133Inst Instance=new A077133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077134
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,60L,360L,2520L,20160L,181440L,1814400L,19958400L,239500800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077134Inst : IEnumerable<long>
{
public static readonly long[] Value=A077134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077134.Bytes);
public long this[int i]=>Value[i];

public static A077134Inst Instance=new A077134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077135
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,20L,21L,22L,25L,26L,33L,34L,35L,38L,39L,44L,46L,49L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,92L,93L,94L,95L,106L,111L,115L,116L,118L,119L,121L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,164L,166L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077135Inst : IEnumerable<long>
{
public static readonly long[] Value=A077135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077135.Bytes);
public long this[int i]=>Value[i];

public static A077135Inst Instance=new A077135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077136
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,21L,22L,24L,25L,26L,28L,33L,34L,35L,38L,39L,46L,49L,51L,55L,57L,58L,62L,65L,69L,74L,76L,77L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,121L,122L,123L,124L,129L,133L,134L,141L,142L,143L,145L,146L,148L,155L,158L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077136Inst : IEnumerable<long>
{
public static readonly long[] Value=A077136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077136.Bytes);
public long this[int i]=>Value[i];

public static A077136Inst Instance=new A077136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077137
{
public static readonly long[] Value={ 2L,4L,9L,16L,25L,64L,289L,729L,1681L,2401L,3481L,4096L,5041L,7921L,10201L,15625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077137Inst : IEnumerable<long>
{
public static readonly long[] Value=A077137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077137.Bytes);
public long this[int i]=>Value[i];

public static A077137Inst Instance=new A077137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077138
{
public static readonly long[] Value={ 0L,1L,2L,5L,20L,25L,150L,157L,1256L,1265L,12650L,12661L,151932L,151945L,2127230L,2127245L,34035920L,34035937L,612646866L,612646885L,12252937700L,12252937721L,269564629862L,269564629885L,6469551117240L,6469551117265L,168208329048890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077138Inst : IEnumerable<long>
{
public static readonly long[] Value=A077138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077138.Bytes);
public long this[int i]=>Value[i];

public static A077138Inst Instance=new A077138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077139
{
public static readonly long[] Value={ 1L,2L,6L,6L,30L,5L,35L,280L,2520L,252L,2772L,231L,3003L,858L,1430L,5720L,97240L,437580L,8314020L,415701L,969969L,176358L,4056234L,2704156L,67603900L,2600150L,70204050L,10029150L,290845350L,9694845L,300540195L,9617286240L,35263382880L,1037158320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077139Inst : IEnumerable<long>
{
public static readonly long[] Value=A077139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077139.Bytes);
public long this[int i]=>Value[i];

public static A077139Inst Instance=new A077139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077140
{
public static readonly long[] Value={ 1L,3L,0L,-4L,1L,7L,0L,-8L,1L,11L,0L,-12L,1L,15L,0L,-16L,1L,19L,0L,-20L,1L,23L,0L,-24L,1L,27L,0L,-28L,1L,31L,0L,-32L,1L,35L,0L,-36L,1L,39L,0L,-40L,1L,43L,0L,-44L,1L,47L,0L,-48L,1L,51L,0L,-52L,1L,55L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077140Inst : IEnumerable<long>
{
public static readonly long[] Value=A077140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077140.Bytes);
public long this[int i]=>Value[i];

public static A077140Inst Instance=new A077140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077141
{
public static readonly long[] Value={ 1L,5L,2L,6L,5L,2L,6L,4L,5L,7L,0L,2L,1L,3L,4L,5L,2L,2L,0L,4L,2L,5L,4L,4L,7L,8L,7L,5L,3L,3L,2L,8L,6L,9L,6L,1L,2L,4L,1L,9L,0L,5L,4L,9L,6L,6L,9L,7L,2L,4L,9L,3L,4L,5L,1L,3L,4L,5L,7L,6L,6L,9L,4L,9L,9L,5L,3L,0L,9L,9L,2L,5L,2L,9L,2L,6L,1L,6L,6L,8L,8L,4L,7L,3L,2L,7L,5L,8L,3L,7L,8L,5L,1L,2L,9L,9L,4L,3L,7L,9L,0L,0L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077141Inst : IEnumerable<long>
{
public static readonly long[] Value=A077141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077141.Bytes);
public long this[int i]=>Value[i];

public static A077141Inst Instance=new A077141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077142
{
public static readonly long[] Value={ 5L,4L,9L,2L,6L,9L,2L,3L,3L,9L,5L,8L,5L,7L,9L,0L,5L,3L,2L,5L,7L,4L,0L,3L,4L,2L,7L,7L,7L,0L,0L,3L,4L,0L,6L,4L,2L,0L,1L,7L,1L,5L,2L,7L,9L,3L,0L,5L,6L,0L,5L,0L,2L,6L,2L,3L,1L,4L,1L,9L,4L,6L,3L,5L,2L,3L,0L,9L,7L,5L,2L,8L,4L,6L,5L,6L,8L,8L,4L,5L,9L,9L,2L,1L,0L,1L,3L,0L,6L,5L,6L,2L,6L,0L,3L,5L,0L,2L,0L,4L,8L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077142Inst : IEnumerable<long>
{
public static readonly long[] Value=A077142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077142.Bytes);
public long this[int i]=>Value[i];

public static A077142Inst Instance=new A077142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077143
{
public static readonly BigInteger[] Value={ 1L,1L,32L,2448L,477595L,172497380L,95614528147L,83140881147429L,108654322319421237L,BigInteger.Parse("182417905018755002030"),BigInteger.Parse("368053025250427620488738"),BigInteger.Parse("1203788517781390541953924706"),BigInteger.Parse("3772396790098755787608470015082") };
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
public class A077143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077143Inst Instance=new A077143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077144
{
public static readonly BigInteger[] Value={ 1L,3L,34L,960L,49500L,3538080L,404020145L,73780761600L,15590323138443L,4627678068946516L,1712182437990539536L,BigInteger.Parse("709629581496779727567"),BigInteger.Parse("434911027744132649793916"),BigInteger.Parse("234745940945367262055489361") };
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
public class A077144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077144Inst Instance=new A077144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077145
{
public static readonly long[] Value={ 0L,0L,0L,3L,17L,106L,590L,3090L,21092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077145Inst : IEnumerable<long>
{
public static readonly long[] Value=A077145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077145.Bytes);
public long this[int i]=>Value[i];

public static A077145Inst Instance=new A077145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077146
{
public static readonly long[] Value={ 23L,19L,173L,14093L,145L,137L,131L,127L,124L,121L,119L,117L,116453592L,11416794012L,1141L,1132L,1124L,1116L,1110L,1104L,1099L,1094L,1090L,1086L,1083L,1079L,1076L,1073L,1071L,1068L,1066L,1064L,1062L,1060L,1058L,1057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077146Inst : IEnumerable<long>
{
public static readonly long[] Value=A077146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077146.Bytes);
public long this[int i]=>Value[i];

public static A077146Inst Instance=new A077146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077147
{
public static readonly BigInteger[] Value={ 1L,6L,41L,308L,2469L,20576L,176366L,1543209L,13717421L,1234567891L,112233444637L,10288065758426L,949667608470093L,88183420786508665L,8230452606740808761L,BigInteger.Parse("771604931881950821344"),BigInteger.Parse("72621640647713018479506") };
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
public class A077147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077147Inst Instance=new A077147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077148
{
public static readonly long[] Value={ 3L,6L,8L,12L,12L,24L,16L,24L,23L,34L,24L,48L,28L,46L,44L,48L,36L,72L,40L,70L,59L,70L,48L,96L,57L,82L,68L,94L,60L,140L,64L,96L,87L,106L,87L,144L,76L,118L,102L,140L,84L,188L,88L,140L,129L,142L,96L,192L,107L,174L,132L,164L,108L,216L,130L,186L,147L,178L,120L,284L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077148Inst : IEnumerable<long>
{
public static readonly long[] Value=A077148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077148.Bytes);
public long this[int i]=>Value[i];

public static A077148Inst Instance=new A077148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077149
{
public static readonly long[] Value={ 3L,7L,13L,13L,31L,16L,57L,25L,37L,27L,133L,31L,183L,39L,49L,49L,307L,46L,381L,55L,71L,63L,553L,61L,151L,75L,109L,78L,871L,71L,993L,97L,118L,99L,148L,91L,1407L,111L,142L,107L,1723L,101L,1893L,125L,142L,135L,2257L,121L,393L,135L,188L,149L,2863L,136L,256L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077149Inst : IEnumerable<long>
{
public static readonly long[] Value=A077149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077149.Bytes);
public long this[int i]=>Value[i];

public static A077149Inst Instance=new A077149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077150
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,0L,4L,2L,3L,0L,7L,0L,9L,3L,4L,3L,12L,2L,14L,4L,7L,4L,17L,2L,14L,6L,11L,5L,22L,1L,23L,9L,13L,8L,16L,3L,27L,9L,15L,6L,31L,2L,33L,11L,14L,12L,37L,7L,32L,10L,21L,12L,41L,6L,27L,11L,22L,14L,45L,3L,48L,18L,24L,19L,35L,6L,53L,19L,30L,9L,56L,10L,59L,23L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077150Inst : IEnumerable<long>
{
public static readonly long[] Value=A077150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077150.Bytes);
public long this[int i]=>Value[i];

public static A077150Inst Instance=new A077150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077151
{
public static readonly long[] Value={ 1L,3L,8L,5L,7L,28L,26L,11L,34L,13L,50L,27L,17L,33L,19L,39L,35L,23L,62L,64L,156L,51L,29L,31L,63L,162L,75L,37L,94L,104L,69L,41L,49L,43L,228L,65L,116L,47L,136L,81L,99L,53L,93L,142L,148L,59L,152L,135L,61L,282L,158L,117L,164L,67L,91L,172L,71L,123L,224L,73L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077151Inst : IEnumerable<long>
{
public static readonly long[] Value=A077151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077151.Bytes);
public long this[int i]=>Value[i];

public static A077151Inst Instance=new A077151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077152
{
public static readonly long[] Value={ 3L,6L,12L,14L,20L,24L,32L,38L,42L,44L,54L,60L,68L,72L,74L,80L,90L,98L,104L,108L,110L,114L,132L,138L,140L,150L,152L,158L,168L,174L,182L,192L,194L,198L,200L,212L,228L,230L,234L,240L,252L,258L,270L,272L,278L,282L,294L,308L,312L,314L,318L,332L,348L,350L,354L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077152Inst : IEnumerable<long>
{
public static readonly long[] Value=A077152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077152.Bytes);
public long this[int i]=>Value[i];

public static A077152Inst Instance=new A077152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077153
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,16L,17L,21L,23L,26L,27L,29L,31L,34L,36L,39L,40L,43L,45L,47L,50L,52L,53L,56L,58L,61L,64L,66L,67L,70L,71L,75L,77L,79L,82L,85L,86L,88L,91L,93L,94L,96L,97L,100L,103L,106L,107L,111L,113L,116L,118L,120L,121L,123L,125L,127L,130L,133L,134L,136L,137L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077153Inst : IEnumerable<long>
{
public static readonly long[] Value=A077153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077153.Bytes);
public long this[int i]=>Value[i];

public static A077153Inst Instance=new A077153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077154
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,10L,11L,15L,17L,19L,21L,22L,23L,26L,28L,29L,31L,33L,34L,36L,39L,40L,41L,45L,47L,50L,52L,53L,55L,56L,57L,59L,63L,65L,67L,69L,70L,73L,76L,77L,78L,79L,81L,83L,86L,87L,88L,91L,93L,95L,97L,99L,100L,103L,106L,109L,112L,113L,115L,116L,117L,119L,121L,123L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077154Inst : IEnumerable<long>
{
public static readonly long[] Value=A077154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077154.Bytes);
public long this[int i]=>Value[i];

public static A077154Inst Instance=new A077154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077155
{
public static readonly BigInteger[] Value={ 1L,4L,96L,4930L,416615L,52346851L,9150486666L,2122773858331L,630854176216923L,233667907156182198L,BigInteger.Parse("105531126177212999940"),BigInteger.Parse("57078667671269237092154"),BigInteger.Parse("36423221938771375213756343"),BigInteger.Parse("27076505528935399371748578683") };
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
public class A077155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077155Inst Instance=new A077155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077156
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,8L,7L,11L,13L,9L,10L,12L,17L,19L,23L,29L,14L,15L,16L,18L,31L,37L,41L,43L,47L,20L,21L,22L,24L,25L,53L,59L,61L,67L,71L,73L,26L,27L,28L,30L,32L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077156Inst : IEnumerable<long>
{
public static readonly long[] Value=A077156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077156.Bytes);
public long this[int i]=>Value[i];

public static A077156Inst Instance=new A077156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077157
{
public static readonly long[] Value={ 1L,4L,2L,6L,8L,3L,5L,9L,10L,12L,7L,11L,13L,14L,15L,16L,18L,17L,19L,23L,29L,20L,21L,22L,24L,25L,31L,37L,41L,43L,47L,26L,27L,28L,30L,32L,33L,53L,59L,61L,67L,71L,73L,34L,35L,36L,38L,39L,40L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077157Inst : IEnumerable<long>
{
public static readonly long[] Value=A077157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077157.Bytes);
public long this[int i]=>Value[i];

public static A077157Inst Instance=new A077157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077158
{
public static readonly long[] Value={ 4L,6L,2L,3L,5L,7L,8L,9L,10L,11L,13L,17L,19L,23L,29L,12L,14L,15L,16L,18L,31L,37L,41L,43L,47L,53L,59L,61L,20L,21L,22L,24L,25L,26L,27L,67L,71L,73L,79L,83L,89L,97L,101L,103L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,44L,45L,46L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077158Inst : IEnumerable<long>
{
public static readonly long[] Value=A077158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077158.Bytes);
public long this[int i]=>Value[i];

public static A077158Inst Instance=new A077158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077159
{
public static readonly long[] Value={ 2L,1L,3L,4L,5L,7L,9L,11L,13L,15L,6L,8L,12L,14L,16L,17L,19L,23L,25L,29L,31L,10L,18L,20L,22L,24L,26L,27L,21L,33L,35L,37L,39L,41L,43L,45L,28L,32L,34L,38L,40L,44L,46L,47L,49L,51L,53L,57L,59L,61L,63L,67L,69L,71L,73L,30L,36L,42L,48L,50L,52L,54L,56L,58L,60L,62L,55L,65L,77L,79L,83L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077159Inst : IEnumerable<long>
{
public static readonly long[] Value=A077159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077159.Bytes);
public long this[int i]=>Value[i];

public static A077159Inst Instance=new A077159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077160
{
public static readonly long[] Value={ 2L,1L,4L,9L,6L,17L,10L,21L,28L,51L,30L,55L,64L,87L,88L,105L,78L,167L,102L,171L,152L,195L,180L,253L,264L,315L,280L,351L,270L,427L,348L,465L,434L,587L,474L,595L,480L,681L,680L,741L,666L,835L,738L,915L,914L,957L,860L,1127L,940L,1197L,1106L,1215L,1092L,1417L,1272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077160Inst : IEnumerable<long>
{
public static readonly long[] Value=A077160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077160.Bytes);
public long this[int i]=>Value[i];

public static A077160Inst Instance=new A077160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077161
{
public static readonly long[] Value={ 2L,3L,7L,15L,16L,31L,27L,45L,49L,73L,62L,103L,86L,129L,133L,163L,146L,217L,178L,251L,248L,293L,262L,359L,316L,399L,386L,461L,418L,569L,472L,585L,580L,657L,634L,761L,675L,813L,796L,911L,830L,1039L,908L,1083L,1072L,1171L,1088L,1313L,1192L,1399L,1334L,1489L,1382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077161Inst : IEnumerable<long>
{
public static readonly long[] Value=A077161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077161.Bytes);
public long this[int i]=>Value[i];

public static A077161Inst Instance=new A077161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077162
{
public static readonly long[] Value={ 2L,4L,16L,48L,56L,144L,147L,294L,358L,624L,548L,1020L,978L,1576L,1685L,2340L,2048L,3456L,3036L,4454L,4481L,5870L,5188L,7722L,7289L,9560L,9365L,11976L,10889L,15378L,13729L,17066L,17330L,21168L,20051L,25428L,22997L,29048L,28817L,34428L,31444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077162Inst : IEnumerable<long>
{
public static readonly long[] Value=A077162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077162.Bytes);
public long this[int i]=>Value[i];

public static A077162Inst Instance=new A077162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077163
{
public static readonly long[] Value={ 1L,4L,9L,64L,125L,216L,2401L,4096L,6561L,10000L,161051L,248832L,371293L,537824L,759375L,16777216L,24137569L,34012224L,47045881L,64000000L,85766121L,2494357888L,3404825447L,4586471424L,6103515625L,8031810176L,10460353203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077163Inst : IEnumerable<long>
{
public static readonly long[] Value=A077163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077163.Bytes);
public long this[int i]=>Value[i];

public static A077163Inst Instance=new A077163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077164
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,11L,13L,15L,17L,18L,19L,21L,22L,23L,25L,29L,31L,35L,37L,41L,43L,44L,45L,46L,47L,48L,50L,51L,53L,55L,57L,59L,61L,63L,65L,67L,68L,70L,71L,73L,74L,76L,77L,79L,81L,83L,87L,89L,91L,93L,97L,99L,101L,103L,104L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077164Inst : IEnumerable<long>
{
public static readonly long[] Value=A077164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077164.Bytes);
public long this[int i]=>Value[i];

public static A077164Inst Instance=new A077164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077165
{
public static readonly long[] Value={ 2L,3L,7L,11L,18L,25L,43L,51L,67L,81L,104L,119L,152L,167L,199L,227L,258L,277L,330L,351L,400L,437L,484L,509L,578L,609L,667L,709L,772L,803L,914L,947L,1010L,1065L,1136L,1187L,1292L,1331L,1411L,1477L,1574L,1619L,1764L,1809L,1906L,1989L,2084L,2135L,2276L,2333L,2458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077165Inst : IEnumerable<long>
{
public static readonly long[] Value=A077165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077165.Bytes);
public long this[int i]=>Value[i];

public static A077165Inst Instance=new A077165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077166
{
public static readonly long[] Value={ 2L,5L,10L,17L,23L,41L,50L,65L,79L,103L,115L,151L,165L,197L,226L,257L,275L,329L,349L,399L,436L,483L,507L,577L,608L,665L,706L,771L,801L,913L,945L,1009L,1063L,1135L,1186L,1291L,1329L,1409L,1474L,1573L,1615L,1763L,1807L,1905L,1988L,2083L,2131L,2275L,2332L,2457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077166Inst : IEnumerable<long>
{
public static readonly long[] Value=A077166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077166.Bytes);
public long this[int i]=>Value[i];

public static A077166Inst Instance=new A077166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077167
{
public static readonly long[] Value={ 2L,8L,25L,56L,103L,198L,323L,464L,655L,924L,1204L,1620L,2063L,2548L,3193L,3872L,4525L,5454L,6448L,7500L,8764L,10116L,11386L,13032L,14828L,16562L,18529L,20712L,22812L,25764L,28814L,31296L,34223L,37424L,40607L,44604L,48504L,52064L,56245L,61000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077167Inst : IEnumerable<long>
{
public static readonly long[] Value=A077167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077167.Bytes);
public long this[int i]=>Value[i];

public static A077167Inst Instance=new A077167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077168
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,259200L,15L,16L,17L,18L,19L,87178291200L,20L,21L,22L,23L,24L,25L,202741834014720L,26L,27L,28L,29L,30L,31L,32L,BigInteger.Parse("484725313854093312000000"),33L,34L,35L,36L,37L,38L,39L,40L };
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
public class A077168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077168Inst Instance=new A077168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077169
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,20L,26L,33L,41L,50L,60L,71L,83L,96L,110L,125L,141L,158L,176L,195L,215L,236L,258L,281L,305L,330L,356L,383L,411L,440L,470L,501L,533L,566L,600L,635L,671L,708L,746L,785L,825L,866L,908L,951L,995L,1040L,1086L,1133L,1181L,1230L,1280L,1331L,1383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077169Inst : IEnumerable<long>
{
public static readonly long[] Value=A077169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077169.Bytes);
public long this[int i]=>Value[i];

public static A077169Inst Instance=new A077169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077170
{
public static readonly BigInteger[] Value={ 1L,3L,6L,10L,259200L,87178291200L,202741834014720L,BigInteger.Parse("484725313854093312000000"),BigInteger.Parse("4438779300500903005519872000000"),BigInteger.Parse("346902756482949716983678260882702336000000000") };
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
public class A077170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077170Inst Instance=new A077170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077171
{
public static readonly long[] Value={ 1L,3L,5L,7L,13L,19L,23L,31L,37L,47L,59L,67L,79L,89L,109L,113L,139L,157L,173L,193L,211L,233L,257L,277L,293L,317L,353L,379L,409L,439L,467L,499L,523L,563L,599L,631L,661L,701L,743L,773L,823L,863L,907L,947L,991L,1039L,1069L,1129L,1171L,1229L,1279L,1327L,1381L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077171Inst : IEnumerable<long>
{
public static readonly long[] Value=A077171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077171.Bytes);
public long this[int i]=>Value[i];

public static A077171Inst Instance=new A077171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077172
{
public static readonly long[] Value={ 2L,1L,6L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,16L,15L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,48L,44L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077172Inst : IEnumerable<long>
{
public static readonly long[] Value=A077172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077172.Bytes);
public long this[int i]=>Value[i];

public static A077172Inst Instance=new A077172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077173
{
public static readonly long[] Value={ 2L,1L,3L,7L,11L,15L,22L,29L,37L,44L,56L,67L,78L,92L,106L,119L,136L,154L,171L,188L,210L,230L,252L,275L,299L,323L,349L,375L,402L,430L,460L,491L,522L,555L,588L,623L,658L,694L,731L,769L,809L,849L,890L,932L,975L,1019L,1064L,1110L,1157L,1205L,1255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077173Inst : IEnumerable<long>
{
public static readonly long[] Value=A077173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077173.Bytes);
public long this[int i]=>Value[i];

public static A077173Inst Instance=new A077173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077174
{
public static readonly long[] Value={ 2L,6L,5L,10L,16L,21L,28L,36L,48L,55L,66L,80L,91L,105L,121L,137L,153L,551L,190L,209L,231L,254L,1271L,298L,326L,3127L,1247L,47027L,432L,461L,2911L,3233L,1591L,590L,222017L,2867L,171749L,139019L,5183L,808L,21182921L,206753L,288569L,4331L,5767L,35139959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077174Inst : IEnumerable<long>
{
public static readonly long[] Value=A077174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077174.Bytes);
public long this[int i]=>Value[i];

public static A077174Inst Instance=new A077174Inst();

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