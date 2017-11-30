using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A239411
{
public static readonly BigInteger[] Value={ 368L,113774L,32507376L,9402398952L,2671846338458L,765206237815409L,217822754771248124L,BigInteger.Parse("62224253930396430225"),BigInteger.Parse("17732860047914475927901"),BigInteger.Parse("5061141668045083629968143"),BigInteger.Parse("1443095146623473513048203207") };
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
public class A239411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239411Inst Instance=new A239411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239410
{
public static readonly BigInteger[] Value={ 156L,20818L,2590704L,326882784L,40566958960L,5072216819342L,630657074443394L,78666433617260802L,9791612259389470778UL,BigInteger.Parse("1220385596630190836830"),BigInteger.Parse("151973853622892194440357"),BigInteger.Parse("18935435888110044394225594") };
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
public class A239410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239410Inst Instance=new A239410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239409
{
public static readonly BigInteger[] Value={ 66L,3805L,205969L,11334364L,614216271L,33522573911L,1820591502437L,99155297311831L,5390539057008613L,293381673332485198L,15956203146991156417UL,BigInteger.Parse("868193383242995642964"),BigInteger.Parse("47226335011968154541246"),BigInteger.Parse("2569370658950018916786902") };
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
public class A239409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239409Inst Instance=new A239409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239408
{
public static readonly BigInteger[] Value={ 28L,698L,16449L,394509L,9340070L,222457036L,5277728354L,125489197292L,2979675864286L,70809806218933L,1681881988746468L,39960823740980549L,949269180927265463L,BigInteger.Parse("22552572727646416085"),BigInteger.Parse("535760871479260663596") };
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
public class A239408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239408Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239408.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239408Inst Instance=new A239408Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239359
{
public static readonly long[] Value={ 7L,19L,39L,77L,156L,266L,409L,599L,852L,1191L,1635L,2213L,2944L,3837L,4910L,6178L,7657L,9363L,11312L,13520L,16003L,18777L,21858L,25262L,29005L,33103L,37572L,42428L,47687L,53365L,59478L,66042L,73073L,80587L,88600L,97128L,106187L,115793L,125962L,136710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239359Inst : IEnumerable<long>
{
public static readonly long[] Value=A239359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239359.Bytes);
public long this[int i]=>Value[i];

public static A239359Inst Instance=new A239359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239358
{
public static readonly long[] Value={ 6L,16L,32L,60L,106L,156L,218L,299L,399L,524L,680L,874L,1113L,1404L,1754L,2170L,2659L,3228L,3884L,4634L,5485L,6444L,7518L,8714L,10039L,11500L,13104L,14858L,16769L,18844L,21090L,23514L,26123L,28924L,31924L,35130L,38549L,42188L,46054L,50154L,54495L,59084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239358Inst : IEnumerable<long>
{
public static readonly long[] Value=A239358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239358.Bytes);
public long this[int i]=>Value[i];

public static A239358Inst Instance=new A239358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239357
{
public static readonly long[] Value={ 2L,7L,17L,43L,106L,266L,729L,2151L,7018L,24408L,89336L,357201L,1458929L,5961455L,24784580L,107143015L,480468133L,2242277805L,11003117564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239357Inst : IEnumerable<long>
{
public static readonly long[] Value=A239357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239357.Bytes);
public long this[int i]=>Value[i];

public static A239357Inst Instance=new A239357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239356
{
public static readonly long[] Value={ 3L,4L,5L,12L,13L,84L,85L,36L,77L,2964L,2573L,3925L,1116L,637L,1285L,893L,924L,43L,925L,372L,997L,497004L,497005L,138204L,82597L,161005L,39973L,155964L,386827L,417085L,258037L,327684L,139763L,356245L,225924L,82643L,240565L,37164L,13573L,39565L,2388L,39637L,26412L,11515L,28813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239356Inst : IEnumerable<long>
{
public static readonly long[] Value=A239356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239356.Bytes);
public long this[int i]=>Value[i];

public static A239356Inst Instance=new A239356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239355
{
public static readonly long[] Value={ 0L,1L,1L,5L,5L,11L,11L,15L,14L,19L,19L,31L,31L,43L,39L,43L,43L,49L,49L,65L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239355Inst : IEnumerable<long>
{
public static readonly long[] Value=A239355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239355.Bytes);
public long this[int i]=>Value[i];

public static A239355Inst Instance=new A239355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239354
{
public static readonly long[] Value={ 0L,5L,6L,8L,5L,2L,8L,1L,9L,4L,4L,0L,0L,5L,4L,6L,9L,0L,5L,8L,2L,7L,6L,7L,8L,7L,8L,5L,4L,1L,8L,2L,3L,4L,3L,1L,9L,2L,4L,4L,9L,9L,8L,6L,5L,6L,3L,9L,7L,4L,4L,7L,4L,5L,8L,7L,9L,3L,1L,9L,9L,9L,0L,5L,0L,6L,6L,0L,6L,3L,7L,8L,0L,3L,0L,3L,0L,5L,2L,8L,4L,3L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239354Inst : IEnumerable<long>
{
public static readonly long[] Value=A239354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239354.Bytes);
public long this[int i]=>Value[i];

public static A239354Inst Instance=new A239354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239353
{
public static readonly long[] Value={ 1L,5L,11L,15L,19L,31L,32L,44L,48L,54L,58L,70L,82L,94L,100L,112L,124L,148L,164L,176L,194L,206L,219L,235L,247L,275L,281L,317L,333L,345L,369L,393L,417L,421L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239353Inst : IEnumerable<long>
{
public static readonly long[] Value=A239353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239353.Bytes);
public long this[int i]=>Value[i];

public static A239353Inst Instance=new A239353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239352
{
public static readonly long[] Value={ 0L,0L,1L,12L,48L,130L,285L,546L,952L,1548L,2385L,3520L,5016L,6942L,9373L,12390L,16080L,20536L,25857L,32148L,39520L,48090L,57981L,69322L,82248L,96900L,113425L,131976L,152712L,175798L,201405L,229710L,260896L,295152L,332673L,373660L,418320L,466866L,519517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239352Inst : IEnumerable<long>
{
public static readonly long[] Value=A239352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239352.Bytes);
public long this[int i]=>Value[i];

public static A239352Inst Instance=new A239352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239351
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239351Inst : IEnumerable<long>
{
public static readonly long[] Value=A239351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239351.Bytes);
public long this[int i]=>Value[i];

public static A239351Inst Instance=new A239351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239350
{
public static readonly BigInteger[] Value={ 1L,4L,144L,129600L,5715360000L,30497732496000000L,BigInteger.Parse("27502882612852046400000000"),BigInteger.Parse("7167813920637790505994548640000000000"),BigInteger.Parse("674376505248717910810215697948155164304000000000000"),BigInteger.Parse("33564007734235791949707248640534383334045138980782017600000000000000") };
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
public class A239350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239350Inst Instance=new A239350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239349
{
public static readonly long[] Value={ 9L,4L,0L,5L,0L,4L,3L,6L,1L,2L,4L,4L,5L,2L,1L,7L,5L,7L,8L,1L,3L,7L,6L,3L,3L,7L,4L,2L,9L,7L,8L,6L,0L,0L,5L,7L,9L,4L,1L,8L,7L,5L,6L,5L,2L,2L,5L,9L,0L,2L,3L,6L,3L,9L,6L,5L,9L,2L,2L,1L,7L,2L,1L,8L,5L,6L,0L,6L,8L,5L,9L,4L,2L,4L,2L,2L,1L,9L,9L,1L,2L,9L,8L,7L,3L,7L,7L,4L,0L,1L,4L,1L,0L,4L,9L,2L,9L,0L,6L,2L,8L,5L,5L,8L,9L,1L,8L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239349Inst : IEnumerable<long>
{
public static readonly long[] Value=A239349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239349.Bytes);
public long this[int i]=>Value[i];

public static A239349Inst Instance=new A239349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239348
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,36L,37L,39L,40L,41L,43L,44L,49L,50L,52L,53L,54L,56L,60L,62L,67L,68L,70L,71L,72L,74L,76L,77L,79L,80L,81L,82L,84L,85L,90L,91L,93L,94L,109L,111L,112L,117L,118L,121L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239348Inst : IEnumerable<long>
{
public static readonly long[] Value=A239348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239348.Bytes);
public long this[int i]=>Value[i];

public static A239348Inst Instance=new A239348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239347
{
public static readonly long[] Value={ 1L,539L,583L,1023L,1903L,2277L,2893L,3047L,4433L,4587L,4983L,5181L,6567L,7271L,7359L,10857L,10989L,11341L,12221L,12507L,13167L,13277L,13453L,13739L,14443L,14729L,17347L,17919L,17941L,18381L,19151L,19437L,19481L,21131L,21197L,21307L,22561L,23331L,24871L,25003L,25289L,27643L,28391L,29161L,29469L,31339L,33077L,35057L,36597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239347Inst : IEnumerable<long>
{
public static readonly long[] Value=A239347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239347.Bytes);
public long this[int i]=>Value[i];

public static A239347Inst Instance=new A239347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239346
{
public static readonly long[] Value={ 2L,4L,10L,20L,40L,98L,100L,118L,122L,134L,140L,164L,190L,262L,272L,362L,400L,410L,494L,592L,602L,632L,638L,664L,830L,860L,862L,880L,938L,944L,962L,1120L,1148L,1162L,1202L,1288L,1340L,1360L,1408L,1498L,1594L,1642L,1772L,1802L,1840L,1870L,1874L,1882L,1960L,2078L,2092L,2158L,2170L,2188L,2348L,2368L,2462L,2474L,2482L,2488L,2498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239346Inst : IEnumerable<long>
{
public static readonly long[] Value=A239346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239346.Bytes);
public long this[int i]=>Value[i];

public static A239346Inst Instance=new A239346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239345
{
public static readonly long[] Value={ 3L,33L,105L,129L,165L,201L,231L,351L,363L,393L,447L,543L,687L,861L,951L,1107L,1149L,1227L,1257L,1269L,1293L,1359L,1389L,1515L,1557L,1605L,1647L,1689L,1761L,1803L,1815L,1941L,1977L,2073L,2127L,2145L,2163L,2289L,2355L,2415L,2445L,2481L,2571L,2607L,2619L,2775L,2811L,2859L,2973L,3141L,3171L,3321L,3327L,3333L,3393L,3471L,3501L,3513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239345Inst : IEnumerable<long>
{
public static readonly long[] Value=A239345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239345.Bytes);
public long this[int i]=>Value[i];

public static A239345Inst Instance=new A239345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239344
{
public static readonly long[] Value={ 0L,16L,48L,66L,76L,94L,114L,120L,214L,216L,270L,346L,454L,496L,516L,594L,598L,606L,628L,730L,780L,786L,808L,936L,948L,1030L,1044L,1104L,1168L,1248L,1258L,1270L,1276L,1396L,1474L,1506L,1548L,1594L,1728L,1746L,1830L,1870L,1900L,1908L,1914L,1936L,1968L,2040L,2070L,2104L,2118L,2136L,2158L,2278L,2320L,2376L,2518L,2586L,2610L,2736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239344Inst : IEnumerable<long>
{
public static readonly long[] Value=A239344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239344.Bytes);
public long this[int i]=>Value[i];

public static A239344Inst Instance=new A239344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239295
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,210L,1897L,18368L,186636L,1965414L,21277685L,235493544L,2653779856L,30357956720L,351719984280L,4119552129280L,48708104589368L,580682799531822L,6973356315752445L,84286657672243880L,1024694111031383100L,12522664914160322460UL,BigInteger.Parse("153762682439070435390") };
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
public class A239295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239295Inst Instance=new A239295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239294
{
public static readonly BigInteger[] Value={ 0L,1L,12L,189L,2808L,42201L,632772L,9492309L,142382448L,2135743281L,32036129532L,480542002029L,7208129853288L,108121948330761L,1621829223367092L,24327438355289349L,364911575314991328L,5473673629767916641L,BigInteger.Parse("82105104446389609452") };
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
public class A239294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239294Inst Instance=new A239294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239293
{
public static readonly long[] Value={ 4L,341L,6L,6L,10L,10L,14L,9L,12L,15L,15L,22L,21L,15L,21L,20L,34L,25L,38L,21L,28L,33L,33L,25L,28L,27L,39L,36L,35L,49L,49L,33L,44L,35L,45L,42L,45L,39L,57L,52L,82L,66L,77L,45L,55L,69L,65L,49L,56L,51L,65L,65L,65L,55L,63L,57L,65L,66L,87L,65L,91L,63L,93L,65L,70L,78L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239293Inst : IEnumerable<long>
{
public static readonly long[] Value=A239293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239293.Bytes);
public long this[int i]=>Value[i];

public static A239293Inst Instance=new A239293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239292
{
public static readonly long[] Value={ 0L,1L,-2L,2L,0L,3L,-4L,-1L,4L,4L,0L,0L,4L,-2L,0L,1L,16L,6L,4L,2L,8L,8L,14L,4L,20L,18L,22L,32L,32L,32L,28L,32L,52L,56L,64L,83L,76L,92L,112L,130L,140L,168L,172L,198L,212L,256L,288L,318L,368L,416L,456L,527L,564L,640L,712L,806L,884L,985L,1116L,1224L,1344L,1496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239292Inst : IEnumerable<long>
{
public static readonly long[] Value=A239292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239292.Bytes);
public long this[int i]=>Value[i];

public static A239292Inst Instance=new A239292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239291
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,5L,7L,9L,16L,16L,22L,22L,34L,37L,46L,46L,57L,71L,79L,81L,103L,103L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239291Inst : IEnumerable<long>
{
public static readonly long[] Value=A239291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239291.Bytes);
public long this[int i]=>Value[i];

public static A239291Inst Instance=new A239291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239290
{
public static readonly long[] Value={ 4L,7L,8L,19L,55L,149L,497L,1799L,6696L,26109L,106953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239290Inst : IEnumerable<long>
{
public static readonly long[] Value=A239290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239290.Bytes);
public long this[int i]=>Value[i];

public static A239290Inst Instance=new A239290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239289
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,46L,47L,48L,49L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,65L,67L,69L,71L,72L,73L,74L,77L,79L,80L,81L,82L,83L,84L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239289Inst : IEnumerable<long>
{
public static readonly long[] Value=A239289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239289.Bytes);
public long this[int i]=>Value[i];

public static A239289Inst Instance=new A239289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239288
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,15L,22L,33L,48L,69L,102L,147L,210L,309L,444L,633L,930L,1335L,1902L,2793L,4008L,5709L,8382L,12027L,17130L,25149L,36084L,51393L,75450L,108255L,154182L,226353L,324768L,462549L,679062L,974307L,1387650L,2037189L,2922924L,4162953L,6111570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239288Inst : IEnumerable<long>
{
public static readonly long[] Value=A239288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239288.Bytes);
public long this[int i]=>Value[i];

public static A239288Inst Instance=new A239288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239287
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,2L,1L,0L,0L,1L,2L,3L,2L,1L,0L,1L,2L,3L,3L,2L,1L,0L,0L,1L,2L,3L,4L,3L,2L,1L,0L,1L,2L,3L,4L,4L,3L,2L,1L,0L,0L,1L,2L,3L,4L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,0L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239287Inst : IEnumerable<long>
{
public static readonly long[] Value=A239287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239287.Bytes);
public long this[int i]=>Value[i];

public static A239287Inst Instance=new A239287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239286
{
public static readonly long[] Value={ 1L,1L,0L,-2L,1L,3L,-5L,1L,6L,-8L,1L,9L,-11L,1L,12L,-14L,1L,15L,-17L,1L,18L,-20L,1L,21L,-23L,1L,24L,-26L,1L,27L,-29L,1L,30L,-32L,1L,33L,-35L,1L,36L,-38L,1L,39L,-41L,1L,42L,-44L,1L,45L,-47L,1L,48L,-50L,1L,51L,-53L,1L,54L,-56L,1L,57L,-59L,1L,60L,-62L,1L,63L,-65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239286Inst : IEnumerable<long>
{
public static readonly long[] Value=A239286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239286.Bytes);
public long this[int i]=>Value[i];

public static A239286Inst Instance=new A239286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239285
{
public static readonly BigInteger[] Value={ 0L,1L,13L,199L,2977L,44671L,670033L,10050559L,150758257L,2261374111L,33920611153L,508809168319L,7632137522737L,114482062845151L,1717230942669073L,25758464140052479L,386376962100754417L,5795654431511381791L,BigInteger.Parse("86934816472670595793"),BigInteger.Parse("1304022247090059199039") };
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
public class A239285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239285Inst Instance=new A239285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239284
{
public static readonly BigInteger[] Value={ 0L,1L,14L,211L,3164L,47461L,711914L,10678711L,160180664L,2402709961L,36040649414L,540609741211L,8109146118164L,121637191772461L,1824557876586914L,27368368148803711L,410525522232055664L,6157882833480834961L,BigInteger.Parse("92368242502212524414"),BigInteger.Parse("1385523637533187866211") };
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
public class A239284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239284Inst Instance=new A239284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239283
{
public static readonly BigInteger[] Value={ 0L,4L,27L,32L,3125L,252L,823543L,192L,1458L,100100L,285311670611L,2016L,302875106592253L,105413700L,762750L,1024L,BigInteger.Parse("827240261886336764177"),11988L,BigInteger.Parse("1978419655660313589123979"),3200800L,1801097802L,584318301411812L,BigInteger.Parse("20880467999847912034355032910567"),15552L,19531250L };
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
public class A239283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239283Inst Instance=new A239283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239282
{
public static readonly long[] Value={ 0L,3L,5L,7L,22L,13L,34L,38L,46L,58L,93L,111L,123L,86L,141L,106L,236L,244L,134L,213L,292L,237L,332L,445L,388L,303L,515L,321L,436L,678L,381L,655L,822L,278L,745L,906L,785L,815L,1169L,692L,895L,1448L,955L,772L,1773L,796L,1055L,1561L,681L,1374L,1864L,1195L,1446L,2008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239282Inst : IEnumerable<long>
{
public static readonly long[] Value=A239282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239282.Bytes);
public long this[int i]=>Value[i];

public static A239282Inst Instance=new A239282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239281
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,2L,3L,1L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,3L,4L,1L,2L,4L,2L,2L,4L,2L,3L,2L,3L,4L,3L,3L,3L,4L,2L,4L,3L,3L,4L,3L,4L,3L,3L,4L,4L,2L,3L,4L,4L,3L,4L,3L,4L,4L,3L,5L,1L,3L,2L,4L,4L,4L,3L,3L,5L,2L,4L,4L,4L,4L,4L,5L,2L,3L,3L,3L,5L,3L,3L,4L,2L,4L,3L,3L,4L,5L,2L,4L,3L,5L,3L,4L,3L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239281Inst : IEnumerable<long>
{
public static readonly long[] Value=A239281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239281.Bytes);
public long this[int i]=>Value[i];

public static A239281Inst Instance=new A239281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239280
{
public static readonly long[] Value={ 8L,16L,32L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239280Inst : IEnumerable<long>
{
public static readonly long[] Value=A239280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239280.Bytes);
public long this[int i]=>Value[i];

public static A239280Inst Instance=new A239280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239215
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,33L,34L,35L,36L,37L,38L,39L,44L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,66L,67L,68L,69L,77L,78L,79L,88L,89L,99L,999L,9999L,99999L,999999L,9999999L,99999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239215Inst : IEnumerable<long>
{
public static readonly long[] Value=A239215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239215.Bytes);
public long this[int i]=>Value[i];

public static A239215Inst Instance=new A239215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239214
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,3L,3L,2L,3L,3L,5L,4L,4L,3L,3L,6L,2L,4L,5L,4L,1L,2L,3L,6L,6L,6L,2L,4L,6L,9L,2L,7L,8L,6L,6L,2L,2L,2L,10L,4L,4L,7L,5L,7L,1L,4L,9L,9L,9L,4L,6L,8L,7L,8L,6L,4L,13L,10L,3L,6L,10L,7L,13L,12L,12L,8L,6L,8L,5L,11L,5L,3L,4L,5L,11L,7L,6L,12L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239214Inst : IEnumerable<long>
{
public static readonly long[] Value=A239214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239214.Bytes);
public long this[int i]=>Value[i];

public static A239214Inst Instance=new A239214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239213
{
public static readonly long[] Value={ 1L,4L,9L,36L,100L,144L,324L,400L,784L,900L,1024L,1296L,1444L,1764L,2304L,2500L,2916L,3600L,9216L,10000L,10404L,11664L,12100L,12996L,14400L,19044L,22500L,24336L,26244L,28224L,32400L,36864L,39204L,40000L,41616L,44100L,48400L,69696L,78400L,82944L,90000L,93636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239213Inst : IEnumerable<long>
{
public static readonly long[] Value=A239213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239213.Bytes);
public long this[int i]=>Value[i];

public static A239213Inst Instance=new A239213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239212
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,12L,18L,20L,28L,30L,32L,36L,38L,42L,48L,50L,54L,60L,96L,100L,102L,108L,110L,114L,120L,138L,150L,156L,162L,168L,180L,192L,198L,200L,204L,210L,220L,264L,280L,288L,300L,306L,318L,320L,332L,336L,338L,342L,348L,350L,360L,372L,380L,390L,402L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239212Inst : IEnumerable<long>
{
public static readonly long[] Value=A239212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239212.Bytes);
public long this[int i]=>Value[i];

public static A239212Inst Instance=new A239212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239211
{
public static readonly long[] Value={ 49L,289L,529L,676L,2209L,2809L,4489L,5329L,5776L,5929L,6889L,7396L,8836L,9409L,20449L,24649L,26569L,27889L,29929L,30976L,34969L,37249L,37636L,38809L,49729L,54289L,55696L,59536L,64009L,65536L,66049L,67600L,75076L,76729L,80089L,82369L,85849L,94249L,97969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239211Inst : IEnumerable<long>
{
public static readonly long[] Value=A239211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239211.Bytes);
public long this[int i]=>Value[i];

public static A239211Inst Instance=new A239211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239210
{
public static readonly long[] Value={ 7L,17L,23L,26L,47L,53L,67L,73L,76L,77L,83L,86L,94L,97L,143L,157L,163L,167L,173L,176L,187L,193L,194L,197L,223L,233L,236L,244L,253L,256L,257L,260L,274L,277L,283L,287L,293L,307L,313L,314L,457L,473L,493L,503L,517L,523L,527L,533L,547L,553L,577L,583L,587L,607L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239210Inst : IEnumerable<long>
{
public static readonly long[] Value=A239210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239210.Bytes);
public long this[int i]=>Value[i];

public static A239210Inst Instance=new A239210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239209
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,1L,4L,2L,3L,3L,3L,2L,3L,4L,2L,4L,4L,4L,8L,3L,3L,4L,6L,5L,3L,5L,10L,4L,4L,7L,5L,4L,3L,8L,7L,6L,3L,4L,5L,4L,3L,7L,5L,5L,3L,4L,5L,11L,7L,10L,3L,10L,8L,12L,6L,4L,10L,4L,8L,5L,11L,7L,5L,14L,5L,7L,4L,10L,1L,10L,9L,12L,8L,5L,10L,1L,7L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239209Inst : IEnumerable<long>
{
public static readonly long[] Value=A239209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239209.Bytes);
public long this[int i]=>Value[i];

public static A239209Inst Instance=new A239209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239208
{
public static readonly long[] Value={ 18L,135L,891L,4095L,10560L,13120L,14144L,21600L,23199L,74655L,144495L,192311L,404415L,4197375L,4612608L,5675775L,6664680L,9180800L,10953215L,11110400L,14381055L,18162144L,18420480L,18920000L,20765024L,25159680L,32058351L,41055200L,55889920L,65327104L,65982464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239208Inst : IEnumerable<long>
{
public static readonly long[] Value=A239208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239208.Bytes);
public long this[int i]=>Value[i];

public static A239208Inst Instance=new A239208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239207
{
public static readonly long[] Value={ 0L,1L,3L,3L,4L,3L,2L,5L,4L,4L,2L,3L,2L,3L,5L,6L,3L,4L,2L,3L,5L,4L,1L,6L,2L,7L,3L,5L,5L,3L,5L,8L,7L,1L,7L,3L,8L,5L,11L,7L,7L,2L,6L,7L,3L,7L,7L,5L,5L,9L,7L,7L,4L,4L,6L,5L,9L,7L,8L,11L,4L,5L,6L,8L,5L,10L,5L,6L,9L,7L,10L,6L,5L,5L,10L,9L,8L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239207Inst : IEnumerable<long>
{
public static readonly long[] Value=A239207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239207.Bytes);
public long this[int i]=>Value[i];

public static A239207Inst Instance=new A239207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239206
{
public static readonly long[] Value={ 1L,1L,3L,9L,17L,35L,73L,147L,295L,591L,1181L,2363L,4729L,9459L,18917L,37837L,75673L,151347L,302697L,605395L,1210791L,2421581L,4843163L,9686329L,19372659L,38745319L,77490641L,154981281L,309962565L,619925129L,1239850261L,2479700523L,4959401047L,9918802097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239206Inst : IEnumerable<long>
{
public static readonly long[] Value=A239206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239206.Bytes);
public long this[int i]=>Value[i];

public static A239206Inst Instance=new A239206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239205
{
public static readonly long[] Value={ 28L,140L,190L,248L,420L,477L,496L,672L,840L,910L,1428L,1488L,1547L,1638L,1848L,1892L,2295L,2398L,2480L,2660L,3417L,3472L,3515L,3640L,3720L,4064L,4095L,4590L,4641L,4655L,4845L,5456L,5655L,5995L,6200L,6678L,6888L,6944L,7030L,7440L,8008L,8128L,8190L,9214L,9282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239205Inst : IEnumerable<long>
{
public static readonly long[] Value=A239205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239205.Bytes);
public long this[int i]=>Value[i];

public static A239205Inst Instance=new A239205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239204
{
public static readonly long[] Value={ 1L,4L,17L,76L,353L,1688L,8257L,41128L,207905L,1063932L,5501073L,28695252L,150827073L,798054000L,4247388417L,22722717328L,122125206977L,659101365812L,3570473750929L,19407758970268L,105820555054241L,578622868877704L,3172136074486337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239204Inst : IEnumerable<long>
{
public static readonly long[] Value=A239204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239204.Bytes);
public long this[int i]=>Value[i];

public static A239204Inst Instance=new A239204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239203
{
public static readonly long[] Value={ 0L,11L,218987L,55844736L,8299697699240L,2585386023324464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239203Inst : IEnumerable<long>
{
public static readonly long[] Value=A239203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239203.Bytes);
public long this[int i]=>Value[i];

public static A239203Inst Instance=new A239203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239202
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,10L,6L,2L,2L,2L,2L,8L,2L,2L,2L,12L,2L,22L,2L,2L,15L,2L,2L,4L,28L,2L,12L,36L,2L,2L,2L,2L,2L,2L,44L,48L,20L,2L,2L,18L,2L,2L,46L,6L,28L,2L,2L,2L,52L,22L,2L,2L,2L,58L,2L,2L,18L,80L,2L,2L,2L,2L,45L,2L,70L,28L,6L,48L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239202Inst : IEnumerable<long>
{
public static readonly long[] Value=A239202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239202.Bytes);
public long this[int i]=>Value[i];

public static A239202Inst Instance=new A239202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239201
{
public static readonly long[] Value={ 2L,5L,17L,68L,293L,1310L,5984L,27725L,129773L,612158L,2905322L,13857035L,66361892L,318901523L,1536964313L,7426185908L,35960185373L,174468439958L,847920579938L,4127211830363L,20116566452918L,98172213841553L,479635277636543L,2345731259059238L,11482918774964588L,56260052353307435L,275862429353287079L,1353641461527506630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239201Inst : IEnumerable<long>
{
public static readonly long[] Value=A239201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239201.Bytes);
public long this[int i]=>Value[i];

public static A239201Inst Instance=new A239201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239200
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239200Inst : IEnumerable<long>
{
public static readonly long[] Value=A239200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239200.Bytes);
public long this[int i]=>Value[i];

public static A239200Inst Instance=new A239200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239151
{
public static readonly long[] Value={ 2L,2L,55L,208L,2778L,17050L,166531L,1221727L,10652903L,83558723L,698912193L,5620874008L,46297856418L,375826633534L,3078013187839L,25072750273992L,204911552403250L,1671311190316246L,13648365689804011L,111372868203567131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239151Inst : IEnumerable<long>
{
public static readonly long[] Value=A239151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239151.Bytes);
public long this[int i]=>Value[i];

public static A239151Inst Instance=new A239151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239150
{
public static readonly long[] Value={ 1L,1L,7L,17L,96L,340L,1639L,6623L,29843L,126163L,554310L,2380524L,10363965L,44756085L,194216303L,840357677L,3642433780L,15771490916L,68331367227L,295943443667L,1282011757819L,5552887116543L,24053558944522L,104188496250108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239150Inst : IEnumerable<long>
{
public static readonly long[] Value=A239150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239150.Bytes);
public long this[int i]=>Value[i];

public static A239150Inst Instance=new A239150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239149
{
public static readonly BigInteger[] Value={ 1L,2L,868L,135766L,821135900L,5427557363908L,486439997897622259L,BigInteger.Parse("105891766683961733641397") };
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
public class A239149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239149Inst Instance=new A239149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239148
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,6L,2L,12L,4L,1L,25L,9L,2L,50L,18L,4L,1L,103L,36L,8L,2L,206L,74L,16L,4L,413L,148L,33L,8L,826L,296L,66L,16L,1L,1654L,593L,132L,2L,3308L,1186L,264L,64L,4L,1L,6617L,2372L,528L,129L,8L,2L,13234L,4745L,1057L,258L,16L,4L,26472L,9490L,211L,516L,32L,8L,52944L,18980L,4228L,1032L,64L,16L,1L,105889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239148Inst : IEnumerable<long>
{
public static readonly long[] Value=A239148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239148.Bytes);
public long this[int i]=>Value[i];

public static A239148Inst Instance=new A239148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239147
{
public static readonly long[] Value={ 12L,25L,29L,36L,45L,55L,78L,87L,105L,109L,111L,130L,140L,141L,155L,160L,190L,196L,209L,216L,231L,245L,246L,265L,274L,280L,289L,294L,311L,315L,329L,356L,364L,385L,409L,441L,444L,465L,475L,489L,494L,531L,535L,572L,582L,600L,624L,629L,650L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239147Inst : IEnumerable<long>
{
public static readonly long[] Value=A239147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239147.Bytes);
public long this[int i]=>Value[i];

public static A239147Inst Instance=new A239147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239146
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,2L,3L,0L,5L,0L,3L,2L,0L,0L,13L,12L,0L,2L,0L,0L,0L,6L,15L,10L,0L,12L,0L,0L,15L,20L,0L,12L,5L,0L,15L,22L,21L,12L,0L,0L,0L,14L,27L,0L,35L,0L,0L,8L,15L,0L,0L,24L,27L,0L,0L,48L,7L,48L,0L,50L,3L,6L,7L,0L,0L,28L,0L,18L,0L,0L,27L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239146Inst : IEnumerable<long>
{
public static readonly long[] Value=A239146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239146.Bytes);
public long this[int i]=>Value[i];

public static A239146Inst Instance=new A239146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239145
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,5L,3L,1L,0L,1L,13L,8L,3L,1L,0L,1L,39L,22L,10L,3L,1L,0L,1L,120L,65L,32L,10L,3L,1L,0L,1L,401L,208L,103L,37L,10L,3L,1L,0L,1L,1385L,703L,344L,136L,37L,10L,3L,1L,0L,1L,5069L,2517L,1206L,501L,151L,37L,10L,3L,1L,0L,1L,19170L,9390L,4421L,1890L,622L,151L,37L,10L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239145Inst : IEnumerable<long>
{
public static readonly long[] Value=A239145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239145.Bytes);
public long this[int i]=>Value[i];

public static A239145Inst Instance=new A239145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239144
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,10L,5L,2L,1L,1L,26L,13L,5L,2L,1L,1L,76L,37L,15L,5L,2L,1L,1L,232L,112L,47L,15L,5L,2L,1L,1L,764L,363L,155L,52L,15L,5L,2L,1L,1L,2620L,1235L,532L,188L,52L,15L,5L,2L,1L,1L,9496L,4427L,1910L,704L,203L,52L,15L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239144Inst : IEnumerable<long>
{
public static readonly long[] Value=A239144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239144.Bytes);
public long this[int i]=>Value[i];

public static A239144Inst Instance=new A239144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239143
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,5L,5L,9L,10L,13L,16L,21L,24L,31L,36L,44L,52L,63L,73L,88L,102L,120L,140L,164L,189L,221L,254L,294L,338L,389L,445L,511L,583L,666L,758L,863L,979L,1112L,1258L,1424L,1608L,1815L,2045L,2303L,2588L,2908L,3262L,3657L,4094L,4581L,5118L,5716L,6376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239143Inst : IEnumerable<long>
{
public static readonly long[] Value=A239143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239143.Bytes);
public long this[int i]=>Value[i];

public static A239143Inst Instance=new A239143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239142
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,3L,4L,5L,8L,10L,12L,16L,20L,24L,30L,36L,43L,52L,62L,73L,87L,102L,119L,140L,163L,189L,220L,254L,293L,338L,388L,445L,510L,583L,665L,758L,862L,979L,1111L,1258L,1423L,1608L,1814L,2045L,2302L,2588L,2907L,3262L,3656L,4094L,4580L,5118L,5715L,6376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239142Inst : IEnumerable<long>
{
public static readonly long[] Value=A239142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239142.Bytes);
public long this[int i]=>Value[i];

public static A239142Inst Instance=new A239142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239141
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239141Inst : IEnumerable<long>
{
public static readonly long[] Value=A239141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239141.Bytes);
public long this[int i]=>Value[i];

public static A239141Inst Instance=new A239141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239140
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239140Inst : IEnumerable<long>
{
public static readonly long[] Value=A239140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239140.Bytes);
public long this[int i]=>Value[i];

public static A239140Inst Instance=new A239140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239139
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,11L,20L,13L,14L,15L,16L,17L,18L,19L,21L,23L,22L,30L,24L,25L,26L,27L,28L,29L,31L,32L,34L,33L,40L,35L,36L,37L,38L,39L,41L,42L,43L,45L,44L,50L,46L,47L,48L,49L,51L,52L,53L,54L,56L,55L,60L,57L,58L,59L,61L,62L,63L,64L,65L,67L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239139Inst : IEnumerable<long>
{
public static readonly long[] Value=A239139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239139.Bytes);
public long this[int i]=>Value[i];

public static A239139Inst Instance=new A239139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239138
{
public static readonly ulong[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,99L,999L,9999L,99999L,999999L,9999999L,99999999L,999999999L,9999999999L,99999999999L,999999999999L,9999999999999L,99999999999999L,999999999999999L,9999999999999999L,99999999999999999L,999999999999999999L,9999999999999999999UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239138Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A239138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239138.Bytes);
public ulong this[int i]=>Value[i];

public static A239138Inst Instance=new A239138Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239137
{
public static readonly long[] Value={ 1L,2L,10L,3L,12L,13L,14L,15L,4L,5L,16L,17L,6L,7L,18L,19L,8L,9L,20L,21L,30L,31L,32L,40L,41L,42L,43L,22L,102L,103L,23L,24L,25L,26L,27L,28L,29L,33L,104L,34L,35L,36L,37L,38L,39L,44L,105L,45L,46L,47L,48L,49L,50L,51L,52L,54L,60L,61L,62L,63L,64L,65L,70L,71L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239137Inst : IEnumerable<long>
{
public static readonly long[] Value=A239137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239137.Bytes);
public long this[int i]=>Value[i];

public static A239137Inst Instance=new A239137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239136
{
public static readonly long[] Value={ 1L,2L,10L,3L,11L,101L,102L,12L,13L,14L,4L,15L,5L,16L,6L,17L,7L,18L,8L,19L,9L,20L,21L,22L,103L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,104L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,105L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,106L,56L,57L,58L,59L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239136Inst : IEnumerable<long>
{
public static readonly long[] Value=A239136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239136.Bytes);
public long this[int i]=>Value[i];

public static A239136Inst Instance=new A239136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239007
{
public static readonly long[] Value={ 4L,87L,34951L,73203L,475341523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239007Inst : IEnumerable<long>
{
public static readonly long[] Value=A239007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239007.Bytes);
public long this[int i]=>Value[i];

public static A239007Inst Instance=new A239007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239006
{
public static readonly long[] Value={ 2L,93L,22857L,5352807L,24204297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239006Inst : IEnumerable<long>
{
public static readonly long[] Value=A239006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239006.Bytes);
public long this[int i]=>Value[i];

public static A239006Inst Instance=new A239006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239005
{
public static readonly long[] Value={ 1L,0L,1L,-1L,-1L,0L,0L,-1L,-2L,-2L,5L,5L,4L,2L,0L,0L,5L,10L,14L,16L,16L,-61L,-61L,-56L,-46L,-32L,-16L,0L,0L,-61L,-122L,-178L,-224L,-256L,-272L,-272L,1385L,1385L,1324L,1202L,1024L,800L,544L,272L,0L,0L,1385L,2770L,4094L,5296L,6320L,7120L,7664L,7936L,7936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239005Inst : IEnumerable<long>
{
public static readonly long[] Value=A239005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239005.Bytes);
public long this[int i]=>Value[i];

public static A239005Inst Instance=new A239005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239004
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,2L,0L,4L,1L,6L,2L,9L,5L,13L,9L,18L,17L,25L,28L,35L,46L,49L,70L,70L,107L,101L,156L,145L,227L,210L,321L,303L,453L,436L,628L,622L,868L,884L,1187L,1243L,1619L,1738L,2192L,2410L,2960L,3317L,3977L,4532L,5331L,6154L,7117L,8298L,9477L,11129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239004Inst : IEnumerable<long>
{
public static readonly long[] Value=A239004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239004.Bytes);
public long this[int i]=>Value[i];

public static A239004Inst Instance=new A239004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239003
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,0L,2L,0L,1L,0L,0L,3L,0L,0L,2L,0L,2L,0L,0L,3L,0L,0L,1L,0L,3L,0L,0L,3L,0L,2L,0L,0L,4L,0L,0L,2L,0L,3L,0L,0L,3L,0L,1L,0L,0L,4L,0L,0L,3L,0L,3L,0L,0L,5L,0L,0L,2L,0L,4L,0L,0L,4L,0L,2L,0L,0L,5L,0L,0L,3L,0L,3L,0L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239003Inst : IEnumerable<long>
{
public static readonly long[] Value=A239003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239003.Bytes);
public long this[int i]=>Value[i];

public static A239003Inst Instance=new A239003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239002
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,1L,2L,0L,2L,1L,0L,3L,0L,2L,2L,0L,3L,0L,1L,3L,0L,3L,2L,0L,4L,0L,2L,3L,0L,3L,1L,0L,4L,0L,3L,3L,0L,5L,0L,2L,4L,0L,4L,2L,0L,5L,0L,3L,3L,0L,4L,0L,1L,4L,0L,4L,3L,0L,6L,0L,3L,5L,0L,5L,2L,0L,6L,0L,4L,4L,0L,6L,0L,2L,5L,0L,5L,3L,0L,6L,0L,3L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239002Inst : IEnumerable<long>
{
public static readonly long[] Value=A239002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239002.Bytes);
public long this[int i]=>Value[i];

public static A239002Inst Instance=new A239002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239001
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,3L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,5L,3L,2L,3L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,3L,3L,3L,2L,1L,3L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,2L,5L,1L,1L,3L,3L,1L,3L,2L,2L,3L,2L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239001Inst : IEnumerable<long>
{
public static readonly long[] Value=A239001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239001.Bytes);
public long this[int i]=>Value[i];

public static A239001Inst Instance=new A239001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239000
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,1L,2L,1L,3L,2L,2L,4L,2L,4L,4L,3L,7L,4L,5L,8L,5L,9L,8L,7L,12L,9L,11L,13L,11L,17L,14L,15L,20L,16L,22L,22L,20L,29L,24L,27L,33L,28L,37L,36L,35L,45L,40L,46L,50L,47L,60L,55L,58L,69L,62L,75L,76L,73L,91L,84L,91L,102L,95L,114L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239000Inst : IEnumerable<long>
{
public static readonly long[] Value=A239000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239000.Bytes);
public long this[int i]=>Value[i];

public static A239000Inst Instance=new A239000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238999
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,2L,4L,3L,5L,5L,6L,8L,8L,10L,12L,12L,16L,16L,19L,23L,23L,28L,31L,33L,40L,41L,47L,53L,56L,64L,69L,75L,86L,89L,101L,109L,117L,131L,139L,151L,168L,175L,195L,208L,223L,245L,259L,280L,304L,320L,350L,370L,397L,430L,452L,488L,521L,550L,596L,626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238999Inst : IEnumerable<long>
{
public static readonly long[] Value=A238999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238999.Bytes);
public long this[int i]=>Value[i];

public static A238999Inst Instance=new A238999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238998
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,2L,2L,3L,2L,4L,4L,6L,5L,9L,8L,11L,11L,16L,16L,22L,22L,29L,31L,40L,42L,54L,57L,71L,77L,95L,103L,127L,137L,165L,182L,218L,238L,285L,313L,369L,408L,479L,530L,619L,684L,794L,883L,1019L,1130L,1304L,1446L,1658L,1843L,2107L,2340L,2670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238998Inst : IEnumerable<long>
{
public static readonly long[] Value=A238998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238998.Bytes);
public long this[int i]=>Value[i];

public static A238998Inst Instance=new A238998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238997
{
public static readonly long[] Value={ 3L,7L,7L,15L,41L,15L,31L,203L,203L,31L,63L,955L,2365L,955L,63L,127L,4393L,25601L,25601L,4393L,127L,255L,20015L,270671L,638779L,270671L,20015L,255L,511L,90841L,2827709L,15482441L,15482441L,2827709L,90841L,511L,1023L,411621L,29422487L,370847909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238997Inst : IEnumerable<long>
{
public static readonly long[] Value=A238997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238997.Bytes);
public long this[int i]=>Value[i];

public static A238997Inst Instance=new A238997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238996
{
public static readonly BigInteger[] Value={ 255L,90841L,29422487L,8839918663L,2576820346901L,741313154055591L,212231595626785699L,BigInteger.Parse("60622006079484508011"),BigInteger.Parse("17303054413357418999617"),BigInteger.Parse("4936645554621315824547589"),BigInteger.Parse("1408303888106364409634945519") };
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
public class A238996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238996Inst Instance=new A238996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238995
{
public static readonly BigInteger[] Value={ 127L,20015L,2827709L,370847909L,47194836429L,5929702056895L,741313154055591L,92478950275376419L,11527212881627494067UL,BigInteger.Parse("1436301913978181060137"),BigInteger.Parse("178940460602912412966007"),BigInteger.Parse("22291640056871828837992711") };
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
public class A238995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238995Inst Instance=new A238995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238994
{
public static readonly BigInteger[] Value={ 63L,4393L,270671L,15482441L,860394281L,47194836429L,2576820346901L,140374233864007L,7641515368274447L,415803711072157063L,BigInteger.Parse("22623254269724301899"),BigInteger.Parse("1230788116725572552851"),BigInteger.Parse("66958898245049949164997") };
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
public class A238994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238994Inst Instance=new A238994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238993
{
public static readonly BigInteger[] Value={ 31L,955L,25601L,638779L,15482441L,370847909L,8839918663L,210298050207L,4998886061169L,118785304972327L,2822242684232115L,67050092047403637L,1592922871540500091L,BigInteger.Parse("37842951297176471361"),BigInteger.Parse("899028950928529166077") };
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
public class A238993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238993Inst Instance=new A238993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238992
{
public static readonly long[] Value={ 15L,203L,2365L,25601L,270671L,2827709L,29422487L,305525459L,3170576253L,32890537051L,341164909807L,3538555502557L,36701472408455L,380656870553721L,3948062617070389L,40947979951532603L,424699049401817205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238992Inst : IEnumerable<long>
{
public static readonly long[] Value=A238992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238992.Bytes);
public long this[int i]=>Value[i];

public static A238992Inst Instance=new A238992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238751
{
public static readonly long[] Value={ 11L,251L,1019L,4091L,65531L,4294967291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238751Inst : IEnumerable<long>
{
public static readonly long[] Value=A238751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238751.Bytes);
public long this[int i]=>Value[i];

public static A238751Inst Instance=new A238751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238750
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,4L,3L,2L,1L,0L,10L,7L,5L,3L,1L,0L,26L,20L,14L,11L,4L,1L,0L,76L,56L,44L,31L,19L,5L,1L,0L,232L,182L,139L,106L,69L,29L,6L,1L,0L,764L,589L,475L,351L,265L,127L,41L,7L,1L,0L,2620L,2088L,1658L,1303L,971L,583L,209L,55L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238750Inst : IEnumerable<long>
{
public static readonly long[] Value=A238750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238750.Bytes);
public long this[int i]=>Value[i];

public static A238750Inst Instance=new A238750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238749
{
public static readonly long[] Value={ 4L,8L,10L,12L,18L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238749Inst : IEnumerable<long>
{
public static readonly long[] Value=A238749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238749.Bytes);
public long this[int i]=>Value[i];

public static A238749Inst Instance=new A238749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238748
{
public static readonly long[] Value={ 1L,6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,36L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,100L,106L,111L,115L,118L,119L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L,177L,178L,183L,185L,187L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238748Inst : IEnumerable<long>
{
public static readonly long[] Value=A238748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238748.Bytes);
public long this[int i]=>Value[i];

public static A238748Inst Instance=new A238748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238747
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,2L,2L,2L,2L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238747Inst : IEnumerable<long>
{
public static readonly long[] Value=A238747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238747.Bytes);
public long this[int i]=>Value[i];

public static A238747Inst Instance=new A238747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238746
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,7L,4L,6L,6L,9L,7L,7L,9L,11L,10L,8L,12L,9L,13L,5L,10L,13L,9L,15L,14L,15L,9L,14L,16L,10L,18L,19L,17L,13L,18L,10L,19L,11L,16L,21L,12L,15L,24L,19L,17L,22L,16L,22L,12L,23L,24L,6L,19L,20L,29L,21L,21L,26L,22L,25L,13L,30L,27L,11L,26L,25L,19L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238746Inst : IEnumerable<long>
{
public static readonly long[] Value=A238746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238746.Bytes);
public long this[int i]=>Value[i];

public static A238746Inst Instance=new A238746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238745
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,3L,2L,8L,4L,3L,2L,6L,2L,3L,3L,16L,2L,6L,2L,6L,3L,3L,2L,12L,4L,3L,8L,6L,2L,5L,2L,32L,3L,3L,3L,9L,2L,3L,3L,12L,2L,5L,2L,6L,6L,3L,2L,24L,4L,6L,3L,6L,2L,12L,3L,12L,3L,3L,2L,10L,2L,3L,6L,64L,3L,5L,2L,6L,3L,5L,2L,18L,2L,3L,6L,6L,3L,5L,2L,24L,16L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238745Inst : IEnumerable<long>
{
public static readonly long[] Value=A238745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238745.Bytes);
public long this[int i]=>Value[i];

public static A238745Inst Instance=new A238745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238744
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,1L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238744Inst : IEnumerable<long>
{
public static readonly long[] Value=A238744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238744.Bytes);
public long this[int i]=>Value[i];

public static A238744Inst Instance=new A238744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238743
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,26L,26L,1L,1L,56L,208L,56L,1L,1L,124L,992L,992L,124L,1L,1L,182L,3224L,6944L,3224L,182L,1L,1L,342L,8892L,42408L,42408L,8892L,342L,1L,1L,448L,21888L,153216L,339264L,153216L,21888L,448L,1L,1L,702L,44928L,590976L,1920672L,1920672L,590976L,44928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238743Inst : IEnumerable<long>
{
public static readonly long[] Value=A238743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238743.Bytes);
public long this[int i]=>Value[i];

public static A238743Inst Instance=new A238743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238742
{
public static readonly long[] Value={ 0L,0L,1L,5L,13L,31L,59L,109L,180L,301L,461L,712L,1051L,1547L,2200L,3138L,4349L,6036L,8211L,11146L,14901L,19908L,26232L,34513L,44953L,58412L,75244L,96752L,123448L,157201L,198931L,251155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238742Inst : IEnumerable<long>
{
public static readonly long[] Value=A238742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238742.Bytes);
public long this[int i]=>Value[i];

public static A238742Inst Instance=new A238742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238741
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,21L,40L,63L,105L,159L,245L,355L,526L,739L,1052L,1452L,2011L,2718L,3691L,4909L,6546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238741Inst : IEnumerable<long>
{
public static readonly long[] Value=A238741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238741.Bytes);
public long this[int i]=>Value[i];

public static A238741Inst Instance=new A238741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238740
{
public static readonly BigInteger[] Value={ 1L,19L,961L,101101L,19116721L,5895818671L,2767218413569L,1876349280125881L,1765053702368618401L,BigInteger.Parse("2229877686380646862891"),BigInteger.Parse("3684146198939103437432641"),BigInteger.Parse("7785613784940909310055130469"),BigInteger.Parse("20653334793956901864746843979601"),BigInteger.Parse("67675129289987844087403319678358151") };
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
public class A238740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238740Inst Instance=new A238740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238739
{
public static readonly long[] Value={ 1L,2L,6L,12L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238739Inst : IEnumerable<long>
{
public static readonly long[] Value=A238739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238739.Bytes);
public long this[int i]=>Value[i];

public static A238739Inst Instance=new A238739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238738
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,15L,18L,24L,30L,34L,42L,50L,55L,65L,75L,81L,93L,105L,112L,126L,140L,148L,164L,180L,189L,207L,225L,235L,255L,275L,286L,308L,330L,342L,366L,390L,403L,429L,455L,469L,497L,525L,540L,570L,600L,616L,648L,680L,697L,731L,765L,783L,819L,855L,874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238738Inst : IEnumerable<long>
{
public static readonly long[] Value=A238738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238738.Bytes);
public long this[int i]=>Value[i];

public static A238738Inst Instance=new A238738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238737
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,3L,5L,1L,1L,3L,5L,1L,3L,1L,1L,3L,1L,3L,5L,1L,3L,5L,1L,1L,3L,5L,1L,3L,1L,1L,3L,5L,1L,3L,1L,3L,5L,1L,3L,5L,7L,1L,3L,1L,1L,3L,1L,1L,3L,1L,3L,5L,7L,9L,11L,13L,1L,3L,1L,3L,5L,1L,1L,3L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238737Inst : IEnumerable<long>
{
public static readonly long[] Value=A238737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238737.Bytes);
public long this[int i]=>Value[i];

public static A238737Inst Instance=new A238737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238736
{
public static readonly long[] Value={ 13L,31L,1546463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238736Inst : IEnumerable<long>
{
public static readonly long[] Value=A238736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238736.Bytes);
public long this[int i]=>Value[i];

public static A238736Inst Instance=new A238736Inst();

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