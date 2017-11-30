using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A205757
{
public static readonly long[] Value={ 12574L,82992L,507035L,3869807L,28155907L,233316016L,1885888870L,16599011784L,144835219234L,1335751969435L,12319659225966L,117640826011747L,1127388561521481L,11036054002196311L,108508423769699944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205757Inst : IEnumerable<long>
{
public static readonly long[] Value=A205757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205757.Bytes);
public long this[int i]=>Value[i];

public static A205757Inst Instance=new A205757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205758
{
public static readonly long[] Value={ 69338L,542718L,3797920L,34977686L,292986186L,2917623614L,26828234464L,279459906314L,2723713739666L,29190925331248L,295846244829092L,3230320670138002L,33638289242782070L,371863257488907590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205758Inst : IEnumerable<long>
{
public static readonly long[] Value=A205758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205758.Bytes);
public long this[int i]=>Value[i];

public static A205758Inst Instance=new A205758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205759
{
public static readonly long[] Value={ 383440L,3602578L,29561841L,341919297L,3496020388L,45262306396L,528507252157L,7409837678586L,95546688005488L,1427488689168257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205759Inst : IEnumerable<long>
{
public static readonly long[] Value=A205759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205759.Bytes);
public long this[int i]=>Value[i];

public static A205759Inst Instance=new A205759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205760
{
public static readonly BigInteger[] Value={ 192L,17674L,9909258L,31592825608L,492612437238998L,BigInteger.Parse("37329289868928312037"),BigInteger.Parse("13716254602126712440880420"),BigInteger.Parse("24435414110066470652645658456176") };
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
public class A205760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205760Inst Instance=new A205760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205761
{
public static readonly long[] Value={ 192L,1262L,8659L,62607L,462040L,3490700L,26672819L,205747848L,1595214033L,12413756669L,96806542939L,756001274858L,5908892541394L,46209002829411L,361485247026700L,2828432016655919L,22133840165287141L,173221954994087709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205761Inst : IEnumerable<long>
{
public static readonly long[] Value=A205761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205761.Bytes);
public long this[int i]=>Value[i];

public static A205761Inst Instance=new A205761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205762
{
public static readonly BigInteger[] Value={ 1262L,17674L,274013L,4570761L,77757894L,1336717872L,23044169753L,397824057617L,6870394713491L,118674185578745L,2049983501229713L,35412502271123185L,611737278096686056L,10567570355635198190UL,BigInteger.Parse("182551538976364797431") };
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
public class A205762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205762Inst Instance=new A205762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205763
{
public static readonly BigInteger[] Value={ 8659L,274013L,9909258L,375857889L,14312320196L,545700470559L,20808476912916L,793486314120669L,30257997968098894L,1153827416366199522L,BigInteger.Parse("43998894299268852777"),BigInteger.Parse("1677809126003982433476"),BigInteger.Parse("63979878224491463514492") };
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
public class A205763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205763Inst Instance=new A205763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205764
{
public static readonly BigInteger[] Value={ 62607L,4570761L,375857889L,31592825608L,2656185934184L,223459321298323L,18792440902201504L,1580709916943096718L,BigInteger.Parse("132941278791630619177"),BigInteger.Parse("11181607234258635896108"),BigInteger.Parse("940424480216599337378896") };
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
public class A205764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205764Inst Instance=new A205764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205765
{
public static readonly BigInteger[] Value={ 462040L,77757894L,14312320196L,2656185934184L,492612437238998L,91342751431917271L,16933907492912073872UL,BigInteger.Parse("3139181759928267573682"),BigInteger.Parse("581918239365879746359719"),BigInteger.Parse("107870252944691557966360427") };
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
public class A205765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205765Inst Instance=new A205765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205766
{
public static readonly BigInteger[] Value={ 3490700L,1336717872L,545700470559L,223459321298323L,91342751431917271L,BigInteger.Parse("37329289868928312037"),BigInteger.Parse("15245666610881157061902"),BigInteger.Parse("6226771909851135513221100"),BigInteger.Parse("2542604116386266994899929934"),BigInteger.Parse("1038308180737975215393212045381") };
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
public class A205766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205766Inst Instance=new A205766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205767
{
public static readonly BigInteger[] Value={ 26672819L,23044169753L,20808476912916L,18792440902201504L,16933907492912073872UL,BigInteger.Parse("15245666610881157061902"),BigInteger.Parse("13716254602126712440880420"),BigInteger.Parse("12336975902231287097446944284"),BigInteger.Parse("11094395430478243340473622599662") };
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
public class A205767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205767Inst Instance=new A205767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205768
{
public static readonly long[] Value={ 192L,1262L,1262L,8659L,17674L,8659L,62607L,274013L,274013L,62607L,462040L,4570761L,9909258L,4570761L,462040L,3490700L,77757894L,375857889L,375857889L,77757894L,3490700L,26672819L,1336717872L,14312320196L,31592825608L,14312320196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205768Inst : IEnumerable<long>
{
public static readonly long[] Value=A205768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205768.Bytes);
public long this[int i]=>Value[i];

public static A205768Inst Instance=new A205768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205769
{
public static readonly long[] Value={ 3L,4L,2L,7L,0L,5L,0L,9L,8L,3L,1L,2L,4L,8L,4L,2L,2L,7L,2L,3L,0L,6L,8L,8L,0L,2L,5L,1L,5L,4L,8L,4L,5L,7L,1L,7L,6L,5L,8L,0L,4L,6L,3L,7L,6L,9L,7L,0L,8L,6L,4L,4L,2L,9L,3L,2L,0L,3L,1L,7L,2L,9L,3L,4L,0L,5L,7L,8L,9L,0L,6L,9L,4L,2L,2L,8L,3L,5L,3L,6L,7L,4L,5L,6L,0L,8L,1L,0L,8L,0L,6L,2L,8L,4L,0L,8L,6L,7L,0L,6L,2L,2L,7L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205769Inst : IEnumerable<long>
{
public static readonly long[] Value=A205769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205769.Bytes);
public long this[int i]=>Value[i];

public static A205769Inst Instance=new A205769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205770
{
public static readonly long[] Value={ 1L,3L,6L,16L,40L,100L,251L,631L,1585L,3981L,10000L,25119L,63096L,158489L,398107L,1000000L,2511886L,6309573L,15848932L,39810717L,100000000L,251188643L,630957344L,1584893192L,3981071706L,10000000000L,25118864315L,63095734448L,158489319246L,398107170553L,1000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205770Inst : IEnumerable<long>
{
public static readonly long[] Value=A205770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205770.Bytes);
public long this[int i]=>Value[i];

public static A205770Inst Instance=new A205770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205771
{
public static readonly BigInteger[] Value={ 3L,11L,251L,2441406251L,BigInteger.Parse("56843418860808014869689941406251"),BigInteger.Parse("49303806576313237838233035330174139354575402194313937798142433166503906251") };
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
public class A205771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205771Inst Instance=new A205771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205772
{
public static readonly long[] Value={ 1L,2L,10L,50L,290L,1766L,11442L,76522L,526574L,3697722L,26403186L,191072922L,1398344838L,10330855286L,76945148882L,577135722754L,4355579825058L,33050011129198L,251996066644866L,1929712025078322L,14834772898730766L,114445491235869774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205772Inst : IEnumerable<long>
{
public static readonly long[] Value=A205772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205772.Bytes);
public long this[int i]=>Value[i];

public static A205772Inst Instance=new A205772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205773
{
public static readonly BigInteger[] Value={ 1L,3L,21L,156L,1335L,12153L,116778L,1160715L,11848530L,123420648L,1306709841L,14019657771L,152092615971L,1665531792021L,18386262679557L,204393214435791L,2286101345820933L,25708109998131381L,290490321604346535L,3296566844230833750L,BigInteger.Parse("37555644504960139647") };
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
public class A205773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205773Inst Instance=new A205773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205774
{
public static readonly long[] Value={ 1L,1L,5L,27L,177L,1245L,9399L,73659L,595510L,4923724L,41451675L,354071010L,3061018302L,26732084764L,235476740731L,2089770720125L,18666863392846L,167697751329817L,1514206777182411L,13734387733516323L,125083419013852945L,1143367086845429280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205774Inst : IEnumerable<long>
{
public static readonly long[] Value=A205774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205774.Bytes);
public long this[int i]=>Value[i];

public static A205774Inst Instance=new A205774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205775
{
public static readonly long[] Value={ 1L,1L,3L,8L,26L,79L,276L,936L,3376L,12259L,45648L,171739L,655664L,2524835L,9813259L,38410167L,151332137L,599541153L,2387199083L,9547195445L,38335338712L,154484001619L,624579964260L,2532713370789L,10298393401623L,41979975505800L,171522040764060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205775Inst : IEnumerable<long>
{
public static readonly long[] Value=A205775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205775.Bytes);
public long this[int i]=>Value[i];

public static A205775Inst Instance=new A205775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205776
{
public static readonly BigInteger[] Value={ 3L,13L,73L,433L,2593L,120932353L,725594113L,33853318889473L,7312316880125953L,BigInteger.Parse("12281884428929630994433"),BigInteger.Parse("160409934466124808814066151718913"),BigInteger.Parse("44904515414709114480174422247585349633"),BigInteger.Parse("452534055376752384160395854386801887645007873") };
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
public class A205776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205776Inst Instance=new A205776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205777
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,-2L,2L,-2L,0L,1L,-3L,0L,-4L,2L,1L,-2L,2L,2L,-6L,-12L,11L,6L,-9L,23L,-42L,103L,-100L,44L,6L,-105L,162L,-291L,239L,-115L,79L,202L,-13L,452L,-539L,-240L,-548L,183L,-18L,-26L,703L,-1537L,2751L,-609L,2091L,2162L,-4328L,5156L,-8972L,-7340L,-125L,-8678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205777Inst : IEnumerable<long>
{
public static readonly long[] Value=A205777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205777.Bytes);
public long this[int i]=>Value[i];

public static A205777Inst Instance=new A205777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205778
{
public static readonly long[] Value={ 2L,3L,3L,3L,5L,4L,5L,5L,4L,5L,7L,4L,4L,5L,6L,9L,8L,6L,8L,5L,8L,8L,13L,8L,8L,6L,7L,5L,10L,6L,9L,11L,7L,8L,12L,9L,5L,11L,9L,5L,5L,8L,7L,9L,6L,13L,15L,9L,13L,12L,8L,9L,7L,9L,9L,11L,8L,14L,6L,9L,7L,12L,15L,19L,6L,9L,11L,8L,13L,12L,21L,13L,17L,12L,8L,12L,8L,9L,12L,16L,9L,17L,7L,8L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205778Inst : IEnumerable<long>
{
public static readonly long[] Value=A205778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205778.Bytes);
public long this[int i]=>Value[i];

public static A205778Inst Instance=new A205778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205779
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,4L,2L,3L,2L,6L,2L,1L,4L,5L,4L,2L,5L,3L,2L,2L,6L,12L,4L,3L,2L,6L,4L,3L,5L,7L,2L,6L,2L,5L,2L,3L,10L,8L,2L,1L,2L,5L,8L,5L,12L,4L,4L,9L,9L,2L,8L,3L,2L,6L,5L,3L,2L,4L,2L,2L,2L,14L,8L,2L,8L,7L,2L,12L,5L,8L,12L,2L,10L,3L,10L,7L,8L,3L,8L,2L,2L,4L,2L,10L,6L,3L,8L,13L,5L,7L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205779Inst : IEnumerable<long>
{
public static readonly long[] Value=A205779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205779.Bytes);
public long this[int i]=>Value[i];

public static A205779Inst Instance=new A205779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205780
{
public static readonly long[] Value={ 2L,3L,2L,3L,3L,4L,4L,3L,5L,5L,5L,4L,5L,6L,5L,4L,7L,6L,7L,5L,4L,7L,7L,4L,9L,7L,7L,6L,7L,5L,8L,6L,6L,7L,6L,6L,8L,9L,5L,6L,10L,6L,10L,7L,10L,10L,8L,6L,11L,9L,9L,7L,9L,7L,5L,6L,9L,9L,12L,5L,13L,13L,5L,8L,8L,10L,19L,7L,12L,13L,11L,6L,11L,19L,9L,9L,8L,8L,23L,6L,10L,12L,22L,6L,10L,10L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205780Inst : IEnumerable<long>
{
public static readonly long[] Value=A205780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205780.Bytes);
public long this[int i]=>Value[i];

public static A205780Inst Instance=new A205780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205781
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,3L,1L,4L,1L,2L,3L,6L,4L,2L,2L,2L,1L,2L,1L,4L,4L,3L,1L,5L,2L,3L,3L,2L,6L,5L,4L,3L,7L,4L,3L,8L,1L,3L,1L,1L,3L,6L,4L,3L,4L,6L,4L,2L,3L,3L,1L,2L,3L,3L,2L,12L,4L,1L,2L,7L,1L,2L,6L,10L,6L,2L,4L,2L,16L,4L,7L,1L,5L,4L,3L,5L,6L,11L,1L,7L,3L,4L,1L,8L,1L,5L,3L,4L,4L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205781Inst : IEnumerable<long>
{
public static readonly long[] Value=A205781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205781.Bytes);
public long this[int i]=>Value[i];

public static A205781Inst Instance=new A205781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205782
{
public static readonly long[] Value={ 2L,3L,2L,4L,3L,3L,4L,5L,2L,3L,5L,5L,6L,4L,3L,6L,7L,3L,8L,4L,5L,5L,9L,6L,4L,6L,3L,4L,11L,3L,3L,7L,5L,7L,4L,5L,7L,8L,6L,6L,12L,5L,6L,5L,3L,9L,9L,6L,6L,4L,7L,6L,7L,3L,6L,5L,8L,11L,18L,6L,7L,10L,5L,7L,7L,5L,9L,7L,9L,4L,18L,6L,17L,7L,8L,8L,5L,6L,18L,7L,10L,12L,12L,5L,7L,6L,11L,6L,13L,3L,6L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205782Inst : IEnumerable<long>
{
public static readonly long[] Value=A205782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205782.Bytes);
public long this[int i]=>Value[i];

public static A205782Inst Instance=new A205782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205783
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,70L,72L,74L,75L,76L,78L,80L,82L,84L,85L,86L,88L,90L,92L,93L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205783Inst : IEnumerable<long>
{
public static readonly long[] Value=A205783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205783.Bytes);
public long this[int i]=>Value[i];

public static A205783Inst Instance=new A205783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205784
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,3L,3L,1L,2L,4L,4L,5L,3L,2L,5L,6L,2L,7L,3L,4L,4L,8L,5L,2L,5L,2L,3L,10L,2L,1L,6L,4L,6L,3L,4L,2L,7L,5L,3L,11L,4L,3L,4L,2L,8L,8L,5L,3L,2L,6L,5L,6L,2L,4L,3L,7L,10L,7L,4L,2L,6L,4L,6L,6L,4L,2L,6L,8L,3L,9L,5L,8L,2L,7L,7L,4L,5L,2L,6L,7L,11L,10L,4L,6L,3L,10L,5L,9L,2L,5L,8L,1L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205784Inst : IEnumerable<long>
{
public static readonly long[] Value=A205784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205784.Bytes);
public long this[int i]=>Value[i];

public static A205784Inst Instance=new A205784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205785
{
public static readonly long[] Value={ 2L,3L,4L,5L,4L,5L,6L,5L,4L,4L,4L,6L,6L,8L,7L,7L,5L,5L,5L,6L,8L,7L,7L,8L,6L,7L,6L,9L,12L,7L,11L,9L,7L,10L,8L,6L,12L,7L,6L,8L,16L,8L,8L,9L,7L,12L,15L,9L,8L,6L,10L,7L,9L,6L,10L,9L,9L,12L,6L,8L,14L,11L,10L,9L,8L,7L,9L,10L,7L,8L,13L,10L,8L,12L,11L,14L,10L,8L,12L,10L,10L,16L,8L,9L,10L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205785Inst : IEnumerable<long>
{
public static readonly long[] Value=A205785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205785.Bytes);
public long this[int i]=>Value[i];

public static A205785Inst Instance=new A205785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205786
{
public static readonly long[] Value={ 1L,1L,3L,4L,2L,2L,1L,4L,3L,2L,1L,4L,3L,7L,6L,2L,3L,2L,1L,5L,7L,4L,3L,6L,5L,2L,4L,8L,5L,6L,4L,8L,4L,8L,7L,4L,5L,5L,3L,6L,12L,7L,3L,6L,6L,6L,3L,8L,7L,5L,8L,2L,3L,4L,7L,8L,3L,5L,2L,6L,6L,4L,9L,8L,6L,4L,7L,8L,3L,7L,6L,9L,1L,5L,10L,9L,7L,6L,8L,8L,9L,12L,5L,8L,8L,9L,6L,6L,1L,6L,7L,6L,4L,11L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205786Inst : IEnumerable<long>
{
public static readonly long[] Value=A205786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205786.Bytes);
public long this[int i]=>Value[i];

public static A205786Inst Instance=new A205786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205787
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,7L,2L,4L,4L,11L,12L,8L,3L,4L,16L,6L,18L,7L,3L,12L,4L,23L,24L,8L,10L,3L,6L,4L,30L,31L,5L,8L,34L,35L,9L,8L,4L,6L,5L,12L,42L,8L,6L,24L,16L,47L,48L,14L,5L,15L,52L,6L,54L,9L,56L,4L,7L,59L,60L,32L,5L,5L,4L,8L,14L,67L,7L,36L,70L,11L,72L,8L,8L,8L,20L,6L,15L,9L,7L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205787Inst : IEnumerable<long>
{
public static readonly long[] Value=A205787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205787.Bytes);
public long this[int i]=>Value[i];

public static A205787Inst Instance=new A205787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205788
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,5L,1L,3L,2L,1L,1L,1L,4L,1L,1L,4L,2L,3L,4L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,3L,5L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,4L,1L,1L,4L,9L,1L,2L,2L,1L,1L,1L,2L,1L,6L,5L,4L,4L,3L,3L,2L,3L,1L,1L,2L,1L,9L,1L,2L,1L,1L,5L,2L,4L,1L,4L,4L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205788Inst : IEnumerable<long>
{
public static readonly long[] Value=A205788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205788.Bytes);
public long this[int i]=>Value[i];

public static A205788Inst Instance=new A205788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205789
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,4L,4L,3L,5L,3L,6L,4L,3L,8L,2L,3L,4L,9L,10L,3L,5L,12L,12L,4L,4L,5L,6L,8L,5L,4L,16L,5L,7L,5L,4L,9L,6L,20L,5L,3L,5L,10L,22L,12L,6L,24L,24L,4L,14L,7L,4L,5L,7L,9L,7L,8L,11L,7L,30L,4L,6L,32L,8L,6L,3L,14L,34L,5L,13L,8L,36L,9L,8L,7L,7L,20L,9L,5L,40L,3L,6L,9L,42L,10L,4L,44L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205789Inst : IEnumerable<long>
{
public static readonly long[] Value=A205789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205789.Bytes);
public long this[int i]=>Value[i];

public static A205789Inst Instance=new A205789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205790
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,1L,4L,1L,5L,2L,2L,6L,1L,1L,1L,3L,9L,1L,2L,10L,11L,2L,3L,1L,3L,6L,2L,2L,15L,3L,4L,3L,3L,3L,1L,18L,1L,1L,4L,4L,21L,10L,3L,22L,23L,2L,7L,1L,1L,1L,2L,3L,4L,6L,8L,3L,29L,2L,5L,30L,1L,2L,2L,8L,33L,3L,10L,6L,35L,3L,3L,5L,1L,18L,2L,1L,39L,1L,3L,1L,41L,4L,1L,42L,2L,10L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205790Inst : IEnumerable<long>
{
public static readonly long[] Value=A205790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205790.Bytes);
public long this[int i]=>Value[i];

public static A205790Inst Instance=new A205790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205791
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,7L,8L,4L,6L,11L,3L,8L,14L,15L,16L,4L,18L,9L,20L,12L,22L,3L,24L,8L,6L,27L,6L,16L,30L,31L,2L,4L,4L,35L,36L,12L,38L,39L,40L,12L,7L,43L,44L,5L,18L,47L,48L,8L,14L,11L,52L,28L,54L,9L,7L,16L,58L,59L,60L,32L,7L,4L,24L,6L,66L,8L,68L,36L,70L,71L,4L,12L,74L,75L,16L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205791Inst : IEnumerable<long>
{
public static readonly long[] Value=A205791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205791.Bytes);
public long this[int i]=>Value[i];

public static A205791Inst Instance=new A205791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205792
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,1L,1L,3L,1L,1L,2L,7L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,2L,2L,2L,3L,2L,1L,2L,1L,2L,1L,1L,3L,6L,1L,1L,1L,2L,5L,1L,1L,2L,3L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205792Inst : IEnumerable<long>
{
public static readonly long[] Value=A205792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205792.Bytes);
public long this[int i]=>Value[i];

public static A205792Inst Instance=new A205792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205793
{
public static readonly long[] Value={ 2L,2L,4L,3L,4L,5L,8L,6L,8L,7L,8L,9L,12L,10L,12L,11L,12L,13L,15L,14L,15L,16L,17L,18L,21L,19L,21L,20L,21L,22L,23L,24L,26L,25L,26L,27L,30L,28L,30L,29L,30L,31L,33L,32L,33L,34L,35L,36L,38L,37L,38L,39L,40L,41L,44L,42L,44L,43L,44L,45L,46L,47L,49L,48L,49L,50L,53L,51L,53L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205793Inst : IEnumerable<long>
{
public static readonly long[] Value=A205793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205793.Bytes);
public long this[int i]=>Value[i];

public static A205793Inst Instance=new A205793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205794
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205794Inst : IEnumerable<long>
{
public static readonly long[] Value=A205794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205794.Bytes);
public long this[int i]=>Value[i];

public static A205794Inst Instance=new A205794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205795
{
public static readonly BigInteger[] Value={ 24L,2880L,43545600L,5230697472000L,2432902008176640000L,BigInteger.Parse("3102242008666197196800000"),BigInteger.Parse("8841761993739701954543616000000"),BigInteger.Parse("49205466506600690141269768273920000000"),BigInteger.Parse("485663859076129603777149565235783270400000000"),BigInteger.Parse("7911522544013240381082219675638737768808448000000000") };
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
public class A205795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205795Inst Instance=new A205795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205796
{
public static readonly long[] Value={ 1L,9L,33L,69L,427L,1009L,2667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205796Inst : IEnumerable<long>
{
public static readonly long[] Value=A205796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205796.Bytes);
public long this[int i]=>Value[i];

public static A205796Inst Instance=new A205796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205797
{
public static readonly long[] Value={ 1L,1L,41L,126L,1526L,5185L,46920L,176865L,1254608L,4986548L,30563031L,123868761L,683127011L,2793828323L,14223836013L,58127497582L,278433541834L,1130954381904L,5159127957638L,20767403083249L,91032595281699L,362455763000997L,1536849042738162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205797Inst : IEnumerable<long>
{
public static readonly long[] Value=A205797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205797.Bytes);
public long this[int i]=>Value[i];

public static A205797Inst Instance=new A205797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205798
{
public static readonly long[] Value={ 11L,19L,35L,37L,43L,67L,107L,133L,163L,323L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205798Inst : IEnumerable<long>
{
public static readonly long[] Value=A205798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205798.Bytes);
public long this[int i]=>Value[i];

public static A205798Inst Instance=new A205798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205799
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,11L,32L,113L,365L,1373L,6072L,25279L,115633L,606321L,3051413L,16344785L,98402881L,576283953L,3523586227L,23840955908L,158428389359L,1085566420290L,8128568533790L,60203101002122L,455911264482697L,3734114950288571L,30413492882578846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205799Inst : IEnumerable<long>
{
public static readonly long[] Value=A205799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205799.Bytes);
public long this[int i]=>Value[i];

public static A205799Inst Instance=new A205799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205800
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,25L,121L,361L,841L,21841L,547345L,4541041L,23292721L,169658281L,7550279881L,95230199065L,692107448761L,25431412450081L,563675083228321L,9791797014753121L,112525775579561185L,3370231071632996281L,BigInteger.Parse("65798618669268652441"),BigInteger.Parse("1345746844683430533961") };
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
public class A205800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205800Inst Instance=new A205800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205801
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,7L,31L,91L,211L,1681L,52417L,461161L,2427481L,10744471L,219643711L,2619643027L,18939628891L,1410692293921L,23943786881281L,263853697605841L,2237281161036337L,53316533506210471L,900164075618402911L,11265158441537890891UL,BigInteger.Parse("112769404714319769571") };
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
public class A205801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205801Inst Instance=new A205801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205802
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,630L,4200L,31990L,274051L,2608220L,27304530L,311820630L,3857738170L,51397726380L,733698365400L,11171708347799L,180738402744866L,3096027531044102L,55980949167688884L,1065496642477438890L,BigInteger.Parse("21293801805033731190"),BigInteger.Parse("445818117237227995260") };
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
public class A205802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205802Inst Instance=new A205802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205803
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,44L,249L,1693L,13384L,120932L,1229759L,13894429L,172677450L,2341111850L,34385290940L,543885462121L,9217332132024L,166621796893824L,3200275345024464L,65082833538054240L,1397097303096855578L,BigInteger.Parse("31569176387677926733"),BigInteger.Parse("749012642530028865010") };
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
public class A205803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205803Inst Instance=new A205803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205804
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,90L,510L,3395L,25831L,221140L,2104310L,22027170L,251540795L,3111928820L,41460769350L,591847005749L,9011786683883L,145794610986004L,2497443795363566L,45157627509568965L,859494143391347310L,17176870199851102510UL,BigInteger.Parse("359623890969235361700") };
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
public class A205804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205804Inst Instance=new A205804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205805
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,10L,12L,14L,16L,18L,21L,22L,24L,26L,29L,31L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205805Inst : IEnumerable<long>
{
public static readonly long[] Value=A205805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205805.Bytes);
public long this[int i]=>Value[i];

public static A205805Inst Instance=new A205805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205806
{
public static readonly BigInteger[] Value={ 1L,2L,11L,100L,1269L,20680L,411655L,9681040L,262644825L,8074470560L,277410402675L,10533370203200L,438024379604525L,19798139730512000L,966408931916064975L,BigInteger.Parse("50666524133429152000"),BigInteger.Parse("2839464166814487200625"),BigInteger.Parse("169393547843598544960000"),BigInteger.Parse("10717798206604377757886875") };
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
public class A205806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205806Inst Instance=new A205806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205807
{
public static readonly long[] Value={ 7L,12L,13L,20L,21L,26L,30L,31L,35L,50L,56L,57L,63L,70L,72L,73L,82L,90L,91L,99L,100L,111L,117L,130L,132L,133L,143L,155L,176L,182L,183L,190L,195L,196L,208L,221L,222L,247L,255L,272L,273L,301L,304L,305L,306L,307L,324L,330L,336L,357L,371L,380L,381L,392L,407L,425L,438L,475L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205807Inst : IEnumerable<long>
{
public static readonly long[] Value=A205807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205807.Bytes);
public long this[int i]=>Value[i];

public static A205807Inst Instance=new A205807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205808
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205808Inst : IEnumerable<long>
{
public static readonly long[] Value=A205808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205808.Bytes);
public long this[int i]=>Value[i];

public static A205808Inst Instance=new A205808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205809
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205809Inst : IEnumerable<long>
{
public static readonly long[] Value=A205809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205809.Bytes);
public long this[int i]=>Value[i];

public static A205809Inst Instance=new A205809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205810
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,3L,3L,4L,3L,3L,1L,1L,4L,6L,8L,9L,8L,6L,4L,1L,1L,5L,10L,15L,20L,21L,20L,15L,10L,5L,1L,1L,6L,15L,26L,39L,48L,52L,48L,39L,26L,15L,6L,1L,1L,7L,21L,42L,70L,98L,119L,127L,119L,98L,70L,42L,21L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205810Inst : IEnumerable<long>
{
public static readonly long[] Value=A205810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205810.Bytes);
public long this[int i]=>Value[i];

public static A205810Inst Instance=new A205810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205811
{
public static readonly BigInteger[] Value={ 1L,1L,6L,29L,221L,1897L,23502L,335334L,5923570L,119354491L,2758647259L,71079498533L,2031108928680L,63520842121792L,2161164726505952L,79394066773371245L,3133259427956392983L,BigInteger.Parse("132166451829847198316"),BigInteger.Parse("5934636812034634649249"),BigInteger.Parse("282609413111134846839482") };
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
public class A205811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205811Inst Instance=new A205811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205812
{
public static readonly BigInteger[] Value={ 1L,11L,70L,719L,7806L,122534L,2097278L,43444159L,1000262653L,25997950846L,743008372734L,23312187863054L,793714773262334L,29197324076701078L,1152921975865606140L,BigInteger.Parse("48663045048486723199"),BigInteger.Parse("2185911559738696663038"),BigInteger.Parse("104128351926393946602653"),BigInteger.Parse("5242880000000000000524286") };
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
public class A205812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205812Inst Instance=new A205812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205813
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,4L,1L,0L,20L,16L,6L,1L,0L,70L,64L,30L,8L,1L,0L,252L,256L,140L,48L,10L,1L,0L,924L,1024L,630L,256L,70L,12L,1L,0L,3432L,4096L,2772L,1280L,420L,96L,14L,1L,0L,12870L,16384L,12012L,6144L,2310L,640L,126L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205813Inst : IEnumerable<long>
{
public static readonly long[] Value=A205813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205813.Bytes);
public long this[int i]=>Value[i];

public static A205813Inst Instance=new A205813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205814
{
public static readonly BigInteger[] Value={ 1L,1L,9L,54L,482L,4239L,55561L,785554L,14133055L,285547760L,6666380256L,172748192767L,4974178683908L,156462697434990L,5354832107694444L,197710292330150160L,7839473395324929677L,BigInteger.Parse("332071887435037103895"),BigInteger.Parse("14968498613432649146050"),BigInteger.Parse("715294449027151380463781") };
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
public class A205814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205814Inst Instance=new A205814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205815
{
public static readonly BigInteger[] Value={ 1L,17L,136L,1585L,16986L,282338L,4784900L,101750689L,2359918963L,62200943002L,1792160567088L,56765070059074L,1946195069937314L,72080471103535786L,2862427829603121696L,BigInteger.Parse("121449533922041845569"),BigInteger.Parse("5480386857784931063958"),BigInteger.Parse("262149577935595804303451") };
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
public class A205815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205815Inst Instance=new A205815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205816
{
public static readonly BigInteger[] Value={ 24L,216L,2880L,67944L,2791080L,206195280L,27196042704L,6437088838008L,2723887997403024L,2064821553536444652L,BigInteger.Parse("2798458452635665138464") };
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
public class A205816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205816Inst Instance=new A205816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205817
{
public static readonly long[] Value={ 66L,216L,714L,2430L,8274L,28242L,96402L,329130L,1123698L,3836538L,13098738L,44721882L,152690034L,521316378L,1779885426L,6076908954L,20747864946L,70837641882L,241854837618L,825744066714L,2819266591602L,9625578232986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205817Inst : IEnumerable<long>
{
public static readonly long[] Value=A205817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205817.Bytes);
public long this[int i]=>Value[i];

public static A205817Inst Instance=new A205817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205818
{
public static readonly long[] Value={ 180L,714L,2880L,12318L,53100L,230532L,1002240L,4361064L,18980472L,82617132L,359622708L,1565418528L,6814215036L,29662110636L,129118523304L,562050276348L,2446593518052L,10649972628456L,46359118343628L,201800318106108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205818Inst : IEnumerable<long>
{
public static readonly long[] Value=A205818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205818.Bytes);
public long this[int i]=>Value[i];

public static A205818Inst Instance=new A205818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205819
{
public static readonly long[] Value={ 492L,2430L,12318L,67944L,380568L,2158482L,12281976L,70022628L,399463842L,2279603796L,13010464716L,74259457206L,423858388308L,2419327070832L,13809259294038L,78821939400948L,449908555238976L,2568038752491042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205819Inst : IEnumerable<long>
{
public static readonly long[] Value=A205819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205819.Bytes);
public long this[int i]=>Value[i];

public static A205819Inst Instance=new A205819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205820
{
public static readonly long[] Value={ 1344L,8274L,53100L,380568L,2791080L,20842578L,156410676L,1177361316L,8870853996L,66873761742L,504225673728L,3802217597802L,28672407717948L,216221748724626L,1630562796353904L,12296378355562308L,92729406038121768L,699291160811405796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205820Inst : IEnumerable<long>
{
public static readonly long[] Value=A205820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205820.Bytes);
public long this[int i]=>Value[i];

public static A205820Inst Instance=new A205820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205821
{
public static readonly long[] Value={ 3672L,28242L,230532L,2158482L,20842578L,206195280L,2053746000L,20547395916L,205854316380L,2064129121566L,20703020123544L,207684698582640L,2083530777092724L,20903078814105732L,209713177538231946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205821Inst : IEnumerable<long>
{
public static readonly long[] Value=A205821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205821.Bytes);
public long this[int i]=>Value[i];

public static A205821Inst Instance=new A205821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205822
{
public static readonly long[] Value={ 10032L,96402L,1002240L,12281976L,156410676L,2053746000L,27196042704L,362290015758L,4834444163676L,64590005130132L,863239060201212L,11540056054532778L,154281470426981232L,2062735520293913052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205822Inst : IEnumerable<long>
{
public static readonly long[] Value=A205822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205822.Bytes);
public long this[int i]=>Value[i];

public static A205822Inst Instance=new A205822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205823
{
public static readonly long[] Value={ 24L,66L,66L,180L,216L,180L,492L,714L,714L,492L,1344L,2430L,2880L,2430L,1344L,3672L,8274L,12318L,12318L,8274L,3672L,10032L,28242L,53100L,67944L,53100L,28242L,10032L,27408L,96402L,230532L,380568L,380568L,230532L,96402L,27408L,74880L,329130L,1002240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205823Inst : IEnumerable<long>
{
public static readonly long[] Value=A205823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205823.Bytes);
public long this[int i]=>Value[i];

public static A205823Inst Instance=new A205823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205824
{
public static readonly BigInteger[] Value={ 1L,10L,280L,13860L,1009008L,98017920L,11972188800L,1766895530400L,306261891936000L,61040779261862400L,13761921142674432000UL,BigInteger.Parse("3464298995338621440000"),BigInteger.Parse("963455812901426718720000"),BigInteger.Parse("293441113300834537758720000") };
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
public class A205824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205824Inst Instance=new A205824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205825
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,20L,120L,210L,1680L,3024L,30240L,55440L,665280L,1235520L,17297280L,32432400L,518918400L,980179200L,17643225600L,33522128640L,670442572800L,1279935820800L,28158588057600L,53970627110400L,1295295050649600L,2490952020480000L,64764752532480000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205825Inst : IEnumerable<long>
{
public static readonly long[] Value=A205825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205825.Bytes);
public long this[int i]=>Value[i];

public static A205825Inst Instance=new A205825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205826
{
public static readonly long[] Value={ 1L,-3L,3L,-1L,0L,0L,0L,-3L,9L,-9L,3L,-3L,9L,-12L,15L,-18L,12L,-6L,18L,-39L,48L,-46L,36L,-24L,37L,-75L,96L,-90L,81L,-78L,99L,-165L,222L,-199L,147L,-150L,208L,-306L,411L,-424L,345L,-327L,442L,-606L,735L,-756L,645L,-606L,837L,-1182L,1386L,-1405L,1281L,-1188L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205826Inst : IEnumerable<long>
{
public static readonly long[] Value=A205826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205826.Bytes);
public long this[int i]=>Value[i];

public static A205826Inst Instance=new A205826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205827
{
public static readonly long[] Value={ 2L,3L,7L,23L,113L,1129L,1327L,19609L,31397L,155921L,360653L,370261L,1357201L,2010733L,17051707L,20831323L,191912783L,436273009L,2300942549L,3842610773L,4302407359L,10726904659L,25056082087L,304599508537L,461690510011L,1346294310749L,1408695493609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205827Inst : IEnumerable<long>
{
public static readonly long[] Value=A205827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205827.Bytes);
public long this[int i]=>Value[i];

public static A205827Inst Instance=new A205827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205828
{
public static readonly BigInteger[] Value={ 30L,630L,32106L,3875376L,1105752330L,745699860222L,1189207742465910L,4487032707620997018L,BigInteger.Parse("40071390912674727590454"),BigInteger.Parse("847234959807682079504883018"),BigInteger.Parse("42418662789019636446257162237448") };
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
public class A205828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205828Inst Instance=new A205828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205829
{
public static readonly long[] Value={ 30L,111L,423L,1611L,6132L,23340L,88839L,338148L,1287093L,4899063L,18647307L,70977258L,270160788L,1028313201L,3914069274L,14898124683L,56706742659L,215842915227L,821563042932L,3127115999160L,11902743868935L,45305422519512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205829Inst : IEnumerable<long>
{
public static readonly long[] Value=A205829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205829.Bytes);
public long this[int i]=>Value[i];

public static A205829Inst Instance=new A205829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205830
{
public static readonly long[] Value={ 111L,630L,3642L,21126L,122526L,710526L,4120230L,23892558L,138549222L,803425470L,4658939862L,27016470606L,156664328166L,908472171486L,5268089398710L,30548834388078L,177147958555782L,1027253571178110L,5956884336128982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205830Inst : IEnumerable<long>
{
public static readonly long[] Value=A205830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205830.Bytes);
public long this[int i]=>Value[i];

public static A205830Inst Instance=new A205830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205831
{
public static readonly long[] Value={ 423L,3642L,32106L,284910L,2531223L,22488006L,199775148L,1774684842L,15765175170L,140047755324L,1244095016967L,11051748079860L,98176695538581L,872139276184362L,7747530234577809L,68824127481596856L,611389743559128132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205831Inst : IEnumerable<long>
{
public static readonly long[] Value=A205831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205831.Bytes);
public long this[int i]=>Value[i];

public static A205831Inst Instance=new A205831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205832
{
public static readonly ulong[] Value={ 1611L,21126L,284910L,3875376L,52826862L,720376872L,9823579164L,133958429916L,1826692958490L,24909186485886L,339666855267840L,4631767319478810L,63159734164254090L,861259161426563160L,11744307584029537416UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205832Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A205832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205832.Bytes);
public ulong this[int i]=>Value[i];

public static A205832Inst Instance=new A205832Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205833
{
public static readonly BigInteger[] Value={ 6132L,122526L,2531223L,52826862L,1105752330L,23163320754L,485313697782L,10168541874792L,213057191546673L,4464093891685218L,93534131935237503L,1959777527759278002L,BigInteger.Parse("41062309396848183363"),BigInteger.Parse("860359480739604665088") };
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
public class A205833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205833Inst Instance=new A205833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205834
{
public static readonly BigInteger[] Value={ 23340L,710526L,22488006L,720376872L,23163320754L,745699860222L,24015926216514L,773556773975484L,24917497813440492L,802644416569685118L,BigInteger.Parse("25854975349134338424"),BigInteger.Parse("832848064828756464702"),BigInteger.Parse("26827960607597793524724") };
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
public class A205834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205834Inst Instance=new A205834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205835
{
public static readonly BigInteger[] Value={ 88839L,4120230L,199775148L,9823579164L,485313697782L,24015926216514L,1189207742465910L,58902272401918020L,2917798904031864318L,BigInteger.Parse("144543808321651240674"),BigInteger.Parse("7160650215359939671695"),BigInteger.Parse("354739170301504007421582") };
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
public class A205835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205835Inst Instance=new A205835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205836
{
public static readonly long[] Value={ 30L,111L,111L,423L,630L,423L,1611L,3642L,3642L,1611L,6132L,21126L,32106L,21126L,6132L,23340L,122526L,284910L,284910L,122526L,23340L,88839L,710526L,2531223L,3875376L,2531223L,710526L,88839L,338148L,4120230L,22488006L,52826862L,52826862L,22488006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205836Inst : IEnumerable<long>
{
public static readonly long[] Value=A205836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205836.Bytes);
public long this[int i]=>Value[i];

public static A205836Inst Instance=new A205836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205837
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205837Inst : IEnumerable<long>
{
public static readonly long[] Value=A205837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205837.Bytes);
public long this[int i]=>Value[i];

public static A205837Inst Instance=new A205837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205838
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,3L,4L,1L,3L,4L,6L,2L,5L,1L,3L,4L,6L,7L,1L,3L,4L,6L,7L,9L,2L,5L,8L,1L,3L,4L,6L,7L,9L,10L,1L,3L,4L,6L,7L,9L,10L,12L,2L,5L,8L,11L,1L,3L,4L,6L,7L,9L,10L,12L,13L,1L,3L,4L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205838Inst : IEnumerable<long>
{
public static readonly long[] Value=A205838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205838.Bytes);
public long this[int i]=>Value[i];

public static A205838Inst Instance=new A205838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205839
{
public static readonly long[] Value={ 2L,4L,2L,6L,12L,10L,8L,20L,18L,16L,8L,32L,26L,54L,52L,50L,42L,34L,88L,86L,84L,76L,68L,34L,142L,136L,110L,232L,230L,228L,220L,212L,178L,144L,376L,374L,372L,364L,356L,322L,288L,144L,608L,602L,576L,466L,986L,984L,982L,974L,966L,932L,898L,754L,610L,1596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205839Inst : IEnumerable<long>
{
public static readonly long[] Value=A205839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205839.Bytes);
public long this[int i]=>Value[i];

public static A205839Inst Instance=new A205839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205840
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,5L,4L,10L,9L,8L,4L,16L,13L,27L,26L,25L,21L,17L,44L,43L,42L,38L,34L,17L,71L,68L,55L,116L,115L,114L,110L,106L,89L,72L,188L,187L,186L,182L,178L,161L,144L,72L,304L,301L,288L,233L,493L,492L,491L,487L,483L,466L,449L,377L,305L,798L,797L,796L,792L,788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205840Inst : IEnumerable<long>
{
public static readonly long[] Value=A205840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205840.Bytes);
public long this[int i]=>Value[i];

public static A205840Inst Instance=new A205840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205841
{
public static readonly long[] Value={ 5L,8L,10L,11L,18L,22L,27L,29L,34L,36L,38L,40L,41L,48L,52L,57L,59L,60L,65L,68L,70L,71L,76L,78L,79L,84L,86L,87L,94L,98L,102L,106L,111L,113L,114L,119L,121L,126L,128L,129L,134L,136L,138L,140L,141L,146L,148L,149L,156L,160L,164L,168L,173L,175L,176L,181L,183L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205841Inst : IEnumerable<long>
{
public static readonly long[] Value=A205841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205841.Bytes);
public long this[int i]=>Value[i];

public static A205841Inst Instance=new A205841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205842
{
public static readonly long[] Value={ 4L,5L,5L,6L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205842Inst : IEnumerable<long>
{
public static readonly long[] Value=A205842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205842.Bytes);
public long this[int i]=>Value[i];

public static A205842Inst Instance=new A205842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205843
{
public static readonly long[] Value={ 2L,2L,4L,1L,3L,1L,6L,1L,6L,8L,2L,4L,5L,3L,7L,2L,4L,5L,10L,2L,4L,5L,10L,12L,1L,6L,8L,9L,3L,7L,11L,1L,6L,8L,9L,14L,1L,6L,8L,9L,14L,16L,2L,4L,5L,10L,12L,13L,3L,7L,11L,15L,2L,4L,5L,10L,12L,13L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205843Inst : IEnumerable<long>
{
public static readonly long[] Value=A205843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205843.Bytes);
public long this[int i]=>Value[i];

public static A205843Inst Instance=new A205843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205844
{
public static readonly long[] Value={ 3L,6L,3L,12L,18L,33L,21L,54L,42L,21L,87L,84L,81L,141L,123L,231L,228L,225L,144L,375L,372L,369L,288L,144L,609L,597L,576L,555L,984L,966L,843L,1596L,1584L,1563L,1542L,987L,2583L,2571L,2550L,2529L,1974L,987L,4179L,4176L,4173L,4092L,3948L,3804L,6762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205844Inst : IEnumerable<long>
{
public static readonly long[] Value=A205844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205844.Bytes);
public long this[int i]=>Value[i];

public static A205844Inst Instance=new A205844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205845
{
public static readonly long[] Value={ 1L,2L,1L,4L,6L,11L,7L,18L,14L,7L,29L,28L,27L,47L,41L,77L,76L,75L,48L,125L,124L,123L,96L,48L,203L,199L,192L,185L,328L,322L,281L,532L,528L,521L,514L,329L,861L,857L,850L,843L,658L,329L,1393L,1392L,1391L,1364L,1316L,1268L,2254L,2248L,2207L,1926L,3648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205845Inst : IEnumerable<long>
{
public static readonly long[] Value=A205845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205845.Bytes);
public long this[int i]=>Value[i];

public static A205845Inst Instance=new A205845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205846
{
public static readonly long[] Value={ 4L,11L,14L,16L,19L,21L,23L,31L,37L,40L,42L,43L,50L,56L,59L,61L,62L,65L,67L,70L,72L,73L,76L,78L,80L,86L,94L,100L,106L,109L,111L,112L,115L,117L,118L,125L,131L,137L,140L,142L,143L,146L,148L,149L,152L,154L,157L,159L,160L,163L,165L,166L,169L,171L,173L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205846Inst : IEnumerable<long>
{
public static readonly long[] Value=A205846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205846.Bytes);
public long this[int i]=>Value[i];

public static A205846Inst Instance=new A205846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205847
{
public static readonly long[] Value={ 4L,6L,6L,7L,7L,7L,8L,9L,10L,10L,10L,10L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,18L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205847Inst : IEnumerable<long>
{
public static readonly long[] Value=A205847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205847.Bytes);
public long this[int i]=>Value[i];

public static A205847Inst Instance=new A205847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205848
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,6L,2L,3L,1L,4L,6L,7L,5L,1L,4L,6L,7L,10L,1L,4L,6L,7L,10L,12L,2L,8L,3L,9L,1L,4L,6L,7L,10L,12L,13L,5L,11L,1L,4L,6L,7L,10L,12L,13L,16L,1L,4L,6L,7L,10L,12L,13L,16L,18L,2L,8L,14L,3L,9L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205848Inst : IEnumerable<long>
{
public static readonly long[] Value=A205848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205848.Bytes);
public long this[int i]=>Value[i];

public static A205848Inst Instance=new A205848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205849
{
public static readonly long[] Value={ 4L,12L,8L,20L,16L,8L,32L,52L,88L,84L,76L,68L,136L,232L,228L,220L,212L,144L,376L,372L,364L,356L,288L,144L,608L,576L,984L,932L,1596L,1592L,1584L,1576L,1508L,1364L,1220L,2576L,2440L,4180L,4176L,4168L,4160L,4092L,3948L,3804L,2584L,6764L,6760L,6752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205849Inst : IEnumerable<long>
{
public static readonly long[] Value=A205849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205849.Bytes);
public long this[int i]=>Value[i];

public static A205849Inst Instance=new A205849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205850
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,2L,8L,13L,22L,21L,19L,17L,34L,58L,57L,55L,53L,36L,94L,93L,91L,89L,72L,36L,152L,144L,246L,233L,399L,398L,396L,394L,377L,341L,305L,644L,610L,1045L,1044L,1042L,1040L,1023L,987L,951L,646L,1691L,1690L,1688L,1686L,1669L,1633L,1597L,1292L,646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205850Inst : IEnumerable<long>
{
public static readonly long[] Value=A205850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205850.Bytes);
public long this[int i]=>Value[i];

public static A205850Inst Instance=new A205850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205851
{
public static readonly long[] Value={ 9L,13L,15L,16L,32L,44L,53L,55L,58L,60L,61L,68L,82L,87L,93L,104L,107L,118L,120L,128L,130L,131L,137L,143L,157L,162L,167L,172L,178L,189L,191L,197L,208L,210L,212L,223L,225L,226L,234L,236L,237L,243L,257L,262L,267L,272L,279L,281L,282L,288L,299L,303L,305L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205851Inst : IEnumerable<long>
{
public static readonly long[] Value=A205851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205851.Bytes);
public long this[int i]=>Value[i];

public static A205851Inst Instance=new A205851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205852
{
public static readonly long[] Value={ 5L,6L,6L,7L,9L,10L,11L,11L,12L,12L,12L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,26L,26L,26L,26L,26L,26L,27L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205852Inst : IEnumerable<long>
{
public static readonly long[] Value=A205852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205852.Bytes);
public long this[int i]=>Value[i];

public static A205852Inst Instance=new A205852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205853
{
public static readonly long[] Value={ 3L,3L,5L,1L,4L,8L,8L,10L,3L,5L,6L,2L,4L,9L,2L,13L,2L,13L,15L,8L,10L,11L,1L,7L,4L,9L,14L,1L,7L,18L,1L,7L,18L,20L,2L,13L,15L,16L,3L,5L,6L,12L,4L,9L,14L,19L,3L,5L,6L,12L,23L,3L,5L,6L,12L,23L,25L,1L,7L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205853Inst : IEnumerable<long>
{
public static readonly long[] Value=A205853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205853.Bytes);
public long this[int i]=>Value[i];

public static A205853Inst Instance=new A205853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205854
{
public static readonly long[] Value={ 5L,10L,5L,20L,50L,55L,110L,55L,230L,225L,220L,375L,605L,555L,985L,610L,1595L,1220L,610L,2550L,2495L,2440L,4180L,4160L,6760L,6710L,6155L,10945L,10925L,6765L,17710L,17690L,13530L,6765L,28655L,28280L,27670L,27060L,46365L,46360L,46355L,46135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205854Inst : IEnumerable<long>
{
public static readonly long[] Value=A205854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205854.Bytes);
public long this[int i]=>Value[i];

public static A205854Inst Instance=new A205854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205855
{
public static readonly long[] Value={ 1L,2L,1L,4L,10L,11L,22L,11L,46L,45L,44L,75L,121L,111L,197L,122L,319L,244L,122L,510L,499L,488L,836L,832L,1352L,1342L,1231L,2189L,2185L,1353L,3542L,3538L,2706L,1353L,5731L,5656L,5534L,5412L,9273L,9272L,9271L,9227L,15004L,14994L,14883L,13652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205855Inst : IEnumerable<long>
{
public static readonly long[] Value=A205855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205855.Bytes);
public long this[int i]=>Value[i];

public static A205855Inst Instance=new A205855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205856
{
public static readonly long[] Value={ 8L,11L,18L,29L,34L,40L,59L,65L,70L,76L,78L,86L,94L,98L,106L,111L,114L,128L,134L,140L,146L,148L,149L,156L,160L,168L,173L,176L,194L,200L,202L,203L,208L,211L,216L,219L,226L,242L,254L,259L,262L,269L,275L,277L,282L,285L,292L,298L,300L,302L,305L,320L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205856Inst : IEnumerable<long>
{
public static readonly long[] Value=A205856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205856.Bytes);
public long this[int i]=>Value[i];

public static A205856Inst Instance=new A205856Inst();

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