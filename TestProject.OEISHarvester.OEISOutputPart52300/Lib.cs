using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A059845
{
public static readonly long[] Value={ 0L,7L,17L,30L,46L,65L,87L,112L,140L,171L,205L,242L,282L,325L,371L,420L,472L,527L,585L,646L,710L,777L,847L,920L,996L,1075L,1157L,1242L,1330L,1421L,1515L,1612L,1712L,1815L,1921L,2030L,2142L,2257L,2375L,2496L,2620L,2747L,2877L,3010L,3146L,3285L,3427L,3572L,3720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059845Inst : IEnumerable<long>
{
public static readonly long[] Value=A059845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059845.Bytes);
public long this[int i]=>Value[i];

public static A059845Inst Instance=new A059845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059846
{
public static readonly long[] Value={ 2L,7L,31L,71L,59L,331L,569L,263L,691L,977L,1091L,2089L,1487L,2417L,2797L,10223L,4987L,6427L,12743L,9811L,17041L,29423L,12739L,20323L,20147L,17839L,53017L,53693L,17033L,67261L,151169L,106357L,129517L,185153L,77969L,253609L,185477L,140717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059846Inst : IEnumerable<long>
{
public static readonly long[] Value=A059846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059846.Bytes);
public long this[int i]=>Value[i];

public static A059846Inst Instance=new A059846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059847
{
public static readonly long[] Value={ 5L,17L,67L,149L,127L,673L,1151L,541L,1399L,1973L,2203L,4201L,2999L,4861L,5623L,20477L,10007L,12889L,25523L,19661L,34123L,58889L,25523L,40693L,40343L,35729L,106087L,107441L,34123L,134581L,302399L,212777L,259099L,370373L,156007L,507289L,371027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059847Inst : IEnumerable<long>
{
public static readonly long[] Value=A059847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059847.Bytes);
public long this[int i]=>Value[i];

public static A059847Inst Instance=new A059847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059848
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,2L,2L,0L,0L,1L,3L,5L,2L,1L,0L,1L,4L,10L,10L,3L,0L,0L,1L,5L,17L,30L,21L,3L,1L,0L,1L,6L,26L,68L,91L,42L,4L,0L,0L,1L,7L,37L,130L,273L,273L,85L,4L,1L,0L,1L,8L,50L,222L,651L,1092L,820L,170L,5L,0L,0L,1L,9L,65L,350L,1333L,3255L,4369L,2460L,341L,5L,1L,0L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059848Inst : IEnumerable<long>
{
public static readonly long[] Value=A059848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059848.Bytes);
public long this[int i]=>Value[i];

public static A059848Inst Instance=new A059848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059849
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,113L,1153L,15125L,245829L,4815403L,111308699L,2985997351L,91712874487L,3189130896077L,124366296990757L,5395176819674205L,258547307299130037L,13603419571939001827UL,BigInteger.Parse("781604484498111072195"),BigInteger.Parse("48806254671145521802863"),BigInteger.Parse("3298007680091577596528415") };
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
public class A059849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059849Inst Instance=new A059849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059850
{
public static readonly long[] Value={ 2L,2L,4L,5L,9L,1L,5L,7L,7L,1L,8L,3L,6L,1L,0L,4L,5L,4L,7L,3L,4L,2L,7L,1L,5L,2L,2L,0L,4L,5L,4L,3L,7L,3L,5L,0L,2L,7L,5L,8L,9L,3L,1L,5L,1L,3L,3L,9L,9L,6L,6L,9L,2L,2L,4L,9L,2L,0L,3L,0L,0L,2L,5L,5L,4L,0L,6L,6L,9L,2L,6L,0L,4L,0L,3L,9L,9L,1L,1L,7L,9L,1L,2L,3L,1L,8L,5L,1L,9L,7L,5L,2L,7L,2L,7L,1L,4L,3L,0L,3L,1L,5L,3L,1L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059850Inst : IEnumerable<long>
{
public static readonly long[] Value=A059850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059850.Bytes);
public long this[int i]=>Value[i];

public static A059850Inst Instance=new A059850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059851
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,4L,4L,6L,4L,7L,7L,9L,7L,9L,9L,13L,10L,12L,12L,14L,12L,16L,16L,18L,14L,17L,17L,21L,19L,21L,21L,23L,19L,23L,23L,27L,24L,26L,26L,30L,26L,28L,28L,30L,28L,34L,34L,36L,30L,33L,33L,37L,35L,37L,37L,41L,37L,41L,41L,43L,39L,41L,41L,47L,42L,46L,46L,48L,46L,50L,50L,52L,46L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059851Inst : IEnumerable<long>
{
public static readonly long[] Value=A059851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059851.Bytes);
public long this[int i]=>Value[i];

public static A059851Inst Instance=new A059851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059852
{
public static readonly long[] Value={ 5L,67L,70L,22L,1L,43L,25L,40L,4L,53L,23L,49L,8L,7L,26L,52L,77L,16L,13L,2L,14L,41L,17L,68L,71L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059852Inst : IEnumerable<long>
{
public static readonly long[] Value=A059852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059852.Bytes);
public long this[int i]=>Value[i];

public static A059852Inst Instance=new A059852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059853
{
public static readonly long[] Value={ 4L,2L,6L,4L,2L,6L,10L,2L,12L,16L,2L,16L,20L,2L,10L,10L,2L,12L,10L,2L,28L,10L,2L,26L,16L,2L,18L,48L,2L,34L,12L,2L,26L,32L,2L,32L,32L,2L,20L,70L,2L,56L,34L,2L,24L,22L,2L,54L,52L,2L,70L,16L,2L,18L,38L,2L,16L,36L,2L,12L,72L,2L,114L,30L,2L,64L,32L,2L,52L,54L,2L,22L,92L,2L,154L,88L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059853Inst : IEnumerable<long>
{
public static readonly long[] Value=A059853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059853.Bytes);
public long this[int i]=>Value[i];

public static A059853Inst Instance=new A059853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059854
{
public static readonly long[] Value={ 4L,6L,2L,3L,6L,8L,10L,2L,4L,9L,4L,14L,2L,16L,6L,12L,12L,2L,16L,22L,10L,24L,2L,24L,12L,24L,16L,2L,6L,26L,30L,26L,2L,7L,20L,12L,18L,2L,18L,11L,20L,64L,2L,20L,30L,19L,22L,2L,40L,20L,10L,50L,2L,10L,38L,74L,14L,2L,22L,64L,50L,72L,2L,48L,10L,30L,48L,2L,22L,51L,10L,36L,2L,34L,12L,47L,46L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059854Inst : IEnumerable<long>
{
public static readonly long[] Value=A059854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059854.Bytes);
public long this[int i]=>Value[i];

public static A059854Inst Instance=new A059854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059855
{
public static readonly long[] Value={ 1L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059855Inst : IEnumerable<long>
{
public static readonly long[] Value=A059855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059855.Bytes);
public long this[int i]=>Value[i];

public static A059855Inst Instance=new A059855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059856
{
public static readonly BigInteger[] Value={ 5L,77L,215L,66490L,1532860L,6065120900L,82402431042L,159335939923L,5988057672348L,84867726777664L,670936947063291L,7467495146314472L,498070824809605040L,1448654283622417399L,BigInteger.Parse("76449235362535003337") };
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
public class A059856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059856Inst Instance=new A059856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059857
{
public static readonly long[] Value={ 12L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,6L,6L,7L,5L,8L,4L,9L,3L,10L,2L,11L,1L,12L,12L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,6L,6L,7L,5L,8L,4L,9L,3L,10L,2L,11L,1L,12L,12L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,6L,6L,7L,5L,8L,4L,9L,3L,10L,2L,11L,1L,12L,12L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,6L,6L,7L,5L,8L,4L,9L,3L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059857Inst : IEnumerable<long>
{
public static readonly long[] Value=A059857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059857.Bytes);
public long this[int i]=>Value[i];

public static A059857Inst Instance=new A059857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059858
{
public static readonly long[] Value={ 151L,241L,251L,431L,571L,641L,911L,971L,1181L,1811L,2011L,2351L,2381L,2411L,2731L,3061L,3121L,3221L,3251L,3301L,3331L,3361L,3391L,3541L,3761L,3821L,3881L,4211L,4751L,4861L,4871L,4931L,5021L,5381L,5441L,5471L,5581L,5641L,5711L,5821L,5861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059858Inst : IEnumerable<long>
{
public static readonly long[] Value=A059858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059858.Bytes);
public long this[int i]=>Value[i];

public static A059858Inst Instance=new A059858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059859
{
public static readonly long[] Value={ 0L,0L,1L,5L,21L,57L,138L,282L,538L,938L,1563L,2463L,3759L,5523L,7924L,11060L,15156L,20340L,26901L,35001L,45001L,57101L,71742L,89166L,109902L,134238L,162799L,195923L,234339L,278439L,329064L,386664L,452200L,526184L,609705L,703341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059859Inst : IEnumerable<long>
{
public static readonly long[] Value=A059859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059859.Bytes);
public long this[int i]=>Value[i];

public static A059859Inst Instance=new A059859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059860
{
public static readonly long[] Value={ 1L,243L,7776L,100000L,759375L,4084101L,17210368L,60466176L,184528125L,503284375L,1252332576L,2887174368L,6240321451L,12762815625L,24883200000L,46525874176L,83841135993L,146211169851L,247609900000L,408410100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059860Inst : IEnumerable<long>
{
public static readonly long[] Value=A059860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059860.Bytes);
public long this[int i]=>Value[i];

public static A059860Inst Instance=new A059860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059861
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,135L,1485L,22275L,378675L,7952175L,214708725L,6226553025L,217929355875L,8499244879125L,348469040044125L,15681106801985625L,799736446901266875L,BigInteger.Parse("45584977473372211875"),BigInteger.Parse("2689513670928960500625") };
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
public class A059861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059861Inst Instance=new A059861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059862
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,64L,640L,8960L,143360L,2867200L,74547200L,2087321600L,70968934400L,2696819507200L,107872780288000L,4746402332672000L,237320116633600000L,13289926531481600000UL,BigInteger.Parse("770815738825932800000"),BigInteger.Parse("49332207284859699200000") };
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
public class A059862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059862Inst Instance=new A059862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059863
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,21L,189L,2457L,36855L,700245L,17506125L,472665375L,15597957375L,577124422875L,22507852492125L,967837657161375L,47424045200907375L,2608322486049905625L,BigInteger.Parse("148674381704844620625"),BigInteger.Parse("9366486047405211099375") };
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
public class A059863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059863Inst Instance=new A059863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059864
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,12L,96L,1152L,16128L,290304L,6967296L,181149696L,5796790272L,208684449792L,7930009092096L,333060381868032L,15986898329665536L,863292509801938944L,BigInteger.Parse("48344380548908580864"),BigInteger.Parse("2997351594032332013568") };
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
public class A059864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059864Inst Instance=new A059864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059865
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,5L,35L,385L,5005L,85085L,1956955L,48923875L,1516640125L,53082404375L,1964048961875L,80526007436875L,3784722349533125L,200590284525255625L,11032465648889059375UL,BigInteger.Parse("672980404582232621875"),BigInteger.Parse("43743726297845120421875") };
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
public class A059865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059865Inst Instance=new A059865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059866
{
public static readonly long[] Value={ 2L,4L,2L,8L,2L,12L,2L,20L,2L,12L,2L,164L,2L,40L,2L,40L,2L,1208L,2L,660L,2L,1304L,2L,3056L,2L,2492L,2L,1080L,2L,13004L,2L,10232L,2L,11296L,2L,148736L,2L,56576L,2L,615482L,2L,44448L,2L,64L,2L,2628524L,2L,28219952L,2L,139558L,2L,3067080L,2L,2683626L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059866Inst : IEnumerable<long>
{
public static readonly long[] Value=A059866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059866.Bytes);
public long this[int i]=>Value[i];

public static A059866Inst Instance=new A059866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059867
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,8L,8L,8L,8L,16L,16L,32L,32L,64L,64L,16L,16L,32L,32L,64L,64L,128L,128L,128L,128L,256L,256L,512L,512L,1024L,1024L,32L,32L,64L,64L,128L,128L,256L,256L,256L,256L,512L,512L,1024L,1024L,2048L,2048L,512L,512L,1024L,1024L,2048L,2048L,4096L,4096L,4096L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059867Inst : IEnumerable<long>
{
public static readonly long[] Value=A059867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059867.Bytes);
public long this[int i]=>Value[i];

public static A059867Inst Instance=new A059867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059868
{
public static readonly long[] Value={ 3L,9L,11L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059868Inst : IEnumerable<long>
{
public static readonly long[] Value=A059868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059868.Bytes);
public long this[int i]=>Value[i];

public static A059868Inst Instance=new A059868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059869
{
public static readonly long[] Value={ 8L,9L,14L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059869Inst : IEnumerable<long>
{
public static readonly long[] Value=A059869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059869.Bytes);
public long this[int i]=>Value[i];

public static A059869Inst Instance=new A059869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059870
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,10L,11L,15L,17L,18L,20L,22L,23L,26L,31L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059870Inst : IEnumerable<long>
{
public static readonly long[] Value=A059870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059870.Bytes);
public long this[int i]=>Value[i];

public static A059870Inst Instance=new A059870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059871
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,4L,6L,12L,16L,31L,46L,90L,140L,276L,449L,877L,1443L,2834L,4725L,9395L,16153L,32037L,55872L,110288L,190815L,380488L,672728L,1342395L,2434797L,4808180L,8579625L,17070112L,30858078L,61271317L,110926277L,220979544L,402354848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059871Inst : IEnumerable<long>
{
public static readonly long[] Value=A059871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059871.Bytes);
public long this[int i]=>Value[i];

public static A059871Inst Instance=new A059871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059872
{
public static readonly long[] Value={ 1L,3L,5L,13L,21L,46L,51L,52L,78L,83L,84L,175L,181L,205L,210L,303L,309L,333L,338L,390L,392L,639L,698L,726L,728L,737L,822L,824L,846L,851L,852L,903L,905L,1143L,1145L,1197L,1202L,1226L,1232L,1311L,1322L,1328L,1350L,1352L,1409L,1562L,1571L,1572L,1601L,2539L,2540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059872Inst : IEnumerable<long>
{
public static readonly long[] Value=A059872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059872.Bytes);
public long this[int i]=>Value[i];

public static A059872Inst Instance=new A059872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059873
{
public static readonly long[] Value={ 1L,3L,5L,13L,21L,46L,78L,175L,303L,639L,1143L,2539L,4542L,9214L,17406L,36735L,69374L,139254L,270327L,556031L,1079294L,2162678L,4259819L,8642558L,17022974L,34078590L,67632893L,136249338L,270401534L,541064701L,1077935867L,2162163707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059873Inst : IEnumerable<long>
{
public static readonly long[] Value=A059873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059873.Bytes);
public long this[int i]=>Value[i];

public static A059873Inst Instance=new A059873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059874
{
public static readonly long[] Value={ 1L,3L,5L,13L,21L,51L,83L,175L,303L,639L,1143L,2539L,4571L,9711L,17903L,36735L,69499L,143339L,270327L,556031L,1080315L,2195431L,4259819L,8646647L,17031163L,34078647L,67632893L,136282091L,270467055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059874Inst : IEnumerable<long>
{
public static readonly long[] Value=A059874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059874.Bytes);
public long this[int i]=>Value[i];

public static A059874Inst Instance=new A059874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059875
{
public static readonly long[] Value={ 1L,3L,5L,13L,21L,52L,84L,210L,392L,905L,1601L,3652L,7173L,15364L,28932L,61952L,122900L,253969L,493572L,1017858L,2031636L,4128801L,8159232L,16547841L,33030657L,66584836L,132251649L,266600448L,532677128L,1069548544L,2139095042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059875Inst : IEnumerable<long>
{
public static readonly long[] Value=A059875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059875.Bytes);
public long this[int i]=>Value[i];

public static A059875Inst Instance=new A059875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059876
{
public static readonly long[] Value={ 2L,1L,3L,3L,5L,7L,9L,-1L,1L,3L,5L,5L,7L,9L,11L,3L,5L,7L,9L,9L,11L,13L,15L,13L,15L,17L,19L,19L,21L,23L,25L,-7L,-5L,-3L,-1L,-1L,1L,3L,5L,3L,5L,7L,9L,9L,11L,13L,15L,7L,9L,11L,13L,13L,15L,17L,19L,17L,19L,21L,23L,23L,25L,27L,29L,-3L,-1L,1L,3L,3L,5L,7L,9L,7L,9L,11L,13L,13L,15L,17L,19L,11L,13L,15L,17L,17L,19L,21L,23L,21L,23L,25L,27L,27L,29L,31L,33L,19L,21L,23L,25L,25L,27L,29L,31L,29L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059876Inst : IEnumerable<long>
{
public static readonly long[] Value=A059876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059876.Bytes);
public long this[int i]=>Value[i];

public static A059876Inst Instance=new A059876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059877
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,10L,11L,12L,13L,15L,16L,17L,18L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,38L,39L,40L,41L,42L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,59L,60L,63L,64L,67L,68L,69L,70L,72L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,87L,89L,93L,94L,96L,98L,102L,103L,104L,105L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059877Inst : IEnumerable<long>
{
public static readonly long[] Value=A059877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059877.Bytes);
public long this[int i]=>Value[i];

public static A059877Inst Instance=new A059877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059878
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,23L,35L,53L,73L,57L,-39L,87L,-13L,231L,-29L,177L,103L,299L,-11L,-139L,85L,-81L,157L,-169L,201L,277L,371L,183L,639L,-251L,663L,403L,263L,1L,195L,157L,235L,241L,-129L,929L,-345L,839L,-125L,-1887L,-151L,-631L,653L,87L,-431L,-223L,-35L,263L,821L,-613L,1793L,479L,-1653L,865L,-59L,919L,-527L,205L,471L,2029L,2289L,-227L,1907L,1011L,1055L,-1511L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059878Inst : IEnumerable<long>
{
public static readonly long[] Value=A059878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059878.Bytes);
public long this[int i]=>Value[i];

public static A059878Inst Instance=new A059878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059879
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,14L,16L,18L,20L,21L,24L,27L,31L,34L,37L,39L,41L,43L,46L,47L,48L,50L,51L,53L,54L,55L,57L,60L,61L,65L,67L,68L,71L,78L,83L,84L,86L,87L,101L,103L,105L,106L,109L,112L,114L,117L,126L,127L,128L,129L,141L,143L,145L,154L,155L,158L,161L,168L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059879Inst : IEnumerable<long>
{
public static readonly long[] Value=A059879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059879.Bytes);
public long this[int i]=>Value[i];

public static A059879Inst Instance=new A059879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059880
{
public static readonly long[] Value={ 8L,32L,33L,34L,35L,36L,64L,65L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L,152L,160L,161L,256L,257L,258L,259L,260L,261L,262L,263L,264L,265L,266L,267L,268L,269L,270L,272L,273L,274L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059880Inst : IEnumerable<long>
{
public static readonly long[] Value=A059880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059880.Bytes);
public long this[int i]=>Value[i];

public static A059880Inst Instance=new A059880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059881
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,1L,6L,5L,3L,2L,1L,1L,1L,9L,8L,5L,2L,2L,1L,1L,1L,14L,13L,9L,4L,3L,2L,1L,1L,1L,23L,19L,14L,8L,3L,3L,2L,1L,1L,1L,35L,31L,20L,13L,7L,4L,3L,2L,1L,1L,1L,55L,49L,32L,20L,12L,6L,4L,3L,2L,1L,1L,1L,87L,76L,50L,32L,18L,11L,7L,4L,3L,2L,1L,1L,1L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059881Inst : IEnumerable<long>
{
public static readonly long[] Value=A059881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059881.Bytes);
public long this[int i]=>Value[i];

public static A059881Inst Instance=new A059881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059882
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,0L,0L,1L,2L,1L,0L,0L,1L,4L,2L,0L,0L,0L,1L,6L,3L,1L,0L,0L,0L,1L,9L,4L,2L,0L,0L,0L,0L,1L,14L,7L,3L,1L,0L,0L,0L,0L,1L,23L,10L,5L,2L,0L,0L,0L,0L,0L,1L,35L,17L,7L,3L,1L,0L,0L,0L,0L,0L,1L,55L,26L,11L,5L,2L,0L,0L,0L,0L,0L,0L,1L,87L,41L,17L,8L,3L,1L,0L,0L,0L,0L,0L,0L,1L,136L,64L,28L,11L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059882Inst : IEnumerable<long>
{
public static readonly long[] Value=A059882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059882.Bytes);
public long this[int i]=>Value[i];

public static A059882Inst Instance=new A059882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059883
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,0L,2L,2L,2L,1L,1L,1L,0L,4L,3L,2L,2L,1L,1L,1L,0L,6L,6L,3L,3L,2L,1L,1L,1L,0L,9L,9L,6L,3L,3L,2L,1L,1L,1L,0L,14L,13L,10L,6L,4L,3L,2L,1L,1L,1L,0L,23L,21L,15L,10L,6L,4L,3L,2L,1L,1L,1L,0L,35L,33L,24L,15L,10L,7L,4L,3L,2L,1L,1L,1L,0L,55L,52L,38L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059883Inst : IEnumerable<long>
{
public static readonly long[] Value=A059883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059883.Bytes);
public long this[int i]=>Value[i];

public static A059883Inst Instance=new A059883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059884
{
public static readonly BigInteger[] Value={ 0L,1L,2L,4L,8L,3L,128L,5L,32L,9L,32768L,6L,2147483648L,129L,10L,16L,9223372036854775808UL,33L,BigInteger.Parse("170141183460469231731687303715884105728"),12L,130L,32769L };
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
public class A059884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059884Inst Instance=new A059884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059885
{
public static readonly long[] Value={ 2L,2L,2L,6L,4L,10L,2L,14L,4L,16L,6L,58L,2L,10L,16L,88L,6L,108L,6L,150L,10L,54L,6L,290L,18L,10L,56L,138L,14L,716L,14L,144L,22L,118L,40L,1088L,6L,54L,90L,670L,14L,730L,6L,570L,356L,22L,30L,13864L,124L,342L,54L,138L,14L,3912L,116L,1362L,118L,238L,6L,22058L,6L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059885Inst : IEnumerable<long>
{
public static readonly long[] Value=A059885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059885.Bytes);
public long this[int i]=>Value[i];

public static A059885Inst Instance=new A059885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059886
{
public static readonly long[] Value={ 2L,2L,4L,4L,6L,16L,6L,8L,26L,38L,14L,68L,6L,54L,84L,16L,6L,462L,6L,140L,132L,110L,14L,664L,120L,118L,128L,188L,62L,4456L,6L,96L,364L,118L,498L,7608L,30L,118L,180L,568L,30L,9000L,30L,892L,3974L,494L,62L,5360L,24L,8024L,1524L,892L,62L,9600L,3050L,1784L,372L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059886Inst : IEnumerable<long>
{
public static readonly long[] Value=A059886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059886.Bytes);
public long this[int i]=>Value[i];

public static A059886Inst Instance=new A059886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059887
{
public static readonly long[] Value={ 3L,5L,3L,12L,9L,37L,3L,28L,18L,47L,3L,180L,3L,53L,81L,176L,9L,446L,21L,564L,39L,117L,9L,884L,180L,53L,360L,244L,21L,5959L,9L,800L,39L,111L,369L,9536L,21L,483L,39L,5476L,9L,18289L,9L,1140L,2958L,111L,3L,9424L,6L,3852L,177L,884L,21L,81048L,561L,1188L,69L,227L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059887Inst : IEnumerable<long>
{
public static readonly long[] Value=A059887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059887.Bytes);
public long this[int i]=>Value[i];

public static A059887Inst Instance=new A059887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059888
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,10L,2L,8L,12L,40L,6L,108L,6L,42L,40L,48L,30L,100L,6L,332L,10L,22L,30L,376L,26L,118L,48L,332L,2L,1436L,6L,448L,54L,222L,88L,7952L,62L,54L,54L,2680L,6L,698L,30L,476L,1476L,222L,14L,7632L,28L,438L,478L,1916L,14L,1872L,84L,11896L,118L,58L,14L,784452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059888Inst : IEnumerable<long>
{
public static readonly long[] Value=A059888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059888.Bytes);
public long this[int i]=>Value[i];

public static A059888Inst Instance=new A059888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059889
{
public static readonly long[] Value={ 4L,6L,8L,26L,4L,42L,12L,48L,52L,66L,12L,778L,4L,138L,80L,300L,12L,528L,12L,1430L,72L,138L,28L,15216L,24L,66L,1216L,966L,28L,3630L,28L,1344L,360L,58L,108L,16988L,28L,138L,176L,12752L,28L,7398L,12L,4422L,1900L,122L,12L,131028L,240L,536L,744L,1046L,28L,23744L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059889Inst : IEnumerable<long>
{
public static readonly long[] Value=A059889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059889.Bytes);
public long this[int i]=>Value[i];

public static A059889Inst Instance=new A059889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059890
{
public static readonly long[] Value={ 2L,4L,2L,18L,6L,24L,10L,72L,4L,84L,14L,462L,14L,128L,54L,672L,30L,124L,14L,4494L,82L,364L,14L,7608L,120L,172L,56L,9054L,62L,3920L,6L,5376L,238L,1500L,1518L,9600L,62L,364L,494L,69048L,30L,5892L,30L,24174L,956L,364L,62L,253280L,52L,12072L,222L,147246L,254L,12072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059890Inst : IEnumerable<long>
{
public static readonly long[] Value=A059890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059890.Bytes);
public long this[int i]=>Value[i];

public static A059890Inst Instance=new A059890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059891
{
public static readonly long[] Value={ 4L,6L,12L,14L,20L,58L,12L,88L,112L,150L,60L,290L,12L,138L,732L,144L,124L,1088L,60L,670L,740L,570L,28L,13864L,360L,138L,3968L,1362L,252L,22058L,124L,320L,1972L,1146L,732L,10704L,124L,570L,12260L,15176L,124L,60470L,28L,11634L,195728L,282L,508L,116592L,2032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059891Inst : IEnumerable<long>
{
public static readonly long[] Value=A059891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059891.Bytes);
public long this[int i]=>Value[i];

public static A059891Inst Instance=new A059891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059892
{
public static readonly long[] Value={ 3L,3L,5L,6L,9L,53L,9L,36L,12L,33L,9L,186L,21L,33L,111L,144L,9L,564L,3L,330L,239L,273L,3L,1756L,84L,165L,76L,714L,93L,16167L,21L,5952L,111L,177L,363L,4288L,21L,15L,99L,5724L,45L,48807L,45L,4314L,1140L,183L,9L,14192L,36L,2940L,495L,1338L,45L,11572L,747L,11484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059892Inst : IEnumerable<long>
{
public static readonly long[] Value=A059892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059892.Bytes);
public long this[int i]=>Value[i];

public static A059892Inst Instance=new A059892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059893
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,12L,10L,14L,9L,13L,11L,15L,16L,24L,20L,28L,18L,26L,22L,30L,17L,25L,21L,29L,19L,27L,23L,31L,32L,48L,40L,56L,36L,52L,44L,60L,34L,50L,42L,58L,38L,54L,46L,62L,33L,49L,41L,57L,37L,53L,45L,61L,35L,51L,43L,59L,39L,55L,47L,63L,64L,96L,80L,112L,72L,104L,88L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059893Inst : IEnumerable<long>
{
public static readonly long[] Value=A059893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059893.Bytes);
public long this[int i]=>Value[i];

public static A059893Inst Instance=new A059893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059894
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,6L,4L,15L,11L,13L,9L,14L,10L,12L,8L,31L,23L,27L,19L,29L,21L,25L,17L,30L,22L,26L,18L,28L,20L,24L,16L,63L,47L,55L,39L,59L,43L,51L,35L,61L,45L,53L,37L,57L,41L,49L,33L,62L,46L,54L,38L,58L,42L,50L,34L,60L,44L,52L,36L,56L,40L,48L,32L,127L,95L,111L,79L,119L,87L,103L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059894Inst : IEnumerable<long>
{
public static readonly long[] Value=A059894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059894.Bytes);
public long this[int i]=>Value[i];

public static A059894Inst Instance=new A059894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059895
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L,1L,1L,5L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,6L,1L,4L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,7L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,5L,1L,1L,1L,1L,5L,1L,3L,1L,1L,1L,2L,1L,4L,1L,2L,1L,8L,1L,2L,1L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059895Inst : IEnumerable<long>
{
public static readonly long[] Value=A059895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059895.Bytes);
public long this[int i]=>Value[i];

public static A059895Inst Instance=new A059895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059896
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,6L,6L,4L,5L,8L,3L,8L,5L,6L,10L,12L,12L,10L,6L,7L,6L,15L,4L,15L,6L,7L,8L,14L,6L,20L,20L,6L,14L,8L,9L,8L,21L,24L,5L,24L,21L,8L,9L,10L,18L,24L,28L,30L,30L,28L,24L,18L,10L,11L,10L,27L,8L,35L,6L,35L,8L,27L,10L,11L,12L,22L,30L,36L,40L,42L,42L,40L,36L,30L,22L,12L,13L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059896Inst : IEnumerable<long>
{
public static readonly long[] Value=A059896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059896.Bytes);
public long this[int i]=>Value[i];

public static A059896Inst Instance=new A059896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059897
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,4L,6L,6L,4L,5L,8L,1L,8L,5L,6L,10L,12L,12L,10L,6L,7L,3L,15L,1L,15L,3L,7L,8L,14L,2L,20L,20L,2L,14L,8L,9L,4L,21L,24L,1L,24L,21L,4L,9L,10L,18L,24L,28L,30L,30L,28L,24L,18L,10L,11L,5L,27L,2L,35L,1L,35L,2L,27L,5L,11L,12L,22L,30L,36L,40L,42L,42L,40L,36L,30L,22L,12L,13L,24L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059897Inst : IEnumerable<long>
{
public static readonly long[] Value=A059897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059897.Bytes);
public long this[int i]=>Value[i];

public static A059897Inst Instance=new A059897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059898
{
public static readonly long[] Value={ 31L,43L,109L,127L,157L,223L,229L,277L,283L,307L,397L,433L,439L,457L,499L,601L,643L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059898Inst : IEnumerable<long>
{
public static readonly long[] Value=A059898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059898.Bytes);
public long this[int i]=>Value[i];

public static A059898Inst Instance=new A059898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059899
{
public static readonly long[] Value={ 31L,229L,397L,439L,457L,499L,601L,643L,691L,727L,739L,811L,919L,997L,1021L,1051L,1093L,1327L,1459L,1657L,1699L,1753L,1933L,1999L,2113L,2179L,2203L,2251L,2281L,2341L,2347L,2383L,2671L,2731L,2767L,2791L,2833L,2953L,2971L,3061L,3229L,3259L,3331L,3373L,3391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059899Inst : IEnumerable<long>
{
public static readonly long[] Value=A059899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059899.Bytes);
public long this[int i]=>Value[i];

public static A059899Inst Instance=new A059899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059900
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,12L,24L,5L,10L,15L,30L,20L,40L,60L,120L,16L,32L,48L,96L,64L,128L,192L,384L,80L,160L,240L,480L,320L,640L,960L,1920L,9L,18L,27L,54L,36L,72L,108L,216L,45L,90L,135L,270L,180L,360L,540L,1080L,144L,288L,432L,864L,576L,1152L,1728L,3456L,720L,1440L,2160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059900Inst : IEnumerable<long>
{
public static readonly long[] Value=A059900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059900.Bytes);
public long this[int i]=>Value[i];

public static A059900Inst Instance=new A059900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059901
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,30L,16L,24L,60L,36L,210L,32L,48L,120L,72L,420L,180L,2310L,64L,96L,240L,144L,840L,360L,216L,4620L,1260L,900L,30030L,128L,192L,480L,288L,1680L,720L,432L,9240L,2520L,1800L,1080L,60060L,13860L,6300L,510510L,256L,384L,960L,576L,3360L,1440L,864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059901Inst : IEnumerable<long>
{
public static readonly long[] Value=A059901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059901.Bytes);
public long this[int i]=>Value[i];

public static A059901Inst Instance=new A059901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059902
{
public static readonly ulong[] Value={ 0L,1L,4L,3L,5L,6L,11L,16L,7L,14L,36L,139L,17L,18L,15L,37L,142L,44L,32907L,20L,19L,26L,48L,143L,45L,39L,32910L,172L,2084L,2147516555L,21L,22L,27L,49L,154L,56L,50L,32911L,173L,2085L,47L,2147516558L,32940L,2212L,9223372039002292363UL,64L,23L,30L,52L,155L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059902Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A059902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059902.Bytes);
public ulong this[int i]=>Value[i];

public static A059902Inst Instance=new A059902Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059903
{
public static readonly long[] Value={ 1L,4L,18L,1L,16L,324L,72030L,162L,1L,64L,5832L,2916L,372027810L,10588410L,1458L,1L,256L,104976L,1036385881030500L,26244L,9421689827550L,4946387159463750L,1556496270L,13122L,1L,1024L,1889568L,2542277241000L,76256028326940L,236196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059903Inst : IEnumerable<long>
{
public static readonly long[] Value=A059903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059903.Bytes);
public long this[int i]=>Value[i];

public static A059903Inst Instance=new A059903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059904
{
public static readonly BigInteger[] Value={ 0L,4L,33L,0L,16L,516L,549755813899L,513L,0L,20L,549L,548L,BigInteger.Parse("604462909948052075708555"),549764202537L,545L,0L,64L,8208L,BigInteger.Parse("13479973333575319897333507543509815336818572211270286381289293482126") };
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
public class A059904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059904Inst Instance=new A059904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059905
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,2L,3L,0L,1L,0L,1L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,6L,7L,4L,5L,4L,5L,6L,7L,6L,7L,0L,1L,0L,1L,2L,3L,2L,3L,0L,1L,0L,1L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,6L,7L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,8L,9L,10L,11L,10L,11L,8L,9L,8L,9L,10L,11L,10L,11L,12L,13L,12L,13L,14L,15L,14L,15L,12L,13L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059905Inst : IEnumerable<long>
{
public static readonly long[] Value=A059905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059905.Bytes);
public long this[int i]=>Value[i];

public static A059905Inst Instance=new A059905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059906
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,4L,4L,5L,5L,4L,4L,5L,5L,6L,6L,7L,7L,6L,6L,7L,7L,4L,4L,5L,5L,4L,4L,5L,5L,6L,6L,7L,7L,6L,6L,7L,7L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,4L,4L,5L,5L,4L,4L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059906Inst : IEnumerable<long>
{
public static readonly long[] Value=A059906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059906.Bytes);
public long this[int i]=>Value[i];

public static A059906Inst Instance=new A059906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059907
{
public static readonly long[] Value={ 0L,1L,2L,2L,5L,2L,6L,4L,6L,3L,12L,2L,10L,6L,8L,4L,13L,2L,18L,6L,10L,4L,16L,4L,12L,9L,12L,4L,26L,2L,20L,6L,8L,12L,20L,4L,15L,6L,16L,4L,32L,2L,24L,10L,10L,6L,20L,4L,26L,9L,18L,4L,26L,6L,32L,12L,12L,4L,28L,2L,20L,10L,12L,18L,25L,4L,24L,6L,26L,4L,52L,2L,18L,10L,12L,18L,26L,4L,40L,8L,14L,5L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059907Inst : IEnumerable<long>
{
public static readonly long[] Value=A059907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059907.Bytes);
public long this[int i]=>Value[i];

public static A059907Inst Instance=new A059907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059908
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,2L,8L,2L,12L,5L,12L,2L,12L,2L,4L,20L,5L,6L,10L,2L,6L,14L,12L,2L,40L,9L,4L,6L,18L,10L,16L,6L,6L,8L,12L,12L,39L,2L,12L,8L,8L,6L,16L,6L,18L,26L,12L,6L,50L,3L,18L,8L,18L,2L,32L,12L,8L,20L,4L,6L,60L,2L,12L,26L,21L,4L,64L,10L,6L,8L,8L,6L,20L,14L,4L,12L,6L,4L,64L,2L,70L,7L,12L,6L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059908Inst : IEnumerable<long>
{
public static readonly long[] Value=A059908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059908.Bytes);
public long this[int i]=>Value[i];

public static A059908Inst Instance=new A059908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059909
{
public static readonly long[] Value={ 0L,2L,6L,4L,12L,4L,26L,18L,14L,6L,24L,12L,64L,8L,16L,8L,66L,20L,36L,8L,64L,24L,76L,6L,28L,12L,64L,24L,48L,12L,100L,40L,50L,48L,36L,8L,96L,40L,28L,8L,104L,12L,208L,36L,24L,36L,200L,18L,48L,36L,36L,24L,128L,8L,152L,16L,172L,24L,48L,12L,48L,36L,56L,72L,40L,8L,128L,56L,48L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059909Inst : IEnumerable<long>
{
public static readonly long[] Value=A059909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059909.Bytes);
public long this[int i]=>Value[i];

public static A059909Inst Instance=new A059909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059910
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,4L,4L,6L,20L,9L,8L,2L,6L,6L,12L,44L,5L,6L,18L,14L,12L,4L,4L,2L,56L,13L,20L,4L,6L,2L,40L,6L,18L,12L,12L,44L,63L,6L,28L,4L,16L,14L,8L,2L,18L,12L,28L,14L,70L,3L,42L,12L,42L,6L,24L,8L,56L,44L,60L,6L,60L,2L,4L,90L,21L,20L,24L,2L,18L,60L,88L,6L,12L,2L,28L,26L,6L,28L,8L,14L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059910Inst : IEnumerable<long>
{
public static readonly long[] Value=A059910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059910.Bytes);
public long this[int i]=>Value[i];

public static A059910Inst Instance=new A059910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059911
{
public static readonly long[] Value={ 0L,3L,10L,16L,37L,10L,42L,24L,58L,53L,164L,26L,68L,38L,32L,68L,169L,22L,222L,38L,42L,50L,328L,40L,180L,219L,108L,26L,334L,82L,460L,82L,92L,72L,220L,108L,449L,86L,128L,80L,192L,22L,336L,110L,222L,218L,540L,84L,778L,129L,150L,80L,270L,54L,328L,356L,132L,68L,348L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059911Inst : IEnumerable<long>
{
public static readonly long[] Value=A059911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059911.Bytes);
public long this[int i]=>Value[i];

public static A059911Inst Instance=new A059911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059912
{
public static readonly long[] Value={ 1L,3L,7L,5L,15L,31L,9L,21L,63L,127L,17L,51L,85L,255L,73L,511L,11L,33L,93L,341L,1023L,23L,89L,2047L,13L,35L,39L,45L,65L,91L,105L,117L,195L,273L,315L,455L,585L,819L,1365L,4095L,8191L,43L,129L,381L,5461L,16383L,151L,217L,1057L,4681L,32767L,257L,771L,1285L,3855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059912Inst : IEnumerable<long>
{
public static readonly long[] Value=A059912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059912.Bytes);
public long this[int i]=>Value[i];

public static A059912Inst Instance=new A059912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059913
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,6L,1L,2L,6L,18L,2L,4L,8L,16L,8L,48L,1L,2L,6L,30L,60L,2L,8L,176L,1L,2L,2L,2L,4L,6L,4L,6L,8L,12L,12L,24L,24L,36L,48L,144L,630L,3L,6L,18L,378L,756L,10L,12L,60L,300L,1800L,16L,32L,64L,128L,256L,512L,1024L,2048L,7710L,1L,1L,2L,6L,6L,6L,8L,12L,18L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059913Inst : IEnumerable<long>
{
public static readonly long[] Value=A059913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059913.Bytes);
public long this[int i]=>Value[i];

public static A059913Inst Instance=new A059913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059914
{
public static readonly long[] Value={ 43L,109L,127L,157L,223L,277L,283L,307L,433L,733L,1069L,1399L,1423L,1471L,1579L,1597L,1627L,1723L,1777L,1789L,1801L,1831L,2017L,2089L,2143L,2287L,2689L,2749L,2917L,3163L,3181L,3271L,3343L,3541L,3607L,3631L,3823L,3889L,4057L,4129L,4153L,4177L,4339L,4513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059914Inst : IEnumerable<long>
{
public static readonly long[] Value=A059914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059914.Bytes);
public long this[int i]=>Value[i];

public static A059914Inst Instance=new A059914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059915
{
public static readonly long[] Value={ 23L,139L,211L,422L,461L,761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059915Inst : IEnumerable<long>
{
public static readonly long[] Value=A059915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059915.Bytes);
public long this[int i]=>Value[i];

public static A059915Inst Instance=new A059915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059916
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,10L,40L,46L,60L,61L,64L,80L,84L,5000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059916Inst : IEnumerable<long>
{
public static readonly long[] Value=A059916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059916.Bytes);
public long this[int i]=>Value[i];

public static A059916Inst Instance=new A059916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059917
{
public static readonly BigInteger[] Value={ 2L,5L,41L,3281L,21523361L,926510094425921L,BigInteger.Parse("1716841910146256242328924544641"),BigInteger.Parse("5895092288869291585760436430706259332839105796137920554548481") };
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
public class A059917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059917Inst Instance=new A059917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059918
{
public static readonly BigInteger[] Value={ 1L,4L,40L,3280L,21523360L,926510094425920L,BigInteger.Parse("1716841910146256242328924544640"),BigInteger.Parse("5895092288869291585760436430706259332839105796137920554548480") };
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
public class A059918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059918Inst Instance=new A059918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059919
{
public static readonly BigInteger[] Value={ 4L,10L,82L,6562L,43046722L,1853020188851842L,BigInteger.Parse("3433683820292512484657849089282"),BigInteger.Parse("11790184577738583171520872861412518665678211592275841109096962") };
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
public class A059919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059919Inst Instance=new A059919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059920
{
public static readonly long[] Value={ 10L,1L,20L,1L,10L,30L,1L,2L,11L,40L,1L,2L,10L,20L,50L,1L,2L,3L,11L,21L,60L,1L,2L,3L,10L,12L,30L,70L,1L,2L,3L,4L,11L,20L,31L,80L,1L,2L,3L,4L,10L,12L,21L,40L,90L,1L,2L,3L,4L,5L,11L,13L,22L,41L,100L,1L,2L,3L,4L,5L,10L,12L,20L,30L,50L,110L,1L,2L,3L,4L,5L,6L,11L,13L,21L,31L,51L,120L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059920Inst : IEnumerable<long>
{
public static readonly long[] Value=A059920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059920.Bytes);
public long this[int i]=>Value[i];

public static A059920Inst Instance=new A059920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059921
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059921Inst : IEnumerable<long>
{
public static readonly long[] Value=A059921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059921.Bytes);
public long this[int i]=>Value[i];

public static A059921Inst Instance=new A059921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059922
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,10L,4L,1L,1L,5L,41L,41L,5L,1L,1L,6L,206L,1682L,206L,6L,1L,1L,7L,1237L,346493L,346493L,1237L,7L,1L,1L,8L,8660L,428611842L,120057399050L,428611842L,8660L,8L,1L,1L,9L,69281L,3711778551721L,BigInteger.Parse("51458022952549550101"),BigInteger.Parse("51458022952549550101"),3711778551721L,69281L,9L,1L };
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
public class A059922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059922Inst Instance=new A059922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059923
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,20L,31L,48L,74L,114L,176L,271L,417L,642L,988L,1521L,2341L,3603L,5545L,8533L,13131L,20207L,31096L,47853L,73639L,113320L,174383L,268350L,412951L,635471L,977896L,1504837L,2315721L,3563551L,5483776L,8438716L,12985930L,19983416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059923Inst : IEnumerable<long>
{
public static readonly long[] Value=A059923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059923.Bytes);
public long this[int i]=>Value[i];

public static A059923Inst Instance=new A059923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059924
{
public static readonly long[] Value={ 0L,2L,10L,34L,80L,158L,274L,438L,656L,938L,1290L,1722L,2240L,2854L,3570L,4398L,5344L,6418L,7626L,8978L,10480L,12142L,13970L,15974L,18160L,20538L,23114L,25898L,28896L,32118L,35570L,39262L,43200L,47394L,51850L,56578L,61584L,66878L,72466L,78358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059924Inst : IEnumerable<long>
{
public static readonly long[] Value=A059924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059924.Bytes);
public long this[int i]=>Value[i];

public static A059924Inst Instance=new A059924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059925
{
public static readonly long[] Value={ 1006301L,2594951L,3919211L,9600551L,10531061L,108816311L,131445701L,152370731L,157131641L,179028761L,211950251L,255352211L,267587861L,557458631L,685124351L,724491371L,821357651L,871411361L,1030262081L,1103104361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059925Inst : IEnumerable<long>
{
public static readonly long[] Value=A059925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059925.Bytes);
public long this[int i]=>Value[i];

public static A059925Inst Instance=new A059925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059926
{
public static readonly long[] Value={ 1L,4L,1L,10L,1L,16L,1L,44L,1L,74L,1L,46L,1L,204L,1L,714L,1L,702L,1L,908L,1L,404L,1L,7754L,1L,1136L,1L,9886L,1L,8154L,1L,23578L,1L,65096L,1L,404762L,1L,23992L,1L,3514774L,1L,110124L,1L,4802160L,1L,6490450L,1L,180832L,1L,115972L,1L,770304L,1L,62665998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059926Inst : IEnumerable<long>
{
public static readonly long[] Value=A059926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059926.Bytes);
public long this[int i]=>Value[i];

public static A059926Inst Instance=new A059926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059927
{
public static readonly long[] Value={ 1L,2L,4L,4L,12L,24L,48L,96L,196L,368L,760L,1524L,3064L,6068L,12168L,24360L,48668L,97160L,194952L,389416L,778832L,1557780L,3116216L,6229836L,12462296L,24923320L,49849604L,99694536L,199394616L,398783628L,797556364L,1595117676L,3190297400L,6380517544L,12761088588L,25522110948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059927Inst : IEnumerable<long>
{
public static readonly long[] Value=A059927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059927.Bytes);
public long this[int i]=>Value[i];

public static A059927Inst Instance=new A059927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059928
{
public static readonly long[] Value={ 1L,1L,1L,9L,1L,1L,1L,9L,1L,1L,1L,81L,1L,169L,841L,9L,1L,1L,1369L,9L,1L,529L,1L,81L,2401L,625L,1L,1521L,1L,841L,1024L,8649L,4489L,1L,5041L,729L,1L,1369L,6241L,9L,6889L,169L,29929L,4761L,841L,2209L,1L,178929L,85849L,2401L,10609L,5625L,100489L,2809L,11881L,1521L,1369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059928Inst : IEnumerable<long>
{
public static readonly long[] Value=A059928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059928.Bytes);
public long this[int i]=>Value[i];

public static A059928Inst Instance=new A059928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059929
{
public static readonly long[] Value={ 0L,2L,3L,10L,24L,65L,168L,442L,1155L,3026L,7920L,20737L,54288L,142130L,372099L,974170L,2550408L,6677057L,17480760L,45765226L,119814915L,313679522L,821223648L,2149991425L,5628750624L,14736260450L,38580030723L,101003831722L,264431464440L,692290561601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059929Inst : IEnumerable<long>
{
public static readonly long[] Value=A059929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059929.Bytes);
public long this[int i]=>Value[i];

public static A059929Inst Instance=new A059929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059930
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,9L,17L,18L,24L,29L,53L,54L,57L,59L,72L,79L,84L,209L,259L,567L,807L,854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059930Inst : IEnumerable<long>
{
public static readonly long[] Value=A059930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059930.Bytes);
public long this[int i]=>Value[i];

public static A059930Inst Instance=new A059930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059931
{
public static readonly long[] Value={ 4L,9L,16L,49L,64L,81L,289L,324L,576L,841L,2809L,2916L,3249L,3481L,5184L,6241L,7056L,43681L,67081L,321489L,651249L,729316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059931Inst : IEnumerable<long>
{
public static readonly long[] Value=A059931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059931.Bytes);
public long this[int i]=>Value[i];

public static A059931Inst Instance=new A059931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059932
{
public static readonly BigInteger[] Value={ 23L,5711L,1317192329L,31374143475359L,BigInteger.Parse("6167717379838997101103107"),BigInteger.Parse("109113127131137139149151157163167173179"),BigInteger.Parse("181191193197199211223227229233239241251257263269271") };
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
public class A059932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059932Inst Instance=new A059932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059933
{
public static readonly BigInteger[] Value={ 16L,7625597484986L,BigInteger.Parse("50973998591214355139406377"),BigInteger.Parse("53793641718868912174424175024032593379100060"),BigInteger.Parse("19916489515870532960258562190639398471599239042185934648024761145811"),BigInteger.Parse("5103708485122940631839901111036829791435007685667303872450435153015345686896530517814322070729709") };
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
public class A059933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059933Inst Instance=new A059933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059934
{
public static readonly BigInteger[] Value={ 0L,2L,60L,467L,3125L,3127L,6310L,9842L,15625L,15627L,15685L,16092L,18750L,18752L,BigInteger.Parse("53793641718868912174424175024032593379100060") };
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
public class A059934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059934Inst Instance=new A059934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059935
{
public static readonly BigInteger[] Value={ 1L,83L,775L,46655L,46657L,93395L,140743L,279935L,279937L,280019L,280711L,326591L,326593L,BigInteger.Parse("19916489515870532960258562190639398471599239042185934648024761145811") };
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
public class A059935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059935Inst Instance=new A059935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059936
{
public static readonly BigInteger[] Value={ 0L,109L,1197L,98039L,823543L,1647195L,2471826L,4215754L,5764801L,5764910L,5765998L,5862840L,6588344L,BigInteger.Parse("5103702287864892035208610181878203902270504134895451401860454182513968464023205038690962121196797") };
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
public class A059936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059936Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059936.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059936Inst Instance=new A059936Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059937
{
public static readonly long[] Value={ 0L,7L,45L,186L,630L,1905L,5355L,14308L,36828L,92115L,225225L,540606L,1277874L,2981797L,6881175L,15728520L,35651448L,80215911L,179306325L,398458690L,880803630L,1937768217L,4244635395L,9261022956L,20132658900L,43620761275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059937Inst : IEnumerable<long>
{
public static readonly long[] Value=A059937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059937.Bytes);
public long this[int i]=>Value[i];

public static A059937Inst Instance=new A059937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059938
{
public static readonly long[] Value={ 0L,4L,31L,141L,506L,1590L,4593L,12523L,32740L,82908L,204755L,495561L,1179582L,2768818L,6422437L,14745495L,33554312L,75759480L,169869159L,378535765L,838860610L,1849687854L,4060086041L,8875147011L,19327352556L,41943039700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059938Inst : IEnumerable<long>
{
public static readonly long[] Value=A059938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059938.Bytes);
public long this[int i]=>Value[i];

public static A059938Inst Instance=new A059938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059939
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059939Inst : IEnumerable<long>
{
public static readonly long[] Value=A059939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059939.Bytes);
public long this[int i]=>Value[i];

public static A059939Inst Instance=new A059939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059940
{
public static readonly long[] Value={ 3L,5L,31L,41L,107L,11L,17L,727L,499L,443L,863L,439L,457L,3373L,23L,1637L,53L,6857L,31L,47L,5323L,811L,6911L,919L,29L,19681L,439L,739L,13499L,29789L,43L,7187L,43L,461L,23327L,50651L,59L,2579L,2909L,22973L,2179L,15901L,14197L,293L,1187L,34607L,11059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059940Inst : IEnumerable<long>
{
public static readonly long[] Value=A059940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059940.Bytes);
public long this[int i]=>Value[i];

public static A059940Inst Instance=new A059940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059941
{
public static readonly long[] Value={ 1L,1L,11L,10L,10L,11L,111L,100L,101L,100L,100L,101L,100L,111L,1111L,1000L,1001L,1000L,1001L,1010L,1001L,1000L,1000L,1001L,1010L,1001L,1000L,1001L,1000L,1111L,11111L,10000L,10001L,10000L,10011L,10000L,10001L,10000L,10001L,10010L,10101L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059941Inst : IEnumerable<long>
{
public static readonly long[] Value=A059941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059941.Bytes);
public long this[int i]=>Value[i];

public static A059941Inst Instance=new A059941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059942
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,3L,7L,4L,5L,4L,4L,5L,4L,7L,15L,8L,9L,8L,9L,10L,9L,8L,8L,9L,10L,9L,8L,9L,8L,15L,31L,16L,17L,16L,19L,16L,17L,16L,17L,18L,21L,16L,17L,18L,17L,16L,16L,17L,18L,17L,16L,21L,18L,17L,16L,17L,16L,19L,16L,17L,16L,31L,63L,32L,33L,32L,35L,32L,33L,32L,35L,36L,33L,32L,35L,32L,33L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059942Inst : IEnumerable<long>
{
public static readonly long[] Value=A059942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059942.Bytes);
public long this[int i]=>Value[i];

public static A059942Inst Instance=new A059942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059943
{
public static readonly long[] Value={ 2L,2L,6L,4L,4L,6L,14L,8L,10L,8L,8L,10L,8L,14L,30L,16L,18L,16L,18L,20L,18L,16L,16L,18L,20L,18L,16L,18L,16L,30L,62L,32L,34L,32L,38L,32L,34L,32L,34L,36L,42L,32L,34L,36L,34L,32L,32L,34L,36L,34L,32L,42L,36L,34L,32L,34L,32L,38L,32L,34L,32L,62L,126L,64L,66L,64L,70L,64L,66L,64L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059943Inst : IEnumerable<long>
{
public static readonly long[] Value=A059943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059943.Bytes);
public long this[int i]=>Value[i];

public static A059943Inst Instance=new A059943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059944
{
public static readonly BigInteger[] Value={ 1L,1L,6L,18L,216L,1080L,19440L,136080L,3265920L,29393280L,881798400L,9699782400L,349192166400L,4539498163200L,190658922854400L,2859883842816000L,137274424455168000L,2333665215737856000L,BigInteger.Parse("126017921649844224000") };
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
public class A059944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059944Inst Instance=new A059944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}