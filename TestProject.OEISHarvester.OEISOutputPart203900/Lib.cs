using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A287293
{
public static readonly long[] Value={ 2L,2L,4L,4L,8L,8L,8L,8L,16L,16L,16L,16L,32L,32L,32L,32L,32L,32L,32L,32L,64L,64L,64L,64L,64L,64L,64L,64L,128L,128L,128L,128L,128L,128L,128L,128L,256L,256L,256L,256L,256L,256L,256L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287293Inst : IEnumerable<long>
{
public static readonly long[] Value=A287293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287293.Bytes);
public long this[int i]=>Value[i];

public static A287293Inst Instance=new A287293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287294
{
public static readonly BigInteger[] Value={ 1L,313L,53135L,7531357L,975313579L,1197531357911L,13119753135791113L,BigInteger.Parse("151311975313579111315"),BigInteger.Parse("1715131197531357911131517"),BigInteger.Parse("19171513119753135791113151719"),BigInteger.Parse("211917151311975313579111315171921"),BigInteger.Parse("2321191715131197531357911131517192123") };
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
public class A287294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287294Inst Instance=new A287294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287295
{
public static readonly BigInteger[] Value={ 1L,11L,131L,1331L,13531L,135531L,1357531L,13577531L,135797531L,1357997531L,135791197531L,13579111197531L,1357911131197531L,135791113131197531L,13579111315131197531UL,BigInteger.Parse("1357911131515131197531"),BigInteger.Parse("135791113151715131197531"),BigInteger.Parse("13579111315171715131197531") };
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
public class A287295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287295Inst Instance=new A287295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287296
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,16L,31L,33L,93L,289L,304L,921L,3946L,4506L,4978L,5481L,7114L,13512L,14703L,14823L,16851L,26662L,1183L,77377L,82417L,95316L,98982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287296Inst : IEnumerable<long>
{
public static readonly long[] Value=A287296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287296.Bytes);
public long this[int i]=>Value[i];

public static A287296Inst Instance=new A287296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287297
{
public static readonly long[] Value={ 161038L,9115426L,143742226L,665387746L,1105826338L,3434672242L,11675882626L,16732427362L,18411253246L,81473324626L,85898088046L,98730252226L,134744844466L,136767694402L,161097973246L,183689075122L,315554044786L,553588254766L,778581406786L,1077392692846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287297Inst : IEnumerable<long>
{
public static readonly long[] Value=A287297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287297.Bytes);
public long this[int i]=>Value[i];

public static A287297Inst Instance=new A287297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287298
{
public static readonly BigInteger[] Value={ 1L,1L,225L,576L,38025L,751689L,10323369L,355624164L,9814072356L,279740499025L,8706730814089L,23132511879129L,11027486960232964L,435408094460869201L,18362780530794065025UL,BigInteger.Parse("48470866291337805316"),BigInteger.Parse("39207739576969100808801"),BigInteger.Parse("1972312183619434816475625"),BigInteger.Parse("104566626183621314286288961") };
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
public class A287298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287298Inst Instance=new A287298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287299
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,0L,2L,1L,0L,1L,2L,2L,0L,0L,2L,2L,1L,1L,3L,0L,1L,1L,4L,3L,0L,2L,2L,2L,0L,3L,4L,3L,1L,2L,6L,3L,1L,0L,5L,4L,2L,2L,4L,3L,0L,2L,3L,5L,0L,1L,3L,4L,3L,2L,4L,3L,3L,4L,5L,4L,0L,2L,5L,5L,0L,4L,6L,2L,1L,1L,7L,3L,1L,2L,7L,4L,2L,4L,5L,5L,1L,3L,6L,5L,1L,3L,6L,6L,3L,4L,4L,4L,2L,4L,7L,6L,3L,1L,4L,4L,0L,4L,6L,5L,2L,2L,7L,5L,2L,1L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287299Inst : IEnumerable<long>
{
public static readonly long[] Value=A287299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287299.Bytes);
public long this[int i]=>Value[i];

public static A287299Inst Instance=new A287299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287300
{
public static readonly long[] Value={ 5L,31L,41L,61L,71L,281L,337L,421L,449L,617L,673L,701L,2297L,2543L,2707L,2789L,2953L,3527L,3691L,4019L,5003L,5167L,5413L,5659L,5741L,5987L,6151L,6397L,21961L,22937L,23669L,24889L,25621L,26597L,27329L,27817L,28549L,28793L,30013L,31477L,31721L,32941L,34649L,35381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287300Inst : IEnumerable<long>
{
public static readonly long[] Value=A287300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287300.Bytes);
public long this[int i]=>Value[i];

public static A287300Inst Instance=new A287300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287301
{
public static readonly long[] Value={ 3L,7L,11L,59L,79L,89L,307L,419L,503L,587L,643L,727L,2377L,2459L,3361L,3607L,3853L,4099L,4591L,4673L,4919L,5657L,5821L,5903L,6067L,20983L,21227L,22447L,22691L,23911L,26107L,26839L,28547L,30011L,31231L,31963L,32939L,33427L,34159L,34403L,36599L,37087L,41479L,42943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287301Inst : IEnumerable<long>
{
public static readonly long[] Value=A287301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287301.Bytes);
public long this[int i]=>Value[i];

public static A287301Inst Instance=new A287301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287302
{
public static readonly long[] Value={ 11L,103L,137L,239L,1171L,1301L,1951L,2081L,2341L,2731L,2861L,3121L,3251L,3511L,16963L,17477L,20047L,21589L,23131L,26729L,30841L,34439L,40093L,43177L,43691L,45233L,46261L,60139L,61681L,63737L,270601L,272651L,278801L,291101L,295201L,297251L,315701L,321851L,325951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287302Inst : IEnumerable<long>
{
public static readonly long[] Value=A287302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287302.Bytes);
public long this[int i]=>Value[i];

public static A287302Inst Instance=new A287302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287303
{
public static readonly long[] Value={ 19L,101L,271L,1429L,1559L,1949L,2339L,2729L,3119L,3769L,4159L,17989L,18503L,19531L,21587L,24671L,27241L,29297L,30839L,32381L,33409L,33923L,36493L,44203L,47287L,51913L,55511L,64763L,286999L,289049L,293149L,295199L,301349L,305449L,323899L,332099L,336199L,350549L,375149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287303Inst : IEnumerable<long>
{
public static readonly long[] Value=A287303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287303.Bytes);
public long this[int i]=>Value[i];

public static A287303Inst Instance=new A287303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287353
{
public static readonly long[] Value={ 0L,2L,23L,235L,2357L,23581L,235823L,2358247L,23582489L,235824913L,2358249159L,23582491621L,235824916247L,2358249162511L,23582491625153L,235824916251577L,2358249162515823L,23582491625158289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287353Inst : IEnumerable<long>
{
public static readonly long[] Value=A287353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287353.Bytes);
public long this[int i]=>Value[i];

public static A287353Inst Instance=new A287353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287354
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,13L,15L,14L,16L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,21L,22L,23L,23L,23L,25L,24L,26L,25L,26L,28L,28L,26L,29L,29L,29L,30L,30L,32L,30L,32L,34L,33L,32L,36L,35L,34L,36L,37L,37L,37L,38L,39L,39L,39L,41L,40L,42L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287354Inst : IEnumerable<long>
{
public static readonly long[] Value=A287354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287354.Bytes);
public long this[int i]=>Value[i];

public static A287354Inst Instance=new A287354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287355
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,3L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287355Inst : IEnumerable<long>
{
public static readonly long[] Value=A287355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287355.Bytes);
public long this[int i]=>Value[i];

public static A287355Inst Instance=new A287355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287356
{
public static readonly long[] Value={ 1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,1L,2L,0L,1L,1L,1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,1L,2L,1L,2L,1L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287356Inst : IEnumerable<long>
{
public static readonly long[] Value=A287356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287356.Bytes);
public long this[int i]=>Value[i];

public static A287356Inst Instance=new A287356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287357
{
public static readonly long[] Value={ 3L,12L,15L,18L,23L,28L,37L,46L,55L,58L,61L,70L,73L,76L,85L,88L,91L,96L,101L,110L,113L,116L,121L,126L,135L,138L,141L,146L,151L,160L,169L,178L,181L,184L,189L,194L,203L,212L,221L,224L,227L,232L,237L,246L,255L,264L,267L,270L,279L,282L,285L,294L,297L,300L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287357Inst : IEnumerable<long>
{
public static readonly long[] Value=A287357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287357.Bytes);
public long this[int i]=>Value[i];

public static A287357Inst Instance=new A287357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287358
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,10L,13L,16L,19L,20L,21L,24L,25L,26L,29L,30L,31L,33L,35L,38L,39L,40L,42L,44L,47L,48L,49L,51L,53L,56L,59L,62L,63L,64L,66L,68L,71L,74L,77L,78L,79L,81L,83L,86L,89L,92L,93L,94L,97L,98L,99L,102L,103L,104L,106L,108L,111L,114L,117L,118L,119L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287358Inst : IEnumerable<long>
{
public static readonly long[] Value=A287358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287358.Bytes);
public long this[int i]=>Value[i];

public static A287358Inst Instance=new A287358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287359
{
public static readonly long[] Value={ 2L,7L,9L,11L,14L,17L,22L,27L,32L,34L,36L,41L,43L,45L,50L,52L,54L,57L,60L,65L,67L,69L,72L,75L,80L,82L,84L,87L,90L,95L,100L,105L,107L,109L,112L,115L,120L,125L,130L,132L,134L,137L,140L,145L,150L,155L,157L,159L,164L,166L,168L,173L,175L,177L,180L,183L,188L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287359Inst : IEnumerable<long>
{
public static readonly long[] Value=A287359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287359.Bytes);
public long this[int i]=>Value[i];

public static A287359Inst Instance=new A287359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287360
{
public static readonly long[] Value={ 0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287360Inst : IEnumerable<long>
{
public static readonly long[] Value=A287360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287360.Bytes);
public long this[int i]=>Value[i];

public static A287360Inst Instance=new A287360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287361
{
public static readonly long[] Value={ 1L,4L,13L,16L,19L,28L,37L,46L,51L,56L,59L,62L,71L,74L,77L,86L,89L,92L,101L,110L,119L,124L,129L,132L,135L,144L,153L,162L,167L,172L,175L,178L,187L,196L,205L,210L,215L,218L,221L,230L,235L,240L,243L,246L,255L,260L,265L,268L,271L,280L,283L,286L,295L,298L,301L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287361Inst : IEnumerable<long>
{
public static readonly long[] Value=A287361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287361.Bytes);
public long this[int i]=>Value[i];

public static A287361Inst Instance=new A287361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287362
{
public static readonly long[] Value={ 3L,6L,8L,10L,11L,12L,15L,18L,21L,23L,25L,26L,27L,30L,32L,34L,35L,36L,39L,41L,43L,44L,45L,48L,49L,50L,53L,54L,55L,58L,61L,64L,66L,68L,69L,70L,73L,76L,79L,81L,83L,84L,85L,88L,91L,94L,96L,98L,99L,100L,103L,105L,107L,108L,109L,112L,114L,116L,117L,118L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287362Inst : IEnumerable<long>
{
public static readonly long[] Value=A287362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287362.Bytes);
public long this[int i]=>Value[i];

public static A287362Inst Instance=new A287362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287363
{
public static readonly long[] Value={ 2L,5L,7L,9L,14L,17L,20L,22L,24L,29L,31L,33L,38L,40L,42L,47L,52L,57L,60L,63L,65L,67L,72L,75L,78L,80L,82L,87L,90L,93L,95L,97L,102L,104L,106L,111L,113L,115L,120L,125L,130L,133L,136L,138L,140L,145L,147L,149L,154L,156L,158L,163L,168L,173L,176L,179L,181L,183L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287363Inst : IEnumerable<long>
{
public static readonly long[] Value=A287363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287363.Bytes);
public long this[int i]=>Value[i];

public static A287363Inst Instance=new A287363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287364
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287364Inst : IEnumerable<long>
{
public static readonly long[] Value=A287364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287364.Bytes);
public long this[int i]=>Value[i];

public static A287364Inst Instance=new A287364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287365
{
public static readonly long[] Value={ 3L,8L,11L,14L,23L,28L,33L,36L,39L,48L,51L,54L,63L,66L,69L,78L,87L,96L,101L,106L,109L,112L,121L,126L,131L,134L,137L,146L,151L,156L,159L,162L,171L,174L,177L,186L,189L,192L,201L,210L,219L,224L,229L,232L,235L,244L,247L,250L,259L,262L,265L,274L,283L,292L,297L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287365Inst : IEnumerable<long>
{
public static readonly long[] Value=A287365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287365.Bytes);
public long this[int i]=>Value[i];

public static A287365Inst Instance=new A287365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287366
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,10L,13L,16L,18L,20L,21L,22L,25L,26L,27L,30L,31L,32L,35L,38L,41L,43L,45L,46L,47L,50L,53L,56L,58L,60L,61L,62L,65L,68L,71L,73L,75L,76L,77L,80L,82L,84L,85L,86L,89L,91L,93L,94L,95L,98L,99L,100L,103L,104L,105L,108L,111L,114L,116L,118L,119L,120L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287366Inst : IEnumerable<long>
{
public static readonly long[] Value=A287366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287366.Bytes);
public long this[int i]=>Value[i];

public static A287366Inst Instance=new A287366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287367
{
public static readonly long[] Value={ 4L,9L,12L,15L,17L,19L,24L,29L,34L,37L,40L,42L,44L,49L,52L,55L,57L,59L,64L,67L,70L,72L,74L,79L,81L,83L,88L,90L,92L,97L,102L,107L,110L,113L,115L,117L,122L,127L,132L,135L,138L,140L,142L,147L,152L,157L,160L,163L,165L,167L,172L,175L,178L,180L,182L,187L,190L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287367Inst : IEnumerable<long>
{
public static readonly long[] Value=A287367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287367.Bytes);
public long this[int i]=>Value[i];

public static A287367Inst Instance=new A287367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287368
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287368Inst : IEnumerable<long>
{
public static readonly long[] Value=A287368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287368.Bytes);
public long this[int i]=>Value[i];

public static A287368Inst Instance=new A287368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287401
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,1L,2L,0L,1L,2L,0L,2L,1L,0L,0L,1L,2L,2L,1L,0L,1L,2L,0L,0L,1L,2L,2L,1L,0L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,0L,1L,2L,0L,1L,2L,0L,2L,1L,0L,0L,1L,2L,2L,1L,0L,1L,2L,0L,0L,1L,2L,0L,1L,2L,2L,1L,0L,1L,2L,0L,1L,2L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287401Inst : IEnumerable<long>
{
public static readonly long[] Value=A287401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287401.Bytes);
public long this[int i]=>Value[i];

public static A287401Inst Instance=new A287401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287402
{
public static readonly long[] Value={ 4L,8L,12L,19L,23L,31L,35L,43L,50L,54L,58L,65L,69L,77L,84L,91L,95L,103L,107L,115L,122L,129L,133L,141L,148L,152L,156L,163L,167L,175L,179L,187L,194L,198L,202L,209L,213L,221L,228L,235L,239L,247L,254L,258L,262L,269L,276L,280L,284L,291L,295L,303L,310L,317L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287402Inst : IEnumerable<long>
{
public static readonly long[] Value=A287402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287402.Bytes);
public long this[int i]=>Value[i];

public static A287402Inst Instance=new A287402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287403
{
public static readonly long[] Value={ 2L,5L,7L,10L,14L,17L,20L,22L,26L,29L,31L,35L,37L,41L,44L,47L,50L,52L,55L,59L,62L,65L,67L,71L,74L,77L,79L,82L,86L,89L,92L,94L,98L,101L,104L,106L,110L,112L,116L,118L,122L,125L,128L,131L,133L,137L,140L,142L,145L,149L,152L,155L,157L,161L,164L,166L,170L,172L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287403Inst : IEnumerable<long>
{
public static readonly long[] Value=A287403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287403.Bytes);
public long this[int i]=>Value[i];

public static A287403Inst Instance=new A287403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287404
{
public static readonly long[] Value={ 3L,4L,8L,11L,13L,18L,19L,23L,27L,28L,32L,36L,38L,40L,45L,48L,49L,53L,56L,58L,63L,64L,68L,72L,75L,76L,80L,83L,85L,90L,91L,95L,99L,102L,103L,107L,109L,113L,117L,119L,121L,126L,129L,130L,134L,138L,139L,143L,146L,148L,153L,154L,158L,162L,163L,167L,171L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287404Inst : IEnumerable<long>
{
public static readonly long[] Value=A287404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287404.Bytes);
public long this[int i]=>Value[i];

public static A287404Inst Instance=new A287404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287405
{
public static readonly BigInteger[] Value={ 3L,35L,931L,27587L,830403L,25054435L,756187747L,22824258947L,688917131651L,20793986742179L,627637106311971L,18944339609269571L,571808137046942019L,17259221092289630307UL,BigInteger.Parse("520945214725090792931"),BigInteger.Parse("15723995613526902256387"),BigInteger.Parse("474606601742375424297731") };
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
public class A287405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287405Inst Instance=new A287405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287406
{
public static readonly BigInteger[] Value={ 1L,1L,1L,29L,121L,10417L,20167393L,1405696961L,1671421144961L,34853495567335169L,BigInteger.Parse("18070618208072153366017"),BigInteger.Parse("76880583838185587571686401"),BigInteger.Parse("5835812465544660559691588302849"),BigInteger.Parse("6474896789559157455730381208091095041"),BigInteger.Parse("143196455096491413680184647037773197755801601"),BigInteger.Parse("76671942287512076984565827384061983641627409659183105") };
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
public class A287406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287406Inst Instance=new A287406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287407
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,2L,0L,1L,2L,0L,1L,2L,1L,0L,0L,1L,2L,2L,0L,1L,0L,1L,2L,2L,1L,0L,2L,0L,1L,0L,1L,2L,2L,1L,0L,2L,0L,1L,2L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,0L,2L,0L,1L,2L,0L,1L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,2L,0L,1L,2L,0L,1L,2L,1L,0L,0L,1L,2L,2L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287407Inst : IEnumerable<long>
{
public static readonly long[] Value=A287407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287407.Bytes);
public long this[int i]=>Value[i];

public static A287407Inst Instance=new A287407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287408
{
public static readonly long[] Value={ 1L,6L,8L,11L,15L,16L,20L,22L,27L,29L,31L,36L,38L,42L,43L,46L,51L,53L,56L,58L,63L,64L,69L,71L,74L,78L,79L,83L,85L,90L,91L,96L,98L,101L,105L,106L,110L,112L,117L,119L,123L,124L,127L,132L,134L,136L,141L,143L,146L,150L,151L,155L,157L,162L,164L,166L,171L,172L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287408Inst : IEnumerable<long>
{
public static readonly long[] Value=A287408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287408.Bytes);
public long this[int i]=>Value[i];

public static A287408Inst Instance=new A287408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287409
{
public static readonly long[] Value={ 2L,5L,9L,12L,14L,17L,21L,23L,26L,30L,32L,35L,39L,41L,44L,47L,50L,54L,57L,59L,62L,65L,68L,72L,75L,77L,80L,84L,86L,89L,92L,95L,99L,102L,104L,107L,111L,113L,116L,120L,122L,125L,128L,131L,135L,137L,140L,144L,147L,149L,152L,156L,158L,161L,165L,167L,170L,173L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287409Inst : IEnumerable<long>
{
public static readonly long[] Value=A287409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287409.Bytes);
public long this[int i]=>Value[i];

public static A287409Inst Instance=new A287409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287410
{
public static readonly long[] Value={ 3L,4L,7L,10L,13L,18L,19L,24L,25L,28L,33L,34L,37L,40L,45L,48L,49L,52L,55L,60L,61L,66L,67L,70L,73L,76L,81L,82L,87L,88L,93L,94L,97L,100L,103L,108L,109L,114L,115L,118L,121L,126L,129L,130L,133L,138L,139L,142L,145L,148L,153L,154L,159L,160L,163L,168L,169L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287410Inst : IEnumerable<long>
{
public static readonly long[] Value=A287410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287410.Bytes);
public long this[int i]=>Value[i];

public static A287410Inst Instance=new A287410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287411
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,0L,0L,2L,1L,1L,2L,0L,0L,2L,1L,0L,1L,2L,0L,1L,2L,0L,2L,1L,1L,2L,0L,1L,2L,0L,0L,2L,1L,0L,1L,2L,0L,1L,2L,0L,2L,1L,1L,2L,0L,0L,1L,2L,1L,2L,0L,0L,2L,1L,0L,1L,2L,1L,2L,0L,0L,2L,1L,0L,1L,2L,0L,2L,1L,1L,2L,0L,1L,2L,0L,0L,2L,1L,0L,1L,2L,1L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287411Inst : IEnumerable<long>
{
public static readonly long[] Value=A287411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287411.Bytes);
public long this[int i]=>Value[i];

public static A287411Inst Instance=new A287411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287412
{
public static readonly long[] Value={ 1L,6L,7L,12L,13L,16L,19L,22L,27L,30L,31L,34L,37L,40L,45L,46L,51L,52L,55L,60L,61L,64L,67L,72L,75L,76L,79L,84L,85L,88L,91L,94L,99L,100L,105L,106L,109L,114L,115L,118L,121L,126L,129L,130L,133L,136L,141L,142L,147L,148L,151L,154L,157L,162L,163L,168L,169L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287412Inst : IEnumerable<long>
{
public static readonly long[] Value=A287412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287412.Bytes);
public long this[int i]=>Value[i];

public static A287412Inst Instance=new A287412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287413
{
public static readonly long[] Value={ 2L,4L,9L,10L,15L,17L,20L,24L,25L,28L,33L,35L,38L,42L,43L,47L,49L,54L,56L,58L,63L,65L,69L,70L,73L,78L,80L,82L,87L,89L,92L,96L,97L,101L,103L,108L,110L,112L,117L,119L,123L,124L,127L,132L,134L,137L,139L,144L,145L,150L,152L,155L,159L,160L,164L,166L,171L,172L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287413Inst : IEnumerable<long>
{
public static readonly long[] Value=A287413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287413.Bytes);
public long this[int i]=>Value[i];

public static A287413Inst Instance=new A287413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287414
{
public static readonly long[] Value={ 3L,5L,8L,11L,14L,18L,21L,23L,26L,29L,32L,36L,39L,41L,44L,48L,50L,53L,57L,59L,62L,66L,68L,71L,74L,77L,81L,83L,86L,90L,93L,95L,98L,102L,104L,107L,111L,113L,116L,120L,122L,125L,128L,131L,135L,138L,140L,143L,146L,149L,153L,156L,158L,161L,165L,167L,170L,173L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287414Inst : IEnumerable<long>
{
public static readonly long[] Value=A287414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287414.Bytes);
public long this[int i]=>Value[i];

public static A287414Inst Instance=new A287414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287415
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,5L,4L,7L,4L,9L,6L,11L,4L,13L,4L,15L,10L,15L,12L,17L,6L,21L,12L,21L,14L,21L,16L,21L,18L,25L,14L,27L,18L,29L,14L,31L,12L,35L,18L,35L,20L,35L,22L,35L,24L,39L,26L,37L,18L,45L,30L,45L,32L,39L,34L,41L,22L,49L,24L,53L,16L,55L,28L,53L,20L,59L,18L,63L,38L,55L,36L,61L,20L,67L,16L,69L,42L,67L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287415Inst : IEnumerable<long>
{
public static readonly long[] Value=A287415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287415.Bytes);
public long this[int i]=>Value[i];

public static A287415Inst Instance=new A287415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287416
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,3L,2L,0L,4L,8L,3L,0L,5L,22L,19L,6L,0L,6L,52L,81L,48L,16L,0L,7L,114L,289L,267L,147L,53L,0L,8L,240L,941L,1250L,968L,529L,204L,0L,9L,494L,2894L,5310L,5469L,3919L,2174L,878L,0L,10L,1004L,8601L,21256L,28083L,25326L,17593L,9961L,4141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287416Inst : IEnumerable<long>
{
public static readonly long[] Value=A287416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287416.Bytes);
public long this[int i]=>Value[i];

public static A287416Inst Instance=new A287416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287449
{
public static readonly long[] Value={ 2L,6L,7L,10L,14L,18L,21L,23L,25L,30L,32L,34L,38L,42L,43L,46L,50L,54L,55L,59L,63L,65L,69L,70L,75L,77L,79L,82L,86L,90L,92L,96L,97L,102L,104L,106L,110L,114L,115L,118L,122L,126L,129L,131L,133L,138L,140L,142L,146L,150L,151L,154L,158L,162L,165L,167L,169L,173L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287449Inst : IEnumerable<long>
{
public static readonly long[] Value=A287449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287449.Bytes);
public long this[int i]=>Value[i];

public static A287449Inst Instance=new A287449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287450
{
public static readonly long[] Value={ 3L,4L,9L,12L,15L,16L,19L,24L,27L,28L,33L,36L,39L,40L,45L,48L,51L,52L,57L,60L,61L,66L,67L,72L,73L,78L,81L,84L,87L,88L,93L,94L,99L,100L,105L,108L,111L,112L,117L,120L,123L,124L,127L,132L,135L,136L,141L,144L,147L,148L,153L,156L,159L,160L,163L,168L,171L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287450Inst : IEnumerable<long>
{
public static readonly long[] Value=A287450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287450.Bytes);
public long this[int i]=>Value[i];

public static A287450Inst Instance=new A287450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287451
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,2L,0L,1L,1L,2L,0L,0L,1L,2L,0L,1L,2L,2L,0L,1L,1L,2L,0L,1L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287451Inst : IEnumerable<long>
{
public static readonly long[] Value=A287451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287451.Bytes);
public long this[int i]=>Value[i];

public static A287451Inst Instance=new A287451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287452
{
public static readonly long[] Value={ 1L,5L,9L,12L,13L,17L,20L,24L,25L,29L,33L,34L,37L,41L,45L,48L,49L,53L,57L,58L,62L,65L,69L,70L,73L,77L,81L,84L,85L,89L,92L,96L,97L,100L,104L,108L,109L,113L,117L,120L,121L,125L,128L,132L,133L,137L,141L,142L,145L,149L,153L,156L,157L,161L,164L,168L,169L,172L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287452Inst : IEnumerable<long>
{
public static readonly long[] Value=A287452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287452.Bytes);
public long this[int i]=>Value[i];

public static A287452Inst Instance=new A287452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287453
{
public static readonly long[] Value={ 2L,6L,7L,10L,14L,18L,21L,22L,26L,30L,31L,35L,38L,42L,43L,46L,50L,54L,55L,59L,63L,66L,67L,71L,74L,78L,79L,82L,86L,90L,93L,94L,98L,101L,105L,106L,110L,114L,115L,118L,122L,126L,129L,130L,134L,138L,139L,143L,146L,150L,151L,154L,158L,162L,165L,166L,170L,173L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287453Inst : IEnumerable<long>
{
public static readonly long[] Value=A287453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287453.Bytes);
public long this[int i]=>Value[i];

public static A287453Inst Instance=new A287453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287454
{
public static readonly long[] Value={ 3L,4L,8L,11L,15L,16L,19L,23L,27L,28L,32L,36L,39L,40L,44L,47L,51L,52L,56L,60L,61L,64L,68L,72L,75L,76L,80L,83L,87L,88L,91L,95L,99L,102L,103L,107L,111L,112L,116L,119L,123L,124L,127L,131L,135L,136L,140L,144L,147L,148L,152L,155L,159L,160L,163L,167L,171L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287454Inst : IEnumerable<long>
{
public static readonly long[] Value=A287454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287454.Bytes);
public long this[int i]=>Value[i];

public static A287454Inst Instance=new A287454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287455
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,2L,1L,0L,2L,1L,0L,0L,1L,2L,2L,0L,1L,2L,1L,0L,2L,0L,1L,0L,1L,2L,2L,1L,0L,2L,0L,1L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,1L,0L,2L,1L,0L,0L,1L,2L,2L,0L,1L,2L,1L,0L,2L,0L,1L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,0L,1L,0L,1L,2L,2L,0L,1L,2L,1L,0L,2L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287455Inst : IEnumerable<long>
{
public static readonly long[] Value=A287455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287455.Bytes);
public long this[int i]=>Value[i];

public static A287455Inst Instance=new A287455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287456
{
public static readonly long[] Value={ 1L,5L,9L,12L,13L,17L,21L,23L,25L,30L,32L,34L,37L,41L,45L,48L,49L,53L,57L,59L,61L,66L,67L,71L,73L,77L,81L,84L,86L,88L,93L,94L,98L,100L,104L,108L,109L,113L,117L,120L,121L,125L,129L,131L,133L,138L,140L,142L,145L,149L,153L,156L,157L,161L,165L,167L,169L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287456Inst : IEnumerable<long>
{
public static readonly long[] Value=A287456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287456.Bytes);
public long this[int i]=>Value[i];

public static A287456Inst Instance=new A287456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287457
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287457Inst : IEnumerable<long>
{
public static readonly long[] Value=A287457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287457.Bytes);
public long this[int i]=>Value[i];

public static A287457Inst Instance=new A287457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287458
{
public static readonly long[] Value={ 3L,4L,7L,10L,15L,16L,19L,22L,27L,28L,31L,36L,39L,40L,43L,46L,51L,52L,55L,58L,63L,64L,69L,70L,75L,76L,79L,82L,85L,90L,91L,96L,97L,102L,103L,106L,111L,112L,115L,118L,123L,124L,127L,130L,135L,136L,139L,144L,147L,148L,151L,154L,159L,160L,163L,166L,171L,172L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287458Inst : IEnumerable<long>
{
public static readonly long[] Value=A287458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287458.Bytes);
public long this[int i]=>Value[i];

public static A287458Inst Instance=new A287458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287459
{
public static readonly long[] Value={ 3L,7L,11L,23L,31L,47L,59L,67L,79L,103L,127L,131L,163L,191L,199L,211L,263L,311L,359L,367L,379L,443L,479L,523L,571L,599L,619L,631L,659L,719L,743L,787L,823L,827L,863L,887L,907L,911L,947L,967L,971L,991L,1019L,1039L,1051L,1103L,1123L,1171L,1223L,1283L,1307L,1367L,1447L,1451L,1499L,1523L,1531L,1571L,1619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287459Inst : IEnumerable<long>
{
public static readonly long[] Value=A287459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287459.Bytes);
public long this[int i]=>Value[i];

public static A287459Inst Instance=new A287459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287460
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1100L,11L,111100L,11L,11111111L,0L,1111111111L,0L,111111111111L,11L,11111111111100L,11L,1111111111111111L,0L,111111111111111001L,101L,11111111111111111001UL,1L,BigInteger.Parse("1111111111111111111001"),101L,BigInteger.Parse("111111111111111111110001"),1111L,BigInteger.Parse("11111111111111111111110001") };
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
public class A287460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287460Inst Instance=new A287460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287461
{
public static readonly BigInteger[] Value={ 1L,11L,100L,11L,11000L,1111L,1100000L,11111111L,0L,1111111111L,0L,111111111111L,1100000000000L,111111111111L,110000000000000L,1111111111111111L,0L,100111111111111111L,1010000000000000000L,10011111111111111111UL,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("1001111111111111111111") };
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
public class A287461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287461Inst Instance=new A287461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287462
{
public static readonly long[] Value={ 1L,3L,1L,12L,3L,60L,3L,255L,0L,1023L,0L,4095L,3L,16380L,3L,65535L,0L,262137L,5L,1048569L,1L,4194297L,5L,16777201L,15L,67108849L,12L,268435451L,24L,1073741823L,0L,4294967295L,31L,17179869124L,31L,68719476684L,7L,274877906892L,47L,1099511627724L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287462Inst : IEnumerable<long>
{
public static readonly long[] Value=A287462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287462.Bytes);
public long this[int i]=>Value[i];

public static A287462Inst Instance=new A287462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287463
{
public static readonly long[] Value={ 1L,3L,4L,3L,24L,15L,96L,255L,0L,1023L,0L,4095L,6144L,4095L,24576L,65535L,0L,163839L,327680L,655359L,1048576L,2621439L,5242880L,9437183L,31457280L,37748735L,25165824L,234881023L,50331648L,1073741823L,0L,4294967295L,8321499136L,2415919103L,33285996544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287463Inst : IEnumerable<long>
{
public static readonly long[] Value=A287463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287463.Bytes);
public long this[int i]=>Value[i];

public static A287463Inst Instance=new A287463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287464
{
public static readonly long[] Value={ 1L,1L,0L,1L,10L,0L,0L,0L,1100L,0L,0L,0L,0L,11L,0L,0L,11110000L,0L,0L,0L,1100L,0L,110000L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1111111100000000L,0L,0L,0L,11000000L,1100010000000000L,1000000000L,10000000000L,100000000000000L,10000000000L,100011000000L,10000010000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287464Inst : IEnumerable<long>
{
public static readonly long[] Value=A287464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287464.Bytes);
public long this[int i]=>Value[i];

public static A287464Inst Instance=new A287464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287609
{
public static readonly long[] Value={ 31L,71L,311L,551L,1151L,14831L,45791L,455471L,2035271L,6345239L,7241615L,8290031L,8329991L,9086231L,9324351L,10449575L,11497199L,15454151L,16515815L,18337271L,20650811L,22946591L,27609311L,33220079L,40487471L,44106191L,45015791L,49021199L,53315519L,54536519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287609Inst : IEnumerable<long>
{
public static readonly long[] Value=A287609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287609.Bytes);
public long this[int i]=>Value[i];

public static A287609Inst Instance=new A287609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287610
{
public static readonly long[] Value={ 1L,-1L,5L,-6L,1L,1L,-2L,2L,-1L,9999L,2L,-2L,-1L,1L,77L,-120L,60L,-20L,3L,1L,-3L,5L,-5L,3L,-1L,9999L,62L,-75L,-25L,75L,-60L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287610Inst : IEnumerable<long>
{
public static readonly long[] Value=A287610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287610.Bytes);
public long this[int i]=>Value[i];

public static A287610Inst Instance=new A287610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287611
{
public static readonly long[] Value={ 2L,94L,96L,194L,204L,678L,712L,2310L,7446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287611Inst : IEnumerable<long>
{
public static readonly long[] Value=A287611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287611.Bytes);
public long this[int i]=>Value[i];

public static A287611Inst Instance=new A287611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287612
{
public static readonly long[] Value={ 1L,2L,4L,18L,114L,131L,180L,258L,324L,412L,431L,605L,646L,864L,1037L,1081L,1101L,1167L,1296L,1313L,1404L,1470L,1765L,1856L,1858L,1900L,1944L,2032L,2117L,2327L,2572L,2630L,2635L,2674L,2787L,2809L,2814L,2897L,3068L,3214L,3219L,3261L,3393L,3451L,3591L,3622L,3630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287612Inst : IEnumerable<long>
{
public static readonly long[] Value=A287612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287612.Bytes);
public long this[int i]=>Value[i];

public static A287612Inst Instance=new A287612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287613
{
public static readonly long[] Value={ 36L,97L,138L,206L,358L,402L,722L,2816L,3205L,3725L,3918L,3962L,5020L,5516L,7461L,8368L,8756L,9193L,9621L,10247L,11219L,11586L,11759L,12365L,12580L,12602L,13164L,13401L,14892L,15820L,17743L,18305L,19644L,20140L,22344L,24785L,29733L,32626L,33276L,34549L,34615L,35888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287613Inst : IEnumerable<long>
{
public static readonly long[] Value=A287613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287613.Bytes);
public long this[int i]=>Value[i];

public static A287613Inst Instance=new A287613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287614
{
public static readonly long[] Value={ 5L,7L,13L,17L,19L,31L,37L,41L,61L,97L,113L,127L,181L,211L,257L,271L,313L,331L,337L,397L,421L,547L,613L,631L,761L,881L,919L,1013L,1201L,1301L,1657L,1741L,1801L,1861L,1951L,2113L,2269L,2381L,2437L,2521L,2791L,3121L,3169L,3571L,3613L,3697L,4219L,4447L,4513L,4651L,5101L,5167L,5419L,6211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287614Inst : IEnumerable<long>
{
public static readonly long[] Value=A287614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287614.Bytes);
public long this[int i]=>Value[i];

public static A287614Inst Instance=new A287614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287615
{
public static readonly long[] Value={ 5L,13L,19L,29L,37L,47L,79L,101L,97L,103L,113L,131L,127L,137L,181L,199L,181L,227L,233L,229L,239L,257L,277L,283L,311L,307L,317L,409L,383L,367L,389L,409L,439L,521L,463L,509L,491L,509L,613L,571L,541L,563L,577L,587L,619L,653L,677L,677L,709L,743L,787L,853L,743L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287615Inst : IEnumerable<long>
{
public static readonly long[] Value=A287615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287615.Bytes);
public long this[int i]=>Value[i];

public static A287615Inst Instance=new A287615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287616
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,3L,1L,3L,1L,3L,3L,2L,4L,2L,3L,3L,3L,4L,3L,2L,5L,1L,2L,4L,3L,5L,4L,5L,4L,4L,3L,6L,3L,3L,2L,5L,2L,3L,7L,3L,7L,2L,6L,3L,5L,6L,7L,2L,4L,6L,3L,7L,2L,8L,4L,2L,6L,6L,3L,8L,3L,4L,6L,3L,7L,5L,6L,7L,4L,6L,9L,5L,6L,4L,4L,3L,4L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287616Inst : IEnumerable<long>
{
public static readonly long[] Value=A287616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287616.Bytes);
public long this[int i]=>Value[i];

public static A287616Inst Instance=new A287616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287617
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,21L,61L,141L,309L,766L,2191L,6436L,18041L,48348L,128311L,347166L,960197L,2674883L,7413514L,20411986L,56130675L,154907229L,429349768L,1192532452L,3312339849L,9196063371L,25538113056L,70994900341L,197595884071L,550414483911L,1533911418946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287617Inst : IEnumerable<long>
{
public static readonly long[] Value=A287617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287617.Bytes);
public long this[int i]=>Value[i];

public static A287617Inst Instance=new A287617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287618
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,3L,3L,4L,2L,4L,4L,5L,5L,3L,4L,4L,5L,5L,6L,3L,5L,5L,6L,6L,7L,7L,4L,5L,5L,6L,6L,7L,7L,8L,4L,6L,6L,7L,7L,8L,8L,9L,9L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,5L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,6L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287618Inst : IEnumerable<long>
{
public static readonly long[] Value=A287618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287618.Bytes);
public long this[int i]=>Value[i];

public static A287618Inst Instance=new A287618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287619
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287619Inst : IEnumerable<long>
{
public static readonly long[] Value=A287619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287619.Bytes);
public long this[int i]=>Value[i];

public static A287619Inst Instance=new A287619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287620
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,3L,2L,10L,11L,6L,13L,14L,15L,2L,17L,4L,19L,10L,21L,22L,23L,9L,2L,26L,3L,14L,29L,30L,31L,5L,33L,34L,35L,4L,37L,38L,39L,15L,41L,42L,43L,22L,10L,46L,47L,6L,2L,4L,51L,26L,53L,6L,55L,21L,57L,58L,59L,30L,61L,62L,14L,6L,65L,66L,67L,34L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287620Inst : IEnumerable<long>
{
public static readonly long[] Value=A287620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287620.Bytes);
public long this[int i]=>Value[i];

public static A287620Inst Instance=new A287620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287621
{
public static readonly long[] Value={ 1L,2L,3L,18L,5L,6L,7L,450L,24L,10L,11L,150L,13L,14L,15L,22050L,17L,192L,19L,90L,21L,22L,23L,7350L,160L,26L,3000L,126L,29L,30L,31L,2668050L,33L,34L,35L,4800L,37L,38L,39L,4410L,41L,42L,43L,198L,120L,46L,47L,705600L,896L,1440L,51L,234L,53L,24000L,55L,3150L,57L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287621Inst : IEnumerable<long>
{
public static readonly long[] Value=A287621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287621.Bytes);
public long this[int i]=>Value[i];

public static A287621Inst Instance=new A287621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287622
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1110L,111L,111110L,1111L,11111110L,11011L,1111111100L,110011L,111111111111L,1111111L,11111111100011L,11111110L,1111111111100111L,110011111L,111111111111111110L,1101101111L,11111111111111111111UL,11111111100L,BigInteger.Parse("1111111111111000001111"),111111111000L };
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
public class A287622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287622Inst Instance=new A287622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287623
{
public static readonly ulong[] Value={ 1L,11L,110L,111L,11100L,11111L,1111000L,1111111L,110110000L,11111111L,11001100000L,111111111111L,1111111000000L,11000111111111L,11111110000000L,1110011111111111L,11111001100000000L,11111111111111111L,1111011011000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287623Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A287623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287623.Bytes);
public ulong this[int i]=>Value[i];

public static A287623Inst Instance=new A287623Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287624
{
public static readonly long[] Value={ 1L,3L,3L,14L,7L,62L,15L,254L,27L,1020L,51L,4095L,127L,16355L,254L,65511L,415L,262142L,879L,1048575L,2044L,4193807L,4088L,16777151L,6598L,67108671L,14278L,268435007L,32735L,1073737662L,65503L,4294966191L,100351L,17179868092L,229367L,68719476668L,524255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287624Inst : IEnumerable<long>
{
public static readonly long[] Value=A287624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287624.Bytes);
public long this[int i]=>Value[i];

public static A287624Inst Instance=new A287624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287673
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,4140L,21147L,115975L,678570L,4213597L,27644436L,190898290L,1382887161L,10477990158L,82819430415L,681282289857L,5820296183791L,51541816775857L,472306124149579L,4471549108520595L,43676154621078016L,439558508006341652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287673Inst : IEnumerable<long>
{
public static readonly long[] Value=A287673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287673.Bytes);
public long this[int i]=>Value[i];

public static A287673Inst Instance=new A287673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287674
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287674Inst : IEnumerable<long>
{
public static readonly long[] Value=A287674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287674.Bytes);
public long this[int i]=>Value[i];

public static A287674Inst Instance=new A287674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287675
{
public static readonly long[] Value={ 2L,3L,7L,8L,11L,12L,16L,17L,21L,22L,25L,26L,30L,31L,34L,35L,39L,40L,44L,45L,48L,49L,53L,54L,58L,59L,62L,63L,67L,68L,71L,72L,76L,77L,81L,82L,85L,86L,90L,91L,94L,95L,99L,100L,104L,105L,108L,109L,113L,114L,118L,119L,122L,123L,127L,128L,131L,132L,136L,137L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287675Inst : IEnumerable<long>
{
public static readonly long[] Value=A287675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287675.Bytes);
public long this[int i]=>Value[i];

public static A287675Inst Instance=new A287675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287676
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,10L,13L,14L,15L,18L,19L,20L,23L,24L,27L,28L,29L,32L,33L,36L,37L,38L,41L,42L,43L,46L,47L,50L,51L,52L,55L,56L,57L,60L,61L,64L,65L,66L,69L,70L,73L,74L,75L,78L,79L,80L,83L,84L,87L,88L,89L,92L,93L,96L,97L,98L,101L,102L,103L,106L,107L,110L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287676Inst : IEnumerable<long>
{
public static readonly long[] Value=A287676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287676.Bytes);
public long this[int i]=>Value[i];

public static A287676Inst Instance=new A287676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287677
{
public static readonly BigInteger[] Value={ 1L,4L,18L,5778L,BigInteger.Parse("215002084978043708894524818"),BigInteger.Parse("8000328475168735073037785452636987975637751878418"),BigInteger.Parse("267093222236137978360266538108484045754096036229865700498"),BigInteger.Parse("8916982544642128998138920801180413422215946187628307595501392018") };
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
public class A287677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287677Inst Instance=new A287677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287678
{
public static readonly long[] Value={ 4L,7L,9L,10L,12L,13L,19L,40L,76L,87L,172L,175L,1005L,1330L,1582L,1849L,2134L,2350L,2652L,5680L,13504L,41416L,95251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287678Inst : IEnumerable<long>
{
public static readonly long[] Value=A287678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287678.Bytes);
public long this[int i]=>Value[i];

public static A287678Inst Instance=new A287678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287679
{
public static readonly BigInteger[] Value={ 1L,2L,12L,408L,13860L,470832L,15994428L,543339720L,18457556052L,627013566048L,21300003689580L,723573111879672L,24580185800219268L,835002744095575440L,BigInteger.Parse("963592443113182178088"),BigInteger.Parse("32733777552734744709300"),BigInteger.Parse("1111984844349868137938112"),BigInteger.Parse("1283229546787304717998403160") };
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
public class A287679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287679Inst Instance=new A287679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287680
{
public static readonly long[] Value={ 0L,2L,3L,9L,11L,26L,39L,42L,58L,75L,105L,167L,279L,561L,2152L,2378L,3774L,5001L,5736L,9470L,13419L,14535L,32291L,89800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287680Inst : IEnumerable<long>
{
public static readonly long[] Value=A287680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287680.Bytes);
public long this[int i]=>Value[i];

public static A287680Inst Instance=new A287680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287681
{
public static readonly long[] Value={ 2L,4L,6L,16L,18L,28L,30L,40L,54L,64L,78L,88L,126L,160L,196L,198L,208L,270L,304L,306L,340L,378L,390L,414L,448L,460L,462L,510L,520L,544L,558L,700L,702L,726L,798L,810L,858L,868L,880L,918L,928L,966L,990L,1024L,1120L,1216L,1230L,1240L,1288L,1300L,1350L,1408L,1456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287681Inst : IEnumerable<long>
{
public static readonly long[] Value=A287681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287681.Bytes);
public long this[int i]=>Value[i];

public static A287681Inst Instance=new A287681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287682
{
public static readonly long[] Value={ 4L,6L,18L,30L,198L,306L,462L,702L,1482L,2550L,3330L,4422L,5778L,6102L,6498L,9042L,11178L,11778L,14418L,15498L,17298L,17442L,19458L,20862L,21582L,22878L,23322L,23550L,25230L,26622L,26862L,26910L,27378L,30210L,34542L,36738L,38610L,39006L,39102L,40350L,40662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287682Inst : IEnumerable<long>
{
public static readonly long[] Value=A287682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287682.Bytes);
public long this[int i]=>Value[i];

public static A287682Inst Instance=new A287682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287683
{
public static readonly long[] Value={ 18L,30L,198L,306L,462L,1482L,2550L,4422L,17298L,23322L,23550L,40350L,52578L,67938L,88506L,92202L,96222L,123006L,131070L,219102L,226182L,237690L,277506L,312702L,359658L,432822L,526878L,533370L,584166L,659934L,1032858L,1051650L,1140414L,1142658L,1243170L,1255422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287683Inst : IEnumerable<long>
{
public static readonly long[] Value=A287683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287683.Bytes);
public long this[int i]=>Value[i];

public static A287683Inst Instance=new A287683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287684
{
public static readonly long[] Value={ 1L,2L,4L,13L,16L,19L,25L,44L,55L,64L,69L,183L,241L,290L,345L,398L,410L,423L,860L,1287L,2398L,2553L,3109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287684Inst : IEnumerable<long>
{
public static readonly long[] Value=A287684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287684.Bytes);
public long this[int i]=>Value[i];

public static A287684Inst Instance=new A287684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287685
{
public static readonly long[] Value={ 1L,7L,13L,44L,73L,128L,152L,245L,408L,436L,618L,638L,884L,1405L,1502L,1656L,2292L,2318L,4212L,5712L,5868L,13837L,18648L,25102L,30742L,34532L,53951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287685Inst : IEnumerable<long>
{
public static readonly long[] Value=A287685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287685.Bytes);
public long this[int i]=>Value[i];

public static A287685Inst Instance=new A287685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287686
{
public static readonly long[] Value={ 83L,366819L,1055019L,1947411L,2740107L,3694179L,6627579L,8851251L,9430899L,20243811L,28391619L,37545291L,38242083L,49459179L,56550291L,88205211L,101931891L,103429491L,108060339L,135085851L,176962659L,183973851L,194907051L,196911171L,212874531L,249687699L,271986651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287686Inst : IEnumerable<long>
{
public static readonly long[] Value=A287686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287686.Bytes);
public long this[int i]=>Value[i];

public static A287686Inst Instance=new A287686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287687
{
public static readonly long[] Value={ 1L,3L,5L,6L,15L,18L,21L,79L,291L,325L,359L,397L,455L,539L,735L,1164L,1653L,1795L,1829L,2622L,3798L,4013L,4795L,8823L,9349L,9366L,97247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287687Inst : IEnumerable<long>
{
public static readonly long[] Value=A287687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287687.Bytes);
public long this[int i]=>Value[i];

public static A287687Inst Instance=new A287687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287688
{
public static readonly long[] Value={ 2L,6L,7L,10L,15L,13L,15L,21L,28L,22L,21L,28L,36L,45L,32L,28L,36L,45L,55L,66L,45L,36L,45L,55L,66L,78L,91L,59L,45L,55L,66L,78L,91L,105L,120L,76L,55L,66L,78L,91L,105L,120L,136L,153L,94L,66L,78L,91L,105L,120L,136L,153L,171L,190L,115L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287688Inst : IEnumerable<long>
{
public static readonly long[] Value=A287688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287688.Bytes);
public long this[int i]=>Value[i];

public static A287688Inst Instance=new A287688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287738
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1110L,1L,111110L,11L,11111100L,11L,1111111100L,11L,111111111100L,11L,11111111111100L,1111L,1111111111110000L,1111L,111111111111110000L,1111L,11111111111111110000UL,1111L,BigInteger.Parse("1111111111111111110000"),1111L,BigInteger.Parse("111111111111111111110000"),1111L };
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
public class A287738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287738Inst Instance=new A287738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287739
{
public static readonly BigInteger[] Value={ 1L,11L,100L,111L,10000L,11111L,1100000L,111111L,110000000L,11111111L,11000000000L,1111111111L,1100000000000L,111111111111L,111100000000000L,111111111111L,11110000000000000L,11111111111111L,1111000000000000000L,1111111111111111L,BigInteger.Parse("111100000000000000000") };
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
public class A287739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287739Inst Instance=new A287739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287740
{
public static readonly long[] Value={ 1L,3L,1L,14L,1L,62L,3L,252L,3L,1020L,3L,4092L,3L,16380L,15L,65520L,15L,262128L,15L,1048560L,15L,4194288L,15L,16777200L,15L,67108848L,15L,268435440L,15L,1073741808L,255L,4294967040L,255L,17179868928L,255L,68719476480L,255L,274877906688L,255L,1099511627552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287740Inst : IEnumerable<long>
{
public static readonly long[] Value=A287740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287740.Bytes);
public long this[int i]=>Value[i];

public static A287740Inst Instance=new A287740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287741
{
public static readonly long[] Value={ 1L,3L,4L,7L,16L,31L,96L,63L,384L,255L,1536L,1023L,6144L,4095L,30720L,4095L,122880L,16383L,491520L,65535L,1966080L,262143L,7864320L,1048575L,31457280L,4194303L,125829120L,16777215L,503316480L,67108863L,2139095040L,16777215L,8556380160L,67108863L,34225520640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287741Inst : IEnumerable<long>
{
public static readonly long[] Value=A287741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287741.Bytes);
public long this[int i]=>Value[i];

public static A287741Inst Instance=new A287741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287742
{
public static readonly long[] Value={ 1L,1L,10L,10L,101L,101L,1010L,1010L,10101L,10101L,101010L,101010L,1010101L,1010101L,10101010L,10101010L,101010101L,101010101L,1010101010L,1010101010L,10101010101L,10101010101L,101010101010L,101010101010L,1010101010101L,1010101010101L,10101010101010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287742Inst : IEnumerable<long>
{
public static readonly long[] Value=A287742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287742.Bytes);
public long this[int i]=>Value[i];

public static A287742Inst Instance=new A287742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287743
{
public static readonly long[] Value={ 1L,10L,10L,100L,10100L,101000L,101000L,1010000L,101010000L,1010100000L,1010100000L,10101000000L,1010101000000L,10101010000000L,10101010000000L,101010100000000L,10101010100000000L,101010101000000000L,101010101000000000L,1010101010000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287743Inst : IEnumerable<long>
{
public static readonly long[] Value=A287743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287743.Bytes);
public long this[int i]=>Value[i];

public static A287743Inst Instance=new A287743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287744
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,5L,10L,10L,21L,21L,42L,42L,85L,85L,170L,170L,341L,341L,682L,682L,1365L,1365L,2730L,2730L,5461L,5461L,10922L,10922L,21845L,21845L,43690L,43690L,87381L,87381L,174762L,174762L,349525L,349525L,699050L,699050L,1398101L,1398101L,2796202L,2796202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287744Inst : IEnumerable<long>
{
public static readonly long[] Value=A287744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287744.Bytes);
public long this[int i]=>Value[i];

public static A287744Inst Instance=new A287744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287745
{
public static readonly long[] Value={ 1L,2L,2L,4L,20L,40L,40L,80L,336L,672L,672L,1344L,5440L,10880L,10880L,21760L,87296L,174592L,174592L,349184L,1397760L,2795520L,2795520L,5591040L,22368256L,44736512L,44736512L,89473024L,357908480L,715816960L,715816960L,1431633920L,5726601216L,11453202432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287745Inst : IEnumerable<long>
{
public static readonly long[] Value=A287745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287745.Bytes);
public long this[int i]=>Value[i];

public static A287745Inst Instance=new A287745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287746
{
public static readonly long[] Value={ 1L,5L,5L,2L,7L,15L,11L,4L,13L,25L,17L,6L,19L,35L,23L,8L,25L,45L,29L,10L,31L,55L,35L,12L,37L,65L,41L,14L,43L,75L,47L,16L,49L,85L,53L,18L,55L,95L,59L,20L,61L,105L,65L,22L,67L,115L,71L,24L,73L,125L,77L,26L,79L,135L,83L,28L,85L,145L,89L,30L,91L,155L,95L,32L,97L,165L,101L,34L,103L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287746Inst : IEnumerable<long>
{
public static readonly long[] Value=A287746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287746.Bytes);
public long this[int i]=>Value[i];

public static A287746Inst Instance=new A287746Inst();

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