using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A116979
{
public static readonly long[] Value={ 0L,0L,1L,3L,19L,114L,905L,9493L,124180L,2044847L,43755729L,1043468386L,30309948241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116979Inst : IEnumerable<long>
{
public static readonly long[] Value=A116979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116979.Bytes);
public long this[int i]=>Value[i];

public static A116979Inst Instance=new A116979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116980
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,4L,19L,23L,16L,43L,59L,66L,127L,492L,886L,964L,2595L,11426L,36780L,78070L,131232L,423402L,1302893L,3356226L,6673924L,16604441L,32195439L,69328860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116980Inst : IEnumerable<long>
{
public static readonly long[] Value=A116980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116980.Bytes);
public long this[int i]=>Value[i];

public static A116980Inst Instance=new A116980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116981
{
public static readonly long[] Value={ 1L,5L,13L,11L,28L,53L,50L,53L,135L,106L,116L,253L,165L,229L,568L,244L,313L,656L,381L,575L,1123L,600L,612L,1297L,956L,871L,1735L,1130L,1102L,3025L,1288L,1314L,3169L,1620L,2671L,3582L,1954L,2149L,4729L,3064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116981Inst : IEnumerable<long>
{
public static readonly long[] Value=A116981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116981.Bytes);
public long this[int i]=>Value[i];

public static A116981Inst Instance=new A116981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116982
{
public static readonly long[] Value={ 2L,4L,2L,4L,4L,6L,6L,6L,6L,4L,4L,6L,6L,6L,2L,6L,4L,2L,6L,4L,6L,6L,8L,8L,4L,4L,2L,4L,14L,14L,14L,4L,6L,6L,10L,10L,10L,6L,6L,6L,4L,6L,6L,6L,2L,10L,10L,2L,4L,12L,12L,12L,12L,12L,12L,4L,2L,4L,6L,2L,10L,10L,6L,6L,6L,6L,6L,6L,6L,4L,10L,10L,10L,14L,14L,14L,4L,2L,4L,14L,14L,14L,6L,6L,10L,10L,2L,4L,6L,8L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116982Inst : IEnumerable<long>
{
public static readonly long[] Value=A116982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116982.Bytes);
public long this[int i]=>Value[i];

public static A116982Inst Instance=new A116982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116983
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,6L,11L,54L,150L,648L,5013L,9849L,19345L,1060707L,10939036L,4343045L,2498014850L,5271260976L,78029366100L,531495923280L,805809810981L,1936900666393L,28724010464057580L,29052364970866225L,75805259574286872L,7466893805506395652L,BigInteger.Parse("80374513001512054041") };
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
public class A116983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116983Inst Instance=new A116983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116984
{
public static readonly long[] Value={ 1L,3L,28L,59L,146L,643L,4004L,8651L,12655L,21306L,76573L,97879L,1838395L,1936274L,13456039L,15392313L,44240665L,59632978L,103873643L,475127550L,579001193L,24793177656L,149338067129L,174131244785L,845863046269L,1865857337323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116984Inst : IEnumerable<long>
{
public static readonly long[] Value=A116984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116984.Bytes);
public long this[int i]=>Value[i];

public static A116984Inst Instance=new A116984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116985
{
public static readonly long[] Value={ 2L,7L,65L,137L,339L,1493L,9297L,20087L,29384L,49471L,177797L,227268L,4268621L,4495889L,31243955L,35739844L,102723643L,138463487L,241187130L,1103212007L,1344399137L,57567975761L,346752253703L,404320229464L,1964033171559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116985Inst : IEnumerable<long>
{
public static readonly long[] Value=A116985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116985.Bytes);
public long this[int i]=>Value[i];

public static A116985Inst Instance=new A116985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116986
{
public static readonly long[] Value={ 1L,1L,3L,23L,443L,23131L,3732309L,2090705825L,4388282355347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116986Inst : IEnumerable<long>
{
public static readonly long[] Value=A116986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116986.Bytes);
public long this[int i]=>Value[i];

public static A116986Inst Instance=new A116986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116987
{
public static readonly long[] Value={ 2L,2L,2L,3L,1L,7L,2L,4L,1L,9L,6L,9L,14L,8L,5L,0L,14L,11L,19L,3L,20L,7L,18L,25L,5L,2L,24L,12L,5L,27L,9L,18L,0L,8L,0L,10L,26L,12L,3L,30L,21L,19L,24L,37L,27L,39L,17L,14L,36L,35L,24L,3L,32L,17L,42L,1L,47L,56L,44L,0L,11L,49L,21L,2L,55L,55L,17L,5L,61L,69L,55L,3L,14L,14L,59L,38L,22L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116987Inst : IEnumerable<long>
{
public static readonly long[] Value=A116987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116987.Bytes);
public long this[int i]=>Value[i];

public static A116987Inst Instance=new A116987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116988
{
public static readonly long[] Value={ 1L,27L,648L,10539L,149346L,1938780L,23903442L,284222502L,3292100235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116988Inst : IEnumerable<long>
{
public static readonly long[] Value=A116988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116988.Bytes);
public long this[int i]=>Value[i];

public static A116988Inst Instance=new A116988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116989
{
public static readonly BigInteger[] Value={ 1L,925L,1135716L,593223373L,130220375812L,14195655302684L,893936543319276L,36397263567477054L,1025115791220794876L,BigInteger.Parse("21899052879460199956"),BigInteger.Parse("372805053916689840596"),BigInteger.Parse("5076066733212581886566"),BigInteger.Parse("57875038239259949679248") };
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
public class A116989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116989Inst Instance=new A116989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116990
{
public static readonly long[] Value={ 1L,2L,11L,20L,40L,68L,92L,212L,236L,253L,266L,321L,328L,452L,582L,589L,596L,668L,695L,716L,782L,788L,836L,928L,932L,970L,991L,1012L,1065L,1076L,1173L,1264L,1300L,1336L,1388L,1436L,1490L,1549L,1796L,1854L,1927L,1995L,2159L,2228L,2252L,2468L,2545L,2588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116990Inst : IEnumerable<long>
{
public static readonly long[] Value=A116990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116990.Bytes);
public long this[int i]=>Value[i];

public static A116990Inst Instance=new A116990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116991
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,3L,6L,7L,8L,7L,10L,7L,12L,7L,9L,15L,16L,13L,18L,15L,10L,16L,22L,16L,24L,18L,26L,21L,28L,14L,30L,31L,22L,22L,22L,29L,36L,24L,26L,31L,40L,14L,42L,35L,33L,29L,46L,32L,48L,32L,37L,44L,52L,36L,41L,41L,43L,38L,58L,36L,60L,40L,46L,63L,51L,32L,66L,57L,49L,35L,70L,59L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116991Inst : IEnumerable<long>
{
public static readonly long[] Value=A116991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116991.Bytes);
public long this[int i]=>Value[i];

public static A116991Inst Instance=new A116991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116992
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,3L,1L,4L,1L,3L,0L,4L,3L,0L,4L,9L,6L,6L,0L,4L,10L,0L,6L,4L,9L,11L,6L,10L,0L,2L,15L,17L,6L,16L,0L,5L,0L,19L,2L,13L,14L,25L,5L,3L,13L,0L,12L,23L,23L,15L,0L,24L,28L,12L,12L,20L,20L,3L,31L,22L,31L,27L,7L,0L,32L,32L,7L,6L,37L,36L,34L,40L,14L,20L,0L,33L,0L,19L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116992Inst : IEnumerable<long>
{
public static readonly long[] Value=A116992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116992.Bytes);
public long this[int i]=>Value[i];

public static A116992Inst Instance=new A116992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116993
{
public static readonly long[] Value={ 13L,1L,4L,44L,66L,484L,4444L,7326L,6666L,48884L,73326L,493284L,888888L,666666L,5426124L,4888884L,6672666L,7333326L,44888844L,73399326L,246888642L,67333266L,4073662593L,4893772884L,4533773244L,6800659866L,2715775062L,1481331852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116993Inst : IEnumerable<long>
{
public static readonly long[] Value=A116993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116993.Bytes);
public long this[int i]=>Value[i];

public static A116993Inst Instance=new A116993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116994
{
public static readonly long[] Value={ 3L,1759L,3323L,469303L,605113L,641969L,1110587L,1426669L,11148289L,18352349L,20473721L,21820391L,24710753L,30048589L,36690923L,40785301L,97060681L,155135369L,160593239L,168132247L,361391623L,377965069L,416572171L,645803201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116994Inst : IEnumerable<long>
{
public static readonly long[] Value=A116994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116994.Bytes);
public long this[int i]=>Value[i];

public static A116994Inst Instance=new A116994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116995
{
public static readonly long[] Value={ 5L,12L,35L,70L,176L,247L,425L,532L,782L,1247L,1426L,2035L,2501L,2752L,3290L,4187L,5192L,5551L,6700L,7526L,7957L,9322L,10292L,11837L,14065L,15251L,15862L,17120L,17767L,19097L,24130L,25676L,28085L,28912L,33227L,34126L,36895L,39772L,41750L,44807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116995Inst : IEnumerable<long>
{
public static readonly long[] Value=A116995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116995.Bytes);
public long this[int i]=>Value[i];

public static A116995Inst Instance=new A116995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116996
{
public static readonly long[] Value={ 0L,1L,4L,6L,10L,15L,22L,28L,36L,45L,56L,66L,78L,91L,106L,120L,136L,153L,172L,190L,210L,231L,254L,276L,300L,325L,352L,378L,406L,435L,466L,496L,528L,561L,596L,630L,666L,703L,742L,780L,820L,861L,904L,946L,990L,1035L,1082L,1128L,1176L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116996Inst : IEnumerable<long>
{
public static readonly long[] Value=A116996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116996.Bytes);
public long this[int i]=>Value[i];

public static A116996Inst Instance=new A116996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116997
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,3L,4L,5L,6L,2L,2L,2L,3L,2L,3L,3L,4L,5L,2L,6L,2L,7L,2L,8L,2L,2L,2L,3L,3L,2L,2L,4L,5L,2L,5L,2L,2L,2L,3L,2L,3L,2L,4L,2L,5L,2L,2L,2L,3L,3L,2L,4L,4L,3L,2L,3L,4L,3L,5L,4L,2L,5L,2L,2L,2L,3L,2L,3L,2L,4L,2L,3L,2L,4L,3L,4L,2L,2L,4L,4L,2L,5L,2L,2L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116997Inst : IEnumerable<long>
{
public static readonly long[] Value=A116997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116997.Bytes);
public long this[int i]=>Value[i];

public static A116997Inst Instance=new A116997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116998
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,30L,42L,60L,66L,70L,78L,84L,90L,102L,105L,110L,114L,120L,126L,130L,132L,138L,140L,150L,154L,156L,165L,168L,170L,174L,180L,182L,186L,190L,195L,198L,204L,210L,330L,390L,420L,462L,510L,546L,570L,630L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116998Inst : IEnumerable<long>
{
public static readonly long[] Value=A116998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116998.Bytes);
public long this[int i]=>Value[i];

public static A116998Inst Instance=new A116998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116999
{
public static readonly long[] Value={ 11L,15L,17L,23L,27L,47L,231L,457L,1249L,1529L,2343L,4693L,5939L,5997L,8367L,19855L,21295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116999Inst : IEnumerable<long>
{
public static readonly long[] Value=A116999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116999.Bytes);
public long this[int i]=>Value[i];

public static A116999Inst Instance=new A116999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117000
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-4L,-2L,8L,1L,7L,-4L,-10L,-2L,-12L,8L,8L,1L,18L,7L,-18L,-4L,-16L,-10L,24L,-2L,21L,-12L,-20L,8L,-28L,8L,32L,1L,20L,18L,-32L,7L,-36L,-18L,24L,-4L,42L,-16L,-42L,-10L,-28L,24L,48L,-2L,57L,21L,-36L,-12L,-52L,-20L,40L,8L,36L,-28L,-58L,8L,-60L,32L,56L,1L,48L,20L,-66L,18L,-48L,-32L,72L,7L,74L,-36L,-42L,-18L,-80L,24L,80L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117000Inst : IEnumerable<long>
{
public static readonly long[] Value=A117000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117000.Bytes);
public long this[int i]=>Value[i];

public static A117000Inst Instance=new A117000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117001
{
public static readonly long[] Value={ 0L,-1L,-4L,-1L,-6L,-4L,6L,-1L,8L,-6L,-12L,2L,-14L,6L,12L,-1L,16L,11L,-20L,-6L,-12L,-12L,22L,2L,24L,-14L,-16L,6L,-30L,22L,30L,-1L,24L,16L,-24L,11L,-38L,-20L,28L,4L,40L,-12L,-44L,-12L,-14L,22L,46L,2L,48L,29L,-32L,-14L,-54L,-16L,48L,-8L,40L,-30L,-60L,22L,-62L,30L,46L,-1L,56L,24L,-68L,16L,-44L,-38L,70L,11L,72L,-38L,-28L,-20L,-96L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117001Inst : IEnumerable<long>
{
public static readonly long[] Value=A117001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117001.Bytes);
public long this[int i]=>Value[i];

public static A117001Inst Instance=new A117001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117002
{
public static readonly long[] Value={ 1L,6L,10L,16L,18L,30L,26L,42L,37L,54L,42L,76L,50L,78L,72L,94L,66L,120L,74L,126L,104L,126L,90L,180L,103L,150L,136L,182L,114L,222L,122L,210L,168L,198L,156L,286L,146L,222L,200L,288L,162L,312L,170L,294L,258L,270L,186L,400L,201L,324L,264L,350L,210L,408L,252L,396L,296L,342L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117002Inst : IEnumerable<long>
{
public static readonly long[] Value=A117002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117002.Bytes);
public long this[int i]=>Value[i];

public static A117002Inst Instance=new A117002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117003
{
public static readonly long[] Value={ 1L,4L,6L,10L,10L,18L,14L,24L,21L,30L,22L,44L,26L,42L,40L,52L,34L,66L,38L,70L,56L,66L,46L,100L,55L,78L,72L,98L,58L,122L,62L,112L,88L,102L,84L,156L,74L,114L,104L,156L,82L,168L,86L,154L,138L,138L,94L,216L,105L,170L,136L,182L,106L,216L,132L,212L,152L,174L,118L,294L,122L,186L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117003Inst : IEnumerable<long>
{
public static readonly long[] Value=A117003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117003.Bytes);
public long this[int i]=>Value[i];

public static A117003Inst Instance=new A117003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117004
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,6L,5L,6L,2L,12L,2L,6L,8L,10L,2L,12L,2L,14L,8L,6L,2L,20L,7L,6L,8L,14L,2L,22L,2L,14L,8L,6L,12L,26L,2L,6L,8L,24L,2L,24L,2L,14L,18L,6L,2L,32L,9L,16L,8L,14L,2L,24L,12L,28L,8L,6L,2L,42L,2L,6L,22L,22L,12L,24L,2L,14L,8L,30L,2L,48L,2L,6L,18L,14L,16L,24L,2L,40L,17L,6L,2L,46L,12L,6L,8L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117004Inst : IEnumerable<long>
{
public static readonly long[] Value=A117004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117004.Bytes);
public long this[int i]=>Value[i];

public static A117004Inst Instance=new A117004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117005
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,-1L,2L,2L,-4L,2L,2L,-4L,2L,2L,-4L,2L,2L,-4L,2L,2L,-4L,-3L,2L,-4L,2L,2L,-14L,2L,2L,-4L,2L,-8L,-4L,2L,2L,-4L,-8L,2L,-4L,2L,2L,-14L,2L,2L,-4L,9L,-8L,-4L,2L,2L,-4L,-8L,16L,-4L,2L,2L,-14L,2L,2L,10L,2L,-8L,-4L,2L,2L,-4L,6L,2L,-4L,2L,2L,-14L,2L,16L,-4L,2L,-8L,5L,2L,2L,10L,-8L,2L,-4L,2L,2L,4L,16L,2L,-4L,2L,-8L,-4L,2L,16L,14L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117005Inst : IEnumerable<long>
{
public static readonly long[] Value=A117005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117005.Bytes);
public long this[int i]=>Value[i];

public static A117005Inst Instance=new A117005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117006
{
public static readonly long[] Value={ 1L,0L,-6L,0L,-10L,-6L,14L,0L,15L,-10L,-22L,0L,-26L,14L,20L,0L,34L,18L,-38L,-10L,-28L,-22L,46L,0L,45L,-26L,-36L,14L,-58L,30L,62L,0L,44L,34L,-56L,18L,-74L,-38L,52L,0L,82L,-28L,-86L,-22L,-42L,46L,94L,0L,105L,50L,-68L,-26L,-106L,-36L,88L,0L,76L,-58L,-118L,30L,-122L,62L,102L,0L,104L,44L,-134L,34L,-92L,-70L,142L,18L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117006Inst : IEnumerable<long>
{
public static readonly long[] Value=A117006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117006.Bytes);
public long this[int i]=>Value[i];

public static A117006Inst Instance=new A117006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117007
{
public static readonly long[] Value={ 2L,-4L,2L,2L,-4L,2L,-8L,10L,2L,2L,-4L,-8L,2L,-4L,16L,2L,4L,-20L,2L,-4L,2L,6L,-4L,2L,2L,14L,-8L,2L,-12L,2L,-24L,16L,2L,2L,14L,16L,-8L,-4L,2L,-20L,-4L,-8L,16L,-12L,2L,2L,16L,2L,36L,-28L,-20L,-8L,14L,2L,2L,-4L,-20L,2L,-4L,2L,2L,12L,2L,16L,-4L,36L,-8L,-4L,-36L,-24L,-14L,38L,-20L,-4L,2L,2L,16L,16L,2L,14L,2L,-8L,4L,-20L,16L,-4L,-8L,-36L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117007Inst : IEnumerable<long>
{
public static readonly long[] Value=A117007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117007.Bytes);
public long this[int i]=>Value[i];

public static A117007Inst Instance=new A117007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117008
{
public static readonly long[] Value={ 1L,-2L,1L,1L,-2L,1L,-4L,5L,1L,1L,-2L,-4L,1L,-2L,8L,1L,2L,-10L,1L,-2L,1L,3L,-2L,1L,1L,7L,-4L,1L,-6L,1L,-12L,8L,1L,1L,7L,8L,-4L,-2L,1L,-10L,-2L,-4L,8L,-6L,1L,1L,8L,1L,18L,-14L,-10L,-4L,7L,1L,1L,-2L,-10L,1L,-2L,1L,1L,6L,1L,8L,-2L,18L,-4L,-2L,-18L,-12L,-7L,19L,-10L,-2L,1L,1L,8L,8L,1L,7L,1L,-4L,2L,-10L,8L,-2L,-4L,-18L,7L,1L,1L,-6L,1L,1L,10L,-12L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117008Inst : IEnumerable<long>
{
public static readonly long[] Value=A117008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117008.Bytes);
public long this[int i]=>Value[i];

public static A117008Inst Instance=new A117008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117009
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,-4L,2L,9L,-4L,-8L,2L,5L,2L,2L,0L,2L,-9L,-4L,2L,-8L,14L,16L,-11L,-4L,-8L,2L,-4L,-20L,16L,19L,2L,2L,-4L,2L,-8L,-16L,2L,19L,-8L,-8L,2L,-4L,16L,2L,16L,2L,-17L,14L,-24L,-16L,-4L,2L,2L,-4L,26L,2L,7L,2L,2L,16L,-20L,-24L,-4L,16L,-8L,-24L,2L,25L,-4L,-8L,16L,8L,2L,2L,8L,2L,2L,-32L,2L,17L,-4L,2L,-20L,14L,-32L,2L,-4L,-24L,36L,16L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117009Inst : IEnumerable<long>
{
public static readonly long[] Value=A117009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117009.Bytes);
public long this[int i]=>Value[i];

public static A117009Inst Instance=new A117009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117010
{
public static readonly long[] Value={ 0L,1L,3L,5L,11L,23L,29L,59L,119L,179L,209L,359L,419L,839L,1259L,1679L,2519L,4619L,7559L,9239L,13859L,18479L,27719L,55439L,83159L,110879L,120119L,180179L,240239L,360359L,720719L,1081079L,1441439L,1801799L,2042039L,2882879L,3063059L,4084079L,5405399L,6126119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117010Inst : IEnumerable<long>
{
public static readonly long[] Value=A117010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117010.Bytes);
public long this[int i]=>Value[i];

public static A117010Inst Instance=new A117010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117011
{
public static readonly BigInteger[] Value={ 0L,5L,2561L,687463202817L,BigInteger.Parse("25362915524915764560280676204545"),BigInteger.Parse("2157638231708538191934637891565042782652856782390367212752413267066881") };
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
public class A117011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117011Inst Instance=new A117011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117012
{
public static readonly long[] Value={ 3L,17L,47L,107L,173L,269L,503L,641L,809L,983L,1187L,1637L,2441L,2753L,4157L,4547L,4967L,5393L,5849L,6311L,6803L,7829L,8363L,9497L,11981L,12653L,13331L,14753L,15497L,17027L,22943L,26723L,29753L,31859L,32933L,38609L,39791L,42221L,47297L,49943L,58313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117012Inst : IEnumerable<long>
{
public static readonly long[] Value=A117012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117012.Bytes);
public long this[int i]=>Value[i];

public static A117012Inst Instance=new A117012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117013
{
public static readonly long[] Value={ 7L,0L,8L,0L,7L,3L,4L,1L,8L,2L,7L,3L,5L,7L,1L,1L,9L,3L,4L,9L,8L,7L,8L,4L,1L,1L,4L,7L,5L,0L,3L,8L,1L,0L,9L,4L,8L,8L,3L,0L,0L,0L,3L,8L,5L,5L,3L,7L,7L,7L,2L,4L,4L,5L,3L,7L,7L,5L,7L,4L,9L,8L,6L,8L,9L,0L,9L,8L,2L,4L,6L,8L,0L,6L,2L,0L,3L,9L,5L,8L,4L,5L,3L,7L,2L,6L,5L,8L,8L,8L,9L,3L,0L,0L,8L,4L,5L,7L,0L,1L,8L,3L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117013Inst : IEnumerable<long>
{
public static readonly long[] Value=A117013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117013.Bytes);
public long this[int i]=>Value[i];

public static A117013Inst Instance=new A117013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117014
{
public static readonly long[] Value={ 5L,9L,5L,8L,2L,3L,2L,3L,6L,5L,9L,0L,9L,5L,5L,5L,7L,4L,4L,6L,4L,1L,9L,0L,5L,4L,0L,5L,2L,0L,6L,9L,6L,6L,7L,9L,7L,5L,5L,1L,8L,8L,9L,7L,9L,5L,3L,5L,7L,1L,1L,9L,0L,3L,2L,1L,6L,5L,9L,3L,1L,2L,2L,1L,8L,5L,8L,2L,7L,3L,0L,0L,8L,0L,1L,6L,7L,6L,1L,3L,3L,7L,3L,3L,6L,5L,9L,2L,6L,4L,4L,4L,3L,9L,2L,7L,0L,5L,5L,9L,5L,3L,1L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117014Inst : IEnumerable<long>
{
public static readonly long[] Value=A117014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117014.Bytes);
public long this[int i]=>Value[i];

public static A117014Inst Instance=new A117014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117015
{
public static readonly long[] Value={ 5L,0L,1L,3L,6L,7L,9L,6L,5L,6L,6L,5L,6L,1L,9L,7L,0L,4L,1L,6L,8L,8L,8L,8L,0L,9L,1L,8L,6L,3L,1L,6L,2L,2L,9L,7L,2L,0L,4L,9L,8L,3L,6L,8L,5L,9L,5L,6L,9L,9L,5L,1L,6L,4L,5L,0L,1L,6L,9L,8L,7L,0L,1L,4L,0L,9L,3L,9L,0L,2L,6L,1L,0L,8L,5L,7L,1L,4L,1L,6L,2L,0L,4L,9L,6L,1L,2L,0L,5L,8L,2L,2L,4L,3L,1L,2L,2L,1L,2L,9L,0L,4L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117015Inst : IEnumerable<long>
{
public static readonly long[] Value=A117015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117015.Bytes);
public long this[int i]=>Value[i];

public static A117015Inst Instance=new A117015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117016
{
public static readonly long[] Value={ 4L,2L,1L,8L,8L,6L,5L,9L,5L,8L,1L,9L,7L,8L,0L,6L,5L,5L,4L,4L,5L,5L,0L,9L,0L,4L,9L,7L,5L,6L,6L,5L,2L,7L,8L,8L,9L,7L,7L,4L,0L,6L,4L,2L,1L,4L,2L,2L,3L,6L,1L,3L,0L,9L,8L,6L,4L,7L,7L,6L,9L,6L,4L,9L,7L,0L,1L,1L,8L,2L,1L,4L,7L,4L,9L,4L,2L,2L,7L,9L,5L,4L,2L,8L,3L,1L,1L,9L,1L,3L,4L,8L,3L,3L,5L,9L,0L,4L,8L,3L,2L,4L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117016Inst : IEnumerable<long>
{
public static readonly long[] Value=A117016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117016.Bytes);
public long this[int i]=>Value[i];

public static A117016Inst Instance=new A117016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117017
{
public static readonly long[] Value={ 9L,1L,7L,3L,1L,7L,2L,7L,5L,9L,7L,8L,1L,0L,8L,0L,8L,1L,9L,0L,4L,2L,7L,1L,8L,3L,5L,3L,6L,0L,2L,6L,0L,3L,0L,8L,3L,1L,6L,8L,3L,1L,3L,8L,2L,5L,3L,1L,2L,3L,4L,2L,3L,0L,4L,0L,7L,3L,0L,6L,7L,8L,3L,5L,6L,5L,5L,6L,3L,1L,6L,8L,8L,5L,4L,3L,4L,9L,8L,5L,0L,9L,5L,4L,3L,7L,9L,0L,9L,0L,0L,6L,8L,9L,0L,4L,8L,3L,9L,7L,3L,5L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117017Inst : IEnumerable<long>
{
public static readonly long[] Value=A117017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117017.Bytes);
public long this[int i]=>Value[i];

public static A117017Inst Instance=new A117017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117018
{
public static readonly long[] Value={ 9L,4L,4L,0L,8L,9L,2L,4L,1L,2L,4L,3L,0L,6L,4L,7L,7L,2L,7L,9L,6L,4L,8L,9L,9L,0L,5L,7L,9L,1L,4L,2L,1L,7L,0L,7L,9L,8L,6L,1L,7L,7L,2L,7L,1L,6L,6L,4L,9L,5L,9L,5L,5L,3L,6L,9L,8L,0L,7L,8L,5L,2L,2L,8L,7L,1L,5L,7L,0L,0L,6L,4L,4L,1L,1L,9L,3L,4L,5L,7L,9L,1L,1L,8L,7L,4L,5L,9L,3L,6L,2L,5L,0L,7L,8L,7L,8L,7L,6L,7L,4L,2L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117018Inst : IEnumerable<long>
{
public static readonly long[] Value=A117018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117018.Bytes);
public long this[int i]=>Value[i];

public static A117018Inst Instance=new A117018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117019
{
public static readonly long[] Value={ 9L,5L,7L,7L,6L,6L,8L,1L,7L,1L,2L,1L,0L,0L,8L,8L,8L,6L,9L,1L,0L,3L,2L,4L,3L,7L,6L,2L,9L,8L,0L,4L,8L,6L,6L,9L,0L,5L,2L,6L,0L,3L,8L,3L,7L,2L,9L,5L,5L,6L,9L,1L,9L,1L,4L,8L,9L,1L,5L,6L,2L,8L,7L,2L,5L,6L,7L,6L,4L,7L,7L,9L,9L,6L,7L,8L,6L,4L,1L,1L,5L,8L,8L,1L,0L,3L,0L,2L,8L,3L,1L,8L,2L,6L,2L,6L,1L,6L,6L,7L,4L,9L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117019Inst : IEnumerable<long>
{
public static readonly long[] Value=A117019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117019.Bytes);
public long this[int i]=>Value[i];

public static A117019Inst Instance=new A117019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117020
{
public static readonly long[] Value={ 9L,6L,6L,0L,6L,8L,2L,9L,4L,2L,8L,2L,2L,8L,4L,8L,0L,7L,5L,9L,2L,8L,3L,4L,0L,0L,7L,7L,9L,0L,8L,2L,8L,4L,8L,7L,3L,4L,8L,6L,9L,9L,5L,7L,0L,0L,1L,3L,8L,6L,3L,0L,2L,1L,9L,1L,1L,7L,3L,8L,5L,9L,7L,3L,1L,0L,1L,5L,9L,6L,0L,8L,6L,2L,2L,5L,3L,7L,7L,8L,8L,9L,6L,5L,1L,7L,7L,2L,1L,6L,1L,1L,4L,9L,4L,7L,5L,6L,9L,5L,8L,0L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117020Inst : IEnumerable<long>
{
public static readonly long[] Value=A117020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117020.Bytes);
public long this[int i]=>Value[i];

public static A117020Inst Instance=new A117020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117021
{
public static readonly long[] Value={ 1L,4L,1L,2L,2L,8L,2L,9L,2L,7L,4L,3L,7L,3L,9L,1L,9L,1L,4L,6L,0L,9L,3L,3L,5L,0L,0L,4L,5L,4L,1L,6L,2L,4L,9L,0L,2L,3L,7L,2L,2L,9L,5L,1L,1L,4L,3L,5L,0L,8L,1L,7L,2L,0L,8L,0L,5L,3L,2L,7L,2L,6L,0L,6L,4L,9L,9L,2L,7L,9L,0L,2L,9L,7L,5L,1L,1L,2L,6L,3L,5L,4L,5L,5L,4L,8L,7L,1L,9L,1L,4L,7L,0L,4L,6L,8L,4L,7L,7L,9L,9L,6L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117021Inst : IEnumerable<long>
{
public static readonly long[] Value=A117021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117021.Bytes);
public long this[int i]=>Value[i];

public static A117021Inst Instance=new A117021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117022
{
public static readonly long[] Value={ 1L,6L,7L,8L,3L,5L,0L,1L,1L,8L,9L,4L,0L,5L,9L,4L,0L,5L,4L,4L,9L,1L,3L,8L,7L,3L,0L,7L,5L,8L,2L,3L,5L,3L,1L,9L,8L,3L,1L,8L,5L,6L,2L,3L,4L,9L,0L,4L,1L,9L,2L,4L,9L,0L,9L,5L,2L,4L,2L,6L,5L,8L,7L,5L,4L,9L,3L,9L,9L,4L,7L,5L,5L,7L,1L,3L,6L,6L,5L,6L,8L,5L,8L,4L,4L,3L,1L,2L,2L,7L,9L,2L,4L,4L,2L,5L,3L,8L,0L,1L,7L,7L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117022Inst : IEnumerable<long>
{
public static readonly long[] Value=A117022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117022.Bytes);
public long this[int i]=>Value[i];

public static A117022Inst Instance=new A117022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117023
{
public static readonly long[] Value={ 1L,9L,9L,4L,5L,4L,3L,0L,6L,7L,1L,3L,1L,1L,2L,9L,5L,9L,6L,0L,1L,2L,5L,2L,3L,0L,9L,0L,4L,4L,0L,8L,2L,8L,4L,2L,5L,0L,9L,5L,4L,7L,7L,5L,4L,0L,8L,0L,3L,4L,4L,8L,3L,0L,4L,5L,4L,0L,7L,9L,4L,8L,7L,0L,3L,1L,4L,6L,2L,5L,7L,9L,7L,2L,2L,8L,3L,6L,1L,9L,7L,9L,8L,2L,2L,6L,8L,4L,8L,4L,0L,1L,5L,1L,3L,8L,2L,1L,4L,0L,2L,3L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117023Inst : IEnumerable<long>
{
public static readonly long[] Value=A117023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117023.Bytes);
public long this[int i]=>Value[i];

public static A117023Inst Instance=new A117023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117024
{
public static readonly long[] Value={ 2L,3L,7L,0L,3L,0L,5L,2L,1L,9L,2L,4L,2L,3L,1L,7L,0L,8L,2L,3L,0L,4L,1L,2L,5L,5L,2L,6L,1L,8L,1L,1L,6L,6L,8L,3L,2L,7L,2L,1L,5L,1L,7L,7L,4L,1L,8L,4L,2L,1L,2L,1L,7L,7L,6L,8L,6L,0L,3L,2L,4L,3L,3L,9L,9L,9L,3L,2L,9L,4L,6L,0L,0L,3L,2L,9L,7L,0L,2L,0L,4L,7L,0L,6L,7L,9L,7L,8L,7L,7L,0L,1L,0L,6L,5L,1L,5L,2L,0L,6L,4L,3L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117024Inst : IEnumerable<long>
{
public static readonly long[] Value=A117024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117024.Bytes);
public long this[int i]=>Value[i];

public static A117024Inst Instance=new A117024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117025
{
public static readonly long[] Value={ 2L,3L,1L,9L,7L,7L,6L,8L,2L,4L,7L,1L,5L,8L,5L,3L,1L,7L,3L,9L,5L,6L,5L,9L,0L,3L,7L,7L,5L,0L,3L,2L,6L,6L,8L,1L,3L,2L,5L,4L,9L,0L,4L,7L,7L,2L,3L,7L,6L,2L,6L,2L,8L,3L,3L,4L,5L,4L,0L,5L,4L,9L,8L,4L,8L,6L,5L,1L,2L,1L,1L,4L,8L,3L,1L,4L,6L,9L,2L,1L,4L,2L,4L,2L,6L,4L,9L,8L,4L,4L,9L,4L,0L,7L,1L,5L,3L,8L,9L,0L,0L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117025Inst : IEnumerable<long>
{
public static readonly long[] Value=A117025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117025.Bytes);
public long this[int i]=>Value[i];

public static A117025Inst Instance=new A117025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117026
{
public static readonly long[] Value={ 4L,3L,1L,0L,7L,5L,9L,5L,0L,6L,4L,5L,5L,9L,2L,3L,2L,4L,6L,6L,6L,6L,5L,8L,6L,3L,6L,1L,0L,7L,7L,8L,0L,8L,0L,2L,9L,8L,6L,8L,3L,5L,7L,2L,8L,1L,8L,5L,6L,7L,4L,6L,0L,3L,3L,6L,2L,2L,6L,4L,7L,7L,0L,4L,4L,3L,5L,0L,2L,3L,1L,7L,1L,6L,3L,4L,8L,8L,6L,2L,7L,2L,0L,1L,8L,7L,0L,5L,3L,3L,7L,2L,1L,4L,3L,8L,1L,5L,1L,3L,0L,6L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117026Inst : IEnumerable<long>
{
public static readonly long[] Value=A117026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117026.Bytes);
public long this[int i]=>Value[i];

public static A117026Inst Instance=new A117026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117027
{
public static readonly long[] Value={ -1L,-12L,-48L,152L,102L,-60L,-24L,-72L,-24L,-60L,-24L,1942L,896L,-1124L,522L,-1938L,554L,1376L,-806L,-96L,-24L,1716L,4598L,-48L,2886L,-2348L,-96L,2380L,4908L,1246L,-4158L,-180L,-1526L,1442L,-1882L,-4986L,-5214L,-72L,-96L,-5694L,-2014L,-84L,-2058L,8232L,-4324L,-24L,-84L,-14076L,-4844L,-7398L,12274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117027Inst : IEnumerable<long>
{
public static readonly long[] Value=A117027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117027.Bytes);
public long this[int i]=>Value[i];

public static A117027Inst Instance=new A117027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117028
{
public static readonly long[] Value={ 0L,7L,4L,9L,6L,0L,8L,5L,4L,5L,6L,0L,4L,9L,5L,5L,0L,6L,1L,3L,8L,3L,8L,9L,4L,5L,4L,2L,5L,9L,4L,0L,4L,6L,9L,6L,5L,9L,4L,8L,7L,4L,5L,4L,0L,4L,6L,5L,3L,5L,8L,7L,3L,3L,5L,4L,1L,5L,5L,6L,7L,5L,7L,1L,2L,4L,2L,2L,6L,9L,7L,6L,6L,2L,2L,1L,3L,3L,1L,3L,2L,3L,4L,3L,0L,3L,6L,4L,8L,9L,8L,8L,7L,9L,6L,7L,9L,4L,2L,7L,9L,3L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117028Inst : IEnumerable<long>
{
public static readonly long[] Value=A117028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117028.Bytes);
public long this[int i]=>Value[i];

public static A117028Inst Instance=new A117028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117029
{
public static readonly long[] Value={ 1L,7L,2L,6L,0L,3L,7L,4L,6L,2L,6L,9L,0L,9L,1L,6L,7L,8L,5L,1L,3L,4L,1L,0L,9L,7L,5L,8L,6L,3L,9L,0L,9L,0L,6L,9L,8L,4L,0L,1L,0L,8L,4L,0L,8L,8L,9L,6L,4L,0L,4L,8L,0L,4L,9L,0L,8L,5L,3L,6L,3L,1L,5L,6L,6L,7L,9L,1L,5L,2L,2L,6L,8L,2L,1L,6L,4L,8L,2L,8L,4L,2L,2L,5L,0L,7L,0L,8L,6L,9L,0L,0L,0L,5L,7L,1L,4L,6L,8L,9L,8L,6L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117029Inst : IEnumerable<long>
{
public static readonly long[] Value=A117029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117029.Bytes);
public long this[int i]=>Value[i];

public static A117029Inst Instance=new A117029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117030
{
public static readonly BigInteger[] Value={ 1L,1L,1L,0L,-2L,-3L,3L,-10L,-28L,279L,-7803L,-2177000L,16987130758L,-36980983660158439L,BigInteger.Parse("-628200804994572838287982201"),BigInteger.Parse("23231483704802676028750227275477328286998042"),BigInteger.Parse("-14594036764575342428539025427350979161630036659925283421091485142638200") };
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
public class A117030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117030Inst Instance=new A117030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117031
{
public static readonly long[] Value={ 5L,7L,9L,3L,6L,1L,7L,0L,0L,7L,8L,3L,1L,2L,5L,4L,5L,7L,0L,2L,1L,5L,6L,5L,4L,5L,6L,1L,0L,7L,2L,5L,9L,3L,2L,1L,9L,8L,4L,6L,2L,6L,0L,0L,6L,3L,9L,9L,3L,0L,7L,0L,3L,0L,2L,4L,7L,1L,1L,9L,0L,3L,6L,2L,5L,1L,8L,7L,7L,2L,0L,5L,8L,2L,8L,6L,3L,3L,6L,8L,8L,5L,3L,0L,4L,3L,6L,4L,5L,5L,0L,8L,4L,5L,8L,4L,3L,9L,4L,7L,6L,3L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117031Inst : IEnumerable<long>
{
public static readonly long[] Value=A117031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117031.Bytes);
public long this[int i]=>Value[i];

public static A117031Inst Instance=new A117031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117032
{
public static readonly long[] Value={ 1L,3L,3L,4L,0L,2L,9L,6L,1L,5L,6L,7L,4L,9L,0L,1L,4L,0L,0L,6L,5L,2L,3L,3L,2L,1L,8L,2L,1L,0L,3L,0L,6L,6L,0L,8L,1L,2L,5L,3L,8L,4L,2L,8L,5L,0L,7L,0L,0L,9L,7L,8L,2L,2L,1L,7L,2L,5L,6L,7L,1L,6L,0L,0L,5L,0L,2L,0L,7L,5L,7L,3L,7L,4L,5L,8L,7L,4L,7L,6L,2L,5L,7L,9L,5L,5L,3L,4L,7L,4L,2L,3L,8L,6L,9L,1L,0L,2L,8L,4L,2L,8L,3L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117032Inst : IEnumerable<long>
{
public static readonly long[] Value=A117032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117032.Bytes);
public long this[int i]=>Value[i];

public static A117032Inst Instance=new A117032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117033
{
public static readonly long[] Value={ 2L,9L,1L,9L,2L,6L,5L,8L,1L,7L,2L,6L,4L,2L,8L,8L,0L,6L,5L,0L,1L,2L,1L,5L,8L,8L,5L,2L,4L,9L,6L,1L,8L,9L,0L,5L,1L,1L,6L,9L,9L,9L,6L,1L,4L,4L,6L,2L,2L,2L,7L,5L,5L,4L,6L,2L,2L,4L,2L,5L,0L,1L,3L,1L,0L,9L,0L,1L,7L,5L,3L,1L,9L,3L,7L,9L,6L,0L,4L,1L,5L,4L,6L,2L,7L,3L,4L,1L,1L,1L,0L,6L,9L,9L,1L,5L,4L,2L,9L,8L,1L,6L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117033Inst : IEnumerable<long>
{
public static readonly long[] Value=A117033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117033.Bytes);
public long this[int i]=>Value[i];

public static A117033Inst Instance=new A117033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117034
{
public static readonly long[] Value={ 1L,5L,7L,7L,2L,8L,6L,0L,5L,2L,5L,0L,9L,9L,3L,4L,2L,3L,7L,3L,2L,8L,0L,9L,2L,5L,6L,8L,9L,9L,4L,1L,7L,1L,2L,7L,2L,0L,0L,8L,1L,3L,0L,4L,1L,3L,0L,9L,5L,4L,4L,5L,8L,8L,5L,4L,9L,0L,5L,1L,4L,5L,8L,3L,0L,3L,7L,4L,2L,9L,9L,6L,7L,0L,2L,5L,7L,0L,5L,1L,8L,2L,8L,1L,3L,9L,0L,2L,7L,2L,2L,2L,6L,4L,6L,4L,1L,6L,6L,4L,6L,4L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117034Inst : IEnumerable<long>
{
public static readonly long[] Value=A117034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117034.Bytes);
public long this[int i]=>Value[i];

public static A117034Inst Instance=new A117034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117035
{
public static readonly long[] Value={ 0L,8L,5L,2L,2L,1L,1L,2L,9L,1L,1L,8L,4L,7L,7L,3L,1L,7L,1L,7L,1L,3L,1L,9L,8L,6L,2L,3L,6L,2L,4L,0L,0L,1L,0L,7L,4L,3L,8L,9L,8L,2L,9L,1L,4L,8L,8L,1L,4L,5L,0L,2L,7L,3L,7L,4L,6L,5L,4L,8L,7L,2L,7L,6L,2L,7L,4L,2L,5L,3L,2L,4L,9L,6L,1L,6L,3L,4L,9L,9L,2L,9L,7L,5L,0L,8L,0L,2L,8L,0L,3L,6L,4L,1L,4L,3L,0L,7L,2L,5L,3L,7L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117035Inst : IEnumerable<long>
{
public static readonly long[] Value=A117035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117035.Bytes);
public long this[int i]=>Value[i];

public static A117035Inst Instance=new A117035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117036
{
public static readonly long[] Value={ 0L,4L,6L,0L,4L,5L,1L,7L,2L,5L,7L,1L,3L,9L,9L,7L,5L,9L,5L,0L,7L,3L,8L,3L,8L,2L,9L,5L,1L,7L,9L,3L,8L,5L,5L,2L,1L,0L,5L,5L,7L,0L,7L,0L,7L,2L,0L,9L,5L,9L,3L,5L,3L,6L,0L,9L,7L,5L,5L,6L,3L,7L,2L,2L,3L,4L,7L,1L,9L,3L,3L,8L,5L,5L,9L,1L,5L,2L,1L,4L,0L,3L,3L,2L,7L,6L,3L,9L,4L,6L,6L,1L,0L,1L,0L,7L,0L,2L,8L,4L,8L,8L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117036Inst : IEnumerable<long>
{
public static readonly long[] Value=A117036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117036.Bytes);
public long this[int i]=>Value[i];

public static A117036Inst Instance=new A117036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117037
{
public static readonly long[] Value={ 7L,3L,5L,0L,5L,2L,5L,8L,7L,1L,4L,4L,7L,1L,5L,5L,9L,7L,3L,2L,0L,9L,2L,6L,1L,0L,3L,5L,7L,3L,4L,7L,4L,1L,0L,3L,8L,9L,1L,7L,5L,2L,2L,9L,1L,7L,6L,1L,9L,4L,9L,8L,7L,4L,6L,9L,4L,8L,3L,7L,8L,5L,2L,3L,7L,8L,4L,5L,2L,7L,7L,7L,6L,6L,6L,2L,9L,7L,8L,0L,4L,0L,3L,5L,9L,6L,3L,2L,3L,9L,3L,8L,5L,2L,3L,8L,3L,1L,9L,8L,5L,5L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117037Inst : IEnumerable<long>
{
public static readonly long[] Value=A117037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117037.Bytes);
public long this[int i]=>Value[i];

public static A117037Inst Instance=new A117037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117038
{
public static readonly long[] Value={ 8L,1L,4L,4L,7L,7L,2L,1L,6L,6L,9L,9L,5L,1L,2L,1L,2L,5L,4L,4L,5L,8L,2L,8L,7L,6L,3L,0L,1L,7L,8L,6L,2L,8L,9L,7L,1L,0L,6L,7L,2L,0L,7L,4L,7L,1L,6L,0L,7L,2L,7L,8L,3L,4L,3L,2L,5L,9L,0L,6L,3L,7L,4L,3L,0L,8L,1L,5L,9L,6L,2L,8L,0L,8L,5L,6L,2L,6L,1L,5L,7L,2L,0L,9L,2L,0L,8L,8L,9L,3L,0L,3L,1L,2L,6L,8L,0L,8L,3L,7L,4L,3L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117038Inst : IEnumerable<long>
{
public static readonly long[] Value=A117038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117038.Bytes);
public long this[int i]=>Value[i];

public static A117038Inst Instance=new A117038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117039
{
public static readonly long[] Value={ 8L,5L,7L,3L,5L,2L,0L,7L,8L,8L,7L,1L,1L,6L,9L,2L,3L,7L,7L,5L,7L,4L,1L,4L,2L,0L,8L,2L,8L,4L,3L,5L,9L,0L,0L,6L,6L,3L,3L,2L,0L,4L,7L,6L,5L,5L,9L,5L,4L,2L,0L,6L,7L,0L,3L,4L,1L,8L,1L,3L,6L,3L,9L,0L,7L,7L,1L,3L,9L,2L,9L,8L,9L,9L,4L,8L,5L,1L,5L,0L,6L,6L,0L,3L,6L,6L,7L,4L,6L,9L,9L,0L,0L,4L,2L,2L,2L,9L,5L,4L,6L,5L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117039Inst : IEnumerable<long>
{
public static readonly long[] Value=A117039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117039.Bytes);
public long this[int i]=>Value[i];

public static A117039Inst Instance=new A117039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117040
{
public static readonly long[] Value={ 8L,8L,4L,1L,5L,2L,8L,7L,6L,5L,0L,1L,7L,7L,9L,7L,4L,3L,2L,5L,2L,5L,9L,2L,6L,7L,1L,5L,1L,7L,5L,6L,0L,2L,1L,9L,1L,8L,7L,1L,6L,6L,4L,3L,9L,1L,9L,3L,9L,8L,9L,1L,2L,4L,9L,6L,6L,2L,8L,0L,5L,6L,8L,3L,4L,1L,0L,1L,3L,1L,6L,0L,0L,3L,5L,9L,6L,0L,1L,8L,7L,6L,4L,0L,3L,6L,8L,0L,0L,2L,6L,6L,3L,6L,3L,0L,9L,3L,7L,7L,4L,0L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117040Inst : IEnumerable<long>
{
public static readonly long[] Value=A117040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117040.Bytes);
public long this[int i]=>Value[i];

public static A117040Inst Instance=new A117040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117041
{
public static readonly long[] Value={ 3L,4L,2L,5L,5L,1L,8L,8L,2L,0L,8L,1L,4L,7L,5L,9L,7L,6L,0L,9L,4L,1L,6L,7L,8L,9L,3L,3L,5L,4L,1L,1L,3L,6L,6L,4L,8L,0L,5L,3L,7L,4L,7L,4L,3L,2L,0L,5L,7L,3L,8L,4L,7L,6L,5L,8L,6L,8L,5L,1L,4L,7L,6L,7L,7L,4L,2L,6L,6L,1L,3L,6L,3L,3L,1L,1L,9L,2L,8L,2L,7L,1L,8L,1L,9L,9L,6L,5L,4L,6L,6L,3L,7L,2L,9L,6L,6L,1L,0L,4L,0L,4L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117041Inst : IEnumerable<long>
{
public static readonly long[] Value=A117041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117041.Bytes);
public long this[int i]=>Value[i];

public static A117041Inst Instance=new A117041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117042
{
public static readonly long[] Value={ 6L,3L,4L,0L,0L,0L,4L,0L,7L,4L,7L,7L,5L,7L,8L,7L,6L,3L,0L,8L,6L,1L,6L,5L,2L,7L,1L,1L,8L,4L,1L,6L,5L,8L,6L,1L,6L,4L,2L,9L,2L,2L,3L,6L,4L,5L,8L,1L,5L,9L,3L,4L,2L,9L,2L,8L,7L,5L,7L,4L,0L,6L,2L,3L,0L,0L,0L,9L,9L,6L,4L,6L,0L,7L,7L,8L,0L,6L,0L,8L,8L,5L,2L,7L,2L,2L,0L,7L,2L,1L,4L,3L,2L,8L,0L,6L,3L,8L,5L,3L,5L,0L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117042Inst : IEnumerable<long>
{
public static readonly long[] Value=A117042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117042.Bytes);
public long this[int i]=>Value[i];

public static A117042Inst Instance=new A117042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117043
{
public static readonly long[] Value={ 1L,1L,7L,3L,4L,1L,7L,9L,1L,9L,1L,7L,5L,6L,1L,4L,2L,1L,9L,0L,4L,3L,2L,6L,7L,7L,6L,8L,6L,5L,3L,5L,1L,2L,7L,4L,6L,8L,8L,6L,4L,4L,8L,0L,5L,0L,4L,9L,4L,4L,6L,0L,9L,5L,7L,2L,6L,0L,0L,8L,9L,1L,8L,8L,9L,6L,4L,3L,6L,2L,6L,8L,7L,7L,9L,0L,2L,8L,7L,4L,9L,4L,7L,2L,0L,0L,1L,0L,6L,9L,9L,5L,6L,7L,5L,1L,7L,4L,0L,7L,4L,5L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117043Inst : IEnumerable<long>
{
public static readonly long[] Value=A117043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117043.Bytes);
public long this[int i]=>Value[i];

public static A117043Inst Instance=new A117043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117044
{
public static readonly long[] Value={ 2L,1L,7L,1L,7L,8L,0L,3L,2L,8L,2L,1L,8L,6L,7L,2L,8L,0L,1L,4L,1L,7L,3L,3L,9L,5L,2L,4L,0L,4L,3L,0L,7L,7L,1L,6L,7L,1L,4L,3L,2L,5L,9L,4L,7L,3L,3L,7L,3L,5L,8L,0L,3L,3L,5L,2L,2L,4L,8L,6L,0L,5L,6L,4L,5L,3L,4L,8L,4L,4L,0L,7L,9L,7L,8L,8L,9L,5L,3L,9L,8L,6L,9L,0L,3L,8L,5L,3L,3L,9L,4L,0L,9L,9L,9L,6L,1L,4L,4L,1L,0L,1L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117044Inst : IEnumerable<long>
{
public static readonly long[] Value=A117044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117044.Bytes);
public long this[int i]=>Value[i];

public static A117044Inst Instance=new A117044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117045
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,15L,17L,18L,20L,24L,26L,27L,30L,35L,37L,38L,39L,40L,42L,48L,50L,51L,56L,63L,65L,66L,68L,72L,80L,82L,83L,84L,87L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117045Inst : IEnumerable<long>
{
public static readonly long[] Value=A117045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117045.Bytes);
public long this[int i]=>Value[i];

public static A117045Inst Instance=new A117045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117046
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,0L,0L,1L,1L,3L,2L,4L,2L,3L,8L,5L,5L,5L,5L,7L,7L,8L,8L,7L,9L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117046Inst : IEnumerable<long>
{
public static readonly long[] Value=A117046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117046.Bytes);
public long this[int i]=>Value[i];

public static A117046Inst Instance=new A117046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117047
{
public static readonly long[] Value={ 11L,71L,131L,191L,251L,311L,431L,491L,911L,971L,1031L,1091L,1151L,1451L,1511L,1571L,1811L,1871L,1931L,2111L,2351L,2411L,2531L,2591L,2711L,3011L,3191L,3251L,3371L,3491L,3671L,3851L,3911L,4091L,4211L,4271L,4391L,4451L,4691L,4751L,4871L,4931L,5051L,5171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117047Inst : IEnumerable<long>
{
public static readonly long[] Value=A117047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117047.Bytes);
public long this[int i]=>Value[i];

public static A117047Inst Instance=new A117047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117048
{
public static readonly long[] Value={ 2L,7L,11L,13L,29L,31L,37L,43L,61L,67L,73L,79L,83L,97L,101L,127L,137L,139L,151L,157L,163L,181L,191L,193L,199L,211L,227L,241L,263L,277L,281L,307L,331L,353L,367L,373L,379L,389L,409L,421L,433L,443L,461L,463L,487L,499L,541L,571L,577L,587L,601L,619L,631L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117048Inst : IEnumerable<long>
{
public static readonly long[] Value=A117048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117048.Bytes);
public long this[int i]=>Value[i];

public static A117048Inst Instance=new A117048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117049
{
public static readonly long[] Value={ 23L,89L,199L,353L,1409L,1783L,2663L,3169L,3719L,4951L,6359L,7129L,13751L,18503L,19801L,21143L,26951L,28513L,30119L,31769L,35201L,55001L,57223L,64153L,68993L,71479L,79201L,92951L,104743L,117239L,120473L,130439L,137303L,162713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117049Inst : IEnumerable<long>
{
public static readonly long[] Value=A117049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117049.Bytes);
public long this[int i]=>Value[i];

public static A117049Inst Instance=new A117049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117050
{
public static readonly long[] Value={ 6359L,26951L,117239L,174263L,306329L,521753L,635801L,720743L,794201L,1103873L,1487201L,4655201L,5412353L,6655001L,8213063L,10053473L,10322951L,12014663L,12841313L,16120193L,23113751L,25613303L,26138201L,39503201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117050Inst : IEnumerable<long>
{
public static readonly long[] Value=A117050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117050.Bytes);
public long this[int i]=>Value[i];

public static A117050Inst Instance=new A117050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117051
{
public static readonly long[] Value={ 0L,1L,9L,261L,969L,1350L,6666L,7944L,10071L,13299L,17466L,24486L,33369L,36159L,39804L,42846L,46806L,54375L,57921L,66309L,75264L,80484L,111696L,116754L,128544L,135339L,153825L,167316L,175056L,181374L,204369L,226950L,235950L,243276L,252591L,260169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117051Inst : IEnumerable<long>
{
public static readonly long[] Value=A117051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117051.Bytes);
public long this[int i]=>Value[i];

public static A117051Inst Instance=new A117051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117052
{
public static readonly long[] Value={ 0L,1L,9L,46L,111L,204L,750L,1089L,1350L,2301L,3075L,3504L,4200L,5500L,6069L,10071L,10450L,10836L,12036L,12450L,15081L,16014L,19500L,20026L,20559L,21099L,22200L,23904L,25075L,27501L,30039L,30691L,31350L,32016L,34056L,34750L,39061L,39804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117052Inst : IEnumerable<long>
{
public static readonly long[] Value=A117052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117052.Bytes);
public long this[int i]=>Value[i];

public static A117052Inst Instance=new A117052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117053
{
public static readonly long[] Value={ 0L,1L,9L,1350L,10071L,39804L,46806L,66309L,80484L,175056L,204369L,226950L,235950L,260169L,305916L,450186L,460284L,473064L,556206L,570246L,581604L,676500L,704481L,733029L,822075L,835701L,930606L,1015476L,1065084L,1155750L,1208634L,1305096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117053Inst : IEnumerable<long>
{
public static readonly long[] Value=A117053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117053.Bytes);
public long this[int i]=>Value[i];

public static A117053Inst Instance=new A117053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117054
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,1L,2L,0L,1L,0L,2L,1L,2L,0L,2L,0L,3L,0L,1L,1L,3L,0L,4L,0L,1L,0L,2L,0L,3L,1L,3L,0L,3L,0L,3L,0L,2L,0L,2L,0L,5L,1L,2L,0L,3L,0L,6L,0L,1L,0L,4L,0L,3L,0L,1L,1L,5L,0L,5L,0L,3L,0L,3L,0L,4L,0L,2L,0L,3L,0L,7L,1L,3L,0L,3L,0L,6L,0L,2L,0L,4L,0L,6L,0L,2L,0L,4L,0L,5L,1L,3L,0L,5L,0L,3L,0L,3L,0L,5L,0L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117054Inst : IEnumerable<long>
{
public static readonly long[] Value=A117054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117054.Bytes);
public long this[int i]=>Value[i];

public static A117054Inst Instance=new A117054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117055
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,101L,111L,121L,131L,141L,151L,161L,171L,181L,191L,202L,212L,222L,303L,313L,404L,505L,606L,676L,707L,777L,808L,909L,1001L,1111L,1221L,1331L,2002L,2112L,3003L,3113L,4004L,5005L,6006L,7007L,8008L,9009L,10001L,10101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117055Inst : IEnumerable<long>
{
public static readonly long[] Value=A117055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117055.Bytes);
public long this[int i]=>Value[i];

public static A117055Inst Instance=new A117055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117056
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,101L,111L,121L,131L,141L,151L,161L,171L,191L,202L,212L,222L,303L,313L,404L,1001L,1111L,1221L,1331L,2002L,2112L,3003L,3113L,4004L,10001L,10101L,10201L,10301L,10401L,10501L,10601L,10701L,10901L,11011L,11111L,11211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117056Inst : IEnumerable<long>
{
public static readonly long[] Value=A117056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117056.Bytes);
public long this[int i]=>Value[i];

public static A117056Inst Instance=new A117056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117057
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,111L,212L,1111L,2112L,4224L,11111L,11711L,13131L,21112L,21312L,31113L,42624L,111111L,211112L,234432L,1111111L,1113111L,2111112L,2112112L,2114112L,2118112L,11111111L,21111112L,21122112L,61111116L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117057Inst : IEnumerable<long>
{
public static readonly long[] Value=A117057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117057.Bytes);
public long this[int i]=>Value[i];

public static A117057Inst Instance=new A117057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117058
{
public static readonly long[] Value={ 2L,3L,5L,7L,121L,131L,151L,171L,11211L,11311L,11511L,11711L,1112111L,1113111L,1115111L,1117111L,111121111L,111131111L,111151111L,111171111L,11111211111L,11111311111L,11111511111L,11111711111L,1111112111111L,1111113111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117058Inst : IEnumerable<long>
{
public static readonly long[] Value=A117058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117058.Bytes);
public long this[int i]=>Value[i];

public static A117058Inst Instance=new A117058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117059
{
public static readonly long[] Value={ 2L,3L,5L,7L,121L,131L,151L,171L,232L,474L,535L,575L,666L,929L,999L,3993L,9339L,11211L,11311L,11511L,11711L,12321L,14741L,15351L,15751L,16661L,19291L,19991L,21312L,22722L,23632L,28782L,29392L,32623L,33233L,33933L,35753L,36363L,38383L,39193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117059Inst : IEnumerable<long>
{
public static readonly long[] Value=A117059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117059.Bytes);
public long this[int i]=>Value[i];

public static A117059Inst Instance=new A117059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117060
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,255L,511L,8191L,16383L,32767L,65535L,262143L,524287L,16777215L,33554431L,134217727L,268435455L,2147483647L,4294967295L,8589934591L,17179869183L,34359738367L,68719476735L,137438953471L,549755813887L,562949953421311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117060Inst : IEnumerable<long>
{
public static readonly long[] Value=A117060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117060.Bytes);
public long this[int i]=>Value[i];

public static A117060Inst Instance=new A117060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117061
{
public static readonly long[] Value={ 1L,3L,12L,13L,21L,15L,43L,57L,153L,91L,111L,21L,22L,30L,24L,52L,66L,162L,100L,21L,30L,31L,39L,168L,250L,75L,171L,109L,129L,174L,175L,201L,42L,70L,84L,180L,118L,138L,183L,184L,210L,51L,79L,300L,54L,127L,147L,192L,193L,219L,195L,277L,309L,198L,379L,417L,201L,67L,228L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117061Inst : IEnumerable<long>
{
public static readonly long[] Value=A117061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117061.Bytes);
public long this[int i]=>Value[i];

public static A117061Inst Instance=new A117061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117062
{
public static readonly long[] Value={ 0L,1L,6L,15L,231L,276L,780L,861L,1653L,1770L,2850L,3003L,4371L,4560L,5995L,6216L,6441L,11175L,14028L,17205L,17578L,20301L,20706L,24090L,24531L,24976L,28203L,32640L,33153L,36856L,37401L,43071L,47278L,52975L,54946L,56953L,67528L,69751L,76636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117062Inst : IEnumerable<long>
{
public static readonly long[] Value=A117062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117062.Bytes);
public long this[int i]=>Value[i];

public static A117062Inst Instance=new A117062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117063
{
public static readonly long[] Value={ 0L,1L,6L,120L,153L,190L,231L,630L,703L,780L,1035L,1540L,1770L,2016L,2701L,2850L,3003L,3160L,4005L,4560L,4950L,6670L,6903L,7140L,9180L,9730L,10011L,10296L,10585L,10878L,12090L,12403L,12720L,13041L,14028L,14706L,15051L,15400L,16110L,17205L,19110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117063Inst : IEnumerable<long>
{
public static readonly long[] Value=A117063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117063.Bytes);
public long this[int i]=>Value[i];

public static A117063Inst Instance=new A117063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117064
{
public static readonly long[] Value={ 0L,1L,6L,231L,780L,1770L,2850L,3003L,4560L,14028L,17205L,20301L,20706L,24090L,24531L,28203L,32640L,37401L,43071L,80601L,96580L,102831L,103740L,112101L,191890L,200661L,201930L,239086L,255970L,286903L,296065L,302253L,303810L,316410L,318003L,332520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117064Inst : IEnumerable<long>
{
public static readonly long[] Value=A117064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117064.Bytes);
public long this[int i]=>Value[i];

public static A117064Inst Instance=new A117064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117065
{
public static readonly long[] Value={ 19L,31L,43L,67L,89L,101L,113L,131L,229L,241L,277L,359L,383L,491L,523L,619L,631L,643L,701L,761L,1321L,1381L,1621L,2221L,2861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117065Inst : IEnumerable<long>
{
public static readonly long[] Value=A117065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117065.Bytes);
public long this[int i]=>Value[i];

public static A117065Inst Instance=new A117065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117066
{
public static readonly long[] Value={ 1L,11L,48L,140L,325L,651L,1176L,1968L,3105L,4675L,6776L,9516L,13013L,17395L,22800L,29376L,37281L,46683L,57760L,70700L,85701L,102971L,122728L,145200L,170625L,199251L,231336L,267148L,306965L,351075L,399776L,453376L,512193L,576555L,646800L,723276L,806341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117066Inst : IEnumerable<long>
{
public static readonly long[] Value=A117066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117066.Bytes);
public long this[int i]=>Value[i];

public static A117066Inst Instance=new A117066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117067
{
public static readonly BigInteger[] Value={ 1L,5L,21L,169L,2705L,173121L,88637953L,1452244221953L,6091153749114355713L,BigInteger.Parse("209290449178831574011566096385"),BigInteger.Parse("15080966222943833716372357571365139853460111361") };
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
public class A117067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117067Inst Instance=new A117067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117068
{
public static readonly BigInteger[] Value={ 5L,161L,164865L,21609185281L,1450167876173430785L,BigInteger.Parse("199309555259989211062227435521"),BigInteger.Parse("224402609700066672987369178785813291654447105") };
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
public class A117068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117068Inst Instance=new A117068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117069
{
public static readonly long[] Value={ 5L,11L,3L,37L,21L,13L,5L,3L,13L,5L,3L,5L,11L,3L,5L,11L,5L,11L,5L,3L,5L,107L,91L,59L,43L,27L,11L,5L,11L,669L,11L,621L,13L,499L,13L,451L,13L,355L,13L,331L,11L,213L,13L,163L,11L,69L,13L,19L,13L,5L,11L,3L,5L,3L,5L,3L,5L,3L,5L,11L,5L,195L,19L,157L,19L,61L,19L,61L,19L,3L,5L,3L,13L,5L,3L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117069Inst : IEnumerable<long>
{
public static readonly long[] Value=A117069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117069.Bytes);
public long this[int i]=>Value[i];

public static A117069Inst Instance=new A117069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117070
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117070Inst : IEnumerable<long>
{
public static readonly long[] Value=A117070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117070.Bytes);
public long this[int i]=>Value[i];

public static A117070Inst Instance=new A117070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117071
{
public static readonly long[] Value={ 3L,7L,14L,26L,49L,92L,177L,346L,683L,1356L,2699L,5384L,10753L,21490L,42963L,85908L,171797L,343574L,687127L,1374232L,2748439L,5496852L,10993677L,21987326L,43974623L,87949216L,175898401L,351796770L,703593507L,1407186980L,2814373925L,5628747814L,11257495591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117071Inst : IEnumerable<long>
{
public static readonly long[] Value=A117071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117071.Bytes);
public long this[int i]=>Value[i];

public static A117071Inst Instance=new A117071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117072
{
public static readonly long[] Value={ 6L,13L,25L,48L,91L,176L,345L,682L,1355L,2698L,5383L,10752L,21489L,42962L,85907L,171796L,343573L,687126L,1374231L,2748438L,5496851L,10993676L,21987325L,43974622L,87949215L,175898400L,351796769L,703593506L,1407186979L,2814373924L,5628747813L,11257495590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117072Inst : IEnumerable<long>
{
public static readonly long[] Value=A117072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117072.Bytes);
public long this[int i]=>Value[i];

public static A117072Inst Instance=new A117072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117073
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,20L,21L,22L,40L,41L,42L,82L,83L,84L,166L,167L,168L,334L,335L,336L,670L,671L,672L,1340L,1341L,1342L,2682L,2683L,2684L,5366L,5367L,5368L,10734L,10735L,10736L,21470L,21471L,21472L,42942L,42943L,42944L,85886L,85887L,85888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117073Inst : IEnumerable<long>
{
public static readonly long[] Value=A117073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117073.Bytes);
public long this[int i]=>Value[i];

public static A117073Inst Instance=new A117073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117074
{
public static readonly long[] Value={ 1L,4L,9L,20L,40L,82L,166L,334L,670L,1340L,2682L,5366L,10734L,21470L,42942L,85886L,171774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117074Inst : IEnumerable<long>
{
public static readonly long[] Value=A117074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117074.Bytes);
public long this[int i]=>Value[i];

public static A117074Inst Instance=new A117074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117075
{
public static readonly long[] Value={ 3L,6L,11L,22L,42L,84L,168L,336L,672L,1342L,2684L,5368L,10736L,21472L,42944L,85888L,171776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117075Inst : IEnumerable<long>
{
public static readonly long[] Value=A117075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117075.Bytes);
public long this[int i]=>Value[i];

public static A117075Inst Instance=new A117075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117076
{
public static readonly long[] Value={ 2L,223L,227L,229L,241L,263L,269L,281L,283L,401L,409L,421L,443L,449L,461L,463L,467L,487L,601L,607L,641L,643L,647L,661L,683L,809L,821L,823L,827L,829L,863L,881L,883L,887L,2003L,2027L,2029L,2063L,2069L,2081L,2083L,2087L,2089L,2203L,2207L,2221L,2243L,2267L,2269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117076Inst : IEnumerable<long>
{
public static readonly long[] Value=A117076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117076.Bytes);
public long this[int i]=>Value[i];

public static A117076Inst Instance=new A117076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117077
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,13L,173L,3501L,1420717L,7343549869L,24407739551034797L,BigInteger.Parse("264579267653248177273154989"),BigInteger.Parse("15107659029337673520218077770654501397966253"),BigInteger.Parse("5900314832748922900613950065282124787723453785544193308390237364661677") };
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
public class A117077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117077Inst Instance=new A117077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117078
{
public static readonly long[] Value={ 0L,0L,3L,0L,3L,9L,3L,5L,17L,3L,25L,11L,3L,13L,41L,47L,3L,11L,7L,3L,67L,5L,7L,9L,31L,3L,9L,3L,5L,33L,41L,25L,3L,43L,3L,29L,151L,53L,7L,167L,3L,19L,3L,7L,3L,17L,199L,73L,3L,5L,227L,3L,11L,7L,251L,257L,3L,53L,7L,3L,13L,31L,101L,3L,103L,101L,13L,109L,3L,5L,347L,9L,19L,367L,5L,13L,127L,131L,131L,19L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117078Inst : IEnumerable<long>
{
public static readonly long[] Value=A117078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117078.Bytes);
public long this[int i]=>Value[i];

public static A117078Inst Instance=new A117078Inst();

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