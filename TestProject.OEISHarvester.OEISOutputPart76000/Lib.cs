using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A279845
{
public static readonly BigInteger[] Value={ 1L,1L,7L,87L,1577L,37921L,1143991L,41734167L,1793837945L,89100737537L,5038278258759L,320488252355991L,22712229678267017L,1778818548078114337L,BigInteger.Parse("152926844472960316055"),BigInteger.Parse("14348332105800041202903"),BigInteger.Parse("1461880180517958608890585"),BigInteger.Parse("161034066043430013259095681"),BigInteger.Parse("19105043857756090069661974951"),BigInteger.Parse("2432865068875486088572762200535"),BigInteger.Parse("331511875063241457659846364208233"),BigInteger.Parse("48205214775404458968179455649349921"),BigInteger.Parse("7461345443274460130807423699070922103") };
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
public class A279845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279845Inst Instance=new A279845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279846
{
public static readonly long[] Value={ 1L,31L,37L,43L,46L,61L,67L,73L,79L,85L,91L,106L,109L,121L,127L,133L,136L,145L,151L,157L,166L,169L,181L,199L,211L,217L,226L,232L,235L,241L,253L,265L,271L,274L,277L,289L,295L,301L,307L,313L,316L,325L,331L,337L,343L,361L,379L,391L,397L,406L,409L,421L,433L,451L,463L,469L,481L,496L,505L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279846Inst : IEnumerable<long>
{
public static readonly long[] Value=A279846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279846.Bytes);
public long this[int i]=>Value[i];

public static A279846Inst Instance=new A279846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279847
{
public static readonly long[] Value={ 0L,1L,2L,7L,8L,22L,23L,44L,54L,84L,85L,151L,152L,206L,241L,326L,327L,458L,459L,605L,664L,790L,791L,1065L,1091L,1265L,1356L,1622L,1623L,2023L,2024L,2365L,2496L,2790L,2865L,3480L,3481L,3847L,4026L,4636L,4637L,5373L,5374L,6000L,6341L,6875L,6876L,7982L,8032L,8787L,9086L,9952L,9953L,11137L,11284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279847Inst : IEnumerable<long>
{
public static readonly long[] Value=A279847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279847.Bytes);
public long this[int i]=>Value[i];

public static A279847Inst Instance=new A279847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,4L,4L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279848Inst : IEnumerable<long>
{
public static readonly long[] Value=A279848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279848.Bytes);
public long this[int i]=>Value[i];

public static A279848Inst Instance=new A279848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279849
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,1L,2L,4L,3L,2L,1L,2L,1L,4L,3L,1L,2L,3L,4L,4L,3L,2L,1L,2L,1L,4L,3L,3L,4L,1L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,1L,3L,4L,4L,3L,1L,2L,1L,2L,4L,3L,4L,3L,1L,2L,3L,4L,2L,1L,2L,1L,3L,4L,1L,3L,2L,4L,2L,4L,1L,3L,4L,2L,3L,1L,3L,1L,4L,2L,1L,3L,2L,4L,4L,2L,3L,1L,3L,1L,4L,2L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279849Inst : IEnumerable<long>
{
public static readonly long[] Value=A279849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279849.Bytes);
public long this[int i]=>Value[i];

public static A279849Inst Instance=new A279849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279850
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,4L,2L,5L,1L,4L,1L,5L,3L,2L,5L,3L,1L,2L,4L,2L,5L,4L,1L,3L,1L,2L,3L,4L,5L,3L,4L,5L,1L,2L,5L,1L,2L,3L,4L,2L,3L,4L,5L,1L,4L,5L,1L,2L,3L,1L,2L,3L,4L,5L,3L,5L,2L,1L,4L,5L,1L,4L,2L,3L,2L,4L,5L,3L,1L,4L,3L,1L,5L,2L,1L,2L,3L,4L,5L,3L,5L,4L,2L,1L,4L,1L,2L,5L,3L,5L,4L,1L,3L,2L,2L,3L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279850Inst : IEnumerable<long>
{
public static readonly long[] Value=A279850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279850.Bytes);
public long this[int i]=>Value[i];

public static A279850Inst Instance=new A279850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279851
{
public static readonly long[] Value={ 0L,4L,10L,24L,54L,116L,250L,528L,1118L,2348L,4930L,10312L,21542L,44900L,93450L,194176L,402926L,834972L,1728210L,3572920L,7378870L,15223764L,31379610L,64623344L,132974974L,273406476L,561726050L,1153278248L,2366208838L,4851722308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279851Inst : IEnumerable<long>
{
public static readonly long[] Value=A279851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279851.Bytes);
public long this[int i]=>Value[i];

public static A279851Inst Instance=new A279851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279852
{
public static readonly long[] Value={ 2L,10L,49L,168L,557L,1758L,5441L,16500L,49253L,145290L,424425L,1229824L,3539405L,10127350L,28832593L,81728396L,230776757L,649427170L,1821994809L,5097729560L,14227693853L,39620451150L,110107647905L,305424435364L,845754303493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279852Inst : IEnumerable<long>
{
public static readonly long[] Value=A279852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279852.Bytes);
public long this[int i]=>Value[i];

public static A279852Inst Instance=new A279852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279853
{
public static readonly long[] Value={ 2L,24L,168L,972L,5200L,26632L,134898L,668668L,3278294L,15902088L,76515244L,365585432L,1736575416L,8206953072L,38615236370L,180986296644L,845359203352L,3936439186972L,18279759467004L,84675466304900L,391350188916098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279853Inst : IEnumerable<long>
{
public static readonly long[] Value=A279853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279853.Bytes);
public long this[int i]=>Value[i];

public static A279853Inst Instance=new A279853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279854
{
public static readonly long[] Value={ 8L,54L,557L,5200L,44893L,373516L,3010179L,23836450L,185854745L,1432781380L,10940440805L,82884481996L,623764753929L,4667668549882L,34757207667097L,257707173342548L,1903562116898937L,14013650638972172L,102857118300106915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279854Inst : IEnumerable<long>
{
public static readonly long[] Value=A279854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279854.Bytes);
public long this[int i]=>Value[i];

public static A279854Inst Instance=new A279854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279855
{
public static readonly long[] Value={ 14L,116L,1758L,26632L,373516L,4989784L,64921744L,827573664L,10392951988L,129001348624L,1586027917024L,19345996306220L,234406391335134L,2824014683941452L,33854795060931456L,404112060548429912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279855Inst : IEnumerable<long>
{
public static readonly long[] Value=A279855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279855.Bytes);
public long this[int i]=>Value[i];

public static A279855Inst Instance=new A279855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279856
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,2L,10L,10L,2L,8L,24L,49L,24L,8L,14L,54L,168L,168L,54L,14L,36L,116L,557L,972L,557L,116L,36L,74L,250L,1758L,5200L,5200L,1758L,250L,74L,168L,528L,5441L,26632L,44893L,26632L,5441L,528L,168L,358L,1118L,16500L,134898L,373516L,373516L,134898L,16500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279856Inst : IEnumerable<long>
{
public static readonly long[] Value=A279856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279856.Bytes);
public long this[int i]=>Value[i];

public static A279856Inst Instance=new A279856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279857
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,41L,53L,59L,61L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,163L,167L,179L,181L,191L,197L,199L,211L,223L,227L,229L,233L,239L,251L,269L,271L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279857Inst : IEnumerable<long>
{
public static readonly long[] Value=A279857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279857.Bytes);
public long this[int i]=>Value[i];

public static A279857Inst Instance=new A279857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279858
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,22L,26L,28L,36L,37L,41L,98L,117L,120L,124L,214L,222L,226L,236L,333L,338L,532L,533L,534L,538L,541L,543L,544L,743L,746L,956L,957L,958L,961L,1054L,1263L,1267L,1463L,1466L,1468L,1473L,1474L,1475L,1476L,1684L,1894L,2196L,2198L,2199L,2205L,2206L,2404L,2406L,2408L,2411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279858Inst : IEnumerable<long>
{
public static readonly long[] Value=A279858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279858.Bytes);
public long this[int i]=>Value[i];

public static A279858Inst Instance=new A279858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279859
{
public static readonly long[] Value={ 3L,-1L,2L,6L,8L,-11L,10L,-14L,0L,-16L,15L,14L,-8L,-26L,-9L,29L,-26L,-27L,-1L,37L,-34L,47L,40L,20L,-36L,26L,6L,-57L,29L,-55L,-23L,53L,-9L,58L,52L,-65L,33L,-37L,-83L,3L,24L,73L,-72L,-66L,-76L,105L,45L,-108L,84L,-84L,19L,109L,-84L,21L,-28L,-19L,-139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279859Inst : IEnumerable<long>
{
public static readonly long[] Value=A279859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279859.Bytes);
public long this[int i]=>Value[i];

public static A279859Inst Instance=new A279859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279860
{
public static readonly long[] Value={ 2L,18L,182L,1828L,98793L,987931L,4349076L,82549802L,450388721L,5291493974L,72883660263L,476539957100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279860Inst : IEnumerable<long>
{
public static readonly long[] Value=A279860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279860.Bytes);
public long this[int i]=>Value[i];

public static A279860Inst Instance=new A279860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279909
{
public static readonly long[] Value={ 0L,2L,1L,3L,3L,3L,2L,8L,3L,4L,4L,7L,4L,6L,3L,11L,9L,6L,4L,15L,5L,12L,5L,11L,8L,6L,5L,7L,7L,14L,4L,18L,11L,10L,10L,11L,7L,9L,5L,11L,16L,6L,6L,15L,13L,12L,6L,17L,12L,9L,9L,11L,7L,11L,6L,19L,8L,8L,8L,11L,15L,14L,5L,24L,19L,14L,11L,13L,11L,13L,11L,16L,12L,8L,8L,10L,10L,10L,6L,16L,11L,17L,17L,18L,7L,26L,7L,24L,16L,11L,14L,13L,13L,15L,7L,23L,18L,14L,13L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279909Inst : IEnumerable<long>
{
public static readonly long[] Value=A279909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279909.Bytes);
public long this[int i]=>Value[i];

public static A279909Inst Instance=new A279909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279910
{
public static readonly long[] Value={ 0L,0L,3L,3L,8L,11L,18L,18L,21L,26L,37L,40L,53L,60L,68L,68L,85L,88L,107L,112L,122L,133L,156L,159L,164L,177L,180L,187L,216L,224L,255L,255L,269L,286L,298L,301L,338L,357L,373L,378L,419L,429L,472L,483L,491L,514L,561L,564L,571L,576L,596L,609L,662L,665L,681L,688L,710L,739L,798L,806L,867L,898L,908L,908L,926L,940L,1007L,1024L,1050L,1062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279910Inst : IEnumerable<long>
{
public static readonly long[] Value=A279910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279910.Bytes);
public long this[int i]=>Value[i];

public static A279910Inst Instance=new A279910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279911
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,11L,10L,22L,22L,31L,28L,56L,36L,79L,58L,72L,86L,137L,80L,172L,112L,145L,148L,254L,146L,261L,208L,274L,230L,407L,182L,466L,342L,375L,360L,448L,322L,667L,456L,528L,444L,821L,384L,904L,592L,635L,676L,1082L,574L,1051L,692L,924L,836L,1379L,732L,1154L,912L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279911Inst : IEnumerable<long>
{
public static readonly long[] Value=A279911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279911.Bytes);
public long this[int i]=>Value[i];

public static A279911Inst Instance=new A279911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279912
{
public static readonly long[] Value={ 0L,1L,3L,7L,10L,21L,21L,43L,36L,57L,63L,111L,70L,157L,129L,147L,136L,273L,171L,343L,210L,301L,333L,507L,252L,505L,471L,495L,430L,813L,441L,931L,528L,777L,819L,903L,570L,1333L,1029L,1099L,756L,1641L,903L,1807L,1110L,1197L,1521L,2163L,952L,2065L,1515L,1911L,1570L,2757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279912Inst : IEnumerable<long>
{
public static readonly long[] Value=A279912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279912.Bytes);
public long this[int i]=>Value[i];

public static A279912Inst Instance=new A279912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279913
{
public static readonly BigInteger[] Value={ 1L,92L,993L,9994L,99995L,999996L,9999997L,99999998L,9999999999L,9999999910L,99999999911L,999999999912L,9999999999913L,99999999999914L,999999999999915L,9999999999999916L,99999999999999917L,999999999999999918L,9999999999999999919UL,BigInteger.Parse("99999999999999999920") };
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
public class A279913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279913Inst Instance=new A279913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279914
{
public static readonly long[] Value={ 1L,5L,7L,9L,11L,13L,15L,19L,19L,21L,23L,32L,27L,29L,31L,39L,35L,45L,39L,50L,43L,45L,47L,68L,51L,53L,58L,68L,59L,81L,63L,79L,67L,69L,71L,103L,75L,77L,79L,106L,83L,109L,87L,104L,102L,93L,95L,140L,99L,113L,103L,122L,107L,138L,111L,144L,115L,117L,119L,184L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279914Inst : IEnumerable<long>
{
public static readonly long[] Value=A279914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279914.Bytes);
public long this[int i]=>Value[i];

public static A279914Inst Instance=new A279914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279915
{
public static readonly long[] Value={ 6L,28L,84L,120L,234L,360L,496L,588L,600L,1080L,1638L,2016L,3000L,3042L,3240L,3276L,4116L,4680L,6048L,7440L,8128L,9720L,11466L,14040L,15000L,18144L,22320L,22932L,23400L,28812L,29160L,30240L,32640L,32760L,37200L,39546L,42120L,42588L,54432L,55800L,60480L,60840L,65520L,66960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279915Inst : IEnumerable<long>
{
public static readonly long[] Value=A279915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279915.Bytes);
public long this[int i]=>Value[i];

public static A279915Inst Instance=new A279915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279916
{
public static readonly long[] Value={ 5L,4L,8L,4L,3L,5L,5L,14L,4L,4L,4L,3L,3L,3L,4L,3L,4L,4L,4L,4L,20L,8L,23L,8L,11L,5L,5L,26L,5L,3L,3L,3L,4L,3L,4L,29L,3L,3L,3L,4L,3L,3L,4L,3L,4L,32L,6L,4L,11L,4L,4L,4L,35L,4L,4L,11L,4L,4L,4L,4L,4L,7L,38L,4L,6L,4L,4L,4L,4L,8L,41L,11L,16L,8L,44L,3L,47L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279916Inst : IEnumerable<long>
{
public static readonly long[] Value=A279916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279916.Bytes);
public long this[int i]=>Value[i];

public static A279916Inst Instance=new A279916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279917
{
public static readonly long[] Value={ 0L,1L,162L,6689L,121250L,1296406L,9613604L,54550049L,252178758L,992204376L,3424910566L,10615778966L,30047257318L,78751366604L,193075366412L,446840757793L,982597838280L,2066025009763L,4171924730922L,8127978871064L,15324653827568L,28059983210370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279917Inst : IEnumerable<long>
{
public static readonly long[] Value=A279917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279917.Bytes);
public long this[int i]=>Value[i];

public static A279917Inst Instance=new A279917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279918
{
public static readonly long[] Value={ 1L,-1L,-5L,4L,5L,0L,11L,-15L,-18L,3L,-10L,29L,10L,11L,37L,-51L,-16L,-30L,-65L,62L,53L,22L,50L,-61L,-52L,-4L,-81L,120L,62L,0L,124L,-182L,-85L,-43L,-157L,171L,123L,60L,202L,-198L,-174L,0L,-190L,301L,117L,54L,278L,-375L,-171L,-153L,-399L,370L,300L,108L,408L,-451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279918Inst : IEnumerable<long>
{
public static readonly long[] Value=A279918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279918.Bytes);
public long this[int i]=>Value[i];

public static A279918Inst Instance=new A279918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279919
{
public static readonly long[] Value={ 1L,4L,5L,9L,50L,59L,109L,168L,613L,7524L,30709L,38233L,10391852L,10430085L,20821937L,52073959L,385339650L,437413609L,15694815965L,94606309399L,110301125364L,1087316437675L,4459566876064L,10006450189803L,14466017065867L,24472467255670L,63410951577207L,87883418832877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279919Inst : IEnumerable<long>
{
public static readonly long[] Value=A279919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279919.Bytes);
public long this[int i]=>Value[i];

public static A279919Inst Instance=new A279919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279920
{
public static readonly long[] Value={ 1L,3L,4L,7L,39L,46L,85L,131L,478L,5867L,23946L,29813L,8103269L,8133082L,16236351L,40605784L,300476839L,341082623L,12238368644L,73771294487L,86009663131L,847858262666L,3477442713795L,7802743690256L,11280186404051L,19082930094307L,49446046592665L,68528976686972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279920Inst : IEnumerable<long>
{
public static readonly long[] Value=A279920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279920.Bytes);
public long this[int i]=>Value[i];

public static A279920Inst Instance=new A279920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279921
{
public static readonly long[] Value={ 1L,0L,15L,142L,1350L,12858L,119396L,1095012L,9924024L,89076240L,792954264L,7008783648L,61565762448L,537846507200L,4675888234720L,40474106338144L,348966901404864L,2998086166443584L,25674017271458048L,219205885504644096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279921Inst : IEnumerable<long>
{
public static readonly long[] Value=A279921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279921.Bytes);
public long this[int i]=>Value[i];

public static A279921Inst Instance=new A279921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279922
{
public static readonly BigInteger[] Value={ 0L,15L,474L,14281L,399487L,11023893L,295670293L,7789959515L,202165948916L,5182571589088L,131491345952984L,3306929199461466L,82536757955761100L,2046354441219248128L,BigInteger.Parse("50438781290555301198"),BigInteger.Parse("1236742541751845876398") };
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
public class A279922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279922Inst Instance=new A279922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279923
{
public static readonly BigInteger[] Value={ 3L,142L,14281L,1230799L,99427182L,7837914954L,601248781220L,45231133438998L,3348526427263799L,244650217481299630L,17677455777661411625UL,BigInteger.Parse("1265259778269055650555"),BigInteger.Parse("89821449423672575925643") };
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
public class A279923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279923Inst Instance=new A279923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279924
{
public static readonly BigInteger[] Value={ 6L,1350L,399487L,99427182L,23145488444L,5222809114196L,1145113368668739L,245748141181813044L,BigInteger.Parse("51832142320779006065"),BigInteger.Parse("10777641141722122787922"),BigInteger.Parse("2214414113682247779439672"),BigInteger.Parse("450373296491025716207853634") };
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
public class A279924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279924Inst Instance=new A279924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280069
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,4L,5L,4L,3L,5L,9L,15L,15L,9L,5L,8L,19L,39L,52L,39L,19L,8L,13L,41L,104L,170L,170L,104L,41L,13L,21L,88L,281L,603L,790L,603L,281L,88L,21L,34L,189L,771L,2157L,3729L,3729L,2157L,771L,189L,34L,55L,406L,2122L,7777L,17468L,23564L,17468L,7777L,2122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280069Inst : IEnumerable<long>
{
public static readonly long[] Value=A280069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280069.Bytes);
public long this[int i]=>Value[i];

public static A280069Inst Instance=new A280069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280070
{
public static readonly BigInteger[] Value={ 1L,11L,191L,3421L,61381L,1101431L,19764371L,354657241L,6364065961L,114198530051L,2049209474951L,36771572019061L,659839086868141L,11840331991607471L,212466136762066331L,3812550129725586481L,BigInteger.Parse("68413436198298490321"),BigInteger.Parse("1227629301439647239291"),BigInteger.Parse("22028913989715351816911") };
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
public class A280070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280070Inst Instance=new A280070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280071
{
public static readonly BigInteger[] Value={ 1L,12L,232L,4621L,92181L,1838992L,36687652L,731914041L,14601593161L,291299949172L,5811397390272L,115936647856261L,2312921559734941L,46142494546842552L,920536969377116092L,18364596892995479281UL,BigInteger.Parse("366371400890532469521"),BigInteger.Parse("7309063420917653911132") };
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
public class A280071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280071Inst Instance=new A280071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280072
{
public static readonly BigInteger[] Value={ 1L,11L,210L,4180L,83381L,1663431L,33185230L,662041160L,13207637961L,263490718051L,5256606723050L,104868643742940L,2092116268135741L,41737456718971871L,832657018111301670L,16611402905507061520UL,BigInteger.Parse("331395401092029928721"),BigInteger.Parse("6611296618935091512891") };
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
public class A280072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280072Inst Instance=new A280072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280073
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,3L,2L,1L,3L,1L,4L,2L,1L,3L,1L,5L,4L,3L,2L,1L,5L,1L,6L,5L,4L,3L,2L,1L,5L,3L,1L,7L,4L,2L,1L,7L,5L,3L,1L,8L,7L,6L,5L,4L,3L,2L,1L,7L,5L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,9L,7L,3L,1L,10L,8L,5L,4L,2L,1L,9L,7L,5L,3L,1L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,11L,7L,5L,1L,12L,11L,9L,8L,7L,6L,4L,3L,2L,1L,11L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280073Inst : IEnumerable<long>
{
public static readonly long[] Value=A280073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280073.Bytes);
public long this[int i]=>Value[i];

public static A280073Inst Instance=new A280073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280074
{
public static readonly long[] Value={ 2L,14L,21L,33L,34L,38L,44L,57L,75L,85L,86L,93L,94L,98L,116L,118L,122L,133L,135L,141L,142L,145L,147L,158L,171L,177L,201L,202L,205L,213L,214L,217L,218L,230L,244L,253L,285L,296L,298L,301L,302L,326L,332L,334L,375L,381L,387L,393L,394L,429L,434L,445L,446L,453L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280074Inst : IEnumerable<long>
{
public static readonly long[] Value=A280074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280074.Bytes);
public long this[int i]=>Value[i];

public static A280074Inst Instance=new A280074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280075
{
public static readonly BigInteger[] Value={ 1L,2L,4L,24L,48L,768L,1536L,36864L,221184L,3538944L,7077888L,2038431744L,4076863488L,65229815808L,1043677052928L,125241246351360L,250482492702720L,72138957898383360L,144277915796766720L,BigInteger.Parse("41552039749468815360"),BigInteger.Parse("664832635991501045760"),BigInteger.Parse("10637322175864016732160") };
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
public class A280075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280075Inst Instance=new A280075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280076
{
public static readonly long[] Value={ 1L,4L,9L,25L,49L,121L,169L,289L,361L,529L,841L,961L,1369L,1681L,1849L,2209L,2809L,3481L,3721L,4489L,5041L,5329L,6241L,6889L,7921L,9409L,10201L,10609L,11449L,11881L,12769L,16129L,17161L,18769L,19321L,22201L,22801L,24649L,26569L,27889L,29929L,32041L,32761L,36481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280076Inst : IEnumerable<long>
{
public static readonly long[] Value=A280076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280076.Bytes);
public long this[int i]=>Value[i];

public static A280076Inst Instance=new A280076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280077
{
public static readonly long[] Value={ 1L,5L,10L,21L,28L,48L,57L,83L,101L,129L,142L,197L,212L,248L,283L,340L,359L,431L,452L,529L,574L,626L,651L,781L,819L,879L,937L,1036L,1067L,1207L,1240L,1360L,1425L,1501L,1564L,1762L,1801L,1885L,1960L,2142L,2185L,2365L,2410L,2553L,2679L,2779L,2828L,3113L,3179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280077Inst : IEnumerable<long>
{
public static readonly long[] Value=A280077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280077.Bytes);
public long this[int i]=>Value[i];

public static A280077Inst Instance=new A280077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280078
{
public static readonly BigInteger[] Value={ 1L,4L,20L,220L,1540L,30800L,277200L,7207200L,129729600L,3632428800L,47221574400L,2597186592000L,38957798880000L,1402480759680000L,49086826588800000L,2797949115561600000L,BigInteger.Parse("53161033195670400000"),BigInteger.Parse("3827594390088268800000"),BigInteger.Parse("80379482191853644800000") };
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
public class A280078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280078Inst Instance=new A280078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280079
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,3L,4L,5L,4L,5L,5L,4L,5L,6L,6L,6L,5L,6L,7L,7L,5L,6L,7L,7L,6L,8L,8L,7L,8L,6L,8L,7L,8L,9L,9L,9L,7L,8L,9L,9L,7L,10L,8L,10L,10L,9L,10L,8L,10L,9L,11L,11L,11L,10L,8L,11L,9L,10L,11L,12L,12L,9L,11L,12L,10L,12L,11L,12L,9L,10L,13L,12L,13L,11L,13L,13L,12L,10L,13L,11L,12L,13L,14L,14L,14L,10L,11L,14L,13L,12L,14L,13L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280079Inst : IEnumerable<long>
{
public static readonly long[] Value=A280079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280079.Bytes);
public long this[int i]=>Value[i];

public static A280079Inst Instance=new A280079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280080
{
public static readonly long[] Value={ 3L,5L,17L,41L,83L,127L,241L,283L,617L,1297L,1913L,2099L,3761L,5869L,9103L,10909L,46751L,104827L,114089L,152953L,177791L,219931L,293123L,368153L,2101553L,3733111L,5188297L,5336477L,7244099L,9026123L,12818959L,21330371L,21459517L,24931771L,32637571L,79689091L,182395973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280080Inst : IEnumerable<long>
{
public static readonly long[] Value=A280080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280080.Bytes);
public long this[int i]=>Value[i];

public static A280080Inst Instance=new A280080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280081
{
public static readonly long[] Value={ 5L,11L,31L,59L,109L,157L,277L,331L,709L,1409L,2027L,2221L,3911L,6037L,9293L,11257L,47123L,105211L,114547L,153427L,178289L,220573L,293861L,369181L,2102797L,3734491L,5189797L,5338243L,7245883L,9027923L,12820811L,21332369L,21461717L,24934051L,32640199L,79692083L,182398973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280081Inst : IEnumerable<long>
{
public static readonly long[] Value=A280081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280081.Bytes);
public long this[int i]=>Value[i];

public static A280081Inst Instance=new A280081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280082
{
public static readonly long[] Value={ 2L,6L,14L,18L,26L,30L,36L,48L,92L,112L,114L,122L,150L,168L,190L,348L,372L,384L,458L,474L,498L,642L,738L,1028L,1244L,1380L,1500L,1766L,1784L,1800L,1852L,1998L,2200L,2280L,2628L,2992L,3000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280082Inst : IEnumerable<long>
{
public static readonly long[] Value=A280082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280082.Bytes);
public long this[int i]=>Value[i];

public static A280082Inst Instance=new A280082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280083
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,11L,13L,16L,17L,19L,23L,31L,43L,61L,79L,101L,127L,167L,191L,199L,313L,347L,701L,1709L,2617L,3539L,5807L,10501L,10691L,11279L,12391L,14479L,42737L,83339L,95369L,117239L,127031L,138937L,141079L,267017L,269987L,374321L,986191L,4031399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280083Inst : IEnumerable<long>
{
public static readonly long[] Value=A280083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280083.Bytes);
public long this[int i]=>Value[i];

public static A280083Inst Instance=new A280083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280084
{
public static readonly long[] Value={ 1L,5L,13L,17L,29L,37L,41L,53L,61L,73L,89L,97L,101L,109L,113L,137L,149L,157L,173L,181L,193L,197L,229L,233L,241L,257L,269L,277L,281L,293L,313L,317L,337L,349L,353L,373L,389L,397L,401L,409L,421L,433L,449L,457L,461L,509L,521L,541L,557L,569L,577L,593L,601L,613L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280084Inst : IEnumerable<long>
{
public static readonly long[] Value=A280084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280084.Bytes);
public long this[int i]=>Value[i];

public static A280084Inst Instance=new A280084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280469
{
public static readonly long[] Value={ 4L,6L,12L,18L,30L,34L,42L,56L,60L,72L,86L,92L,94L,102L,108L,138L,142L,144L,150L,160L,180L,184L,186L,192L,198L,202L,204L,214L,216L,218L,220L,228L,236L,240L,248L,266L,270L,282L,300L,302L,304L,312L,320L,322L,328L,340L,348L,392L,394L,412L,414L,416L,420L,432L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280469Inst : IEnumerable<long>
{
public static readonly long[] Value=A280469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280469.Bytes);
public long this[int i]=>Value[i];

public static A280469Inst Instance=new A280469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280470
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,5L,7L,10L,15L,14L,19L,26L,36L,51L,42L,56L,75L,101L,137L,188L,132L,174L,230L,305L,406L,543L,731L,429L,561L,735L,965L,1270L,1676L,2219L,2950L,1430L,1859L,2420L,3155L,4120L,5390L,7066L,9285L,12235L,4862L,6292L,8151L,10571L,13726L,17846L,23236L,30302L,39587L,51822L,16796L,21658L,27950L,36101L,46672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280470Inst : IEnumerable<long>
{
public static readonly long[] Value=A280470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280470.Bytes);
public long this[int i]=>Value[i];

public static A280470Inst Instance=new A280470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280471
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,6L,7L,8L,9L,9L,10L,11L,12L,13L,13L,14L,15L,16L,17L,17L,18L,19L,20L,21L,21L,22L,23L,24L,25L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,33L,34L,35L,36L,37L,38L,38L,39L,40L,41L,42L,42L,43L,44L,45L,46L,47L,48L,49L,50L,50L,51L,52L,53L,54L,54L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280471Inst : IEnumerable<long>
{
public static readonly long[] Value=A280471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280471.Bytes);
public long this[int i]=>Value[i];

public static A280471Inst Instance=new A280471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280472
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,3L,3L,3L,3L,4L,3L,6L,4L,4L,4L,4L,6L,3L,4L,4L,6L,6L,4L,3L,4L,5L,3L,4L,5L,5L,3L,7L,7L,4L,4L,5L,7L,6L,5L,7L,4L,6L,5L,2L,6L,4L,4L,3L,7L,4L,4L,6L,9L,7L,4L,8L,4L,6L,4L,6L,7L,5L,6L,5L,6L,9L,3L,5L,6L,5L,5L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280472Inst : IEnumerable<long>
{
public static readonly long[] Value=A280472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280472.Bytes);
public long this[int i]=>Value[i];

public static A280472Inst Instance=new A280472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280473
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,21L,43L,70L,127L,215L,364L,591L,989L,1562L,2515L,3954L,6194L,9538L,14754L,22349L,33926L,50910L,76102L,112721L,166747L,244205L,356984L,518344L,749924L,1078711L,1547668L,2207418L,3140135L,4446572L,6276657L,8823776L,12371487L,17275879L,24061878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280473Inst : IEnumerable<long>
{
public static readonly long[] Value=A280473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280473.Bytes);
public long this[int i]=>Value[i];

public static A280473Inst Instance=new A280473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280474
{
public static readonly long[] Value={ 1L,6L,30L,158L,846L,4446L,22734L,113310L,552654L,2647390L,12492366L,58202526L,268228430L,1224529758L,5544352206L,24921415326L,111297979854L,494186360670L,2182903872334L,9596971862430L,42012203555406L,183197641092446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280474Inst : IEnumerable<long>
{
public static readonly long[] Value=A280474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280474.Bytes);
public long this[int i]=>Value[i];

public static A280474Inst Instance=new A280474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280475
{
public static readonly long[] Value={ 0L,22L,208L,1939L,17406L,149057L,1224092L,9717407L,75078490L,567486429L,4212636472L,30802884219L,222362166198L,1587624277241L,11227499711316L,78737492563415L,548110879578258L,3790518591777685L,26059838687117808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280475Inst : IEnumerable<long>
{
public static readonly long[] Value=A280475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280475.Bytes);
public long this[int i]=>Value[i];

public static A280475Inst Instance=new A280475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280476
{
public static readonly long[] Value={ 6L,63L,997L,15104L,214635L,2886700L,37224679L,464804972L,5658641517L,67497024458L,791686330307L,9155901061480L,104627294693465L,1183339450854998L,13264070830389055L,147510583604457748L,1629077899911720149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280476Inst : IEnumerable<long>
{
public static readonly long[] Value=A280476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280476.Bytes);
public long this[int i]=>Value[i];

public static A280476Inst Instance=new A280476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280477
{
public static readonly BigInteger[] Value={ 6L,162L,4070L,100306L,2272190L,48481917L,990070284L,19550495121L,375972018492L,7077631558153L,130917736928836L,2386330581933385L,42958320934899628L,765084427823374321L,13499826227679683140UL,BigInteger.Parse("236266604028642547153") };
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
public class A280477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280477Inst Instance=new A280477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280478
{
public static readonly BigInteger[] Value={ 30L,381L,15441L,618883L,22475478L,767741328L,25082093017L,792009247239L,24350633737743L,732782392386670L,21666466702540919L,631254359107473122L,18163265143313278519UL,BigInteger.Parse("517037287890494364049"),BigInteger.Parse("14581505333544329061184") };
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
public class A280478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280478Inst Instance=new A280478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280479
{
public static readonly BigInteger[] Value={ 54L,884L,55149L,3589912L,208736159L,11437392975L,599110195185L,30314748582007L,1492988077983829L,71948030099393732L,3405865992508069195L,BigInteger.Parse("158838750032932099900"),BigInteger.Parse("7314605470197927796802"),BigInteger.Parse("333202239966625982544310") };
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
public class A280479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280479Inst Instance=new A280479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280480
{
public static readonly long[] Value={ 0L,1L,0L,0L,6L,0L,6L,22L,30L,0L,6L,63L,208L,158L,0L,30L,162L,997L,1939L,846L,0L,54L,381L,4070L,15104L,17406L,4446L,0L,158L,884L,15441L,100306L,214635L,149057L,22734L,0L,342L,1995L,55149L,618883L,2272190L,2886700L,1224092L,113310L,0L,846L,4478L,189470L,3589912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280480Inst : IEnumerable<long>
{
public static readonly long[] Value=A280480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280480.Bytes);
public long this[int i]=>Value[i];

public static A280480Inst Instance=new A280480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280481
{
public static readonly long[] Value={ 0L,6L,22L,63L,162L,381L,884L,1995L,4478L,9913L,21832L,47687L,103666L,224117L,482556L,1034819L,2211686L,4712113L,10011696L,21217471L,44862298L,94656621L,199333092L,419016123L,879354062L,1842593961L,3855445784L,8056377655L,16813670338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280481Inst : IEnumerable<long>
{
public static readonly long[] Value=A280481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280481.Bytes);
public long this[int i]=>Value[i];

public static A280481Inst Instance=new A280481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280482
{
public static readonly long[] Value={ 0L,30L,208L,997L,4070L,15441L,55149L,189470L,630973L,2051794L,6544747L,20548963L,63673137L,195096252L,592041835L,1781597453L,5321888489L,15793808706L,46599296619L,136773367915L,399552426209L,1162212024424L,3367443663003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280482Inst : IEnumerable<long>
{
public static readonly long[] Value=A280482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280482.Bytes);
public long this[int i]=>Value[i];

public static A280482Inst Instance=new A280482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280483
{
public static readonly long[] Value={ 0L,158L,1939L,15104L,100306L,618883L,3589912L,20094736L,109292013L,581664562L,3041562335L,15676720945L,79831562595L,402387057319L,2010428875456L,9967869656098L,49089654019152L,240315798975781L,1170192251577228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280483Inst : IEnumerable<long>
{
public static readonly long[] Value=A280483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280483.Bytes);
public long this[int i]=>Value[i];

public static A280483Inst Instance=new A280483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280484
{
public static readonly long[] Value={ 0L,846L,17406L,214635L,2272190L,22475478L,208736159L,1872290290L,16303280577L,138811090897L,1160103714772L,9546680180339L,77537445203196L,622719069148966L,4952853901078386L,39060613089881366L,305763598880219395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280484Inst : IEnumerable<long>
{
public static readonly long[] Value=A280484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280484.Bytes);
public long this[int i]=>Value[i];

public static A280484Inst Instance=new A280484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280533
{
public static readonly long[] Value={ 3L,1L,1L,5L,2L,9L,3L,0L,7L,5L,3L,8L,8L,4L,0L,1L,6L,6L,0L,0L,4L,4L,6L,3L,5L,9L,0L,2L,9L,5L,5L,1L,2L,6L,6L,3L,2L,5L,2L,8L,9L,7L,7L,9L,6L,2L,7L,0L,3L,6L,2L,9L,3L,7L,4L,3L,6L,7L,8L,1L,8L,2L,2L,2L,5L,6L,3L,8L,9L,7L,2L,4L,8L,3L,9L,9L,6L,6L,2L,4L,6L,7L,0L,4L,4L,1L,3L,4L,7L,3L,6L,5L,1L,3L,0L,2L,1L,3L,8L,8L,8L,8L,2L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280533Inst : IEnumerable<long>
{
public static readonly long[] Value=A280533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280533.Bytes);
public long this[int i]=>Value[i];

public static A280533Inst Instance=new A280533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280534
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,2L,4L,1L,5L,3L,5L,2L,5L,2L,3L,2L,4L,4L,5L,3L,6L,4L,5L,4L,7L,5L,6L,4L,6L,5L,7L,3L,7L,6L,6L,3L,6L,5L,7L,3L,6L,4L,8L,4L,9L,4L,8L,4L,10L,5L,8L,3L,8L,6L,9L,4L,10L,5L,9L,6L,10L,5L,9L,5L,9L,6L,9L,5L,12L,6L,8L,6L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280534Inst : IEnumerable<long>
{
public static readonly long[] Value=A280534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280534.Bytes);
public long this[int i]=>Value[i];

public static A280534Inst Instance=new A280534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280535
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,1L,2L,1L,2L,0L,2L,2L,3L,1L,2L,1L,3L,2L,3L,2L,3L,2L,4L,2L,3L,1L,2L,2L,4L,2L,4L,3L,5L,1L,4L,2L,4L,2L,3L,1L,5L,3L,6L,3L,5L,2L,6L,2L,5L,3L,5L,3L,6L,3L,4L,3L,6L,2L,7L,3L,6L,4L,6L,2L,6L,4L,5L,4L,6L,3L,8L,5L,9L,4L,8L,4L,8L,3L,8L,6L,9L,3L,9L,6L,8L,3L,7L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280535Inst : IEnumerable<long>
{
public static readonly long[] Value=A280535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280535.Bytes);
public long this[int i]=>Value[i];

public static A280535Inst Instance=new A280535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280536
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,11L,12L,14L,15L,19L,21L,27L,35L,55L,59L,60L,64L,65L,75L,81L,83L,93L,95L,96L,100L,102L,108L,109L,114L,122L,124L,130L,132L,133L,135L,137L,141L,146L,152L,155L,158L,162L,165L,171L,178L,183L,192L,193L,198L,204L,206L,208L,214L,216L,223L,227L,243L,249L,255L,257L,263L,277L,279L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280536Inst : IEnumerable<long>
{
public static readonly long[] Value=A280536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280536.Bytes);
public long this[int i]=>Value[i];

public static A280536Inst Instance=new A280536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280537
{
public static readonly long[] Value={ 5L,8L,10L,13L,16L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280537Inst : IEnumerable<long>
{
public static readonly long[] Value=A280537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280537.Bytes);
public long this[int i]=>Value[i];

public static A280537Inst Instance=new A280537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280538
{
public static readonly long[] Value={ 1L,1L,232L,38L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280538Inst : IEnumerable<long>
{
public static readonly long[] Value=A280538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280538.Bytes);
public long this[int i]=>Value[i];

public static A280538Inst Instance=new A280538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280539
{
public static readonly long[] Value={ 1L,2L,3L,37L,47L,67L,87L,98L,252L,274L,450L,468L,556L,618L,662L,731L,789L,847L,866L,950L,971L,990L,1154L,1163L,1590L,1800L,1851L,1954L,1959L,2073L,2240L,2775L,2999L,3095L,3234L,3520L,3816L,3848L,3986L,4193L,4497L,4541L,4557L,4661L,4710L,4815L,4982L,5123L,5220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280539Inst : IEnumerable<long>
{
public static readonly long[] Value=A280539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280539.Bytes);
public long this[int i]=>Value[i];

public static A280539Inst Instance=new A280539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280540
{
public static readonly long[] Value={ 1L,1L,5L,11L,33L,67L,180L,366L,871L,1782L,3927L,7885L,16637L,32763L,66469L,128938L,253871L,484034L,930959L,1747304L,3292730L,6092664L,11282364L,20596790L,37568653L,67736175L,121886533L,217261372L,386216073L,681119439L,1197524035L,2091091902L,3639519280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280540Inst : IEnumerable<long>
{
public static readonly long[] Value=A280540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280540.Bytes);
public long this[int i]=>Value[i];

public static A280540Inst Instance=new A280540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280541
{
public static readonly long[] Value={ 1L,1L,4L,10L,24L,52L,125L,253L,549L,1126L,2290L,4525L,8987L,17259L,33174L,62669L,117425L,217295L,399904L,726984L,1314257L,2354807L,4191671L,7405590L,13009916L,22696115L,39384232L,67937488L,116584833L,199001304L,338076500L,571507377L,961855945L,1611567819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280541Inst : IEnumerable<long>
{
public static readonly long[] Value=A280541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280541.Bytes);
public long this[int i]=>Value[i];

public static A280541Inst Instance=new A280541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280542
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,2L,3L,1L,0L,3L,4L,3L,0L,4L,8L,6L,1L,5L,14L,10L,4L,7L,22L,20L,10L,12L,32L,39L,20L,21L,49L,70L,42L,37L,79L,116L,88L,65L,129L,193L,174L,122L,207L,326L,320L,238L,333L,551L,575L,463L,555L,914L,1029L,874L,959L,1502L,1829L,1621L,1691L,2486L,3192L,2989L,3000L,4172L,5488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280542Inst : IEnumerable<long>
{
public static readonly long[] Value=A280542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280542.Bytes);
public long this[int i]=>Value[i];

public static A280542Inst Instance=new A280542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280543
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,31L,62L,123L,244L,483L,958L,1899L,3765L,7463L,14794L,29329L,58141L,115258L,228486L,452949L,897922L,1780031L,3528716L,6995293L,13867402L,27490602L,54497104L,108034531L,214166610L,424561814L,841647229L,1668473323L,3307565365L,6556885566L,12998306479L,25767716954L,51081672682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280543Inst : IEnumerable<long>
{
public static readonly long[] Value=A280543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280543.Bytes);
public long this[int i]=>Value[i];

public static A280543Inst Instance=new A280543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280544
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,3L,0L,5L,2L,8L,3L,13L,5L,22L,10L,34L,18L,58L,31L,94L,57L,153L,99L,254L,172L,417L,302L,685L,523L,1136L,901L,1872L,1557L,3097L,2673L,5133L,4577L,8505L,7843L,14109L,13380L,23440L,22816L,38953L,38855L,64789L,66053L,107871L,112190L,179664L,190369L,299478L,322683L,499501L,546548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280544Inst : IEnumerable<long>
{
public static readonly long[] Value=A280544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280544.Bytes);
public long this[int i]=>Value[i];

public static A280544Inst Instance=new A280544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280545
{
public static readonly long[] Value={ 1L,4L,13228L,19289L,187838L,201255L,281771L,308591L,7391381L,9041581L,9124081L,9589141L,193690242024L,254218445292L,306676216538L,375274847812L,402512534123L,423082506591L,425477274579L,443127377343L,456962010177L,458339382147L,476155178309L,480858185253L,484213195281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280545Inst : IEnumerable<long>
{
public static readonly long[] Value=A280545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280545.Bytes);
public long this[int i]=>Value[i];

public static A280545Inst Instance=new A280545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280546
{
public static readonly long[] Value={ 2L,19L,150L,953L,2708L,32414L,158810L,4602784L,472173970L,472173970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280546Inst : IEnumerable<long>
{
public static readonly long[] Value=A280546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280546.Bytes);
public long this[int i]=>Value[i];

public static A280546Inst Instance=new A280546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280547
{
public static readonly long[] Value={ 4L,7L,3L,14L,1L,23L,3L,7L,2L,2L,1L,75L,3L,7L,3L,36L,1L,2476L,1L,1L,2L,165L,1L,14L,4L,7L,3L,149L,1L,2972L,3L,2L,4L,14L,1L,977L,4L,5L,1L,34L,1L,135L,2L,7L,4L,136L,1L,23L,2L,7L,2L,11L,1L,2L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280547Inst : IEnumerable<long>
{
public static readonly long[] Value=A280547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280547.Bytes);
public long this[int i]=>Value[i];

public static A280547Inst Instance=new A280547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280548
{
public static readonly long[] Value={ 0L,0L,50L,382L,1764L,6502L,20334L,56102L,141398L,332810L,743966L,1598198L,3328362L,6763114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280548Inst : IEnumerable<long>
{
public static readonly long[] Value=A280548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280548.Bytes);
public long this[int i]=>Value[i];

public static A280548Inst Instance=new A280548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281143
{
public static readonly long[] Value={ 4L,5L,2L,8L,7L,2L,8L,6L,8L,8L,1L,1L,6L,7L,6L,4L,7L,6L,2L,2L,0L,3L,3L,0L,9L,3L,3L,7L,1L,9L,5L,5L,0L,8L,7L,9L,3L,4L,9L,8L,6L,3L,1L,6L,7L,6L,0L,8L,9L,3L,9L,0L,4L,6L,2L,8L,8L,6L,1L,1L,4L,7L,6L,0L,4L,6L,9L,2L,6L,2L,5L,5L,3L,8L,4L,5L,4L,1L,2L,8L,3L,9L,0L,7L,5L,1L,7L,7L,2L,4L,6L,5L,8L,2L,8L,8L,4L,9L,9L,4L,5L,8L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281143Inst : IEnumerable<long>
{
public static readonly long[] Value=A281143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281143.Bytes);
public long this[int i]=>Value[i];

public static A281143Inst Instance=new A281143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281144
{
public static readonly long[] Value={ 1L,4L,7L,9L,16L,33L,55L,63L,75L,195L,412L,766L,1083L,1657L,2254L,4972L,10053L,10605L,13413L,18085L,24595L,25161L,36441L,80638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281144Inst : IEnumerable<long>
{
public static readonly long[] Value=A281144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281144.Bytes);
public long this[int i]=>Value[i];

public static A281144Inst Instance=new A281144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281145
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,14L,2L,54L,10L,38L,2L,494L,2L,134L,42L,4470L,2L,3422L,2L,10262L,138L,2054L,2L,490926L,34L,8198L,1514L,314294L,2L,628318L,2L,30229110L,2058L,131078L,162L,150147342L,2L,524294L,8202L,628073814L,2L,109952254L,2L,371210294L,207370L,8388614L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281145Inst : IEnumerable<long>
{
public static readonly long[] Value=A281145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281145.Bytes);
public long this[int i]=>Value[i];

public static A281145Inst Instance=new A281145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281146
{
public static readonly ulong[] Value={ 1L,10L,100L,1000L,10100L,101000L,1010100L,10101000L,101010100L,1010101000L,10101010100L,101010101000L,1010101010100L,10101010101000L,101010101010100L,1010101010101000L,10101010101010100L,101010101010101000L,1010101010101010100L,10101010101010101000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281146Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281146.Bytes);
public ulong this[int i]=>Value[i];

public static A281146Inst Instance=new A281146Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281148
{
public static readonly long[] Value={ 2L,3L,8L,9L,13L,14L,22L,33L,44L,52L,72L,77L,87L,92L,222L,322L,622L,7737L,7878L,30302L,44449L,72777L,844844L,44744744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281148Inst : IEnumerable<long>
{
public static readonly long[] Value=A281148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281148.Bytes);
public long this[int i]=>Value[i];

public static A281148Inst Instance=new A281148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281149
{
public static readonly long[] Value={ 1L,100L,101L,11000L,11001L,11010L,11011L,1110000L,1110001L,1110010L,1110011L,1110100L,1110101L,1110110L,1110111L,111100000L,111100001L,111100010L,111100011L,111100100L,111100101L,111100110L,111100111L,111101000L,111101001L,111101010L,111101011L,111101100L,111101101L,111101110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281149Inst : IEnumerable<long>
{
public static readonly long[] Value=A281149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281149.Bytes);
public long this[int i]=>Value[i];

public static A281149Inst Instance=new A281149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281150
{
public static readonly long[] Value={ 1L,1000L,1001L,10100L,10101L,10110L,10111L,11000000L,11000001L,11000010L,11000011L,11000100L,11000101L,11000110L,11000111L,110010000L,110010001L,110010010L,110010011L,110010100L,110010101L,110010110L,110010111L,110011000L,110011001L,110011010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281150Inst : IEnumerable<long>
{
public static readonly long[] Value=A281150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281150.Bytes);
public long this[int i]=>Value[i];

public static A281150Inst Instance=new A281150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281151
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,24L,33L,44L,57L,72L,88L,105L,124L,145L,168L,192L,217L,244L,273L,304L,336L,369L,404L,441L,480L,520L,561L,604L,649L,696L,744L,793L,844L,897L,952L,1008L,1065L,1124L,1185L,1248L,1312L,1377L,1444L,1513L,1584L,1656L,1729L,1804L,1881L,1960L,2040L,2121L,2204L,2289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281151Inst : IEnumerable<long>
{
public static readonly long[] Value=A281151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281151.Bytes);
public long this[int i]=>Value[i];

public static A281151Inst Instance=new A281151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281152
{
public static readonly long[] Value={ 1L,4L,9L,4L,2L,12L,49L,11L,3L,40L,26L,60L,1L,11L,225L,112L,5L,144L,43L,12L,6L,220L,21L,18L,7L,32L,60L,364L,8L,420L,961L,4L,9L,25L,77L,612L,10L,16L,243L,760L,2L,840L,94L,4L,12L,1012L,165L,81L,13L,52L,111L,1300L,14L,24L,340L,67L,15L,1624L,9L,1740L,16L,35L,3969L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281152Inst : IEnumerable<long>
{
public static readonly long[] Value=A281152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281152.Bytes);
public long this[int i]=>Value[i];

public static A281152Inst Instance=new A281152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281153
{
public static readonly long[] Value={ 3L,10L,21L,36L,55L,78L,105L,136L,171L,210L,253L,300L,351L,406L,465L,18L,595L,666L,741L,820L,903L,990L,1081L,1176L,1275L,1378L,1485L,1596L,1711L,1830L,1953L,2080L,2211L,4L,2485L,2628L,2775L,12L,3081L,3240L,3403L,3570L,3741L,3916L,4095L,4278L,4465L,4656L,4851L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281153Inst : IEnumerable<long>
{
public static readonly long[] Value=A281153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281153.Bytes);
public long this[int i]=>Value[i];

public static A281153Inst Instance=new A281153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281154
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,2L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,1L,2L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,2L,1L,0L,2L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281154Inst : IEnumerable<long>
{
public static readonly long[] Value=A281154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281154.Bytes);
public long this[int i]=>Value[i];

public static A281154Inst Instance=new A281154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281155
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,3L,0L,3L,0L,0L,1L,0L,6L,0L,0L,0L,3L,3L,0L,3L,0L,6L,0L,0L,3L,0L,3L,3L,6L,0L,0L,1L,6L,6L,0L,0L,0L,6L,0L,6L,6L,0L,3L,0L,6L,6L,0L,0L,6L,3L,3L,3L,6L,6L,0L,3L,0L,6L,1L,3L,12L,6L,0L,0L,6L,3L,6L,6L,0L,3L,0L,3L,15L,6L,0L,0L,6L,12L,0L,3L,3L,6L,6L,0L,12L,3L,0L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281155Inst : IEnumerable<long>
{
public static readonly long[] Value=A281155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281155.Bytes);
public long this[int i]=>Value[i];

public static A281155Inst Instance=new A281155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281156
{
public static readonly long[] Value={ 1L,1L,5L,19L,54L,165L,467L,1317L,3599L,9687L,25519L,66203L,169254L,426750L,1062950L,2616818L,6373911L,15369774L,36716706L,86939235L,204152395L,475631501L,1099874363L,2525418842L,5759549109L,13050991205L,29391523405L,65801951770L,146486952644L,324340095729L,714389015139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281156Inst : IEnumerable<long>
{
public static readonly long[] Value=A281156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281156.Bytes);
public long this[int i]=>Value[i];

public static A281156Inst Instance=new A281156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281157
{
public static readonly long[] Value={ 1L,1L,6L,25L,78L,258L,800L,2463L,7344L,21511L,61677L,173980L,483319L,1323470L,3577605L,9553658L,25227727L,65918419L,170552866L,437196640L,1110945961L,2799689792L,7000246591L,17372882671L,42809388080L,104774554942L,254771953179L,615667051237L,1478934870484L,3532347875968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281157Inst : IEnumerable<long>
{
public static readonly long[] Value=A281157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281157.Bytes);
public long this[int i]=>Value[i];

public static A281157Inst Instance=new A281157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281158
{
public static readonly long[] Value={ 2L,3L,5L,3L,3L,5L,5L,3L,5L,3L,5L,5L,3L,3L,11L,7L,5L,11L,3L,7L,11L,5L,3L,5L,3L,5L,5L,3L,13L,7L,5L,5L,5L,5L,11L,7L,5L,13L,5L,3L,7L,17L,3L,3L,7L,5L,17L,5L,3L,7L,11L,7L,3L,13L,13L,5L,5L,3L,5L,17L,5L,7L,5L,3L,3L,31L,7L,3L,29L,23L,5L,17L,11L,19L,11L,17L,5L,23L,5L,3L,7L,5L,5L,5L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281158Inst : IEnumerable<long>
{
public static readonly long[] Value=A281158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281158.Bytes);
public long this[int i]=>Value[i];

public static A281158Inst Instance=new A281158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281159
{
public static readonly long[] Value={ 0L,0L,5L,18L,85L,346L,1388L,5454L,21171L,81250L,309019L,1166316L,4372916L,16300940L,60456037L,223201490L,820709441L,3006697550L,10978569420L,39965443098L,145083078903L,525337769138L,1897732902967L,6840395954992L,24606162295316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281159Inst : IEnumerable<long>
{
public static readonly long[] Value=A281159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281159.Bytes);
public long this[int i]=>Value[i];

public static A281159Inst Instance=new A281159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281208
{
public static readonly long[] Value={ 0L,38L,168L,270L,470L,804L,1358L,2284L,3834L,6432L,10786L,18080L,30290L,50712L,84838L,141812L,236846L,395228L,658966L,1097796L,1827410L,3039624L,5052282L,8391768L,13929370L,23106544L,38306878L,63470044L,105104774L,173959572L,287777246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281208Inst : IEnumerable<long>
{
public static readonly long[] Value=A281208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281208.Bytes);
public long this[int i]=>Value[i];

public static A281208Inst Instance=new A281208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281209
{
public static readonly long[] Value={ 0L,130L,448L,676L,1141L,1906L,3137L,5160L,8510L,14084L,23379L,38894L,64795L,108022L,180126L,300318L,500525L,833770L,1388053L,2309332L,3839550L,6379528L,10592935L,17578086L,29151695L,48317346L,80038622L,132514530L,219282785L,362687074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281209Inst : IEnumerable<long>
{
public static readonly long[] Value=A281209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281209.Bytes);
public long this[int i]=>Value[i];

public static A281209Inst Instance=new A281209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281210
{
public static readonly long[] Value={ 0L,420L,1120L,1588L,2602L,4248L,6838L,11010L,17840L,29120L,47838L,78978L,130842L,217250L,361188L,600860L,999718L,1663078L,2765630L,4596962L,7636856L,12679768L,21040526L,34894090L,57836514L,95810754L,158634028L,262516660L,434214550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281210Inst : IEnumerable<long>
{
public static readonly long[] Value=A281210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281210.Bytes);
public long this[int i]=>Value[i];

public static A281210Inst Instance=new A281210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281211
{
public static readonly long[] Value={ 0L,1308L,2688L,3604L,5712L,9118L,14375L,22700L,36144L,58168L,94524L,154800L,254959L,421560L,698756L,1159898L,1926760L,3201376L,5318733L,8833940L,14666360L,24337820L,40366132L,66914912L,110866187L,183590176L,303864300L,502685950L,831204864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281211Inst : IEnumerable<long>
{
public static readonly long[] Value=A281211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281211.Bytes);
public long this[int i]=>Value[i];

public static A281211Inst Instance=new A281211Inst();

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