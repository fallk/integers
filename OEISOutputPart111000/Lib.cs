using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188115
{
public static readonly long[] Value={ 0L,2L,2L,8L,16L,52L,152L,484L,1536L,5064L,16946L,57528L,197616L,686588L,2407538L,8510428L,30300268L,108575996L,391301260L,1417520988L,5159160792L,18857230104L,69193592020L,254802169904L,941383915572L,3488574124056L,12964318919492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188115Inst : IEnumerable<long>
{
public static readonly long[] Value=A188115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188115.Bytes);
public long this[int i]=>Value[i];

public static A188115Inst Instance=new A188115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188116
{
public static readonly long[] Value={ 0L,3L,4L,16L,42L,137L,426L,1398L,4622L,15594L,53252L,184060L,642392L,2261829L,8024726L,28664946L,103015222L,372234190L,1351655526L,4930080182L,18055480464L,66371559466L,244817099870L,905883648170L,3361795172242L,12509691344838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188116Inst : IEnumerable<long>
{
public static readonly long[] Value=A188116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188116.Bytes);
public long this[int i]=>Value[i];

public static A188116Inst Instance=new A188116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188117
{
public static readonly long[] Value={ 0L,4L,8L,31L,90L,308L,1032L,3528L,12124L,42262L,148518L,525869L,1874648L,6725266L,24260940L,87958188L,320349712L,1171609968L,4301272078L,15846418258L,58569008756L,217121189648L,807123533172L,3008133255026L,11238226082080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188117Inst : IEnumerable<long>
{
public static readonly long[] Value=A188117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188117.Bytes);
public long this[int i]=>Value[i];

public static A188117Inst Instance=new A188117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188118
{
public static readonly long[] Value={ 0L,5L,12L,51L,172L,624L,2216L,7970L,28660L,103599L,375854L,1368883L,5003340L,18351050L,67525962L,249235562L,922567826L,3424217898L,12741735980L,47526320684L,177671217830L,665611279282L,2498575823284L,9396889413586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188118Inst : IEnumerable<long>
{
public static readonly long[] Value=A188118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188118.Bytes);
public long this[int i]=>Value[i];

public static A188118Inst Instance=new A188118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188119
{
public static readonly long[] Value={ 0L,6L,18L,80L,296L,1154L,4376L,16547L,62222L,233880L,878268L,3297368L,12383528L,46541138L,175070668L,659220634L,2485025556L,9378589340L,35437315784L,134061346668L,507765754320L,1925456658954L,7309793143626L,27782162090527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188119Inst : IEnumerable<long>
{
public static readonly long[] Value=A188119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188119.Bytes);
public long this[int i]=>Value[i];

public static A188119Inst Instance=new A188119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188120
{
public static readonly long[] Value={ 0L,7L,24L,118L,482L,1999L,8044L,32035L,126122L,493267L,1918884L,7436318L,28736532L,110822456L,426763772L,1641751842L,6311555602L,24254371734L,93187581596L,358022612486L,1375631211812L,5286588768343L,20321901846262L,78143777698585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188120Inst : IEnumerable<long>
{
public static readonly long[] Value=A188120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188120.Bytes);
public long this[int i]=>Value[i];

public static A188120Inst Instance=new A188120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188121
{
public static readonly long[] Value={ 0L,8L,32L,167L,740L,3278L,13994L,58595L,241250L,982016L,3959736L,15848648L,63063260L,249773862L,985585668L,3877333900L,15216566840L,59600223620L,233072224782L,910286934007L,3551576307448L,13845532229952L,53940983618522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188121Inst : IEnumerable<long>
{
public static readonly long[] Value=A188121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188121.Bytes);
public long this[int i]=>Value[i];

public static A188121Inst Instance=new A188121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188122
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,0L,3L,2L,3L,0L,4L,4L,8L,4L,0L,5L,8L,16L,16L,16L,0L,6L,12L,31L,42L,52L,42L,0L,7L,18L,51L,90L,137L,152L,137L,0L,8L,24L,80L,172L,308L,426L,484L,426L,0L,9L,32L,118L,296L,624L,1032L,1398L,1536L,1398L,0L,10L,40L,167L,482L,1154L,2216L,3528L,4622L,5064L,4622L,0L,11L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188122Inst : IEnumerable<long>
{
public static readonly long[] Value=A188122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188122.Bytes);
public long this[int i]=>Value[i];

public static A188122Inst Instance=new A188122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188123
{
public static readonly long[] Value={ 1L,3L,8L,16L,31L,51L,80L,118L,167L,227L,302L,390L,495L,617L,758L,918L,1101L,1305L,1534L,1788L,2069L,2377L,2716L,3084L,3485L,3919L,4388L,4892L,5435L,6015L,6636L,7298L,8003L,8751L,9546L,10386L,11275L,12213L,13202L,14242L,15337L,16485L,17690L,18952L,20273L,21653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188123Inst : IEnumerable<long>
{
public static readonly long[] Value=A188123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188123.Bytes);
public long this[int i]=>Value[i];

public static A188123Inst Instance=new A188123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188508
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,21L,144L,229L,144L,21L,37L,441L,971L,971L,441L,37L,65L,1369L,4351L,5626L,4351L,1369L,65L,114L,4225L,20124L,35079L,35079L,20124L,4225L,114L,200L,12996L,92597L,230877L,317751L,230877L,92597L,12996L,200L,351L,40000L,423074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188508Inst : IEnumerable<long>
{
public static readonly long[] Value=A188508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188508.Bytes);
public long this[int i]=>Value[i];

public static A188508Inst Instance=new A188508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188509
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,7L,1L,9L,13L,15L,1L,17L,25L,29L,31L,1L,33L,49L,57L,61L,63L,1L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188509Inst : IEnumerable<long>
{
public static readonly long[] Value=A188509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188509.Bytes);
public long this[int i]=>Value[i];

public static A188509Inst Instance=new A188509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188510
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188510Inst : IEnumerable<long>
{
public static readonly long[] Value=A188510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188510.Bytes);
public long this[int i]=>Value[i];

public static A188510Inst Instance=new A188510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188511
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,46L,46L,47L,48L,49L,49L,50L,51L,51L,52L,53L,53L,54L,55L,56L,56L,57L,58L,58L,59L,60L,60L,61L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188511Inst : IEnumerable<long>
{
public static readonly long[] Value=A188511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188511.Bytes);
public long this[int i]=>Value[i];

public static A188511Inst Instance=new A188511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188512
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188512Inst : IEnumerable<long>
{
public static readonly long[] Value=A188512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188512.Bytes);
public long this[int i]=>Value[i];

public static A188512Inst Instance=new A188512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188513
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,9L,11L,5L,1L,29L,40L,23L,7L,1L,97L,147L,99L,39L,9L,1L,333L,544L,413L,194L,59L,11L,1L,1165L,2025L,1691L,907L,333L,83L,13L,1L,4135L,7575L,6842L,4078L,1725L,524L,111L,15L,1L,14845L,28455L,27464L,17856L,8453L,2979L,775L,143L,17L,1L,53791L,107277L,109631L,76718L,39851L,15804L,4797L,1094L,179L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188513Inst : IEnumerable<long>
{
public static readonly long[] Value=A188513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188513.Bytes);
public long this[int i]=>Value[i];

public static A188513Inst Instance=new A188513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188514
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-5L,11L,91L,-391L,-4115L,27971L,357331L,-3353731L,-50789375L,607914581L,10692083221L,-155442170521L,-3120028100285L,53341649623091L,1204301220497011L,-23663734574555011L,-593828627529030095L,13182525824990398001UL };
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
public class A188514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188514Inst Instance=new A188514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188515
{
public static readonly BigInteger[] Value={ 2L,16L,229L,6760L,342240L,32470385L,5593606875L,1811059364020L,1103649329789000L,1283030748540574429L,BigInteger.Parse("2858394905740312536937"),BigInteger.Parse("12271770983630246007920447"),BigInteger.Parse("101822638806356395388304091003"),BigInteger.Parse("1636793382556126237888634491914956") };
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
public class A188515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188515Inst Instance=new A188515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188516
{
public static readonly long[] Value={ 4L,16L,49L,144L,400L,1089L,2916L,7744L,20449L,53824L,141376L,370881L,972196L,2547216L,6671889L,17472400L,45751696L,119793025L,313644100L,821166336L,2149898689L,5628600576L,14736017664L,38579637889L,101003196100L,264430435984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188516Inst : IEnumerable<long>
{
public static readonly long[] Value=A188516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188516.Bytes);
public long this[int i]=>Value[i];

public static A188516Inst Instance=new A188516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188517
{
public static readonly long[] Value={ 7L,49L,229L,1016L,4143L,16438L,63575L,242843L,918833L,3457086L,12955090L,48421778L,180653858L,673156166L,2506152176L,9324771027L,34680539851L,128945324565L,479330913137L,1781567026168L,6621013690288L,24604558144729L,91429145674242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188517Inst : IEnumerable<long>
{
public static readonly long[] Value=A188517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188517.Bytes);
public long this[int i]=>Value[i];

public static A188517Inst Instance=new A188517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188518
{
public static readonly long[] Value={ 12L,144L,1016L,6760L,40230L,231400L,1286120L,7034258L,37987114L,203649331L,1086048101L,5772562367L,30611227680L,162077331288L,857234934742L,4530655310672L,23933312899024L,126384275780253L,667233389909168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188518Inst : IEnumerable<long>
{
public static readonly long[] Value=A188518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188518.Bytes);
public long this[int i]=>Value[i];

public static A188518Inst Instance=new A188518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188519
{
public static readonly long[] Value={ 20L,400L,4143L,40230L,342240L,2800798L,22015314L,169875850L,1291198707L,9730141740L,72859323174L,543367409130L,4040626627139L,29988912453443L,222268109960222L,1645817547627269L,12178540896840119L,90075084742836021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188519Inst : IEnumerable<long>
{
public static readonly long[] Value=A188519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188519.Bytes);
public long this[int i]=>Value[i];

public static A188519Inst Instance=new A188519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188520
{
public static readonly long[] Value={ 33L,1089L,16438L,231400L,2800798L,32470385L,359696109L,3903047802L,41642655120L,440047202716L,4617244898772L,48229127405889L,502163657044635L,5217313950984361L,54124162283409093L,560894846117339319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188520Inst : IEnumerable<long>
{
public static readonly long[] Value=A188520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188520.Bytes);
public long this[int i]=>Value[i];

public static A188520Inst Instance=new A188520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188521
{
public static readonly ulong[] Value={ 54L,2916L,63575L,1286120L,22015314L,359696109L,5593606875L,85072486586L,1270511986433L,18779814902475L,275479123825628L,4021463733992753L,58503148106709186L,849117447746208056L,12303966393066654445UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188521Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A188521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188521.Bytes);
public ulong this[int i]=>Value[i];

public static A188521Inst Instance=new A188521Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188522
{
public static readonly BigInteger[] Value={ 88L,7744L,242843L,7034258L,169875850L,3903047802L,85072486586L,1811059364020L,37821597590709L,781325885220314L,16012231196353370L,326488652600242878L,6633121196128165894L,BigInteger.Parse("134436194716739170904"),BigInteger.Parse("2720029462045283755053") };
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
public class A188522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188522Inst Instance=new A188522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188523
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,20L,144L,229L,144L,20L,33L,400L,1016L,1016L,400L,33L,54L,1089L,4143L,6760L,4143L,1089L,54L,88L,2916L,16438L,40230L,40230L,16438L,2916L,88L,143L,7744L,63575L,231400L,342240L,231400L,63575L,7744L,143L,232L,20449L,242843L,1286120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188523Inst : IEnumerable<long>
{
public static readonly long[] Value=A188523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188523.Bytes);
public long this[int i]=>Value[i];

public static A188523Inst Instance=new A188523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188540
{
public static readonly long[] Value={ 1L,13L,19L,22L,31L,37L,38L,53L,67L,83L,86L,89L,109L,113L,124L,127L,131L,133L,134L,139L,148L,157L,169L,181L,187L,199L,211L,233L,251L,253L,257L,263L,292L,293L,295L,307L,310L,317L,326L,328L,337L,338L,343L,353L,355L,361L,376L,379L,389L,401L,406L,409L,412L,422L,427L,438L,443L,449L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188540Inst : IEnumerable<long>
{
public static readonly long[] Value=A188540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188540.Bytes);
public long this[int i]=>Value[i];

public static A188540Inst Instance=new A188540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188541
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,5L,9L,14L,24L,40L,70L,120L,211L,371L,658L,1172L,2102L,3786L,6856L,12470L,22782L,41789L,76947L,142180L,263578L,490104L,913858L,1708386L,3201290L,6011962L,11313274L,21329276L,40282947L,76202831L,144370582L,273906268L,520359324L,989804122L,1884992934L,3593832942L,6859139352L,13104584156L,25061042050L,47971076906L,91906883496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188541Inst : IEnumerable<long>
{
public static readonly long[] Value=A188541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188541.Bytes);
public long this[int i]=>Value[i];

public static A188541Inst Instance=new A188541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188542
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,1L,2L,3L,2L,3L,2L,4L,4L,4L,3L,5L,5L,4L,4L,7L,4L,4L,8L,7L,6L,5L,6L,5L,4L,6L,6L,5L,6L,9L,5L,5L,5L,7L,9L,7L,5L,7L,12L,8L,8L,12L,7L,8L,13L,10L,10L,9L,10L,7L,11L,11L,11L,6L,5L,11L,13L,12L,8L,8L,14L,9L,5L,7L,5L,14L,12L,13L,8L,11L,15L,15L,12L,11L,5L,11L,17L,14L,15L,15L,12L,15L,14L,16L,14L,17L,13L,15L,15L,12L,6L,17L,16L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188542Inst : IEnumerable<long>
{
public static readonly long[] Value=A188542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188542.Bytes);
public long this[int i]=>Value[i];

public static A188542Inst Instance=new A188542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188543
{
public static readonly long[] Value={ 4L,2L,3L,5L,4L,6L,6L,6L,1L,5L,4L,7L,8L,1L,4L,7L,8L,8L,7L,4L,1L,4L,2L,2L,2L,0L,9L,5L,7L,7L,9L,1L,5L,4L,1L,0L,8L,6L,3L,7L,0L,7L,2L,0L,3L,3L,9L,5L,4L,1L,2L,5L,9L,1L,4L,6L,2L,9L,8L,6L,5L,8L,2L,7L,8L,9L,3L,4L,2L,6L,9L,3L,8L,5L,1L,3L,9L,7L,0L,3L,0L,1L,3L,7L,4L,4L,1L,2L,4L,7L,6L,2L,7L,0L,4L,0L,4L,5L,5L,8L,1L,8L,1L,9L,0L,6L,4L,1L,8L,2L,8L,9L,3L,0L,4L,6L,7L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188543Inst : IEnumerable<long>
{
public static readonly long[] Value=A188543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188543.Bytes);
public long this[int i]=>Value[i];

public static A188543Inst Instance=new A188543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188544
{
public static readonly long[] Value={ 3L,6L,8L,9L,3L,1L,2L,7L,4L,9L,4L,7L,8L,0L,5L,8L,4L,2L,6L,5L,1L,9L,1L,1L,2L,7L,2L,6L,8L,8L,6L,4L,0L,8L,5L,7L,1L,8L,6L,8L,3L,4L,4L,2L,8L,8L,3L,5L,2L,6L,1L,9L,0L,6L,5L,9L,8L,5L,4L,6L,2L,1L,2L,1L,1L,1L,1L,7L,6L,5L,9L,8L,7L,5L,6L,8L,4L,9L,0L,6L,0L,6L,7L,0L,1L,2L,1L,0L,6L,0L,4L,8L,5L,9L,8L,4L,2L,8L,4L,2L,8L,0L,9L,9L,1L,1L,8L,2L,1L,8L,8L,5L,9L,6L,9L,8L,4L,4L,2L,2L,9L,4L,8L,7L,3L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188544Inst : IEnumerable<long>
{
public static readonly long[] Value=A188544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188544.Bytes);
public long this[int i]=>Value[i];

public static A188544Inst Instance=new A188544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188545
{
public static readonly long[] Value={ 1L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188545Inst : IEnumerable<long>
{
public static readonly long[] Value=A188545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188545.Bytes);
public long this[int i]=>Value[i];

public static A188545Inst Instance=new A188545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188546
{
public static readonly long[] Value={ 69L,271L,349L,3001L,3399L,4949L,6051L,9101L,9751L,10099L,10149L,11719L,12281L,15911L,22569L,24269L,25201L,25889L,28841L,31979L,37271L,39901L,42109L,44929L,46399L,48321L,50811L,60009L,63659L,63999L,71051L,71851L,75089L,76711L,87029L,96791L,103701L,110551L,111411L,112461L,113949L,125721L,126089L,127959L,129261L,131859L,132939L,137481L,144651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188546Inst : IEnumerable<long>
{
public static readonly long[] Value=A188546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188546.Bytes);
public long this[int i]=>Value[i];

public static A188546Inst Instance=new A188546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188547
{
public static readonly long[] Value={ 4949L,6051L,169219L,183241L,560769L,1113621L,1306689L,1370269L,1421869L,1485561L,1640711L,1730709L,1876351L,1967769L,2147661L,2217351L,2293939L,2428461L,2440871L,3346661L,3625139L,3625889L,3763969L,3991209L,4020711L,4728141L,5219691L,5547221L,5554939L,5965699L,7345719L,8495879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188547Inst : IEnumerable<long>
{
public static readonly long[] Value=A188547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188547.Bytes);
public long this[int i]=>Value[i];

public static A188547Inst Instance=new A188547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188548
{
public static readonly long[] Value={ 1L,11L,11L,111L,101L,111L,111L,1111L,1001L,1111L,1011L,1111L,1101L,1111L,1111L,11111L,10001L,11011L,10011L,11111L,10101L,11111L,10111L,11111L,11001L,11111L,11011L,11111L,11101L,11111L,11111L,111111L,100001L,110011L,100011L,111111L,100101L,110111L,100111L,111111L,101001L,111111L,101011L,111111L,101101L,111111L,101111L,111111L,110001L,111011L,110011L,111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188548Inst : IEnumerable<long>
{
public static readonly long[] Value=A188548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188548.Bytes);
public long this[int i]=>Value[i];

public static A188548Inst Instance=new A188548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188549
{
public static readonly long[] Value={ 3L,12L,15L,18L,21L,33L,36L,48L,51L,66L,78L,81L,93L,102L,114L,120L,132L,150L,153L,162L,180L,183L,213L,225L,228L,231L,234L,237L,243L,246L,252L,279L,282L,285L,294L,303L,318L,324L,333L,375L,378L,381L,384L,393L,396L,399L,417L,432L,450L,459L,468L,480L,489L,495L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188549Inst : IEnumerable<long>
{
public static readonly long[] Value=A188549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188549.Bytes);
public long this[int i]=>Value[i];

public static A188549Inst Instance=new A188549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188550
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,2L,2L,1L,4L,3L,2L,3L,4L,2L,3L,4L,4L,3L,2L,3L,6L,4L,4L,3L,4L,3L,4L,4L,5L,4L,4L,3L,6L,6L,3L,3L,6L,3L,4L,4L,4L,5L,4L,4L,8L,5L,6L,3L,4L,4L,4L,6L,6L,4L,4L,1L,8L,6L,4L,6L,6L,3L,5L,4L,4L,3L,4L,3L,9L,8L,6L,5L,6L,3L,4L,4L,8L,5L,6L,5L,8L,6L,4L,3L,6L,6L,6L,8L,6L,6L,4L,3L,10L,6L,8L,5L,6L,4L,6L,6L,6L,7L,4L,3L,8L,9L,4L,4L,8L,5L,6L,6L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188550Inst : IEnumerable<long>
{
public static readonly long[] Value=A188550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188550.Bytes);
public long this[int i]=>Value[i];

public static A188550Inst Instance=new A188550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188551
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,12L,14L,17L,20L,23L,24L,27L,31L,35L,39L,40L,44L,49L,54L,59L,60L,65L,71L,77L,83L,84L,90L,97L,104L,111L,112L,119L,127L,135L,143L,144L,152L,161L,170L,179L,180L,189L,199L,209L,219L,220L,230L,241L,252L,263L,264L,275L,287L,299L,311L,312L,324L,337L,350L,363L,364L,377L,391L,405L,419L,420L,434L,449L,464L,479L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188551Inst : IEnumerable<long>
{
public static readonly long[] Value=A188551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188551.Bytes);
public long this[int i]=>Value[i];

public static A188551Inst Instance=new A188551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188552
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,23L,31L,59L,71L,83L,97L,127L,179L,199L,241L,263L,311L,337L,419L,449L,479L,577L,647L,683L,839L,881L,967L,1103L,1151L,1249L,1511L,1567L,2111L,2243L,2311L,2591L,2663L,2887L,2963L,3041L,3119L,3361L,3527L,3697L,4049L,4139L,4231L,4703L,4801L,4999L,5099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188552Inst : IEnumerable<long>
{
public static readonly long[] Value=A188552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188552.Bytes);
public long this[int i]=>Value[i];

public static A188552Inst Instance=new A188552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188553
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,4L,5L,8L,7L,5L,6L,12L,12L,9L,6L,7L,17L,20L,16L,11L,7L,8L,23L,32L,28L,20L,13L,8L,9L,30L,49L,48L,36L,24L,15L,9L,10L,38L,72L,80L,64L,44L,28L,17L,10L,11L,47L,102L,129L,112L,80L,52L,32L,19L,11L,12L,57L,140L,201L,192L,144L,96L,60L,36L,21L,12L,13L,68L,187L,303L,321L,256L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188553Inst : IEnumerable<long>
{
public static readonly long[] Value=A188553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188553.Bytes);
public long this[int i]=>Value[i];

public static A188553Inst Instance=new A188553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188554
{
public static readonly long[] Value={ 4L,7L,12L,20L,32L,49L,72L,102L,140L,187L,244L,312L,392L,485L,592L,714L,852L,1007L,1180L,1372L,1584L,1817L,2072L,2350L,2652L,2979L,3332L,3712L,4120L,4557L,5024L,5522L,6052L,6615L,7212L,7844L,8512L,9217L,9960L,10742L,11564L,12427L,13332L,14280L,15272L,16309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188554Inst : IEnumerable<long>
{
public static readonly long[] Value=A188554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188554.Bytes);
public long this[int i]=>Value[i];

public static A188554Inst Instance=new A188554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188555
{
public static readonly long[] Value={ 5L,9L,16L,28L,48L,80L,129L,201L,303L,443L,630L,874L,1186L,1578L,2063L,2655L,3369L,4221L,5228L,6408L,7780L,9364L,11181L,13253L,15603L,18255L,21234L,24566L,28278L,32398L,36955L,41979L,47501L,53553L,60168L,67380L,75224L,83736L,92953L,102913L,113655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188555Inst : IEnumerable<long>
{
public static readonly long[] Value=A188555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188555.Bytes);
public long this[int i]=>Value[i];

public static A188555Inst Instance=new A188555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188620
{
public static readonly long[] Value={ 3L,17L,29L,73L,127L,251L,281L,433L,521L,577L,757L,1009L,1217L,1459L,2663L,2729L,2753L,2927L,3257L,3457L,3529L,3719L,5039L,5573L,5897L,6833L,6841L,7561L,7589L,8009L,8191L,8513L,9001L,9929L,10657L,11161L,12097L,12377L,12511L,12637L,13499L,16001L,16481L,17921L,18089L,18523L,19001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188620Inst : IEnumerable<long>
{
public static readonly long[] Value=A188620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188620.Bytes);
public long this[int i]=>Value[i];

public static A188620Inst Instance=new A188620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188621
{
public static readonly long[] Value={ 3L,2L,6L,12L,3L,5L,42L,56L,14L,18L,8L,10L,33L,2L,27L,240L,60L,68L,15L,3L,13L,105L,61L,67L,138L,150L,47L,51L,24L,26L,930L,117L,21L,6L,40L,66L,315L,41L,7L,231L,35L,37L,118L,5L,83L,495L,220L,230L,564L,55L,28L,147L,663L,98L,10L,50L,92L,798L,221L,229L,885L,12L,741L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188621Inst : IEnumerable<long>
{
public static readonly long[] Value=A188621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188621.Bytes);
public long this[int i]=>Value[i];

public static A188621Inst Instance=new A188621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188622
{
public static readonly long[] Value={ 1L,3L,10L,34L,118L,418L,1508L,5524L,20486L,76722L,289580L,1099836L,4198396L,16093236L,61902472L,238805864L,923574598L,3579675026L,13900879132L,54071886764L,210645038548L,821701422716L,3209243934712L,12547819633304L,49109812222108L,192382627198868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188622Inst : IEnumerable<long>
{
public static readonly long[] Value=A188622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188622.Bytes);
public long this[int i]=>Value[i];

public static A188622Inst Instance=new A188622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188623
{
public static readonly long[] Value={ 1L,2L,2L,5L,7L,8L,12L,15L,17L,22L,26L,29L,35L,40L,44L,51L,57L,62L,70L,77L,83L,92L,100L,107L,117L,126L,134L,145L,155L,164L,176L,187L,197L,210L,222L,233L,247L,260L,272L,287L,301L,314L,330L,345L,359L,376L,392L,407L,425L,442L,458L,477L,495L,512L,532L,551L,569L,590L,610L,629L,651L,672L,692L,715L,737L,758L,782L,805L,827L,852L,876L,899L,925L,950L,974L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188623Inst : IEnumerable<long>
{
public static readonly long[] Value=A188623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188623.Bytes);
public long this[int i]=>Value[i];

public static A188623Inst Instance=new A188623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188624
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,7L,11L,19L,32L,56L,102L,180L,331L,596L,1101L,2015L,3724L,6904L,12782L,23923L,44444L,83755L,156334L,296084L,555531L,1056095L,1991784L,3797790L,7197369L,13757665L,26186491L,50164787L,95847772L,183980036L,352670170L,678215028L,1303661995L,2511483176L,4838822931L,9337575130L,18025920971L,34840575458L,67371021603L,130412367572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188624Inst : IEnumerable<long>
{
public static readonly long[] Value=A188624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188624.Bytes);
public long this[int i]=>Value[i];

public static A188624Inst Instance=new A188624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188625
{
public static readonly long[] Value={ 1L,1L,3L,7L,19L,56L,180L,596L,2015L,6904L,23923L,83755L,296084L,1056095L,3797790L,13757665L,50164787L,183980036L,678215028L,2511483176L,9337575130L,34840575458L,130412367572L,489546890178L,1842438724560L,6950471604901L,26276784902865L,99539079724648L,377759500611913L,1436093975018569L,5468247624237042L,20853026397347178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188625Inst : IEnumerable<long>
{
public static readonly long[] Value=A188625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188625.Bytes);
public long this[int i]=>Value[i];

public static A188625Inst Instance=new A188625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188626
{
public static readonly long[] Value={ 1L,3L,7L,16L,37L,86L,199L,456L,1033L,2314L,5131L,11276L,24589L,53262L,114703L,245776L,524305L,1114130L,2359315L,4980756L,10485781L,22020118L,46137367L,96469016L,201326617L,419430426L,872415259L,1811939356L,3758096413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188626Inst : IEnumerable<long>
{
public static readonly long[] Value=A188626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188626.Bytes);
public long this[int i]=>Value[i];

public static A188626Inst Instance=new A188626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188627
{
public static readonly long[] Value={ 5L,4L,15L,6L,1L,13L,2L,1L,1L,21L,3L,2L,16L,1L,4L,1L,1L,157L,1L,9L,1L,3L,1L,5L,1L,2L,1L,3L,1L,1L,1L,1L,11L,1L,1L,22L,1L,9L,1L,1L,1L,1L,12L,1L,7L,6L,1L,3L,2L,8L,1L,1L,1L,1L,4L,2L,3L,1L,10L,17L,1L,2L,1L,5L,8L,1L,2L,1L,6L,1L,12L,1L,39L,16L,14L,1L,46L,72L,16L,3L,1L,1L,5L,2L,1L,5L,2L,1L,10L,4L,2L,2L,3L,2L,1L,3L,2L,2L,27L,10L,4L,2L,8L,1L,2L,6L,3L,945L,1L,1L,106L,1L,1L,3L,1L,2L,6L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188627Inst : IEnumerable<long>
{
public static readonly long[] Value=A188627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188627.Bytes);
public long this[int i]=>Value[i];

public static A188627Inst Instance=new A188627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188628
{
public static readonly long[] Value={ 7L,4L,2L,1L,1L,1L,2L,1L,11L,11L,32L,16L,8L,4L,2L,1L,4006L,2003L,9284L,4642L,2321L,107566L,53783L,313702L,156851L,1364479L,1493338L,746669L,12145148L,6072574L,3036287L,107186842L,53593421L,323781196L,161890598L,80945299L,3501584548L,1750792274L,875396137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188628Inst : IEnumerable<long>
{
public static readonly long[] Value=A188628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188628.Bytes);
public long this[int i]=>Value[i];

public static A188628Inst Instance=new A188628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188629
{
public static readonly long[] Value={ 2L,4L,8L,14L,16L,22L,38L,58L,135L,158L,178L,256L,297L,382L,502L,542L,568L,676L,718L,878L,1202L,1215L,1312L,1318L,1382L,1438L,1593L,1622L,1822L,2018L,2144L,2336L,2558L,2578L,2744L,2858L,2902L,3062L,3118L,3296L,3375L,3778L,3993L,4023L,4064L,4192L,4282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188629Inst : IEnumerable<long>
{
public static readonly long[] Value=A188629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188629.Bytes);
public long this[int i]=>Value[i];

public static A188629Inst Instance=new A188629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188630
{
public static readonly long[] Value={ 36L,45L,210L,630L,780L,990L,1540L,2850L,3570L,4095L,4851L,8778L,11781L,15400L,17955L,19110L,21528L,25200L,26565L,26796L,33930L,37128L,40755L,43956L,61425L,61776L,70125L,79800L,105570L,113050L,122265L,145530L,176715L,189420L,192510L,246753L,270480L,303810L,349866L,437580L,500500L,526851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188630Inst : IEnumerable<long>
{
public static readonly long[] Value=A188630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188630.Bytes);
public long this[int i]=>Value[i];

public static A188630Inst Instance=new A188630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188631
{
public static readonly long[] Value={ 62L,63L,74L,164L,188L,194L,195L,207L,255L,275L,278L,279L,284L,314L,356L,362L,363L,398L,399L,404L,422L,423L,428L,455L,458L,459L,483L,494L,524L,539L,584L,614L,615L,662L,674L,692L,734L,747L,758L,759L,764L,824L,854L,867L,890L,927L,935L,944L,956L,998L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188631Inst : IEnumerable<long>
{
public static readonly long[] Value=A188631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188631.Bytes);
public long this[int i]=>Value[i];

public static A188631Inst Instance=new A188631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188632
{
public static readonly long[] Value={ 1L,4L,12L,44L,160L,640L,2240L,8912L,32256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188632Inst : IEnumerable<long>
{
public static readonly long[] Value=A188632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188632.Bytes);
public long this[int i]=>Value[i];

public static A188632Inst Instance=new A188632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188633
{
public static readonly long[] Value={ 36L,60L,72L,84L,100L,108L,120L,132L,140L,144L,156L,168L,180L,196L,200L,204L,216L,220L,228L,240L,252L,260L,264L,276L,280L,288L,300L,308L,312L,324L,336L,340L,348L,360L,364L,372L,380L,392L,396L,400L,408L,420L,432L,440L,444L,456L,460L,468L,476L,480L,484L,492L,500L,504L,516L,520L,528L,532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188633Inst : IEnumerable<long>
{
public static readonly long[] Value=A188633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188633.Bytes);
public long this[int i]=>Value[i];

public static A188633Inst Instance=new A188633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188634
{
public static readonly BigInteger[] Value={ 1L,1L,4L,46L,1066L,41506L,2441314L,202229266L,22447207906L,3216941445106L,578333776748674L,127464417117501586L,BigInteger.Parse("33800841048945424546"),BigInteger.Parse("10617398393395844992306"),BigInteger.Parse("3898852051843774954576834"),BigInteger.Parse("1654948033478889053351543506"),BigInteger.Parse("804119629083230641164978005986") };
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
public class A188634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188634Inst Instance=new A188634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188635
{
public static readonly long[] Value={ 2L,10L,2L,40L,10L,2L,2L,1L,14L,1L,12L,3L,2L,1L,3L,9L,2L,12L,3L,1L,5L,1L,51L,29L,1L,3L,2L,35L,1L,27L,3L,75L,5L,1L,3L,2L,36L,1L,5L,1L,1L,3L,1L,2L,40L,1L,2L,7L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,8L,11L,6L,1L,2L,1L,3L,1L,2L,7L,1L,9L,1L,1L,9L,2L,1L,2L,1L,2L,7L,2L,34L,9L,13L,1L,2L,2L,24L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,1L,2L,4L,11L,3L,1L,3L,1L,6L,1L,5L,20L,2L,1L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188635Inst : IEnumerable<long>
{
public static readonly long[] Value=A188635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188635.Bytes);
public long this[int i]=>Value[i];

public static A188635Inst Instance=new A188635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188668
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,-2L,4L,-1L,0L,0L,0L,1L,3L,-9L,9L,-2L,-21L,27L,-9L,1L,0L,0L,0L,0L,1L,-4L,16L,-24L,16L,-3L,92L,-176L,120L,-32L,3L,-232L,256L,-96L,16L,-1L,0L,0L,0L,0L,0L,1L,5L,-25L,50L,-50L,25L,-4L,-315L,775L,-750L,350L,-75L,6L,2115L,-3275L,1950L,-550L,75L,-4L,-3005L,3125L,-1250L,250L,-25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188668Inst : IEnumerable<long>
{
public static readonly long[] Value=A188668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188668.Bytes);
public long this[int i]=>Value[i];

public static A188668Inst Instance=new A188668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188669
{
public static readonly long[] Value={ 1L,2L,4L,9L,26L,77L,246L,805L,2702L,9238L,32066L,112674L,400024L,1432736L,5170584L,18783763L,68635478L,252087092L,930138522L,3446163221L,12815663678L,47820430994L,178987624514L,671825076732L,2528212128756L,9536894864387L,36054433808299L,136583760727865L,518401146543812L,1971076359414358L,7506908923471954L,28634752202227978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188669Inst : IEnumerable<long>
{
public static readonly long[] Value=A188669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188669.Bytes);
public long this[int i]=>Value[i];

public static A188669Inst Instance=new A188669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188670
{
public static readonly long[] Value={ 3L,6L,5L,3L,6L,8L,3L,6L,13L,3L,6L,21L,3L,6L,34L,3L,6L,55L,3L,6L,89L,3L,6L,144L,3L,6L,233L,3L,6L,377L,3L,6L,610L,3L,6L,987L,3L,6L,1597L,3L,6L,2584L,3L,6L,4181L,3L,6L,6765L,3L,6L,10946L,3L,6L,17711L,3L,6L,28657L,3L,6L,46368L,3L,6L,75025L,3L,6L,121393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188670Inst : IEnumerable<long>
{
public static readonly long[] Value=A188670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188670.Bytes);
public long this[int i]=>Value[i];

public static A188670Inst Instance=new A188670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188671
{
public static readonly long[] Value={ 1L,0L,-24L,-32L,108L,275L,-176L,-1056L,45L,3157L,1080L,-6541L,-836L,16839L,2072L,-33824L,1188L,67100L,1672L,-95883L,19162L,161083L,-8208L,-224653L,2707L,371325L,67500L,-520025L,-1188L,870551L,8512L,-1082400L,148334L,1419889L,10428L,-1588228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188671Inst : IEnumerable<long>
{
public static readonly long[] Value=A188671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188671.Bytes);
public long this[int i]=>Value[i];

public static A188671Inst Instance=new A188671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188672
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,4L,0L,2L,3L,0L,0L,0L,6L,2L,2L,3L,2L,7L,4L,2L,4L,0L,2L,7L,2L,2L,4L,3L,2L,2L,4L,2L,4L,4L,2L,2L,3L,5L,5L,2L,2L,3L,2L,2L,2L,3L,2L,4L,3L,2L,3L,4L,2L,0L,2L,2L,2L,5L,2L,3L,4L,2L,5L,2L,2L,3L,3L,2L,2L,2L,2L,4L,4L,2L,2L,3L,2L,2L,3L,2L,4L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188672Inst : IEnumerable<long>
{
public static readonly long[] Value=A188672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188672.Bytes);
public long this[int i]=>Value[i];

public static A188672Inst Instance=new A188672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188673
{
public static readonly long[] Value={ 4L,6L,10L,9L,14L,15L,22L,21L,25L,34L,33L,39L,46L,46L,49L,55L,62L,74L,69L,74L,86L,82L,85L,91L,134L,106L,106L,118L,111L,115L,129L,133L,142L,141L,166L,158L,159L,166L,169L,178L,202L,183L,194L,206L,202L,201L,213L,226L,274L,302L,235L,262L,254L,253L,259L,265L,274L,274L,314L,298L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188673Inst : IEnumerable<long>
{
public static readonly long[] Value=A188673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188673.Bytes);
public long this[int i]=>Value[i];

public static A188673Inst Instance=new A188673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188674
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,3L,4L,5L,7L,9L,13L,17L,24L,31L,42L,54L,71L,90L,117L,147L,188L,236L,298L,371L,466L,576L,716L,882L,1088L,1331L,1633L,1987L,2422L,2935L,3557L,4290L,5177L,6216L,7465L,8932L,10682L,12731L,15169L,18016L,21387L,25321L,29955L,35353L,41696L,49063L,57689L,67698L,79375L,92896L,108633L,126817L,147922L,172272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188674Inst : IEnumerable<long>
{
public static readonly long[] Value=A188674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188674.Bytes);
public long this[int i]=>Value[i];

public static A188674Inst Instance=new A188674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188675
{
public static readonly long[] Value={ 1L,4L,19L,103L,598L,3601L,22165L,138445L,873916L,5560741L,35605756L,229142476L,1480820176L,9603245620L,62463474700L,407330900284L,2662179813931L,17433248900656L,114359597479261L,751343566800961L,4943188072606456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188675Inst : IEnumerable<long>
{
public static readonly long[] Value=A188675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188675.Bytes);
public long this[int i]=>Value[i];

public static A188675Inst Instance=new A188675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188676
{
public static readonly long[] Value={ 1L,2L,13L,71L,424L,2579L,15985L,100295L,635176L,4051649L,25993366L,167543354L,1084134346L,7038291098L,45821937982L,299045487602L,1955803426045L,12815265660680L,84111082917925L,552872886403775L,3638971619401720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188676Inst : IEnumerable<long>
{
public static readonly long[] Value=A188676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188676.Bytes);
public long this[int i]=>Value[i];

public static A188676Inst Instance=new A188676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188677
{
public static readonly long[] Value={ 11L,13L,19L,23L,29L,37L,43L,53L,59L,61L,67L,71L,83L,97L,109L,131L,139L,151L,157L,181L,197L,227L,233L,239L,251L,263L,269L,293L,317L,353L,359L,383L,409L,433L,439L,499L,509L,523L,541L,571L,601L,613L,619L,643L,661L,691L,709L,739L,751L,773L,797L,827L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188677Inst : IEnumerable<long>
{
public static readonly long[] Value=A188677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188677.Bytes);
public long this[int i]=>Value[i];

public static A188677Inst Instance=new A188677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188678
{
public static readonly long[] Value={ 1L,0L,3L,9L,46L,227L,1201L,6551L,36712L,209963L,1220752L,7193888L,42873220L,257957352L,1564809168L,9559946496L,58768808463L,363261736872L,2256369305793L,14076552984507L,88163556913188L,554148894304557L,3494365949734563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188678Inst : IEnumerable<long>
{
public static readonly long[] Value=A188678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188678.Bytes);
public long this[int i]=>Value[i];

public static A188678Inst Instance=new A188678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188679
{
public static readonly BigInteger[] Value={ 1L,10L,235L,7291L,252316L,9270325L,353892421L,13874930821L,554792522662L,22521121103287L,925224047453512L,38381686035811912L,1605078750713101912L,BigInteger.Parse("67578873844051699048"),BigInteger.Parse("2861782692234129345448"),BigInteger.Parse("121795323921169907086504") };
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
public class A188679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188679Inst Instance=new A188679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188680
{
public static readonly BigInteger[] Value={ 1L,8L,217L,6839L,238186L,8779823L,335842273L,13185196127L,527732395714L,21438596184911L,881264330165314L,36575197658193086L,1530121867019096914L,BigInteger.Parse("64443673226319500222"),BigInteger.Parse("2729760145163758146178"),BigInteger.Parse("116203781083772019594878") };
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
public class A188680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188680Inst Instance=new A188680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188681
{
public static readonly BigInteger[] Value={ 1L,3L,45L,1008L,27225L,819819L,26509392L,901402560L,31818681873L,1156122556875L,42985853635725L,1628541825580800L,62667882587091600L,2443473892345873968L,BigInteger.Parse("96351855806554401600"),BigInteger.Parse("3836565846094702507776"),BigInteger.Parse("154071018890153214025473") };
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
public class A188681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188681Inst Instance=new A188681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188682
{
public static readonly BigInteger[] Value={ 1L,4L,49L,1057L,28282L,848101L,27357493L,928760053L,32747441926L,1188869998801L,44174723634526L,1672716549215326L,64340599136306926L,2507814491482180894L,BigInteger.Parse("98859670298036582494"),BigInteger.Parse("3935425516392739090270"),BigInteger.Parse("158006444406545953115743") };
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
public class A188682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188682Inst Instance=new A188682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188683
{
public static readonly BigInteger[] Value={ 1L,2L,43L,965L,26260L,793559L,25715833L,875686727L,30942995146L,1125179561729L,41860674073996L,1586681151506804L,61081201435584796L,2382392690910289172L,BigInteger.Parse("93969463115644112428"),BigInteger.Parse("3742596382979058395348") };
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
public class A188683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188683Inst Instance=new A188683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188716
{
public static readonly long[] Value={ 1L,1L,4L,15L,46L,125L,316L,763L,1786L,4089L,9208L,20471L,45046L,98293L,212980L,458739L,983026L,2097137L,4456432L,9437167L,19922926L,41943021L,88080364L,184549355L,385875946L,805306345L,1677721576L,3489660903L,7247757286L,15032385509L,31138512868L,64424509411L,133143986146L,274877906913L,566935683040L,1168231104479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188716Inst : IEnumerable<long>
{
public static readonly long[] Value=A188716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188716.Bytes);
public long this[int i]=>Value[i];

public static A188716Inst Instance=new A188716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188717
{
public static readonly long[] Value={ 17L,1297L,1336337L,4477457L,29986577L,45212177L,126247697L,193877777L,406586897L,562448657L,916636177L,1416468497L,1944810001L,3208542737L,4162314257L,5006411537L,5972816657L,12444741137L,19565295377L,34188010001L,38167092497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188717Inst : IEnumerable<long>
{
public static readonly long[] Value=A188717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188717.Bytes);
public long this[int i]=>Value[i];

public static A188717Inst Instance=new A188717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188718
{
public static readonly BigInteger[] Value={ 1L,6L,130L,3772L,125378L,4512788L,171163380L,6737259192L,272624233922L,11270562833828L,473960605546620L,20211120713747144L,871908517791261620L,BigInteger.Parse("37984137010354633288"),BigInteger.Parse("1668675534695695271592"),BigInteger.Parse("73839856328273510564464"),BigInteger.Parse("3288232505457053332149954"),BigInteger.Parse("147251876924939254405677892"),BigInteger.Parse("6626961347483273293096934060") };
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
public class A188718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188718Inst Instance=new A188718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188719
{
public static readonly long[] Value={ 2L,7L,25L,115L,670L,4324L,30657L,229568L,1775675L,14156112L,115500275L,960392564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188719Inst : IEnumerable<long>
{
public static readonly long[] Value=A188719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188719.Bytes);
public long this[int i]=>Value[i];

public static A188719Inst Instance=new A188719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188720
{
public static readonly long[] Value={ 3L,0L,4L,6L,5L,2L,4L,6L,9L,5L,3L,3L,3L,4L,7L,2L,4L,7L,1L,8L,1L,1L,4L,0L,1L,7L,6L,6L,5L,8L,7L,1L,5L,5L,2L,4L,3L,2L,7L,4L,6L,0L,7L,0L,5L,8L,8L,7L,9L,7L,9L,4L,7L,7L,4L,5L,7L,7L,4L,2L,2L,4L,9L,6L,3L,1L,2L,0L,4L,6L,2L,8L,7L,4L,0L,0L,0L,6L,5L,6L,0L,6L,0L,1L,8L,9L,8L,5L,5L,3L,5L,0L,7L,3L,6L,5L,9L,4L,2L,6L,8L,0L,6L,1L,2L,7L,1L,1L,0L,2L,5L,2L,3L,4L,2L,9L,9L,9L,8L,0L,8L,1L,3L,2L,0L,9L,6L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188720Inst : IEnumerable<long>
{
public static readonly long[] Value=A188720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188720.Bytes);
public long this[int i]=>Value[i];

public static A188720Inst Instance=new A188720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188721
{
public static readonly long[] Value={ 3L,21L,2L,40L,1L,8L,1L,18L,1L,4L,2L,7L,14L,25L,1L,2L,1L,4L,1L,1L,1L,1L,2L,8L,50L,4L,1L,1L,3L,1L,11L,1L,1L,2L,3L,1L,1L,3L,1L,2L,22L,1L,1L,4L,1L,4L,1L,1L,4L,4L,2L,2L,2L,57L,1L,1L,34L,5L,1L,2L,2L,1L,1L,8L,13L,2L,3L,3L,17L,1L,1L,49L,1L,2L,1L,5L,1L,7L,1L,9L,1L,11L,1L,1L,7L,13L,1L,1L,59L,4L,8L,1L,3L,1L,4L,6L,1L,9L,11L,1L,1L,4L,456L,2L,8L,23L,2L,4L,2L,2L,1066L,1L,2L,2L,1L,11L,1L,3L,2L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188721Inst : IEnumerable<long>
{
public static readonly long[] Value=A188721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188721.Bytes);
public long this[int i]=>Value[i];

public static A188721Inst Instance=new A188721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188722
{
public static readonly long[] Value={ 3L,4L,3L,2L,8L,9L,2L,2L,1L,5L,9L,1L,3L,4L,8L,3L,2L,4L,4L,2L,0L,1L,4L,6L,0L,3L,7L,0L,2L,3L,5L,8L,1L,0L,9L,6L,6L,9L,0L,2L,7L,3L,4L,1L,0L,5L,8L,2L,0L,2L,4L,4L,4L,1L,9L,5L,1L,0L,1L,5L,2L,2L,2L,1L,9L,5L,8L,7L,9L,8L,8L,1L,1L,1L,4L,5L,4L,4L,9L,7L,0L,2L,3L,0L,4L,1L,2L,0L,2L,4L,6L,9L,6L,5L,7L,3L,3L,7L,8L,4L,4L,6L,2L,1L,6L,9L,9L,3L,2L,3L,2L,9L,8L,3L,6L,4L,2L,4L,4L,3L,3L,3L,0L,0L,7L,2L,7L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188722Inst : IEnumerable<long>
{
public static readonly long[] Value=A188722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188722.Bytes);
public long this[int i]=>Value[i];

public static A188722Inst Instance=new A188722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188723
{
public static readonly long[] Value={ 3L,2L,3L,4L,2L,3L,1L,1L,105L,1L,2L,1L,13L,5L,16L,1L,44L,1L,1L,4L,2L,1L,2L,3L,100L,4L,1L,1L,18L,4L,2L,2L,2L,8L,2L,5L,2L,2L,3L,7L,184L,1L,8L,6L,2L,6L,2L,1L,5L,1L,38L,1L,2L,1L,1L,1L,4L,2L,6L,2L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,2L,1L,2L,3L,8L,1L,1L,2L,1L,3L,1L,2L,1L,10L,1L,6L,1L,3L,1L,1L,1L,1L,2L,2L,1L,7L,1L,11L,1L,6L,1L,2L,13L,35L,1L,5L,2L,2L,1L,1L,2L,8L,2L,6L,2L,3L,1L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188723Inst : IEnumerable<long>
{
public static readonly long[] Value=A188723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188723.Bytes);
public long this[int i]=>Value[i];

public static A188723Inst Instance=new A188723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188724
{
public static readonly long[] Value={ 2L,0L,5L,6L,9L,5L,2L,4L,3L,8L,7L,1L,0L,9L,6L,5L,9L,0L,9L,3L,9L,6L,7L,8L,7L,9L,2L,4L,3L,7L,8L,8L,0L,7L,2L,5L,8L,5L,8L,8L,0L,9L,9L,1L,4L,1L,5L,4L,9L,7L,1L,7L,6L,2L,0L,4L,6L,7L,6L,4L,2L,6L,8L,3L,4L,1L,6L,1L,9L,5L,6L,5L,7L,6L,0L,3L,4L,1L,7L,4L,6L,1L,3L,2L,2L,1L,8L,2L,6L,6L,1L,4L,5L,7L,6L,5L,0L,2L,1L,5L,1L,8L,9L,6L,9L,9L,2L,5L,3L,9L,6L,2L,4L,2L,1L,0L,6L,6L,2L,4L,8L,0L,9L,8L,2L,4L,8L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188724Inst : IEnumerable<long>
{
public static readonly long[] Value=A188724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188724.Bytes);
public long this[int i]=>Value[i];

public static A188724Inst Instance=new A188724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188725
{
public static readonly long[] Value={ 6L,4L,3L,8L,5L,0L,0L,9L,6L,3L,0L,6L,5L,4L,0L,8L,3L,9L,7L,2L,2L,3L,2L,3L,2L,5L,6L,3L,5L,9L,4L,6L,9L,1L,7L,2L,9L,2L,6L,2L,1L,6L,6L,5L,4L,0L,8L,1L,3L,2L,6L,1L,5L,2L,5L,6L,1L,0L,6L,5L,1L,7L,3L,2L,5L,8L,9L,5L,9L,2L,1L,2L,6L,3L,3L,4L,3L,7L,5L,1L,1L,6L,9L,3L,8L,6L,9L,6L,6L,9L,2L,7L,7L,2L,1L,5L,3L,0L,9L,8L,5L,0L,0L,3L,9L,3L,0L,2L,8L,1L,2L,1L,5L,8L,5L,8L,7L,0L,2L,3L,1L,6L,7L,6L,5L,3L,0L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188725Inst : IEnumerable<long>
{
public static readonly long[] Value=A188725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188725.Bytes);
public long this[int i]=>Value[i];

public static A188725Inst Instance=new A188725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188726
{
public static readonly long[] Value={ 6L,2L,3L,1L,1L,3L,2L,1L,16L,47L,1L,4L,2L,7L,1L,5L,317L,4L,1L,1L,1L,2L,13L,1L,38L,37L,1L,4L,1L,13L,1L,59L,3L,17L,1L,2L,2L,2L,5L,1L,3L,1L,3L,9L,1L,3L,4L,1L,2L,2L,1L,1L,2L,1L,23L,8L,9L,84L,1L,3L,1L,2L,1L,1L,3L,5L,5L,1L,1L,16L,1L,8L,4L,11L,1L,3L,1L,16L,4L,1L,1L,1L,1L,18L,1L,12L,1L,21L,3L,3L,1L,2L,4L,2L,10L,3L,5L,6L,1L,1L,25L,4L,10L,1L,5L,2L,1L,4L,16L,2L,5L,4L,2L,1L,4L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188726Inst : IEnumerable<long>
{
public static readonly long[] Value=A188726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188726.Bytes);
public long this[int i]=>Value[i];

public static A188726Inst Instance=new A188726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188727
{
public static readonly long[] Value={ 1L,8L,8L,8L,6L,2L,6L,2L,8L,9L,6L,4L,8L,2L,1L,6L,1L,6L,7L,0L,7L,5L,8L,1L,9L,4L,2L,5L,3L,2L,1L,7L,7L,0L,9L,2L,4L,4L,2L,4L,1L,9L,5L,2L,7L,0L,1L,1L,9L,0L,6L,0L,6L,0L,0L,9L,4L,2L,6L,4L,6L,6L,8L,8L,2L,5L,7L,9L,6L,8L,5L,5L,6L,1L,0L,1L,6L,9L,4L,5L,7L,4L,2L,8L,7L,0L,6L,2L,9L,9L,5L,7L,1L,6L,9L,2L,4L,5L,4L,1L,7L,5L,9L,0L,1L,3L,4L,9L,3L,3L,5L,7L,9L,1L,6L,1L,2L,2L,4L,6L,4L,3L,8L,9L,5L,4L,5L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188727Inst : IEnumerable<long>
{
public static readonly long[] Value=A188727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188727.Bytes);
public long this[int i]=>Value[i];

public static A188727Inst Instance=new A188727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188728
{
public static readonly long[] Value={ 1L,1L,7L,1L,46L,8L,30L,1L,5L,4L,2L,6L,3L,2L,5L,1L,1L,1L,3L,50L,1L,3L,1L,1L,3L,1L,45L,1L,1L,1L,4L,1L,1L,2L,8L,2L,35L,2L,1L,27L,6L,112L,1L,113L,16L,1L,11L,1L,1L,6L,1L,12L,1L,3L,2L,15L,1L,2L,1L,1L,5L,1L,16L,2L,2L,2L,1L,10L,1L,43L,1L,13L,1L,6L,1L,4L,1L,2L,1L,1L,1L,6L,1L,8L,8L,1L,6L,3L,3L,17L,3L,1L,27L,1L,11L,1L,1L,1L,1L,1L,1L,9L,7L,2L,1L,5L,5L,7L,6L,2L,1L,5L,1L,2L,1L,5L,57L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188728Inst : IEnumerable<long>
{
public static readonly long[] Value=A188728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188728.Bytes);
public long this[int i]=>Value[i];

public static A188728Inst Instance=new A188728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188729
{
public static readonly long[] Value={ 1L,3L,4L,4L,0L,3L,0L,6L,5L,0L,8L,9L,1L,0L,5L,5L,0L,1L,7L,9L,7L,5L,7L,7L,5L,4L,0L,2L,2L,5L,4L,8L,0L,4L,7L,6L,7L,8L,2L,8L,9L,8L,4L,9L,8L,3L,7L,7L,1L,9L,7L,9L,9L,7L,5L,3L,0L,0L,5L,3L,9L,7L,2L,4L,9L,0L,0L,4L,7L,0L,3L,9L,1L,4L,6L,2L,8L,1L,3L,4L,9L,1L,8L,7L,4L,5L,3L,9L,7L,2L,9L,1L,1L,1L,2L,4L,3L,1L,3L,7L,8L,9L,7L,9L,8L,2L,2L,5L,3L,8L,2L,5L,5L,9L,3L,4L,8L,5L,1L,4L,9L,1L,6L,1L,9L,0L,3L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188729Inst : IEnumerable<long>
{
public static readonly long[] Value=A188729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188729.Bytes);
public long this[int i]=>Value[i];

public static A188729Inst Instance=new A188729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188730
{
public static readonly long[] Value={ 1L,4L,7L,7L,0L,3L,2L,9L,6L,1L,4L,2L,6L,9L,0L,0L,8L,0L,6L,2L,5L,0L,1L,4L,2L,0L,9L,8L,3L,0L,8L,0L,6L,5L,9L,1L,1L,2L,5L,9L,0L,2L,4L,0L,3L,2L,3L,2L,8L,9L,5L,7L,7L,6L,7L,5L,3L,6L,0L,7L,7L,7L,3L,4L,0L,0L,3L,3L,2L,9L,1L,9L,2L,5L,6L,5L,5L,3L,1L,7L,3L,8L,5L,7L,5L,3L,2L,6L,7L,5L,6L,3L,3L,5L,9L,6L,7L,0L,9L,6L,8L,8L,3L,7L,4L,0L,9L,6L,4L,3L,5L,8L,7L,8L,9L,1L,5L,2L,1L,2L,1L,5L,3L,7L,7L,2L,4L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188730Inst : IEnumerable<long>
{
public static readonly long[] Value=A188730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188730.Bytes);
public long this[int i]=>Value[i];

public static A188730Inst Instance=new A188730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188731
{
public static readonly long[] Value={ 2L,8L,5L,0L,7L,8L,1L,0L,5L,9L,3L,5L,8L,2L,1L,2L,1L,7L,1L,6L,2L,2L,0L,5L,4L,4L,1L,8L,6L,5L,5L,4L,5L,3L,3L,1L,6L,1L,3L,0L,1L,0L,5L,0L,3L,3L,1L,5L,5L,2L,5L,4L,7L,2L,1L,3L,8L,2L,3L,1L,8L,1L,5L,6L,6L,6L,7L,0L,4L,5L,6L,8L,9L,5L,4L,9L,2L,1L,9L,0L,1L,8L,5L,7L,2L,3L,3L,8L,5L,7L,5L,5L,6L,2L,4L,6L,7L,4L,9L,0L,7L,9L,2L,7L,0L,2L,9L,5L,8L,1L,2L,5L,9L,4L,9L,2L,9L,5L,8L,1L,5L,6L,1L,7L,4L,3L,6L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188731Inst : IEnumerable<long>
{
public static readonly long[] Value=A188731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188731.Bytes);
public long this[int i]=>Value[i];

public static A188731Inst Instance=new A188731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188812
{
public static readonly long[] Value={ 9L,272L,25904L,7114752L,4566151168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188812Inst : IEnumerable<long>
{
public static readonly long[] Value=A188812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188812.Bytes);
public long this[int i]=>Value[i];

public static A188812Inst Instance=new A188812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188813
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,2L,9L,20L,20L,9L,44L,272L,448L,272L,44L,265L,6032L,25904L,25904L,6032L,265L,1854L,205312L,2952608L,7114752L,2952608L,205312L,1854L,14833L,9672448L,596917696L,4566151168L,4566151168L,596917696L,9672448L,14833L,133496L,601903360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188813Inst : IEnumerable<long>
{
public static readonly long[] Value=A188813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188813.Bytes);
public long this[int i]=>Value[i];

public static A188813Inst Instance=new A188813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188814
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,12L,27L,57L,107L,192L,327L,538L,855L,1329L,2018L,3003L,4402L,6349L,9045L,12720L,17713L,24395L,33335L,45118L,60655L,80888L,107242L,141177L,184905L,240679L,311850L,401860L,515725L,658630L,838006L,1061561L,1340193L,1685271L,2112576L,2638727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188814Inst : IEnumerable<long>
{
public static readonly long[] Value=A188814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188814.Bytes);
public long this[int i]=>Value[i];

public static A188814Inst Instance=new A188814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188815
{
public static readonly long[] Value={ 3L,5L,2L,19L,97L,23L,31L,73L,67L,347L,89L,109L,199L,83L,281L,631L,233L,607L,131L,421L,727L,1103L,743L,353L,577L,907L,307L,641L,433L,1237L,251L,389L,271L,829L,593L,449L,1879L,487L,331L,3109L,1609L,3257L,1907L,383L,2357L,1987L,3163L,443L,2719L,683L,1861L,6211L,719L,2251L,769L,3943L,5647L,2437L,4153L,3371L,563L,877L,3677L,929L,937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188815Inst : IEnumerable<long>
{
public static readonly long[] Value=A188815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188815.Bytes);
public long this[int i]=>Value[i];

public static A188815Inst Instance=new A188815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188816
{
public static readonly long[] Value={ 1L,0L,1L,2L,-1L,0L,0L,1L,-3L,6L,-2L,9L,-6L,1L,0L,0L,0L,1L,4L,-12L,12L,-3L,-44L,60L,-24L,3L,64L,-48L,12L,-1L,0L,0L,0L,0L,1L,-5L,20L,-30L,20L,-4L,155L,-300L,210L,-60L,6L,-655L,780L,-330L,60L,-4L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188816Inst : IEnumerable<long>
{
public static readonly long[] Value=A188816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188816.Bytes);
public long this[int i]=>Value[i];

public static A188816Inst Instance=new A188816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188817
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,2L,2L,1L,2L,3L,2L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,2L,2L,1L,2L,3L,3L,3L,2L,2L,2L,3L,3L,3L,2L,3L,4L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,3L,3L,3L,2L,3L,3L,4L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,5L,5L,5L,4L,4L,3L,4L,4L,4L,4L,5L,4L,4L,4L,4L,3L,4L,4L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,6L,6L,6L,6L,6L,5L,5L,5L,5L,4L,4L,3L,3L,3L,4L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188817Inst : IEnumerable<long>
{
public static readonly long[] Value=A188817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188817.Bytes);
public long this[int i]=>Value[i];

public static A188817Inst Instance=new A188817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188818
{
public static readonly long[] Value={ 2L,9L,48L,256L,1360L,7056L,36000L,179776L,884256L,4276624L,20432608L,96353856L,449990080L,2080089664L,9540782208L,43403888896L,196212020800L,881112632976L,3936117388896L,17487049789504L,77350773736512L,340574032803904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188818Inst : IEnumerable<long>
{
public static readonly long[] Value=A188818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188818.Bytes);
public long this[int i]=>Value[i];

public static A188818Inst Instance=new A188818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188819
{
public static readonly long[] Value={ 8L,25L,48L,81L,120L,169L,224L,289L,360L,441L,528L,625L,728L,841L,960L,1089L,1224L,1369L,1520L,1681L,1848L,2025L,2208L,2401L,2600L,2809L,3024L,3249L,3480L,3721L,3968L,4225L,4488L,4761L,5040L,5329L,5624L,5929L,6240L,6561L,6888L,7225L,7568L,7921L,8280L,8649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188819Inst : IEnumerable<long>
{
public static readonly long[] Value=A188819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188819.Bytes);
public long this[int i]=>Value[i];

public static A188819Inst Instance=new A188819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188820
{
public static readonly long[] Value={ 32L,169L,432L,841L,1360L,2025L,2800L,3721L,4752L,5929L,7216L,8649L,10192L,11881L,13680L,15625L,17680L,19881L,22192L,24649L,27216L,29929L,32752L,35721L,38800L,42025L,45360L,48841L,52432L,56169L,60016L,64009L,68112L,72361L,76720L,81225L,85840L,90601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188820Inst : IEnumerable<long>
{
public static readonly long[] Value=A188820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188820.Bytes);
public long this[int i]=>Value[i];

public static A188820Inst Instance=new A188820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188821
{
public static readonly long[] Value={ 64L,441L,1296L,2704L,4624L,7056L,10000L,13456L,17424L,21904L,26896L,32400L,38416L,44944L,51984L,59536L,67600L,76176L,85264L,94864L,104976L,115600L,126736L,138384L,150544L,163216L,176400L,190096L,204304L,219024L,234256L,250000L,266256L,283024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188821Inst : IEnumerable<long>
{
public static readonly long[] Value=A188821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188821.Bytes);
public long this[int i]=>Value[i];

public static A188821Inst Instance=new A188821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188822
{
public static readonly long[] Value={ 128L,1156L,3888L,8836L,15776L,24964L,36000L,49284L,64416L,81796L,101024L,122500L,145824L,171396L,198816L,228484L,260000L,293764L,329376L,367236L,406944L,448900L,492704L,538756L,586656L,636804L,688800L,743044L,799136L,857476L,917664L,980100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188822Inst : IEnumerable<long>
{
public static readonly long[] Value=A188822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188822.Bytes);
public long this[int i]=>Value[i];

public static A188822Inst Instance=new A188822Inst();

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