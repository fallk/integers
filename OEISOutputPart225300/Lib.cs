using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275962
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,2L,3L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,2L,3L,0L,0L,0L,0L,0L,2L,2L,2L,2L,2L,2L,4L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,2L,3L,0L,0L,2L,2L,0L,2L,0L,0L,2L,2L,0L,2L,2L,2L,3L,3L,2L,4L,0L,2L,2L,4L,2L,3L,0L,2L,0L,2L,2L,3L,0L,2L,0L,2L,2L,3L,0L,2L,2L,4L,2L,3L,2L,3L,2L,3L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275962Inst : IEnumerable<long>
{
public static readonly long[] Value=A275962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275962.Bytes);
public long this[int i]=>Value[i];

public static A275962Inst Instance=new A275962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275963
{
public static readonly BigInteger[] Value={ 18L,234L,2244L,22098L,237594L,2743164L,33556818L,441925794L,12449045364L,267703255698L,5497712563434L,112804699752300L,2358022995718578L,51007863864388434L,1135446810698914644L,BigInteger.Parse("26241095309660220138"),BigInteger.Parse("626391138692542250154"),BigInteger.Parse("15519080113275337003404"),BigInteger.Parse("397364781519139001021778"),BigInteger.Parse("10545585096254938755221394"),BigInteger.Parse("289700229771377481566636364") };
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
public class A275963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275963Inst Instance=new A275963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275964
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,2L,3L,3L,4L,2L,3L,0L,2L,2L,3L,2L,4L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,0L,2L,2L,3L,2L,4L,2L,2L,2L,4L,3L,3L,0L,0L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,2L,2L,2L,4L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275964Inst : IEnumerable<long>
{
public static readonly long[] Value=A275964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275964.Bytes);
public long this[int i]=>Value[i];

public static A275964Inst Instance=new A275964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275965
{
public static readonly BigInteger[] Value={ 1L,4L,18L,216L,1794L,16050L,161748L,1754886L,20252058L,257046648L,9715067802L,169069882650L,3334258948644L,65130972856014L,1314162130657122L,27756075741907992L,599859130159322082L,13631049605170919850UL,BigInteger.Parse("318062816759187443364"),BigInteger.Parse("7775218520916136276470"),BigInteger.Parse("195524294317191054759258"),BigInteger.Parse("5132224614520884668600904"),BigInteger.Parse("139264442985628101392954898") };
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
public class A275965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275965Inst Instance=new A275965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275966
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,0L,2L,-2L,0L,2L,0L,-2L,0L,0L,2L,0L,0L,0L,-2L,-2L,0L,4L,2L,-2L,0L,0L,0L,-2L,0L,0L,0L,-2L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,-4L,-2L,0L,0L,2L,-2L,0L,2L,0L,0L,0L,0L,2L,0L,0L,4L,0L,-2L,0L,0L,2L,-4L,0L,0L,-4L,-2L,0L,4L,0L,-2L,0L,0L,0L,0L,0L,4L,0L,-2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275966Inst : IEnumerable<long>
{
public static readonly long[] Value=A275966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275966.Bytes);
public long this[int i]=>Value[i];

public static A275966Inst Instance=new A275966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275967
{
public static readonly long[] Value={ 9L,2L,5L,8L,3L,7L,0L,5L,7L,6L,1L,3L,8L,8L,6L,0L,0L,8L,3L,7L,6L,8L,9L,1L,2L,1L,2L,3L,3L,5L,4L,1L,1L,0L,9L,6L,8L,9L,2L,7L,8L,2L,9L,6L,1L,1L,6L,8L,3L,0L,0L,9L,2L,2L,1L,9L,6L,0L,1L,6L,8L,1L,5L,8L,4L,2L,3L,4L,9L,0L,9L,3L,1L,9L,5L,3L,2L,2L,9L,7L,9L,2L,1L,5L,1L,9L,2L,7L,2L,3L,5L,3L,1L,8L,4L,6L,6L,8L,9L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275967Inst : IEnumerable<long>
{
public static readonly long[] Value=A275967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275967.Bytes);
public long this[int i]=>Value[i];

public static A275967Inst Instance=new A275967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275968
{
public static readonly long[] Value={ 173L,409L,419L,421L,439L,487L,521L,557L,571L,617L,761L,887L,919L,1009L,1039L,1117L,1153L,1171L,1217L,1327L,1373L,1549L,1559L,1571L,1657L,1693L,1709L,1721L,1733L,1783L,1831L,1861L,1901L,1993L,1997L,2053L,2089L,2339L,2393L,2521L,2539L,2647L,2657L,2677L,2693L,2777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275968Inst : IEnumerable<long>
{
public static readonly long[] Value=A275968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275968.Bytes);
public long this[int i]=>Value[i];

public static A275968Inst Instance=new A275968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275969
{
public static readonly long[] Value={ 3L,5L,13L,17L,51L,85L,193L,257L,769L,1285L,3281L,4369L,12289L,21845L,49601L,65537L,196611L,327685L,786433L,1114129L,3158273L,5570645L,12648641L,16843009L,50397953L,84215045L,202113281L,286331153L,805384193L,1431655765L,3221225473L,8168859365L,12952273921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275969Inst : IEnumerable<long>
{
public static readonly long[] Value=A275969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275969.Bytes);
public long this[int i]=>Value[i];

public static A275969Inst Instance=new A275969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275970
{
public static readonly long[] Value={ 2L,6L,13L,26L,51L,100L,197L,390L,775L,1544L,3081L,6154L,12299L,24588L,49165L,98318L,196623L,393232L,786449L,1572882L,3145747L,6291476L,12582933L,25165846L,50331671L,100663320L,201326617L,402653210L,805306395L,1610612764L,3221225501L,6442450974L,12884901919L,25769803808L,51539607585L,103079215138L,206158430243L,412316860452L,824633720869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275970Inst : IEnumerable<long>
{
public static readonly long[] Value=A275970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275970.Bytes);
public long this[int i]=>Value[i];

public static A275970Inst Instance=new A275970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275971
{
public static readonly long[] Value={ 5L,15L,85L,165L,235L,485L,1665L,1885L,4835L,5765L,7585L,15085L,15885L,16665L,18365L,18915L,22885L,27115L,27885L,50235L,57665L,58115L,72335L,85635L,87885L,150915L,166665L,182415L,194235L,194365L,229635L,240365L,268835L,503515L,507665L,524915L,568835L,570415L,577515L,581165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275971Inst : IEnumerable<long>
{
public static readonly long[] Value=A275971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275971.Bytes);
public long this[int i]=>Value[i];

public static A275971Inst Instance=new A275971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275972
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,5L,5L,8L,7L,11L,11L,15L,14L,21L,20L,28L,26L,38L,35L,51L,45L,65L,61L,82L,74L,108L,97L,130L,116L,161L,148L,201L,176L,238L,224L,288L,258L,354L,317L,416L,373L,501L,453L,596L,525L,705L,638L,833L,727L,993L,876L,1148L,1007L,1336L,1199L,1583L,1366L,1816L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275972Inst : IEnumerable<long>
{
public static readonly long[] Value=A275972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275972.Bytes);
public long this[int i]=>Value[i];

public static A275972Inst Instance=new A275972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275973
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275973Inst : IEnumerable<long>
{
public static readonly long[] Value=A275973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275973.Bytes);
public long this[int i]=>Value[i];

public static A275973Inst Instance=new A275973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275974
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,3L,3L,3L,4L,5L,6L,7L,8L,9L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,43L,43L,43L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275974Inst : IEnumerable<long>
{
public static readonly long[] Value=A275974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275974.Bytes);
public long this[int i]=>Value[i];

public static A275974Inst Instance=new A275974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275975
{
public static readonly long[] Value={ 3L,0L,8L,6L,0L,9L,0L,0L,8L,5L,5L,6L,2L,3L,1L,8L,5L,6L,4L,0L,0L,3L,4L,0L,4L,7L,9L,7L,1L,8L,0L,2L,5L,2L,2L,1L,6L,9L,7L,4L,3L,3L,9L,0L,4L,1L,6L,6L,4L,4L,1L,3L,6L,6L,8L,0L,1L,3L,6L,7L,2L,2L,1L,1L,5L,6L,9L,4L,4L,3L,8L,5L,8L,0L,5L,4L,6L,1L,9L,7L,2L,2L,7L,6L,6L,2L,4L,8L,7L,5L,6L,4L,0L,8L,5L,3L,5L,0L,7L,0L,8L,6L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275975Inst : IEnumerable<long>
{
public static readonly long[] Value=A275975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275975.Bytes);
public long this[int i]=>Value[i];

public static A275975Inst Instance=new A275975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275976
{
public static readonly long[] Value={ 5L,1L,5L,5L,1L,2L,4L,3L,4L,0L,0L,7L,4L,6L,4L,4L,0L,5L,5L,1L,4L,1L,6L,1L,9L,3L,3L,7L,5L,6L,5L,2L,2L,8L,2L,8L,7L,4L,8L,5L,7L,6L,0L,4L,5L,1L,8L,8L,1L,1L,0L,0L,2L,4L,8L,3L,1L,4L,3L,1L,1L,0L,7L,7L,6L,9L,7L,3L,5L,0L,2L,9L,8L,8L,6L,6L,9L,4L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275976Inst : IEnumerable<long>
{
public static readonly long[] Value=A275976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275976.Bytes);
public long this[int i]=>Value[i];

public static A275976Inst Instance=new A275976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275977
{
public static readonly long[] Value={ 4L,7L,8L,2L,2L,0L,2L,7L,8L,8L,0L,5L,4L,6L,1L,2L,0L,2L,9L,5L,2L,8L,3L,9L,2L,9L,8L,6L,6L,0L,0L,0L,5L,9L,0L,9L,7L,4L,1L,4L,9L,7L,1L,7L,2L,4L,0L,2L,2L,3L,6L,5L,0L,0L,8L,5L,1L,3L,3L,4L,5L,1L,0L,9L,9L,1L,8L,3L,7L,8L,9L,5L,0L,9L,4L,2L,6L,6L,2L,9L,7L,0L,2L,7L,8L,9L,2L,7L,6L,8L,6L,1L,1L,2L,7L,0L,7L,8L,9L,4L,5L,8L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275977Inst : IEnumerable<long>
{
public static readonly long[] Value=A275977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275977.Bytes);
public long this[int i]=>Value[i];

public static A275977Inst Instance=new A275977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275978
{
public static readonly long[] Value={ 1L,4L,6L,12L,34L,54L,60L,61L,73L,148L,349L,552L,649L,967L,1044L,2521L,4501L,5721L,6133L,9052L,9880L,16126L,16215L,19146L,61770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275978Inst : IEnumerable<long>
{
public static readonly long[] Value=A275978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275978.Bytes);
public long this[int i]=>Value[i];

public static A275978Inst Instance=new A275978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275979
{
public static readonly long[] Value={ 3L,4L,6L,0L,8L,8L,2L,8L,2L,4L,9L,0L,8L,5L,1L,2L,1L,5L,2L,4L,2L,9L,6L,0L,3L,9L,5L,7L,6L,7L,4L,1L,3L,3L,1L,6L,7L,2L,2L,6L,2L,8L,6L,6L,8L,9L,0L,0L,2L,3L,8L,5L,4L,7L,7L,9L,0L,4L,8L,9L,2L,8L,3L,4L,4L,5L,0L,0L,6L,2L,2L,0L,8L,0L,9L,8L,3L,4L,1L,1L,4L,4L,6L,4L,3L,6L,4L,3L,7L,5L,5L,4L,4L,1L,5L,3L,7L,0L,7L,5L,3L,3L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275979Inst : IEnumerable<long>
{
public static readonly long[] Value=A275979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275979.Bytes);
public long this[int i]=>Value[i];

public static A275979Inst Instance=new A275979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275980
{
public static readonly long[] Value={ 2L,8L,1L,4L,1L,1L,2L,0L,1L,3L,6L,9L,7L,3L,7L,3L,1L,3L,3L,3L,9L,3L,1L,5L,2L,9L,7L,5L,8L,4L,2L,5L,8L,4L,1L,9L,1L,8L,1L,8L,6L,6L,2L,3L,8L,2L,0L,1L,3L,6L,0L,0L,7L,8L,7L,8L,9L,2L,4L,1L,9L,3L,4L,9L,3L,4L,5L,5L,1L,5L,1L,7L,6L,6L,8L,2L,2L,7L,6L,3L,1L,3L,8L,1L,0L,7L,1L,5L,0L,9L,4L,7L,4L,5L,6L,3L,3L,2L,5L,7L,0L,7L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275980Inst : IEnumerable<long>
{
public static readonly long[] Value=A275980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275980.Bytes);
public long this[int i]=>Value[i];

public static A275980Inst Instance=new A275980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275981
{
public static readonly long[] Value={ 4L,3L,1L,5L,4L,2L,4L,7L,9L,7L,3L,8L,8L,1L,6L,2L,6L,4L,8L,0L,5L,5L,2L,3L,5L,5L,1L,6L,3L,3L,7L,9L,1L,9L,8L,3L,9L,0L,5L,3L,9L,3L,5L,0L,4L,3L,2L,2L,6L,7L,1L,1L,5L,0L,5L,1L,6L,5L,2L,5L,0L,5L,4L,1L,4L,0L,3L,3L,3L,0L,6L,8L,0L,1L,3L,7L,6L,5L,8L,0L,9L,1L,1L,3L,0L,4L,5L,1L,3L,6L,2L,9L,3L,1L,8L,5L,8L,4L,6L,6L,5L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275981Inst : IEnumerable<long>
{
public static readonly long[] Value=A275981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275981.Bytes);
public long this[int i]=>Value[i];

public static A275981Inst Instance=new A275981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275982
{
public static readonly long[] Value={ 4L,4L,8L,6L,7L,9L,1L,6L,6L,1L,1L,9L,0L,4L,3L,3L,3L,4L,7L,9L,4L,9L,5L,1L,4L,1L,0L,3L,6L,1L,5L,9L,1L,7L,7L,8L,7L,2L,7L,2L,0L,9L,0L,2L,3L,7L,2L,9L,3L,8L,8L,6L,1L,3L,0L,1L,0L,3L,6L,4L,8L,0L,4L,4L,7L,5L,1L,2L,7L,8L,5L,6L,0L,9L,1L,5L,8L,0L,5L,3L,6L,3L,7L,1L,6L,2L,0L,1L,8L,3L,9L,5L,9L,2L,0L,1L,8L,3L,1L,0L,8L,6L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275982Inst : IEnumerable<long>
{
public static readonly long[] Value=A275982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275982.Bytes);
public long this[int i]=>Value[i];

public static A275982Inst Instance=new A275982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275983
{
public static readonly long[] Value={ 4L,0L,2L,8L,7L,4L,1L,1L,5L,7L,7L,8L,9L,8L,8L,7L,7L,8L,1L,8L,1L,8L,7L,3L,3L,2L,9L,0L,7L,1L,5L,9L,1L,7L,6L,7L,7L,2L,2L,4L,3L,8L,5L,0L,6L,8L,9L,1L,6L,2L,2L,4L,2L,0L,0L,4L,1L,0L,2L,9L,9L,6L,3L,5L,7L,8L,6L,9L,4L,5L,9L,5L,2L,4L,0L,8L,8L,7L,4L,0L,0L,8L,6L,7L,6L,3L,9L,8L,6L,1L,4L,6L,1L,4L,6L,6L,5L,3L,7L,1L,0L,3L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275983Inst : IEnumerable<long>
{
public static readonly long[] Value=A275983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275983.Bytes);
public long this[int i]=>Value[i];

public static A275983Inst Instance=new A275983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275984
{
public static readonly long[] Value={ 8L,5L,4L,5L,0L,9L,8L,2L,4L,3L,0L,3L,6L,3L,3L,8L,0L,3L,1L,9L,3L,3L,0L,0L,7L,0L,5L,3L,1L,8L,4L,0L,3L,0L,3L,6L,5L,0L,9L,9L,0L,1L,5L,9L,1L,3L,0L,4L,0L,2L,1L,0L,5L,8L,3L,4L,3L,2L,6L,9L,2L,5L,8L,2L,8L,2L,2L,9L,0L,0L,6L,4L,7L,8L,2L,1L,6L,7L,6L,3L,5L,8L,5L,6L,2L,0L,0L,5L,0L,0L,0L,1L,4L,4L,5L,7L,6L,4L,5L,8L,6L,1L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275984Inst : IEnumerable<long>
{
public static readonly long[] Value=A275984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275984.Bytes);
public long this[int i]=>Value[i];

public static A275984Inst Instance=new A275984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275985
{
public static readonly long[] Value={ 1L,3L,6L,4L,10L,6L,14L,4L,7L,10L,22L,6L,26L,14L,10L,5L,34L,7L,38L,10L,14L,22L,46L,6L,11L,26L,9L,14L,58L,10L,62L,5L,22L,34L,14L,7L,74L,38L,26L,10L,82L,14L,86L,22L,10L,46L,94L,6L,21L,11L,34L,26L,106L,9L,22L,14L,38L,58L,118L,10L,122L,62L,14L,6L,26L,22L,134L,34L,46L,14L,142L,7L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275985Inst : IEnumerable<long>
{
public static readonly long[] Value=A275985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275985.Bytes);
public long this[int i]=>Value[i];

public static A275985Inst Instance=new A275985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275986
{
public static readonly long[] Value={ 101L,1233L,8833L,10001L,10100L,990100L,1000001L,5882353L,94122353L,99009901L,100000001L,100010000L,1765038125L,2584043776L,7416043776L,8235038125L,9901009901L,10000000001L,48600220401L,116788321168L,123288328768L,601300773101L,876712328768L,883212321168L,990100990100L,999900010000L,1000000000001L,1000001000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275986Inst : IEnumerable<long>
{
public static readonly long[] Value=A275986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275986.Bytes);
public long this[int i]=>Value[i];

public static A275986Inst Instance=new A275986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275987
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,6L,12L,13L,14L,14L,16L,10L,18L,19L,20L,21L,22L,14L,24L,16L,20L,27L,28L,29L,30L,21L,32L,33L,34L,33L,36L,37L,24L,28L,40L,20L,42L,43L,44L,45L,30L,33L,48L,49L,50L,30L,52L,34L,54L,30L,54L,57L,40L,24L,60L,61L,42L,63L,64L,44L,66L,67L,68L,42L,66L,30L,72L,73L,74L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275987Inst : IEnumerable<long>
{
public static readonly long[] Value=A275987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275987.Bytes);
public long this[int i]=>Value[i];

public static A275987Inst Instance=new A275987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275988
{
public static readonly long[] Value={ 3L,10L,18L,30L,36L,48L,56L,70L,80L,84L,106L,114L,126L,138L,150L,170L,174L,190L,202L,210L,234L,238L,264L,270L,282L,296L,316L,326L,340L,350L,360L,372L,386L,418L,422L,442L,450L,456L,476L,486L,498L,520L,536L,550L,564L,588L,600L,604L,626L,634L,650L,672L,696L,702L,720L,734L,750L,762L,774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275988Inst : IEnumerable<long>
{
public static readonly long[] Value=A275988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275988.Bytes);
public long this[int i]=>Value[i];

public static A275988Inst Instance=new A275988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275989
{
public static readonly long[] Value={ 3L,4L,8L,12L,26L,30L,44L,52L,66L,84L,100L,126L,140L,150L,176L,198L,222L,232L,270L,288L,300L,330L,350L,374L,424L,456L,466L,486L,492L,506L,592L,612L,650L,670L,714L,730L,772L,808L,830L,860L,890L,910L,972L,988L,1016L,1024L,1090L,1200L,1212L,1222L,1248L,1272L,1290L,1350L,1370L,1430L,1464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275989Inst : IEnumerable<long>
{
public static readonly long[] Value=A275989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275989.Bytes);
public long this[int i]=>Value[i];

public static A275989Inst Instance=new A275989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275990
{
public static readonly long[] Value={ 0L,0L,2L,6L,18L,24L,36L,42L,56L,78L,82L,114L,132L,138L,152L,186L,212L,220L,250L,278L,286L,318L,338L,368L,406L,440L,454L,470L,484L,500L,574L,602L,632L,648L,708L,712L,754L,790L,816L,848L,882L,888L,960L,970L,996L,1014L,1080L,1176L,1202L,1210L,1226L,1254L,1270L,1332L,1362L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275990Inst : IEnumerable<long>
{
public static readonly long[] Value=A275990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275990.Bytes);
public long this[int i]=>Value[i];

public static A275990Inst Instance=new A275990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275991
{
public static readonly long[] Value={ 5L,10L,14L,16L,18L,24L,26L,28L,30L,32L,40L,36L,38L,46L,50L,48L,44L,46L,46L,60L,64L,60L,66L,62L,66L,66L,70L,74L,84L,84L,72L,92L,90L,90L,84L,88L,94L,94L,96L,96L,92L,100L,102L,114L,114L,114L,106L,114L,120L,120L,126L,134L,138L,132L,132L,134L,140L,148L,144L,152L,156L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275991Inst : IEnumerable<long>
{
public static readonly long[] Value=A275991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275991.Bytes);
public long this[int i]=>Value[i];

public static A275991Inst Instance=new A275991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275992
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,3L,3L,2L,2L,3L,3L,2L,2L,3L,3L,1L,3L,3L,3L,3L,2L,4L,4L,2L,3L,3L,3L,3L,2L,4L,4L,2L,3L,3L,3L,3L,1L,4L,4L,3L,3L,5L,4L,3L,3L,5L,5L,2L,4L,4L,4L,4L,2L,5L,5L,3L,3L,4L,4L,3L,3L,5L,5L,2L,4L,4L,4L,4L,2L,5L,5L,3L,3L,4L,5L,3L,3L,4L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275992Inst : IEnumerable<long>
{
public static readonly long[] Value=A275992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275992.Bytes);
public long this[int i]=>Value[i];

public static A275992Inst Instance=new A275992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275993
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,1L,0L,1L,1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,9L,1L,10L,1L,11L,1L,12L,1L,13L,1L,14L,1L,15L,2L,0L,2L,1L,2L,2L,2L,3L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,2L,9L,2L,10L,2L,11L,2L,12L,2L,13L,2L,14L,2L,15L,3L,0L,3L,1L,3L,2L,3L,3L,3L,4L,3L,5L,3L,6L,3L,7L,3L,8L,3L,9L,3L,10L,3L,11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275993Inst : IEnumerable<long>
{
public static readonly long[] Value=A275993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275993.Bytes);
public long this[int i]=>Value[i];

public static A275993Inst Instance=new A275993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275994
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-17L,31L,-691L,5461L,-929569L,3202291L,-221930581L,4722116521L,-968383680827L,14717667114151L,-2093660879252671L,86125672563201181L,BigInteger.Parse("-129848163681107301953"),BigInteger.Parse("868320396104950823611"),BigInteger.Parse("-209390615747646519456961"),BigInteger.Parse("14129659550745551130667441"),BigInteger.Parse("-8486725345098385062639014237") };
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
public class A275994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275994Inst Instance=new A275994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275995
{
public static readonly long[] Value={ 8L,192L,640L,14336L,18432L,180224L,425984L,15728640L,8912896L,79691776L,176160768L,3087007744L,3355443200L,28991029248L,62277025792L,4260607557632L,1133871366144L,9620726743040L,20340965113856L,343047627866112L,360639813910528L,3025855999639552L,6333186975989760L,211669182486413312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275995Inst : IEnumerable<long>
{
public static readonly long[] Value=A275995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275995.Bytes);
public long this[int i]=>Value[i];

public static A275995Inst Instance=new A275995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275996
{
public static readonly long[] Value={ 108L,220L,6808L,8968L,14008L,24448L,66928L,552568L,786208L,1020568L,5303488L,8229568L,10001848L,133685248L,499722448L,2608895488L,4733164768L,7163795488L,13707973408L,14468025568L,16122444736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275996Inst : IEnumerable<long>
{
public static readonly long[] Value=A275996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275996.Bytes);
public long this[int i]=>Value[i];

public static A275996Inst Instance=new A275996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275997
{
public static readonly long[] Value={ 134L,284L,410L,632L,1292L,1628L,4064L,9752L,12224L,22712L,66992L,72944L,403988L,556544L,2161664L,2330528L,8517632L,13228352L,14563832L,15422912L,20732792L,89472632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275997Inst : IEnumerable<long>
{
public static readonly long[] Value=A275997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275997.Bytes);
public long this[int i]=>Value[i];

public static A275997Inst Instance=new A275997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275998
{
public static readonly long[] Value={ 3L,27L,267L,8820000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275998Inst : IEnumerable<long>
{
public static readonly long[] Value=A275998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275998.Bytes);
public long this[int i]=>Value[i];

public static A275998Inst Instance=new A275998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275999
{
public static readonly long[] Value={ 0L,3L,1L,5L,10L,19L,15L,22L,31L,51L,61L,37L,82L,71L,126L,96L,92L,136L,162L,187L,206L,276L,191L,261L,236L,247L,317L,302L,401L,292L,422L,547L,456L,544L,551L,612L,591L,577L,521L,666L,742L,726L,682L,877L,796L,1052L,961L,1046L,1171L,1027L,954L,1017L,1006L,1207L,1396L,1262L,1311L,1496L,1482L,1571L,1717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275999Inst : IEnumerable<long>
{
public static readonly long[] Value=A275999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275999.Bytes);
public long this[int i]=>Value[i];

public static A275999Inst Instance=new A275999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276000
{
public static readonly long[] Value={ 1L,3L,6L,6L,10L,10L,14L,14L,14L,14L,22L,22L,26L,26L,26L,26L,34L,34L,38L,38L,38L,38L,46L,46L,46L,46L,46L,46L,58L,58L,62L,62L,62L,62L,62L,62L,74L,74L,74L,74L,82L,82L,86L,86L,86L,86L,94L,94L,94L,94L,94L,94L,106L,106L,106L,106L,106L,106L,118L,118L,122L,122L,122L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276000Inst : IEnumerable<long>
{
public static readonly long[] Value=A276000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276000.Bytes);
public long this[int i]=>Value[i];

public static A276000Inst Instance=new A276000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276001
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,12L,14L,18L,19L,22L,23L,24L,48L,54L,72L,74L,84L,86L,96L,97L,100L,101L,114L,115L,118L,119L,120L,240L,264L,360L,366L,408L,414L,480L,482L,492L,494L,552L,554L,564L,566L,600L,601L,604L,605L,618L,619L,622L,623L,696L,697L,700L,701L,714L,715L,718L,719L,720L,1440L,1560L,2160L,2184L,2400L,2424L,2880L,2886L,2928L,2934L,3240L,3246L,3288L,3294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276001Inst : IEnumerable<long>
{
public static readonly long[] Value=A276001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276001.Bytes);
public long this[int i]=>Value[i];

public static A276001Inst Instance=new A276001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276002
{
public static readonly long[] Value={ 3L,7L,8L,10L,11L,13L,15L,16L,17L,20L,21L,25L,26L,28L,29L,30L,36L,38L,42L,43L,46L,47L,49L,50L,52L,53L,55L,56L,58L,59L,60L,62L,66L,67L,70L,71L,73L,75L,76L,77L,78L,80L,85L,87L,88L,89L,90L,91L,92L,93L,94L,95L,98L,99L,102L,103L,106L,107L,108L,109L,110L,111L,112L,113L,116L,117L,121L,122L,124L,125L,126L,132L,134L,138L,139L,142L,143L,144L,168L,174L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276002Inst : IEnumerable<long>
{
public static readonly long[] Value=A276002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276002.Bytes);
public long this[int i]=>Value[i];

public static A276002Inst Instance=new A276002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276003
{
public static readonly long[] Value={ 9L,27L,31L,32L,34L,35L,37L,39L,40L,41L,44L,45L,51L,57L,61L,63L,64L,65L,68L,69L,79L,81L,82L,83L,104L,105L,123L,127L,128L,130L,131L,133L,135L,136L,137L,140L,141L,145L,146L,148L,149L,150L,156L,158L,162L,163L,166L,167L,169L,170L,172L,173L,175L,176L,178L,179L,180L,182L,186L,187L,190L,191L,193L,195L,196L,197L,198L,200L,205L,207L,208L,209L,210L,211L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276003Inst : IEnumerable<long>
{
public static readonly long[] Value=A276003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276003.Bytes);
public long this[int i]=>Value[i];

public static A276003Inst Instance=new A276003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276004
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,3L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276004Inst : IEnumerable<long>
{
public static readonly long[] Value=A276004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276004.Bytes);
public long this[int i]=>Value[i];

public static A276004Inst Instance=new A276004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276005
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,12L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,48L,49L,54L,55L,60L,66L,67L,72L,74L,76L,78L,84L,86L,88L,90L,92L,94L,96L,97L,98L,100L,101L,102L,103L,108L,110L,112L,114L,115L,116L,118L,119L,120L,121L,122L,124L,125L,126L,127L,132L,134L,136L,138L,139L,140L,142L,143L,240L,241L,242L,244L,245L,264L,265L,266L,268L,269L,288L,289L,312L,314L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276005Inst : IEnumerable<long>
{
public static readonly long[] Value=A276005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276005.Bytes);
public long this[int i]=>Value[i];

public static A276005Inst Instance=new A276005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276006
{
public static readonly long[] Value={ 3L,8L,9L,10L,11L,13L,15L,17L,21L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,56L,57L,58L,59L,61L,62L,63L,64L,65L,68L,69L,70L,71L,73L,75L,77L,79L,80L,81L,82L,83L,85L,87L,89L,91L,93L,95L,99L,104L,105L,106L,107L,109L,111L,113L,117L,123L,128L,129L,130L,131L,133L,135L,137L,141L,144L,145L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276006Inst : IEnumerable<long>
{
public static readonly long[] Value=A276006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276006.Bytes);
public long this[int i]=>Value[i];

public static A276006Inst Instance=new A276006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276007
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,3L,2L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,0L,0L,1L,2L,1L,1L,0L,0L,2L,3L,2L,2L,0L,1L,1L,3L,1L,2L,0L,0L,1L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,3L,1L,2L,0L,2L,0L,3L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276007Inst : IEnumerable<long>
{
public static readonly long[] Value=A276007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276007.Bytes);
public long this[int i]=>Value[i];

public static A276007Inst Instance=new A276007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276008
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,6L,7L,8L,9L,8L,9L,6L,7L,8L,9L,8L,9L,6L,7L,8L,9L,8L,9L,24L,25L,26L,27L,26L,27L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,24L,25L,26L,27L,26L,27L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,24L,25L,26L,27L,26L,27L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,30L,31L,32L,33L,32L,33L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276008Inst : IEnumerable<long>
{
public static readonly long[] Value=A276008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276008.Bytes);
public long this[int i]=>Value[i];

public static A276008Inst Instance=new A276008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276009
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,2L,2L,6L,6L,6L,6L,8L,8L,12L,12L,12L,12L,14L,14L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,2L,2L,6L,6L,6L,6L,8L,8L,12L,12L,12L,12L,14L,14L,24L,24L,24L,24L,26L,26L,24L,24L,24L,24L,26L,26L,30L,30L,30L,30L,32L,32L,36L,36L,36L,36L,38L,38L,48L,48L,48L,48L,50L,50L,48L,48L,48L,48L,50L,50L,54L,54L,54L,54L,56L,56L,60L,60L,60L,60L,62L,62L,72L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276009Inst : IEnumerable<long>
{
public static readonly long[] Value=A276009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276009.Bytes);
public long this[int i]=>Value[i];

public static A276009Inst Instance=new A276009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276010
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,4L,5L,6L,7L,5L,5L,2L,3L,2L,3L,3L,3L,1L,1L,3L,3L,1L,1L,8L,9L,10L,11L,9L,9L,12L,13L,14L,15L,13L,13L,10L,11L,10L,11L,11L,11L,9L,9L,11L,11L,9L,9L,4L,5L,6L,7L,5L,5L,4L,5L,6L,7L,5L,5L,6L,7L,6L,7L,7L,7L,5L,5L,7L,7L,5L,5L,2L,3L,2L,3L,3L,3L,6L,7L,6L,7L,7L,7L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,1L,3L,3L,1L,1L,5L,5L,7L,7L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276010Inst : IEnumerable<long>
{
public static readonly long[] Value=A276010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276010.Bytes);
public long this[int i]=>Value[i];

public static A276010Inst Instance=new A276010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276011
{
public static readonly long[] Value={ 0L,3L,1L,2L,14L,17L,15L,16L,10L,13L,11L,12L,4L,5L,8L,9L,6L,7L,78L,81L,79L,80L,92L,95L,93L,94L,88L,91L,89L,90L,82L,83L,86L,87L,84L,85L,60L,63L,61L,62L,74L,77L,75L,76L,70L,73L,71L,72L,64L,65L,68L,69L,66L,67L,42L,45L,43L,44L,56L,59L,57L,58L,52L,55L,53L,54L,46L,47L,50L,51L,48L,49L,18L,19L,22L,23L,20L,21L,36L,37L,40L,41L,38L,39L,30L,31L,34L,35L,32L,33L,24L,25L,28L,29L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276011Inst : IEnumerable<long>
{
public static readonly long[] Value=A276011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276011.Bytes);
public long this[int i]=>Value[i];

public static A276011Inst Instance=new A276011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276012
{
public static readonly long[] Value={ 0L,2L,3L,1L,12L,13L,16L,17L,14L,15L,8L,10L,11L,9L,4L,6L,7L,5L,72L,73L,76L,77L,74L,75L,90L,91L,94L,95L,92L,93L,84L,85L,88L,89L,86L,87L,78L,79L,82L,83L,80L,81L,54L,56L,57L,55L,66L,67L,70L,71L,68L,69L,62L,64L,65L,63L,58L,60L,61L,59L,36L,38L,39L,37L,48L,49L,52L,53L,50L,51L,44L,46L,47L,45L,40L,42L,43L,41L,18L,20L,21L,19L,30L,31L,34L,35L,32L,33L,26L,28L,29L,27L,22L,24L,25L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276012Inst : IEnumerable<long>
{
public static readonly long[] Value=A276012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276012.Bytes);
public long this[int i]=>Value[i];

public static A276012Inst Instance=new A276012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276013
{
public static readonly BigInteger[] Value={ 1L,12L,864L,100800L,14112000L,2139830784L,338341183488L,54913641209856L,9080061146956800L,1523231914913280000L,BigInteger.Parse("258557709598427086848"),BigInteger.Parse("44324863067728222027776"),BigInteger.Parse("7663322563977594870300672"),BigInteger.Parse("1334677098876385703362560000"),BigInteger.Parse("233951210561895726160281600000") };
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
public class A276013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276013Inst Instance=new A276013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276014
{
public static readonly BigInteger[] Value={ 1L,72L,45360L,46569600L,59594535000L,86482063571904L,136141986298526208L,BigInteger.Parse("226888189910421811200"),BigInteger.Parse("394399917777684601926000"),BigInteger.Parse("708188604075430924446000000"),BigInteger.Parse("1304782547573305224852017990400"),BigInteger.Parse("2454776409299366206456800694732800"),BigInteger.Parse("4699106882676505497505898579906736000"),BigInteger.Parse("9127695522416954472516114289988092800000") };
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
public class A276014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276014Inst Instance=new A276014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276015
{
public static readonly BigInteger[] Value={ 1L,18L,1404L,158760L,21234150L,3126159036L,489778537248L,80153987120064L,13547671656870780L,2347445149320843000L,BigInteger.Parse("414851046001557525360"),BigInteger.Parse("74499573518808987538080"),BigInteger.Parse("13557818392046546526712440"),BigInteger.Parse("2495117936356342079352318000"),BigInteger.Parse("463604343771018075763879080000"),BigInteger.Parse("86854813070150110063356637257600") };
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
public class A276015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276015Inst Instance=new A276015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276016
{
public static readonly BigInteger[] Value={ 1L,18L,1620L,211680L,32744250L,5578048476L,1011486123648L,191622065057280L,37496545808513220L,7522455177633825000L,BigInteger.Parse("1539274868268143806800"),BigInteger.Parse("320076654200479057190400"),BigInteger.Parse("67449486609121784655852000"),BigInteger.Parse("14374016718897406159444968000") };
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
public class A276016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276016Inst Instance=new A276016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276017
{
public static readonly BigInteger[] Value={ 1L,18L,2160L,423360L,99792000L,25499650176L,6797581959168L,1860535606026240L,518890571236477440L,BigInteger.Parse("146835076503772800000"),BigInteger.Parse("42046646730013562757120"),BigInteger.Parse("12160617341681775057960960"),BigInteger.Parse("3547136319516173918512742400"),BigInteger.Parse("1042325945372157283978798694400"),BigInteger.Parse("308269259704090665806809006080000") };
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
public class A276017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276017Inst Instance=new A276017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276018
{
public static readonly BigInteger[] Value={ 1L,3L,36L,588L,11025L,223587L,4769856L,105423552L,2391796836L,55365667500L,1302200499600L,31026810250800L,747229013540100L,18158991471060300L,444709995209640000L,10963583748568324800UL,BigInteger.Parse("271862615765280179025"),BigInteger.Parse("6775869970094509098675"),BigInteger.Parse("169647707399403264840900"),BigInteger.Parse("4264689597367270438867500") };
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
public class A276018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276018Inst Instance=new A276018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276019
{
public static readonly BigInteger[] Value={ 1L,10L,230L,6500L,199750L,6366060L,204990300L,6539387400L,202432551750L,5897526329500L,151804596385780L,2807347223915000L,-15232296765302500L,-5584390420089725000L,BigInteger.Parse("-416025902106681525000"),BigInteger.Parse("-24002385182809425846000"),BigInteger.Parse("-1235898175219724085176250"),BigInteger.Parse("-59486502796252242452122500"),BigInteger.Parse("-2731496764897242177292037500"),BigInteger.Parse("-120874274801920384164027025000"),BigInteger.Parse("-5181210157044172846922944311500") };
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
public class A276019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276019Inst Instance=new A276019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276020
{
public static readonly BigInteger[] Value={ 1L,10L,90L,780L,6630L,55820L,469220L,3967000L,33951750L,295553500L,2622492940L,23701797800L,217528135900L,2018704327800L,18862262001800L,176834576018480L,1659586559786950L,15575074941839100L,146164364053448700L,1372547571923176200L,12910383388613518580UL,BigInteger.Parse("121770360957324308200"),BigInteger.Parse("1152648798132152849400") };
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
public class A276020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276020Inst Instance=new A276020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276021
{
public static readonly BigInteger[] Value={ 1L,21L,693L,23940L,734643L,13697019L,-494620749L,-83079255420L,-6814815765975L,-444980496382695L,-25071954462140859L,-1226361084729855984L,BigInteger.Parse("-49426887403935395172"),BigInteger.Parse("-1287188243957889124740"),BigInteger.Parse("23935850133162849385308"),BigInteger.Parse("6798920856226697943604944"),BigInteger.Parse("650950202721260061404073891") };
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
public class A276021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276021Inst Instance=new A276021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276022
{
public static readonly long[] Value={ 1L,6L,30L,144L,690L,3348L,16536L,83232L,426618L,2223180L,11756052L,62959680L,340881792L,1862954784L,10262937600L,56926831104L,317632207194L,1781352834300L,10034760283356L,56748881420640L,322033934657628L,1833043230774360L,10462349697348528L,59861990921495616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276022Inst : IEnumerable<long>
{
public static readonly long[] Value=A276022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276022.Bytes);
public long this[int i]=>Value[i];

public static A276022Inst Instance=new A276022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276023
{
public static readonly long[] Value={ 3L,2L,9L,8L,5L,0L,8L,9L,0L,2L,7L,3L,8L,7L,0L,6L,8L,6L,9L,3L,8L,2L,1L,0L,6L,5L,0L,3L,7L,4L,4L,5L,1L,1L,7L,0L,3L,6L,9L,4L,4L,7L,9L,0L,9L,1L,5L,6L,1L,8L,3L,4L,3L,8L,5L,3L,1L,9L,5L,4L,6L,5L,6L,1L,3L,5L,3L,5L,1L,0L,4L,4L,9L,3L,3L,1L,7L,1L,4L,5L,7L,9L,9L,8L,2L,9L,6L,2L,7L,0L,0L,0L,1L,2L,7L,9L,9L,7L,4L,7L,7L,5L,7L,6L,8L,6L,2L,9L,0L,0L,0L,5L,4L,6L,3L,5L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276023Inst : IEnumerable<long>
{
public static readonly long[] Value=A276023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276023.Bytes);
public long this[int i]=>Value[i];

public static A276023Inst Instance=new A276023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276024
{
public static readonly long[] Value={ 1L,3L,7L,14L,27L,47L,81L,130L,210L,319L,492L,718L,1063L,1512L,2178L,3012L,4237L,5765L,7930L,10613L,14364L,18936L,25259L,32938L,43302L,55862L,72694L,92797L,119499L,151468L,193052L,242748L,307135L,383315L,481301L,597252L,744199L,918030L,1137607L,1395101L,1718237L,2098096L,2569047L,3121825L,3805722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276024Inst : IEnumerable<long>
{
public static readonly long[] Value=A276024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276024.Bytes);
public long this[int i]=>Value[i];

public static A276024Inst Instance=new A276024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276025
{
public static readonly BigInteger[] Value={ 2L,23L,337L,4447L,55579L,666667L,7777801L,88888901L,1000000007L,10101010101010101073UL,BigInteger.Parse("1111111111111111111189"),BigInteger.Parse("121212121212121212121327"),BigInteger.Parse("13131313131313131313131439"),BigInteger.Parse("1414141414141414141414141451"),BigInteger.Parse("151515151515151515151515151607"),BigInteger.Parse("16161616161616161616161616161709"),BigInteger.Parse("1717171717171717171717171717171741") };
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
public class A276025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276025Inst Instance=new A276025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276026
{
public static readonly long[] Value={ 140L,204L,284L,380L,492L,620L,764L,924L,1100L,1292L,1500L,1724L,1964L,2220L,2492L,2780L,3084L,3404L,3740L,4092L,4460L,4844L,5244L,5660L,6092L,6540L,7004L,7484L,7980L,8492L,9020L,9564L,10124L,10700L,11292L,11900L,12524L,13164L,13820L,14492L,15180L,15884L,16604L,17340L,18092L,18860L,19644L,20444L,21260L,22092L,22940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276026Inst : IEnumerable<long>
{
public static readonly long[] Value=A276026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276026.Bytes);
public long this[int i]=>Value[i];

public static A276026Inst Instance=new A276026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276027
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,7L,18L,43L,93L,266L,702L,1687L,5136L,14405L,36898L,117016L,341842L,914064L,2983027L,8972121L,24743851L,82478973L,253555061L,715745648L,2424954125L,7582390623L,21796481477L,74805170349L,237095926682L,691568408221L,2398418942361L,7686495623620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276027Inst : IEnumerable<long>
{
public static readonly long[] Value=A276027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276027.Bytes);
public long this[int i]=>Value[i];

public static A276027Inst Instance=new A276027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276028
{
public static readonly long[] Value={ 1L,3L,10L,50L,259L,1540L,9594L,62649L,422598L,2960716L,21030711L,152470357L,1129502128L,8434189996L,63674017174L,488573782216L,3762932025753L,29178861276815L,229208503750838L,1803350026315019L,14248236439629534L,113825380196996557L,909507867095014380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276028Inst : IEnumerable<long>
{
public static readonly long[] Value=A276028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276028.Bytes);
public long this[int i]=>Value[i];

public static A276028Inst Instance=new A276028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276029
{
public static readonly BigInteger[] Value={ 1L,4L,27L,228L,2226L,23778L,270693L,3229106L,39922172L,507680620L,6604676830L,87549425068L,1178880306174L,16086844260290L,222045139578443L,3095457073064120L,43529719213465854L,616853383573066504L,8801227720060618544L,BigInteger.Parse("126344910516550743232") };
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
public class A276029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276029Inst Instance=new A276029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276030
{
public static readonly long[] Value={ 2L,11L,131L,251L,491L,599L,1439L,3371L,5639L,5879L,6971L,7079L,8039L,8291L,9839L,10799L,11171L,12119L,14879L,16931L,17159L,18839L,23039L,23159L,25919L,50291L,53411L,53639L,59051L,69371L,74771L,74891L,75239L,81119L,81359L,117839L,119039L,126839L,130811L,131771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276030Inst : IEnumerable<long>
{
public static readonly long[] Value=A276030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276030.Bytes);
public long this[int i]=>Value[i];

public static A276030Inst Instance=new A276030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276031
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,14L,21L,30L,41L,54L,70L,89L,110L,135L,164L,195L,231L,272L,315L,364L,419L,476L,540L,611L,684L,765L,854L,945L,1045L,1154L,1265L,1386L,1517L,1650L,1794L,1949L,2106L,2275L,2456L,2639L,2835L,3044L,3255L,3480L,3719L,3960L,4216L,4487L,4760L,5049L,5354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276031Inst : IEnumerable<long>
{
public static readonly long[] Value=A276031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276031.Bytes);
public long this[int i]=>Value[i];

public static A276031Inst Instance=new A276031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276032
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,21L,22L,63L,64L,195L,196L,624L,625L,2054L,2055L,6916L,6917L,23712L,23713L,82498L,82499L,290510L,290511L,1033410L,1033411L,3707850L,3707851L,13402695L,13402696L,48760365L,48760366L,178405155L,178405156L,656043855L,656043856L,2423307045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276032Inst : IEnumerable<long>
{
public static readonly long[] Value=A276032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276032.Bytes);
public long this[int i]=>Value[i];

public static A276032Inst Instance=new A276032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276033
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,17L,22L,50L,64L,154L,196L,493L,625L,1626L,2055L,5487L,6917L,18851L,23713L,65703L,82499L,231725L,290511L,825399L,1033411L,2964951L,3707851L,10728256L,13402696L,39065521L,48760366L,143047486L,178405156L,526399066L,656043856L,1945668346L,2423307046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276033Inst : IEnumerable<long>
{
public static readonly long[] Value=A276033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276033.Bytes);
public long this[int i]=>Value[i];

public static A276033Inst Instance=new A276033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276034
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,0L,3L,2L,1L,2L,2L,2L,1L,2L,1L,0L,2L,1L,1L,2L,2L,3L,3L,2L,2L,2L,2L,3L,2L,1L,2L,4L,3L,1L,5L,3L,2L,5L,1L,2L,2L,2L,5L,2L,3L,4L,5L,3L,2L,5L,2L,1L,4L,0L,1L,5L,3L,1L,3L,5L,4L,4L,3L,2L,4L,3L,3L,4L,2L,3L,7L,2L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276034Inst : IEnumerable<long>
{
public static readonly long[] Value=A276034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276034.Bytes);
public long this[int i]=>Value[i];

public static A276034Inst Instance=new A276034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276035
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,4L,3L,5L,11L,6L,13L,7L,15L,4L,17L,3L,19L,5L,7L,11L,23L,6L,5L,13L,6L,14L,29L,15L,31L,4L,33L,17L,35L,6L,37L,19L,13L,10L,41L,7L,43L,22L,15L,23L,47L,6L,7L,5L,51L,13L,53L,6L,11L,14L,19L,29L,59L,15L,61L,31L,21L,4L,65L,33L,67L,17L,69L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276035Inst : IEnumerable<long>
{
public static readonly long[] Value=A276035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276035.Bytes);
public long this[int i]=>Value[i];

public static A276035Inst Instance=new A276035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276036
{
public static readonly long[] Value={ 1L,4L,5L,6L,2L,3L,9L,12L,13L,14L,8L,15L,7L,18L,11L,20L,10L,26L,17L,25L,19L,27L,30L,21L,23L,29L,31L,22L,16L,41L,45L,32L,34L,24L,38L,36L,39L,33L,37L,46L,43L,28L,35L,42L,56L,55L,57L,50L,51L,62L,53L,60L,64L,71L,58L,69L,40L,74L,68L,54L,63L,80L,65L,82L,73L,47L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276036Inst : IEnumerable<long>
{
public static readonly long[] Value=A276036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276036.Bytes);
public long this[int i]=>Value[i];

public static A276036Inst Instance=new A276036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276037
{
public static readonly long[] Value={ 1L,5L,11L,15L,51L,55L,111L,115L,151L,155L,511L,515L,551L,555L,1111L,1115L,1151L,1155L,1511L,1515L,1551L,1555L,5111L,5115L,5151L,5155L,5511L,5515L,5551L,5555L,11111L,11115L,11151L,11155L,11511L,11515L,11551L,11555L,15111L,15115L,15151L,15155L,15511L,15515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276037Inst : IEnumerable<long>
{
public static readonly long[] Value=A276037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276037.Bytes);
public long this[int i]=>Value[i];

public static A276037Inst Instance=new A276037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276038
{
public static readonly long[] Value={ 1L,6L,11L,16L,23L,32L,49L,61L,66L,94L,111L,116L,123L,132L,149L,161L,166L,194L,213L,229L,231L,236L,263L,292L,312L,321L,326L,334L,343L,362L,389L,398L,419L,433L,469L,491L,496L,611L,616L,623L,632L,649L,661L,666L,694L,839L,893L,914L,922L,938L,941L,946L,964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276038Inst : IEnumerable<long>
{
public static readonly long[] Value=A276038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276038.Bytes);
public long this[int i]=>Value[i];

public static A276038Inst Instance=new A276038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276039
{
public static readonly long[] Value={ 1L,7L,11L,17L,71L,77L,111L,117L,171L,177L,711L,717L,771L,777L,1111L,1117L,1171L,1177L,1711L,1717L,1771L,1777L,7111L,7117L,7171L,7177L,7711L,7717L,7771L,7777L,11111L,11117L,11171L,11177L,11711L,11717L,11771L,11777L,17111L,17117L,17171L,17177L,17711L,17717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276039Inst : IEnumerable<long>
{
public static readonly long[] Value=A276039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276039.Bytes);
public long this[int i]=>Value[i];

public static A276039Inst Instance=new A276039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276040
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,12L,18L,20L,22L,24L,26L,28L,30L,24L,34L,36L,38L,40L,42L,44L,46L,36L,50L,52L,45L,56L,58L,60L,62L,48L,66L,68L,70L,72L,74L,76L,78L,60L,82L,84L,86L,88L,90L,92L,94L,72L,98L,100L,102L,104L,106L,90L,110L,84L,114L,116L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276040Inst : IEnumerable<long>
{
public static readonly long[] Value=A276040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276040.Bytes);
public long this[int i]=>Value[i];

public static A276040Inst Instance=new A276040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276041
{
public static readonly long[] Value={ 1L,6L,28L,104L,336L,992L,2752L,7296L,18688L,46592L,113664L,272384L,643072L,1499136L,3457024L,7897088L,17891328L,40239104L,89915392L,199753728L,441450496L,970981376L,2126512128L,4638900224L,10083106816L,21843935232L,47177531392L,101602820096L,218238025728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276041Inst : IEnumerable<long>
{
public static readonly long[] Value=A276041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276041.Bytes);
public long this[int i]=>Value[i];

public static A276041Inst Instance=new A276041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276042
{
public static readonly long[] Value={ 1L,4L,16L,62L,230L,812L,2728L,8752L,26944L,80000L,230144L,644096L,1759744L,4707328L,12359680L,31920128L,81231872L,204013568L,506331136L,1243217920L,3022913536L,7285243904L,17415274496L,41321234432L,97370767360L,227993976832L,530713673728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276042Inst : IEnumerable<long>
{
public static readonly long[] Value=A276042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276042.Bytes);
public long this[int i]=>Value[i];

public static A276042Inst Instance=new A276042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276043
{
public static readonly long[] Value={ 1L,2L,3L,5L,33L,6L,105L,14L,22L,33L,651L,24L,2667L,105L,66L,54L,57337L,88L,172011L,114L,210L,1302L,2752491L,120L,510L,5334L,472L,378L,199753347L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276043Inst : IEnumerable<long>
{
public static readonly long[] Value=A276043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276043.Bytes);
public long this[int i]=>Value[i];

public static A276043Inst Instance=new A276043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276044
{
public static readonly long[] Value={ 1L,3L,5L,7L,17L,13L,85L,31L,37L,65L,1285L,61L,4369L,193L,185L,143L,65537L,181L,327685L,241L,577L,3281L,5570645L,403L,1297L,12289L,1057L,1037L,286331153L,779L,1431655765L,899L,9509L,197633L,5629L,1333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276044Inst : IEnumerable<long>
{
public static readonly long[] Value=A276044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276044.Bytes);
public long this[int i]=>Value[i];

public static A276044Inst Instance=new A276044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276045
{
public static readonly long[] Value={ 7L,13L,17L,19L,43L,47L,59L,61L,71L,79L,101L,107L,109L,149L,151L,163L,167L,197L,223L,257L,263L,271L,311L,317L,347L,349L,353L,383L,389L,401L,421L,439L,449L,461L,479L,503L,521L,523L,557L,569L,599L,601L,613L,631L,673L,677L,691L,701L,811L,821L,827L,839L,853L,863L,881L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276045Inst : IEnumerable<long>
{
public static readonly long[] Value=A276045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276045.Bytes);
public long this[int i]=>Value[i];

public static A276045Inst Instance=new A276045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276046
{
public static readonly long[] Value={ 1L,2L,10L,16L,78L,97L,125L,138L,192L,242L,290L,373L,408L,467L,583L,892L,899L,1709L,1944L,2154L,3618L,5225L,8974L,9377L,12504L,20042L,49106L,63073L,92152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276046Inst : IEnumerable<long>
{
public static readonly long[] Value=A276046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276046.Bytes);
public long this[int i]=>Value[i];

public static A276046Inst Instance=new A276046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276047
{
public static readonly long[] Value={ 1L,2L,3L,7L,15L,22L,30L,35L,44L,73L,89L,91L,224L,533L,821L,1037L,1338L,1458L,1777L,2046L,2257L,2877L,3047L,3407L,13398L,42766L,55906L,61625L,66653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276047Inst : IEnumerable<long>
{
public static readonly long[] Value=A276047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276047.Bytes);
public long this[int i]=>Value[i];

public static A276047Inst Instance=new A276047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276048
{
public static readonly BigInteger[] Value={ 0L,2L,9L,2L,625L,1L,117649L,2L,9L,1L,25937424601L,1L,23298085122481L,1L,1L,2L,BigInteger.Parse("48661191875666868481"),1L,BigInteger.Parse("104127350297911241532841"),1L,1L,1L,BigInteger.Parse("907846434775996175406740561329"),1L,625L,1L,9L,1L,BigInteger.Parse("88540901833145211536614766025207452637361"),1L };
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
public class A276048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276048Inst Instance=new A276048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276049
{
public static readonly long[] Value={ 19L,29L,41L,71L,79L,89L,101L,103L,113L,139L,197L,199L,223L,271L,281L,307L,349L,353L,367L,379L,401L,439L,449L,461L,463L,491L,499L,521L,571L,607L,617L,619L,641L,643L,701L,727L,739L,761L,769L,811L,821L,859L,881L,911L,919L,929L,941L,953L,967L,991L,1039L,1061L,1063L,1087L,1181L,1217L,1231L,1279L,1289L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276049Inst : IEnumerable<long>
{
public static readonly long[] Value=A276049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276049.Bytes);
public long this[int i]=>Value[i];

public static A276049Inst Instance=new A276049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276050
{
public static readonly long[] Value={ 55L,161L,175L,209L,221L,259L,305L,319L,341L,351L,365L,391L,415L,475L,497L,533L,545L,551L,559L,581L,649L,679L,703L,737L,749L,785L,799L,833L,835L,869L,895L,979L,1001L,1037L,1099L,1121L,1145L,1147L,1159L,1183L,1189L,1205L,1219L,1241L,1313L,1315L,1331L,1339L,1351L,1375L,1421L,1457L,1495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276050Inst : IEnumerable<long>
{
public static readonly long[] Value=A276050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276050.Bytes);
public long this[int i]=>Value[i];

public static A276050Inst Instance=new A276050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276051
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,80L,244L,732L,2320L,7172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276051Inst : IEnumerable<long>
{
public static readonly long[] Value=A276051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276051.Bytes);
public long this[int i]=>Value[i];

public static A276051Inst Instance=new A276051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276052
{
public static readonly long[] Value={ 5L,4L,3L,2L,15L,106L,21L,127L,3L,39282L,3L,53L,135L,65014L,5L,9489L,171L,361L,27L,19641L,7L,13133L,141L,6326L,3L,6978L,19L,32507L,375L,13094L,165L,93186L,19L,1359L,9L,12588L,15L,171L,45L,35253L,3L,35794L,9L,16796L,7L,1689L,69L,3163L,3L,13653L,57L,3489L,12L,249L,45L,58497L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276052Inst : IEnumerable<long>
{
public static readonly long[] Value=A276052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276052.Bytes);
public long this[int i]=>Value[i];

public static A276052Inst Instance=new A276052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276053
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,2L,2L,8L,7L,8L,4L,3L,26L,4L,13L,24L,24L,6L,66L,28L,8L,23L,62L,104L,8L,10L,158L,120L,64L,42L,148L,352L,80L,16L,19L,350L,416L,344L,16L,75L,334L,1052L,448L,160L,33L,756L,1252L,1440L,208L,32L,136L,726L,2860L,1936L,1024L,32L,61L,1578L,3448L,5176L,1440L,384L,244L,1534L,7312L,7056L,5072L,512L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276053Inst : IEnumerable<long>
{
public static readonly long[] Value=A276053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276053.Bytes);
public long this[int i]=>Value[i];

public static A276053Inst Instance=new A276053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276054
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,8L,16L,34L,72L,146L,294L,590L,1156L,2278L,4422L,8572L,16510L,31682L,60558L,115398L,219190L,415348L,784996L,1480600L,2786818L,5236078L,9821222L,18393268L,34397388L,64241880L,119831316L,223266154L,415532226L,772587316L,1435082052L,2663283782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276054Inst : IEnumerable<long>
{
public static readonly long[] Value=A276054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276054.Bytes);
public long this[int i]=>Value[i];

public static A276054Inst Instance=new A276054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276055
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,7L,3L,13L,6L,23L,10L,42L,19L,75L,33L,136L,61L,244L,108L,441L,197L,793L,352L,1431L,638L,2576L,1145L,4645L,2069L,8366L,3721L,15080L,6714L,27167L,12087L,48961L,21794L,88215L,39254L,158970L,70755L,286439L,127469L,516164L,229725L,930072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276055Inst : IEnumerable<long>
{
public static readonly long[] Value=A276055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276055.Bytes);
public long this[int i]=>Value[i];

public static A276055Inst Instance=new A276055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276056
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,3L,6L,3L,6L,4L,5L,10L,4L,4L,12L,12L,7L,18L,16L,6L,22L,24L,8L,10L,34L,36L,8L,9L,36L,52L,32L,15L,58L,76L,40L,13L,60L,108L,80L,16L,22L,96L,160L,112L,16L,19L,100L,204L,192L,80L,32L,160L,312L,272L,96L,28L,162L,376L,440L,240L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276056Inst : IEnumerable<long>
{
public static readonly long[] Value=A276056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276056.Bytes);
public long this[int i]=>Value[i];

public static A276056Inst Instance=new A276056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276057
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,4L,6L,14L,18L,36L,50L,94L,130L,236L,330L,580L,816L,1404L,1984L,3354L,4758L,7932L,11286L,18600L,26532L,43308L,61908L,100232L,143540L,230776L,331008L,528950L,759726L,1207584L,1736534L,2747242L,3954826L,6230444L,8977686L,14090410L,20320854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276057Inst : IEnumerable<long>
{
public static readonly long[] Value=A276057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276057.Bytes);
public long this[int i]=>Value[i];

public static A276057Inst Instance=new A276057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276058
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,3L,6L,3L,10L,5L,14L,4L,24L,7L,30L,4L,6L,46L,8L,10L,58L,20L,9L,84L,36L,15L,106L,68L,13L,152L,112L,22L,188L,196L,19L,264L,304L,8L,32L,324L,492L,24L,28L,446L,732L,72L,47L,546L,1120L,160L,41L,744L,1616L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276058Inst : IEnumerable<long>
{
public static readonly long[] Value=A276058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276058.Bytes);
public long this[int i]=>Value[i];

public static A276058Inst Instance=new A276058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276059
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,2L,2L,4L,6L,10L,14L,24L,38L,62L,98L,156L,242L,376L,580L,896L,1380L,2126L,3266L,5008L,7658L,11688L,17804L,27084L,41148L,62448L,94668L,143360L,216864L,327726L,494790L,746368L,1124950L,1694286L,2549942L,3835120L,5764274L,8658442L,12997998L,19501468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276059Inst : IEnumerable<long>
{
public static readonly long[] Value=A276059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276059.Bytes);
public long this[int i]=>Value[i];

public static A276059Inst Instance=new A276059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276060
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,3L,6L,3L,10L,5L,10L,4L,4L,20L,4L,7L,22L,12L,6L,34L,20L,10L,42L,36L,9L,64L,48L,8L,15L,70L,96L,8L,13L,112L,120L,32L,22L,124L,204L,56L,19L,184L,280L,112L,32L,212L,436L,176L,16L,28L,310L,564L,360L,16L,47L,346L,896L,504L,80L,41L,512L,1128L,920L,144L,69L,570L,1704L,1360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276060Inst : IEnumerable<long>
{
public static readonly long[] Value=A276060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276060.Bytes);
public long this[int i]=>Value[i];

public static A276060Inst Instance=new A276060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276061
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,2L,4L,6L,10L,18L,28L,46L,74L,114L,184L,286L,448L,700L,1080L,1676L,2582L,3970L,6104L,9338L,14288L,21808L,33224L,50580L,76844L,116640L,176832L,267740L,405058L,612110L,924204L,1394266L,2101558L,3165406L,4764184L,7165530L,10770386L,16178378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276061Inst : IEnumerable<long>
{
public static readonly long[] Value=A276061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276061.Bytes);
public long this[int i]=>Value[i];

public static A276061Inst Instance=new A276061Inst();

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