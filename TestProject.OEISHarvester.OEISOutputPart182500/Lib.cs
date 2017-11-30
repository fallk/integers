using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A212957
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,2L,2L,1L,0L,3L,2L,2L,2L,0L,2L,5L,4L,6L,1L,0L,4L,2L,3L,4L,4L,3L,0L,2L,6L,2L,12L,6L,10L,1L,0L,4L,4L,8L,4L,9L,16L,2L,4L,0L,3L,6L,2L,26L,4L,37L,6L,14L,2L,0L,4L,3L,12L,18L,4L,10L,3L,8L,4L,5L,0L,2L,12L,5L,14L,6L,42L,2L,28L,26L,16L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212957Inst : IEnumerable<long>
{
public static readonly long[] Value=A212957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212957.Bytes);
public long this[int i]=>Value[i];

public static A212957Inst Instance=new A212957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212958
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,12L,22L,0L,21L,22L,123L,131L,343L,0L,342L,343L,1234L,2531L,4664L,0L,1421L,3242L,4663L,12345L,58985L,0L,58984L,58985L,23456L,497531L,713306L,0L,137421L,276842L,436463L,575884L,713305L,713306L,1234567L,1810675L,2907844L,4002993L,6197531L,8367727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212958Inst : IEnumerable<long>
{
public static readonly long[] Value=A212958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212958.Bytes);
public long this[int i]=>Value[i];

public static A212958Inst Instance=new A212958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212959
{
public static readonly long[] Value={ 1L,4L,11L,20L,33L,48L,67L,88L,113L,140L,171L,204L,241L,280L,323L,368L,417L,468L,523L,580L,641L,704L,771L,840L,913L,988L,1067L,1148L,1233L,1320L,1411L,1504L,1601L,1700L,1803L,1908L,2017L,2128L,2243L,2360L,2481L,2604L,2731L,2860L,2993L,3128L,3267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212959Inst : IEnumerable<long>
{
public static readonly long[] Value=A212959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212959.Bytes);
public long this[int i]=>Value[i];

public static A212959Inst Instance=new A212959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212960
{
public static readonly long[] Value={ 0L,4L,16L,44L,92L,168L,276L,424L,616L,860L,1160L,1524L,1956L,2464L,3052L,3728L,4496L,5364L,6336L,7420L,8620L,9944L,11396L,12984L,14712L,16588L,18616L,20804L,23156L,25680L,28380L,31264L,34336L,37604L,41072L,44748L,48636L,52744L,57076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212960Inst : IEnumerable<long>
{
public static readonly long[] Value=A212960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212960.Bytes);
public long this[int i]=>Value[i];

public static A212960Inst Instance=new A212960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212961
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,26L,88L,389L,1617L,7808L,34783L,184426L,878705L,4960662L,25295649L,152048803L,820978097L,5254469132L,30147771222L,204763245407L,1249116889562L,9012614482274L,58336358284152L,446435253834922L,3064458931156669L,24788742473819564L,179927874744752672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212961Inst : IEnumerable<long>
{
public static readonly long[] Value=A212961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212961.Bytes);
public long this[int i]=>Value[i];

public static A212961Inst Instance=new A212961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212962
{
public static readonly long[] Value={ 0L,3L,10L,36L,118L,393L,1297L,4287L,14158L,46764L,154450L,510117L,1684801L,5564523L,18378370L,60699636L,200477278L,662131473L,2186871697L,7222746567L,23855111398L,78788080764L,260219353690L,859446141837L,2838557779201L,9375119479443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212962Inst : IEnumerable<long>
{
public static readonly long[] Value=A212962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212962.Bytes);
public long this[int i]=>Value[i];

public static A212962Inst Instance=new A212962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212963
{
public static readonly long[] Value={ 0L,0L,0L,12L,36L,84L,156L,264L,408L,600L,840L,1140L,1500L,1932L,2436L,3024L,3696L,4464L,5328L,6300L,7380L,8580L,9900L,11352L,12936L,14664L,16536L,18564L,20748L,23100L,25620L,28320L,31200L,34272L,37536L,41004L,44676L,48564L,52668L,57000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212963Inst : IEnumerable<long>
{
public static readonly long[] Value=A212963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212963.Bytes);
public long this[int i]=>Value[i];

public static A212963Inst Instance=new A212963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212964
{
public static readonly long[] Value={ 0L,0L,0L,2L,6L,14L,26L,44L,68L,100L,140L,190L,250L,322L,406L,504L,616L,744L,888L,1050L,1230L,1430L,1650L,1892L,2156L,2444L,2756L,3094L,3458L,3850L,4270L,4720L,5200L,5712L,6256L,6834L,7446L,8094L,8778L,9500L,10260L,11060L,11900L,12782L,13706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212964Inst : IEnumerable<long>
{
public static readonly long[] Value=A212964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212964.Bytes);
public long this[int i]=>Value[i];

public static A212964Inst Instance=new A212964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212965
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,52L,76L,97L,129L,156L,196L,229L,277L,316L,372L,417L,481L,532L,604L,661L,741L,804L,892L,961L,1057L,1132L,1236L,1317L,1429L,1516L,1636L,1729L,1857L,1956L,2092L,2197L,2341L,2452L,2604L,2721L,2881L,3004L,3172L,3301L,3477L,3612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212965Inst : IEnumerable<long>
{
public static readonly long[] Value=A212965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212965.Bytes);
public long this[int i]=>Value[i];

public static A212965Inst Instance=new A212965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212966
{
public static readonly long[] Value={ 1L,1L,3L,8L,10L,12L,23L,25L,29L,44L,48L,52L,73L,77L,83L,108L,114L,120L,151L,157L,165L,200L,208L,216L,257L,265L,275L,320L,330L,340L,391L,401L,413L,468L,480L,492L,553L,565L,579L,644L,658L,672L,743L,757L,773L,848L,864L,880L,961L,977L,995L,1080L,1098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212966Inst : IEnumerable<long>
{
public static readonly long[] Value=A212966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212966.Bytes);
public long this[int i]=>Value[i];

public static A212966Inst Instance=new A212966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212967
{
public static readonly long[] Value={ 0L,3L,10L,26L,50L,89L,140L,212L,300L,415L,550L,718L,910L,1141L,1400L,1704L,2040L,2427L,2850L,3330L,3850L,4433L,5060L,5756L,6500L,7319L,8190L,9142L,10150L,11245L,12400L,13648L,14960L,16371L,17850L,19434L,21090L,22857L,24700L,26660L,28700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212967Inst : IEnumerable<long>
{
public static readonly long[] Value=A212967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212967.Bytes);
public long this[int i]=>Value[i];

public static A212967Inst Instance=new A212967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212968
{
public static readonly long[] Value={ 1L,5L,17L,38L,75L,127L,203L,300L,429L,585L,781L,1010L,1287L,1603L,1975L,2392L,2873L,3405L,4009L,4670L,5411L,6215L,7107L,8068L,9125L,10257L,11493L,12810L,14239L,15755L,17391L,19120L,20977L,22933L,25025L,27222L,29563L,32015L,34619L,37340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212968Inst : IEnumerable<long>
{
public static readonly long[] Value=A212968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212968.Bytes);
public long this[int i]=>Value[i];

public static A212968Inst Instance=new A212968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212969
{
public static readonly long[] Value={ 0L,0L,2L,10L,26L,56L,100L,166L,252L,368L,510L,690L,902L,1160L,1456L,1806L,2200L,2656L,3162L,3738L,4370L,5080L,5852L,6710L,7636L,8656L,9750L,10946L,12222L,13608L,15080L,16670L,18352L,20160L,22066L,24106L,26250L,28536L,30932L,33478L,36140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212969Inst : IEnumerable<long>
{
public static readonly long[] Value=A212969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212969.Bytes);
public long this[int i]=>Value[i];

public static A212969Inst Instance=new A212969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212970
{
public static readonly long[] Value={ 0L,2L,8L,22L,44L,80L,128L,196L,280L,390L,520L,682L,868L,1092L,1344L,1640L,1968L,2346L,2760L,3230L,3740L,4312L,4928L,5612L,6344L,7150L,8008L,8946L,9940L,11020L,12160L,13392L,14688L,16082L,17544L,19110L,20748L,22496L,24320L,26260L,28280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212970Inst : IEnumerable<long>
{
public static readonly long[] Value=A212970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212970.Bytes);
public long this[int i]=>Value[i];

public static A212970Inst Instance=new A212970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212971
{
public static readonly long[] Value={ 0L,0L,3L,11L,25L,48L,82L,128L,189L,267L,363L,480L,620L,784L,975L,1195L,1445L,1728L,2046L,2400L,2793L,3227L,3703L,4224L,4792L,5408L,6075L,6795L,7569L,8400L,9290L,10240L,11253L,12331L,13475L,14688L,15972L,17328L,18759L,20267L,21853L,23520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212971Inst : IEnumerable<long>
{
public static readonly long[] Value=A212971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212971.Bytes);
public long this[int i]=>Value[i];

public static A212971Inst Instance=new A212971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212972
{
public static readonly long[] Value={ 1L,8L,24L,53L,100L,168L,261L,384L,540L,733L,968L,1248L,1577L,1960L,2400L,2901L,3468L,4104L,4813L,5600L,6468L,7421L,8464L,9600L,10833L,12168L,13608L,15157L,16820L,18600L,20501L,22528L,24684L,26973L,29400L,31968L,34681L,37544L,40560L,43733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212972Inst : IEnumerable<long>
{
public static readonly long[] Value=A212972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212972.Bytes);
public long this[int i]=>Value[i];

public static A212972Inst Instance=new A212972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212973
{
public static readonly long[] Value={ 1L,4L,12L,27L,50L,84L,131L,192L,270L,367L,484L,624L,789L,980L,1200L,1451L,1734L,2052L,2407L,2800L,3234L,3711L,4232L,4800L,5417L,6084L,6804L,7579L,8410L,9300L,10251L,11264L,12342L,13487L,14700L,15984L,17341L,18772L,20280L,21867L,23534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212973Inst : IEnumerable<long>
{
public static readonly long[] Value=A212973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212973.Bytes);
public long this[int i]=>Value[i];

public static A212973Inst Instance=new A212973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212974
{
public static readonly long[] Value={ 0L,4L,15L,37L,75L,132L,212L,320L,459L,633L,847L,1104L,1408L,1764L,2175L,2645L,3179L,3780L,4452L,5200L,6027L,6937L,7935L,9024L,10208L,11492L,12879L,14373L,15979L,17700L,19540L,21504L,23595L,25817L,28175L,30672L,33312L,36100L,39039L,42133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212974Inst : IEnumerable<long>
{
public static readonly long[] Value=A212974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212974.Bytes);
public long this[int i]=>Value[i];

public static A212974Inst Instance=new A212974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212975
{
public static readonly long[] Value={ 1L,2L,15L,28L,65L,102L,175L,248L,369L,490L,671L,852L,1105L,1358L,1695L,2032L,2465L,2898L,3439L,3980L,4641L,5302L,6095L,6888L,7825L,8762L,9855L,10948L,12209L,13470L,14911L,16352L,17985L,19618L,21455L,23292L,25345L,27398L,29679L,31960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212975Inst : IEnumerable<long>
{
public static readonly long[] Value=A212975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212975.Bytes);
public long this[int i]=>Value[i];

public static A212975Inst Instance=new A212975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212976
{
public static readonly long[] Value={ 0L,6L,12L,36L,60L,114L,168L,264L,360L,510L,660L,876L,1092L,1386L,1680L,2064L,2448L,2934L,3420L,4020L,4620L,5346L,6072L,6936L,7800L,8814L,9828L,11004L,12180L,13530L,14880L,16416L,17952L,19686L,21420L,23364L,25308L,27474L,29640L,32040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212976Inst : IEnumerable<long>
{
public static readonly long[] Value=A212976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212976.Bytes);
public long this[int i]=>Value[i];

public static A212976Inst Instance=new A212976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212977
{
public static readonly long[] Value={ 0L,3L,6L,16L,25L,46L,64L,100L,130L,185L,230L,308L,371L,476L,560L,696L,804L,975L,1110L,1320L,1485L,1738L,1936L,2236L,2470L,2821L,3094L,3500L,3815L,4280L,4640L,5168L,5576L,6171L,6630L,7296L,7809L,8550L,9120L,9940L,10570L,11473L,12166L,13156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212977Inst : IEnumerable<long>
{
public static readonly long[] Value=A212977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212977.Bytes);
public long this[int i]=>Value[i];

public static A212977Inst Instance=new A212977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212978
{
public static readonly long[] Value={ 1L,5L,11L,20L,32L,46L,63L,83L,105L,130L,158L,188L,221L,257L,295L,336L,380L,426L,475L,527L,581L,638L,698L,760L,825L,893L,963L,1036L,1112L,1190L,1271L,1355L,1441L,1530L,1622L,1716L,1813L,1913L,2015L,2120L,2228L,2338L,2451L,2567L,2685L,2806L,2930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212978Inst : IEnumerable<long>
{
public static readonly long[] Value=A212978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212978.Bytes);
public long this[int i]=>Value[i];

public static A212978Inst Instance=new A212978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212979
{
public static readonly long[] Value={ 1L,1L,1L,7L,10L,13L,19L,25L,34L,40L,49L,61L,70L,82L,94L,109L,124L,136L,154L,172L,190L,208L,226L,250L,271L,292L,316L,340L,367L,391L,418L,448L,475L,505L,535L,568L,601L,631L,667L,703L,739L,775L,811L,853L,892L,931L,973L,1015L,1060L,1102L,1147L,1195L,1240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212979Inst : IEnumerable<long>
{
public static readonly long[] Value=A212979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212979.Bytes);
public long this[int i]=>Value[i];

public static A212979Inst Instance=new A212979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212980
{
public static readonly long[] Value={ 0L,1L,6L,17L,37L,68L,113L,174L,254L,355L,480L,631L,811L,1022L,1267L,1548L,1868L,2229L,2634L,3085L,3585L,4136L,4741L,5402L,6122L,6903L,7748L,8659L,9639L,10690L,11815L,13016L,14296L,15657L,17102L,18633L,20253L,21964L,23769L,25670L,27670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212980Inst : IEnumerable<long>
{
public static readonly long[] Value=A212980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212980.Bytes);
public long this[int i]=>Value[i];

public static A212980Inst Instance=new A212980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212981
{
public static readonly long[] Value={ 0L,2L,8L,21L,43L,77L,125L,190L,274L,380L,510L,667L,853L,1071L,1323L,1612L,1940L,2310L,2724L,3185L,3695L,4257L,4873L,5546L,6278L,7072L,7930L,8855L,9849L,10915L,12055L,13272L,14568L,15946L,17408L,18957L,20595L,22325L,24149L,26070L,28090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212981Inst : IEnumerable<long>
{
public static readonly long[] Value=A212981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212981.Bytes);
public long this[int i]=>Value[i];

public static A212981Inst Instance=new A212981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212982
{
public static readonly long[] Value={ 0L,3L,11L,27L,53L,92L,146L,218L,310L,425L,565L,733L,931L,1162L,1428L,1732L,2076L,2463L,2895L,3375L,3905L,4488L,5126L,5822L,6578L,7397L,8281L,9233L,10255L,11350L,12520L,13768L,15096L,16507L,18003L,19587L,21261L,23028L,24890L,26850L,28910L,31073L,33341L,35717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212982Inst : IEnumerable<long>
{
public static readonly long[] Value=A212982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212982.Bytes);
public long this[int i]=>Value[i];

public static A212982Inst Instance=new A212982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212983
{
public static readonly long[] Value={ 1L,5L,15L,33L,62L,104L,162L,238L,335L,455L,601L,775L,980L,1218L,1492L,1804L,2157L,2553L,2995L,3485L,4026L,4620L,5270L,5978L,6747L,7579L,8477L,9443L,10480L,11590L,12776L,14040L,15385L,16813L,18327L,19929L,21622L,23408L,25290L,27270L,29351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212983Inst : IEnumerable<long>
{
public static readonly long[] Value=A212983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212983.Bytes);
public long this[int i]=>Value[i];

public static A212983Inst Instance=new A212983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212984
{
public static readonly long[] Value={ 1L,1L,3L,6L,8L,12L,17L,21L,27L,34L,40L,48L,57L,65L,75L,86L,96L,108L,121L,133L,147L,162L,176L,192L,209L,225L,243L,262L,280L,300L,321L,341L,363L,386L,408L,432L,457L,481L,507L,534L,560L,588L,617L,645L,675L,706L,736L,768L,801L,833L,867L,902L,936L,972L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212984Inst : IEnumerable<long>
{
public static readonly long[] Value=A212984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212984.Bytes);
public long this[int i]=>Value[i];

public static A212984Inst Instance=new A212984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212985
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,11L,18L,21L,24L,34L,38L,42L,55L,60L,65L,81L,87L,93L,112L,119L,126L,148L,156L,164L,189L,198L,207L,235L,245L,255L,286L,297L,308L,342L,354L,366L,403L,416L,429L,469L,483L,497L,540L,555L,570L,616L,632L,648L,697L,714L,731L,783L,801L,819L,874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212985Inst : IEnumerable<long>
{
public static readonly long[] Value=A212985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212985.Bytes);
public long this[int i]=>Value[i];

public static A212985Inst Instance=new A212985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212986
{
public static readonly long[] Value={ 1L,1L,3L,5L,7L,10L,14L,17L,22L,27L,32L,38L,45L,51L,59L,67L,75L,84L,94L,103L,114L,125L,136L,148L,161L,173L,187L,201L,215L,230L,246L,261L,278L,295L,312L,330L,349L,367L,387L,407L,427L,448L,470L,491L,514L,537L,560L,584L,609L,633L,659L,685L,711L,738L,766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212986Inst : IEnumerable<long>
{
public static readonly long[] Value=A212986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212986.Bytes);
public long this[int i]=>Value[i];

public static A212986Inst Instance=new A212986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212987
{
public static readonly long[] Value={ 1L,1L,3L,5L,8L,10L,16L,18L,25L,29L,37L,41L,52L,56L,68L,74L,87L,93L,109L,115L,132L,140L,158L,166L,187L,195L,217L,227L,250L,260L,286L,296L,323L,335L,363L,375L,406L,418L,450L,464L,497L,511L,547L,561L,598L,614L,652L,668L,709L,725L,767L,785L,828L,846L,892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212987Inst : IEnumerable<long>
{
public static readonly long[] Value=A212987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212987.Bytes);
public long this[int i]=>Value[i];

public static A212987Inst Instance=new A212987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212988
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,9L,12L,16L,21L,25L,30L,36L,43L,49L,56L,64L,73L,81L,90L,100L,111L,121L,132L,144L,157L,169L,182L,196L,211L,225L,240L,256L,273L,289L,306L,324L,343L,361L,380L,400L,421L,441L,462L,484L,507L,529L,552L,576L,601L,625L,650L,676L,703L,729L,756L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212988Inst : IEnumerable<long>
{
public static readonly long[] Value=A212988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212988.Bytes);
public long this[int i]=>Value[i];

public static A212988Inst Instance=new A212988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212989
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,11L,13L,15L,24L,27L,30L,33L,46L,50L,54L,58L,75L,80L,85L,90L,111L,117L,123L,129L,154L,161L,168L,175L,204L,212L,220L,228L,261L,270L,279L,288L,325L,335L,345L,355L,396L,407L,418L,429L,474L,486L,498L,510L,559L,572L,585L,598L,651L,665L,679L,693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212989Inst : IEnumerable<long>
{
public static readonly long[] Value=A212989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212989.Bytes);
public long this[int i]=>Value[i];

public static A212989Inst Instance=new A212989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212990
{
public static readonly long[] Value={ 1L,2L,2L,9L,7L,14L,10L,17L,21L,27L,32L,43L,35L,32L,43L,48L,50L,54L,59L,78L,71L,69L,48L,75L,74L,100L,80L,85L,77L,115L,105L,110L,102L,137L,139L,147L,148L,159L,156L,186L,151L,144L,156L,166L,167L,148L,222L,233L,209L,247L,214L,219L,249L,245L,226L,241L,234L,267L,243L,233L,256L,292L,290L,269L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212990Inst : IEnumerable<long>
{
public static readonly long[] Value=A212990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212990.Bytes);
public long this[int i]=>Value[i];

public static A212990Inst Instance=new A212990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212991
{
public static readonly long[] Value={ 0L,1L,3L,3L,6L,10L,10L,9L,11L,20L,22L,21L,21L,19L,20L,20L,20L,38L,38L,37L,45L,46L,41L,41L,40L,38L,43L,43L,44L,44L,45L,44L,37L,67L,64L,63L,83L,89L,85L,86L,84L,89L,85L,89L,85L,88L,82L,82L,78L,79L,85L,87L,87L,85L,93L,91L,89L,100L,93L,96L,98L,96L,91L,91L,75L,116L,111L,111L,141L,146L,140L,142L,160L,208L,185L,186L,185L,204L,183L,184L,167L,162L,174L,175L,174L,167L,176L,176L,162L,167L,161L,168L,172L,173L,169L,165L,153L,150L,171L,171L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212991Inst : IEnumerable<long>
{
public static readonly long[] Value=A212991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212991.Bytes);
public long this[int i]=>Value[i];

public static A212991Inst Instance=new A212991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212992
{
public static readonly long[] Value={ 0L,1L,1L,3L,9L,4L,6L,5L,6L,7L,12L,11L,63L,16L,16L,16L,16L,49L,16L,50L,18L,20L,19L,74L,19L,19L,84L,17L,29L,27L,42L,37L,3023696L,37L,220L,195L,234L,40L,49L,49L,47L,225L,45L,47L,1534L,44L,258L,250L,42L,48L,45L,266L,45L,49L,45L,41L,51L,325L,53L,311L,321L,335L,56L,55L,54L,60L,59L,370L,59L,61L,59L,2418L,60L,364L,62L,62L,65L,381L,2632L,395L,2797L,54L,44068L,66L,67113L,84L,611L,611L,88L,84L,5680L,119L,848L,112L,117L,804L,111L,897L,811L,782L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212992Inst : IEnumerable<long>
{
public static readonly long[] Value=A212992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212992.Bytes);
public long this[int i]=>Value[i];

public static A212992Inst Instance=new A212992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212993
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,10L,12L,4L,6L,13L,7L,6L,23L,19L,7L,8L,8L,52L,13L,12L,13731L,369L,76L,20L,22L,25L,86L,81L,22L,24L,21L,73L,73L,18L,26L,24L,321783L,23L,100L,100L,120L,27L,544L,26L,112L,28L,120L,111L,28L,121L,28L,29L,4585L,32L,30L,142L,28L,31L,31L,29L,33L,29L,131L,719L,29L,189L,191L,1028L,1524L,14439L,1637L,53L,52L,330L,347L,53L,57L,356L,302L,1787L,216458L,70L,420L,83L,81L,2815L,84L,85L,85L,471L,81L,86L,423L,85L,329242L,437L,79L,77L,2849L,492L,476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212993Inst : IEnumerable<long>
{
public static readonly long[] Value=A212993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212993.Bytes);
public long this[int i]=>Value[i];

public static A212993Inst Instance=new A212993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212994
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,18L,13L,25L,4L,6L,34L,8L,7L,6L,21L,9L,7L,8L,25L,71L,9L,24L,8L,10L,9L,15L,173L,151L,54L,1584L,114L,677618179L,21L,12109L,94L,27L,15320L,2272L,26L,106L,31L,31L,109L,504L,111L,19076L,28L,33879567L,2066L,94L,22L,570L,487L,27L,37L,498L,552L,138L,31L,33L,132L,130L,138L,142L,144L,36L,4637L,152L,142L,32L,157L,161L,157L,34L,4729L,147L,168L,152L,36L,160L,4722L,6386943L,4580L,160L,43L,40L,41L,44L,192L,39L,40L,181L,189L,40L,5908L,860L,41L,861L,181L,9068626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212994Inst : IEnumerable<long>
{
public static readonly long[] Value=A212994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212994.Bytes);
public long this[int i]=>Value[i];

public static A212994Inst Instance=new A212994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212995
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,3L,20L,14L,12L,110L,4L,6L,15L,8L,37L,7L,6L,24372L,9L,8L,63L,28L,23L,23L,9L,25L,8L,282034L,36968L,6510L,33L,12L,982L,26L,9591L,10L,16L,255487L,3979L,166L,157L,12605L,31L,28L,105L,22L,22L,31L,209297L,127L,203842L,2476718L,15757L,123L,36L,217940L,476L,3308L,22984L,36L,150L,152L,2899L,137L,12111685419L,21726L,37L,132L,32L,123L,530L,2246L,26L,520L,2995L,32L,121L,647L,161L,174L,171L,40L,39L,38L,40L,813L,188L,41L,788L,43L,41L,837L,31346L,166L,4484L,43L,862L,965L,898L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212995Inst : IEnumerable<long>
{
public static readonly long[] Value=A212995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212995.Bytes);
public long this[int i]=>Value[i];

public static A212995Inst Instance=new A212995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212996
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,3L,21L,14L,13L,25L,25L,4L,6L,32L,8L,100L,4414L,7L,6L,25L,9L,8L,270L,666L,292906L,25L,12L,13L,40551L,166L,83257249L,33859L,57L,4999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212996Inst : IEnumerable<long>
{
public static readonly long[] Value=A212996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212996.Bytes);
public long this[int i]=>Value[i];

public static A212996Inst Instance=new A212996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212997
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,3L,207L,14L,26L,12L,48L,51L,4L,6L,16L,8L,19L,36936L,253L,7L,6L,24L,9L,8L,13L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212997Inst : IEnumerable<long>
{
public static readonly long[] Value=A212997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212997.Bytes);
public long this[int i]=>Value[i];

public static A212997Inst Instance=new A212997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212998
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,3L,23L,14L,26L,13L,24L,3829L,273L,4L,6L,2225L,8L,21L,39L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212998Inst : IEnumerable<long>
{
public static readonly long[] Value=A212998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212998.Bytes);
public long this[int i]=>Value[i];

public static A212998Inst Instance=new A212998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212999
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,45L,14L,329L,48L,13L,1451L,36L,22L,6426011142L,4L,6L,34L,8L,46L,33730569L,43L,32L,260L,207L,7L,6L,58L,9L,8L,171L,29L,12L,13L,825769L,59L,53L,61L,30L,82L,179L,30L,8760451204L,13L,331L,15L,65L,35L,81L,309474L,14L,15L,17L,13L,62020L,108L,393376945L,41L,6306L,92L,18L,524L,44L,1256L,116L,16L,15L,107L,108L,36L,380737L,6670L,15L,377L,311L,418L,17L,41L,51L,64386749L,1376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212999Inst : IEnumerable<long>
{
public static readonly long[] Value=A212999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212999.Bytes);
public long this[int i]=>Value[i];

public static A212999Inst Instance=new A212999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213000
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,79084L,14L,33L,338L,25L,12L,5046L,950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213000Inst : IEnumerable<long>
{
public static readonly long[] Value=A213000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213000.Bytes);
public long this[int i]=>Value[i];

public static A213000Inst Instance=new A213000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213001
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,418L,14L,32L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213001Inst : IEnumerable<long>
{
public static readonly long[] Value=A213001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213001.Bytes);
public long this[int i]=>Value[i];

public static A213001Inst Instance=new A213001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213002
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,39L,14L,2192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213002Inst : IEnumerable<long>
{
public static readonly long[] Value=A213002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213002.Bytes);
public long this[int i]=>Value[i];

public static A213002Inst Instance=new A213002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213003
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,39L,14L,900776833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213003Inst : IEnumerable<long>
{
public static readonly long[] Value=A213003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213003.Bytes);
public long this[int i]=>Value[i];

public static A213003Inst Instance=new A213003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213004
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,39L,14L,8935434522L,426879L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213004Inst : IEnumerable<long>
{
public static readonly long[] Value=A213004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213004.Bytes);
public long this[int i]=>Value[i];

public static A213004Inst Instance=new A213004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213005
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,33L,45L,72L,143L,152L,303L,420L,451L,603L,952L,1398L,1572L,2408L,3762L,4233L,5880L,6325L,8469L,13384L,20079L,34189L,62769L,82665L,87448L,161037L,287283L,371337L,515745L,533505L,573815L,734484L,737035L,737149L,767505L,825495L,887865L,1136468L,2272935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213005Inst : IEnumerable<long>
{
public static readonly long[] Value=A213005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213005.Bytes);
public long this[int i]=>Value[i];

public static A213005Inst Instance=new A213005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213006
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,18L,1001L,1002L,1003L,1004L,1005L,1006L,1007L,1008L,1009L,1010L,2001L,2002L,2003L,2004L,2005L,2006L,2007L,2008L,2009L,2010L,3001L,3002L,3003L,3004L,3005L,3006L,3007L,3008L,3009L,3010L,4001L,4002L,4003L,4004L,4005L,4006L,4007L,4008L,4009L,4010L,5001L,5002L,5003L,5004L,5005L,5006L,5007L,5008L,5009L,5010L,6001L,6002L,6003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213006Inst : IEnumerable<long>
{
public static readonly long[] Value=A213006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213006.Bytes);
public long this[int i]=>Value[i];

public static A213006Inst Instance=new A213006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213007
{
public static readonly long[] Value={ 8L,7L,0L,5L,8L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213007Inst : IEnumerable<long>
{
public static readonly long[] Value=A213007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213007.Bytes);
public long this[int i]=>Value[i];

public static A213007Inst Instance=new A213007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213008
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,3L,4L,5L,1L,3L,5L,6L,7L,1L,4L,7L,9L,10L,11L,1L,4L,8L,10L,12L,13L,14L,1L,5L,9L,14L,16L,18L,19L,20L,1L,5L,12L,17L,21L,23L,25L,26L,27L,1L,6L,13L,21L,26L,30L,32L,34L,35L,36L,1L,6L,16L,25L,33L,37L,41L,43L,45L,46L,47L,1L,7L,19L,32L,42L,50L,54L,58L,60L,62L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213008Inst : IEnumerable<long>
{
public static readonly long[] Value=A213008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213008.Bytes);
public long this[int i]=>Value[i];

public static A213008Inst Instance=new A213008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213009
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,21L,125L,825L,6133L,49925L,439417L,4142945L,41544161L,440710117L,4924691541L,57766255689L,709205703565L,9090541134373L,121389729560633L,1685431945085489L,24289856880005441L,362776874949660485L,5606980244843123077L,BigInteger.Parse("89560387072919814553") };
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
public class A213009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213009Inst Instance=new A213009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213010
{
public static readonly BigInteger[] Value={ 1L,2L,4L,16L,80L,480L,3296L,25152L,209600L,1884160L,18110080L,184898304L,1994964736L,22654449664L,269855506944L,3362350046208L,43715434232832L,591812683833344L,8326660788725760L,121550217508892672L,1838089917983911936L,BigInteger.Parse("28753297176215257088"),BigInteger.Parse("464675647688625364992") };
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
public class A213010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213010Inst Instance=new A213010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213011
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,10L,16L,17L,25L,28L,36L,41L,49L,58L,64L,77L,81L,100L,121L,129L,144L,160L,169L,196L,197L,225L,238L,256L,281L,289L,324L,328L,361L,381L,400L,440L,441L,484L,501L,529L,568L,576L,625L,639L,676L,712L,729L,784L,791L,841L,874L,900L,961L,963L,1024L,1060L,1089L,1156L,1161L,1225L,1264L,1296L,1369L,1371L,1444L,1480L,1521L,1593L,1600L,1681L,1720L,1764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213011Inst : IEnumerable<long>
{
public static readonly long[] Value=A213011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213011.Bytes);
public long this[int i]=>Value[i];

public static A213011Inst Instance=new A213011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213012
{
public static readonly long[] Value={ 26L,37L,78L,135L,360L,405L,744L,837L,1488L,1581L,3024L,3213L,6048L,6237L,12192L,12573L,24384L,24765L,48960L,49725L,97920L,98685L,196224L,197757L,392448L,393981L,785664L,788733L,1571328L,1574397L,3144192L,3150333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213012Inst : IEnumerable<long>
{
public static readonly long[] Value=A213012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213012.Bytes);
public long this[int i]=>Value[i];

public static A213012Inst Instance=new A213012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213013
{
public static readonly long[] Value={ 0L,2L,0L,2L,2L,1L,0L,8L,2L,2L,8L,5L,8L,2L,0L,2L,8L,18L,12L,8L,2L,16L,8L,2L,18L,26L,8L,11L,2L,2L,0L,2L,2L,22L,8L,31L,18L,5L,32L,2L,8L,27L,24L,17L,16L,8L,32L,43L,2L,2L,44L,45L,26L,2L,8L,56L,40L,47L,32L,33L,2L,8L,0L,57L,2L,5L,36L,62L,22L,60L,8L,1L,68L,2L,56L,57L,44L,8L,32L,80L,2L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213013Inst : IEnumerable<long>
{
public static readonly long[] Value=A213013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213013.Bytes);
public long this[int i]=>Value[i];

public static A213013Inst Instance=new A213013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213014
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,6L,5L,4L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,0L,3L,2L,1L,0L,0L,1L,0L,3L,2L,1L,0L,0L,6L,5L,4L,3L,2L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,0L,0L,6L,5L,4L,3L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,0L,1L,0L,5L,4L,3L,2L,1L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,0L,2L,1L,0L,0L,4L,3L,2L,1L,0L,0L,0L,0L,3L,2L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213014Inst : IEnumerable<long>
{
public static readonly long[] Value=A213014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213014.Bytes);
public long this[int i]=>Value[i];

public static A213014Inst Instance=new A213014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213015
{
public static readonly long[] Value={ 4L,8L,9L,21L,25L,30L,32L,33L,36L,49L,57L,69L,70L,84L,85L,93L,100L,102L,120L,121L,128L,129L,133L,135L,144L,145L,162L,169L,174L,177L,182L,190L,205L,213L,217L,228L,237L,238L,246L,249L,253L,260L,265L,286L,289L,308L,309L,310L,312L,318L,340L,351L,361L,372L,393L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213015Inst : IEnumerable<long>
{
public static readonly long[] Value=A213015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213015.Bytes);
public long this[int i]=>Value[i];

public static A213015Inst Instance=new A213015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213016
{
public static readonly long[] Value={ 8L,9L,14L,20L,24L,26L,27L,38L,44L,62L,68L,74L,105L,112L,116L,125L,126L,134L,150L,160L,180L,188L,192L,195L,208L,212L,216L,218L,231L,234L,243L,254L,275L,278L,314L,330L,332L,343L,352L,356L,362L,396L,398L,422L,428L,465L,483L,490L,496L,548L,558L,575L,588L,609L,614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213016Inst : IEnumerable<long>
{
public static readonly long[] Value=A213016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213016.Bytes);
public long this[int i]=>Value[i];

public static A213016Inst Instance=new A213016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213017
{
public static readonly long[] Value={ 0L,0L,0L,8L,22L,30L,31L,35L,38L,43L,48L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213017Inst : IEnumerable<long>
{
public static readonly long[] Value=A213017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213017.Bytes);
public long this[int i]=>Value[i];

public static A213017Inst Instance=new A213017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213018
{
public static readonly BigInteger[] Value={ 349859L,96614184696363331L,BigInteger.Parse("21453921664462866568480385"),BigInteger.Parse("5396625577204731352098054139"),BigInteger.Parse("1230847457959658263441326143300761"),BigInteger.Parse("95861957783594714393831931415189937897"),BigInteger.Parse("246968512564969427282294385793684699270364003"),BigInteger.Parse("2275670244821939317343219562642735197101789412250091"),BigInteger.Parse("452359410421075824795509870868069265597540337861667320077") };
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
public class A213018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213018Inst Instance=new A213018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213019
{
public static readonly BigInteger[] Value={ 9L,95L,959L,9599L,95999L,959999L,9599999L,95999987L,959999879L,9599998799L,95999987999L,959999879999L,9599998791827L,95999987918279L,959999879182793L,9599998791715333L,95999987917153339L,959999879171533399L,9599998791715333999UL,BigInteger.Parse("95999987917153339993") };
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
public class A213019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213019Inst Instance=new A213019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213020
{
public static readonly long[] Value={ 2L,4L,8L,15L,21L,35L,33L,39L,65L,51L,57L,95L,69L,115L,86L,87L,93L,155L,212L,111L,122L,123L,129L,215L,141L,235L,158L,159L,265L,371L,177L,183L,194L,427L,201L,335L,213L,219L,365L,511L,237L,395L,249L,415L,446L,267L,278L,623L,964L,291L,302L,303L,309L,515L,321L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213020Inst : IEnumerable<long>
{
public static readonly long[] Value=A213020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213020.Bytes);
public long this[int i]=>Value[i];

public static A213020Inst Instance=new A213020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213021
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,7L,9L,2L,19L,13L,21L,25L,10L,22L,60L,2L,5L,11L,25L,9L,41L,11L,14L,53L,21L,141L,54L,137L,79L,30L,1L,2L,51L,16L,5L,8L,9L,39L,5L,10L,74L,11L,3L,61L,25L,69L,32L,104L,129L,44L,48L,151L,243L,19L,165L,7L,96L,20L,93L,130L,136L,98L,25L,102L,156L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213021Inst : IEnumerable<long>
{
public static readonly long[] Value=A213021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213021.Bytes);
public long this[int i]=>Value[i];

public static A213021Inst Instance=new A213021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213022
{
public static readonly long[] Value={ 1L,5L,8L,5L,8L,16L,9L,8L,16L,8L,17L,24L,8L,16L,16L,13L,24L,16L,16L,24L,32L,13L,8L,32L,8L,24L,40L,16L,25L,24L,24L,24L,32L,16L,16L,40L,17L,32L,32L,16L,40L,48L,16L,16L,32L,21L,48L,32L,16L,24L,40L,32L,24L,56L,24L,45L,40L,16L,32L,24L,32L,40L,48L,16L,32L,64L,25L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213022Inst : IEnumerable<long>
{
public static readonly long[] Value=A213022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213022.Bytes);
public long this[int i]=>Value[i];

public static A213022Inst Instance=new A213022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213023
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,4L,4L,5L,3L,4L,5L,4L,6L,4L,4L,5L,7L,5L,3L,6L,8L,8L,8L,6L,3L,7L,6L,10L,6L,5L,10L,4L,8L,7L,8L,10L,6L,9L,8L,5L,10L,10L,11L,6L,9L,11L,6L,12L,9L,8L,8L,10L,9L,6L,6L,15L,12L,9L,9L,6L,13L,10L,13L,10L,7L,14L,12L,12L,8L,7L,13L,10L,16L,9L,10L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213023Inst : IEnumerable<long>
{
public static readonly long[] Value=A213023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213023.Bytes);
public long this[int i]=>Value[i];

public static A213023Inst Instance=new A213023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213024
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,2L,2L,0L,2L,1L,0L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,6L,0L,0L,4L,0L,2L,4L,2L,3L,4L,2L,2L,2L,0L,6L,4L,2L,4L,0L,4L,2L,4L,2L,0L,8L,2L,2L,6L,0L,2L,8L,2L,6L,4L,0L,6L,1L,0L,4L,6L,4L,4L,6L,2L,2L,6L,2L,4L,8L,4L,0L,4L,2L,2L,10L,4L,6L,4L,2L,6L,2L,2L,8L,6L,6L,6L,0L,2L,0L,8L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213024Inst : IEnumerable<long>
{
public static readonly long[] Value=A213024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213024.Bytes);
public long this[int i]=>Value[i];

public static A213024Inst Instance=new A213024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213025
{
public static readonly long[] Value={ 34L,86L,94L,122L,142L,185L,194L,202L,214L,218L,262L,289L,302L,314L,321L,358L,371L,394L,407L,413L,415L,422L,446L,471L,489L,493L,497L,517L,535L,562L,581L,586L,626L,634L,669L,687L,698L,734L,785L,791L,815L,838L,842L,922L,982L,989L,1042L,1057L,1079L,1135L,1138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213025Inst : IEnumerable<long>
{
public static readonly long[] Value=A213025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213025.Bytes);
public long this[int i]=>Value[i];

public static A213025Inst Instance=new A213025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213026
{
public static readonly long[] Value={ 0L,2L,6L,56L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213026Inst : IEnumerable<long>
{
public static readonly long[] Value=A213026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213026.Bytes);
public long this[int i]=>Value[i];

public static A213026Inst Instance=new A213026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213027
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,4L,1L,0L,1L,1L,7L,19L,1L,0L,1L,1L,10L,61L,98L,1L,0L,1L,1L,13L,127L,591L,531L,1L,0L,1L,1L,16L,217L,1810L,6101L,2974L,1L,0L,1L,1L,19L,331L,4085L,27631L,65719L,17060L,1L,0L,1L,1L,22L,469L,7746L,82593L,441604L,729933L,99658L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213027Inst : IEnumerable<long>
{
public static readonly long[] Value=A213027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213027.Bytes);
public long this[int i]=>Value[i];

public static A213027Inst Instance=new A213027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213028
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,8L,1L,0L,1L,4L,21L,38L,1L,0L,1L,5L,40L,183L,196L,1L,0L,1L,6L,65L,508L,1773L,1062L,1L,0L,1L,7L,96L,1085L,7240L,18303L,5948L,1L,0L,1L,8L,133L,1986L,20425L,110524L,197157L,34120L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213028Inst : IEnumerable<long>
{
public static readonly long[] Value=A213028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213028.Bytes);
public long this[int i]=>Value[i];

public static A213028Inst Instance=new A213028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213029
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,5L,5L,12L,7L,16L,16L,20L,20L,33L,24L,39L,39L,45L,45L,64L,51L,72L,72L,80L,80L,105L,88L,115L,115L,125L,125L,156L,135L,168L,168L,180L,180L,217L,192L,231L,231L,245L,245L,288L,259L,304L,304L,320L,320L,369L,336L,387L,387L,405L,405L,460L,423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213029Inst : IEnumerable<long>
{
public static readonly long[] Value=A213029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213029.Bytes);
public long this[int i]=>Value[i];

public static A213029Inst Instance=new A213029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213030
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,8L,12L,12L,21L,27L,27L,40L,48L,48L,65L,75L,75L,96L,108L,108L,133L,147L,147L,176L,192L,192L,225L,243L,243L,280L,300L,300L,341L,363L,363L,408L,432L,432L,481L,507L,507L,560L,588L,588L,645L,675L,675L,736L,768L,768L,833L,867L,867L,936L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213030Inst : IEnumerable<long>
{
public static readonly long[] Value=A213030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213030.Bytes);
public long this[int i]=>Value[i];

public static A213030Inst Instance=new A213030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213031
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,7L,19L,19L,56L,37L,98L,98L,152L,152L,279L,218L,387L,387L,513L,513L,784L,657L,988L,988L,1216L,1216L,1685L,1468L,2015L,2015L,2375L,2375L,3096L,2765L,3582L,3582L,4104L,4104L,5131L,4662L,5803L,5803L,6517L,6517L,7904L,7273L,8792L,8792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213031Inst : IEnumerable<long>
{
public static readonly long[] Value=A213031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213031.Bytes);
public long this[int i]=>Value[i];

public static A213031Inst Instance=new A213031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213032
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,5L,5L,7L,11L,14L,14L,20L,20L,24L,31L,36L,36L,45L,45L,51L,61L,68L,68L,80L,80L,88L,101L,110L,110L,125L,125L,135L,151L,162L,162L,180L,180L,192L,211L,224L,224L,245L,245L,259L,281L,296L,296L,320L,320L,336L,361L,378L,378L,405L,405L,423L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213032Inst : IEnumerable<long>
{
public static readonly long[] Value=A213032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213032.Bytes);
public long this[int i]=>Value[i];

public static A213032Inst Instance=new A213032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213033
{
public static readonly long[] Value={ 0L,0L,0L,3L,8L,10L,36L,42L,64L,108L,150L,165L,288L,312L,392L,525L,640L,680L,972L,1026L,1200L,1470L,1694L,1771L,2304L,2400L,2704L,3159L,3528L,3654L,4500L,4650L,5120L,5808L,6358L,6545L,7776L,7992L,8664L,9633L,10400L,10660L,12348L,12642L,13552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213033Inst : IEnumerable<long>
{
public static readonly long[] Value=A213033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213033.Bytes);
public long this[int i]=>Value[i];

public static A213033Inst Instance=new A213033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213034
{
public static readonly long[] Value={ 0L,0L,0L,4L,6L,7L,18L,21L,24L,40L,45L,49L,72L,78L,84L,112L,120L,127L,162L,171L,180L,220L,231L,241L,288L,300L,312L,364L,378L,391L,450L,465L,480L,544L,561L,577L,648L,666L,684L,760L,780L,799L,882L,903L,924L,1012L,1035L,1057L,1152L,1176L,1200L,1300L,1326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213034Inst : IEnumerable<long>
{
public static readonly long[] Value=A213034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213034.Bytes);
public long this[int i]=>Value[i];

public static A213034Inst Instance=new A213034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213035
{
public static readonly long[] Value={ 0L,1L,4L,8L,15L,24L,32L,45L,60L,72L,91L,112L,128L,153L,180L,200L,231L,264L,288L,325L,364L,392L,435L,480L,512L,561L,612L,648L,703L,760L,800L,861L,924L,968L,1035L,1104L,1152L,1225L,1300L,1352L,1431L,1512L,1568L,1653L,1740L,1800L,1891L,1984L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213035Inst : IEnumerable<long>
{
public static readonly long[] Value=A213035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213035.Bytes);
public long this[int i]=>Value[i];

public static A213035Inst Instance=new A213035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213036
{
public static readonly long[] Value={ 0L,1L,3L,5L,12L,16L,20L,33L,39L,45L,64L,72L,80L,105L,115L,125L,156L,168L,180L,217L,231L,245L,288L,304L,320L,369L,387L,405L,460L,480L,500L,561L,583L,605L,672L,696L,720L,793L,819L,845L,924L,952L,980L,1065L,1095L,1125L,1216L,1248L,1280L,1377L,1411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213036Inst : IEnumerable<long>
{
public static readonly long[] Value=A213036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213036.Bytes);
public long this[int i]=>Value[i];

public static A213036Inst Instance=new A213036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213037
{
public static readonly long[] Value={ 0L,1L,2L,7L,8L,17L,18L,31L,32L,49L,50L,71L,72L,97L,98L,127L,128L,161L,162L,199L,200L,241L,242L,287L,288L,337L,338L,391L,392L,449L,450L,511L,512L,577L,578L,647L,648L,721L,722L,799L,800L,881L,882L,967L,968L,1057L,1058L,1151L,1152L,1249L,1250L,1351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213037Inst : IEnumerable<long>
{
public static readonly long[] Value=A213037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213037.Bytes);
public long this[int i]=>Value[i];

public static A213037Inst Instance=new A213037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213038
{
public static readonly long[] Value={ 0L,1L,1L,6L,4L,13L,9L,22L,16L,33L,25L,46L,36L,61L,49L,78L,64L,97L,81L,118L,100L,141L,121L,166L,144L,193L,169L,222L,196L,253L,225L,286L,256L,321L,289L,358L,324L,397L,361L,438L,400L,481L,441L,526L,484L,573L,529L,622L,576L,673L,625L,726L,676L,781L,729L,838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213038Inst : IEnumerable<long>
{
public static readonly long[] Value=A213038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213038.Bytes);
public long this[int i]=>Value[i];

public static A213038Inst Instance=new A213038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213039
{
public static readonly long[] Value={ 0L,1L,8L,26L,63L,124L,208L,335L,504L,702L,973L,1304L,1664L,2133L,2680L,3250L,3971L,4788L,5616L,6643L,7784L,8918L,10305L,11824L,13312L,15113L,17064L,18954L,21223L,23660L,26000L,28791L,31768L,34606L,37973L,41544L,44928L,48925L,53144L,57122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213039Inst : IEnumerable<long>
{
public static readonly long[] Value=A213039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213039.Bytes);
public long this[int i]=>Value[i];

public static A213039Inst Instance=new A213039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213040
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,11L,12L,14L,17L,21L,24L,26L,27L,29L,32L,36L,41L,45L,48L,50L,51L,53L,56L,60L,65L,71L,76L,80L,83L,85L,86L,88L,91L,95L,100L,106L,113L,119L,124L,128L,131L,133L,134L,136L,139L,143L,148L,154L,161L,169L,176L,182L,187L,191L,194L,196L,197L,199L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213040Inst : IEnumerable<long>
{
public static readonly long[] Value=A213040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213040.Bytes);
public long this[int i]=>Value[i];

public static A213040Inst Instance=new A213040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213041
{
public static readonly long[] Value={ 1L,2L,7L,12L,21L,30L,43L,56L,73L,90L,111L,132L,157L,182L,211L,240L,273L,306L,343L,380L,421L,462L,507L,552L,601L,650L,703L,756L,813L,870L,931L,992L,1057L,1122L,1191L,1260L,1333L,1406L,1483L,1560L,1641L,1722L,1807L,1892L,1981L,2070L,2163L,2256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213041Inst : IEnumerable<long>
{
public static readonly long[] Value=A213041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213041.Bytes);
public long this[int i]=>Value[i];

public static A213041Inst Instance=new A213041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213042
{
public static readonly long[] Value={ 1L,0L,2L,2L,3L,4L,7L,6L,11L,12L,15L,18L,24L,24L,33L,36L,42L,48L,58L,60L,74L,80L,90L,100L,115L,120L,140L,150L,165L,180L,201L,210L,237L,252L,273L,294L,322L,336L,371L,392L,420L,448L,484L,504L,548L,576L,612L,648L,693L,720L,774L,810L,855L,900L,955L,990L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213042Inst : IEnumerable<long>
{
public static readonly long[] Value=A213042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213042.Bytes);
public long this[int i]=>Value[i];

public static A213042Inst Instance=new A213042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213043
{
public static readonly long[] Value={ 1L,0L,3L,1L,7L,5L,16L,17L,38L,50L,94L,138L,239L,370L,617L,979L,1605L,2575L,4190L,6755L,10956L,17700L,28668L,46356L,75037L,121380L,196431L,317797L,514243L,832025L,1346284L,2178293L,3524594L,5702870L,9227482L,14930334L,24157835L,39088150L,63246005L,102334135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213043Inst : IEnumerable<long>
{
public static readonly long[] Value=A213043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213043.Bytes);
public long this[int i]=>Value[i];

public static A213043Inst Instance=new A213043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213044
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,12L,22L,34L,56L,94L,150L,244L,399L,643L,1042L,1691L,2733L,4424L,7164L,11588L,18752L,30348L,49100L,79448L,128557L,208005L,336562L,544577L,881139L,1425716L,2306866L,3732582L,6039448L,9772042L,15811490L,25583532L,41395035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213044Inst : IEnumerable<long>
{
public static readonly long[] Value=A213044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213044.Bytes);
public long this[int i]=>Value[i];

public static A213044Inst Instance=new A213044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213045
{
public static readonly long[] Value={ 0L,4L,14L,36L,72L,128L,206L,312L,448L,620L,830L,1084L,1384L,1736L,2142L,2608L,3136L,3732L,4398L,5140L,5960L,6864L,7854L,8936L,10112L,11388L,12766L,14252L,15848L,17560L,19390L,21344L,23424L,25636L,27982L,30468L,33096L,35872L,38798L,41880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213045Inst : IEnumerable<long>
{
public static readonly long[] Value=A213045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213045.Bytes);
public long this[int i]=>Value[i];

public static A213045Inst Instance=new A213045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213046
{
public static readonly long[] Value={ 2L,3L,8L,13L,25L,41L,71L,116L,193L,314L,514L,834L,1356L,2197L,3562L,5767L,9339L,15115L,24465L,39590L,64067L,103668L,167748L,271428L,439190L,710631L,1149836L,1860481L,3010333L,4870829L,7881179L,12752024L,20633221L,33385262L,54018502L,87403782L,141422304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213046Inst : IEnumerable<long>
{
public static readonly long[] Value=A213046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213046.Bytes);
public long this[int i]=>Value[i];

public static A213046Inst Instance=new A213046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213047
{
public static readonly long[] Value={ 41L,73L,179L,227L,233L,331L,373L,409L,457L,467L,487L,521L,523L,547L,563L,577L,587L,599L,601L,607L,643L,691L,727L,739L,809L,907L,947L,971L,977L,1009L,1019L,1021L,1091L,1117L,1171L,1181L,1187L,1193L,1217L,1223L,1229L,1283L,1429L,1433L,1543L,1553L,1607L,1777L,1871L,1877L,1901L,1907L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213047Inst : IEnumerable<long>
{
public static readonly long[] Value=A213047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213047.Bytes);
public long this[int i]=>Value[i];

public static A213047Inst Instance=new A213047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213048
{
public static readonly BigInteger[] Value={ 1L,1L,5L,31L,229L,1981L,19775L,224589L,2864901L,40591255L,632760105L,10765616885L,198543617119L,3945765358653L,84070841065937L,1911864488674531L,46222718892288645L,1183919151676806177L,BigInteger.Parse("32025836905529003471"),BigInteger.Parse("912372909851608715945"),BigInteger.Parse("27304698509111141688969") };
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
public class A213048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213048Inst Instance=new A213048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213049
{
public static readonly long[] Value={ 5L,37L,73L,101L,109L,197L,257L,577L,601L,641L,677L,727L,1601L,1801L,2593L,3137L,3389L,3457L,4057L,4357L,5477L,8101L,8837L,10369L,14401L,14407L,16901L,17957L,18253L,18433L,20809L,21317L,22501L,25601L,30977L,33857L,37447L,42437L,44101L,47629L,47653L,50177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213049Inst : IEnumerable<long>
{
public static readonly long[] Value=A213049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213049.Bytes);
public long this[int i]=>Value[i];

public static A213049Inst Instance=new A213049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213050
{
public static readonly long[] Value={ 5L,13L,29L,37L,53L,61L,101L,149L,173L,181L,197L,269L,293L,317L,349L,373L,389L,421L,461L,509L,541L,557L,613L,653L,661L,677L,701L,709L,757L,773L,797L,821L,829L,853L,877L,941L,1061L,1109L,1117L,1213L,1229L,1237L,1277L,1301L,1373L,1381L,1453L,1493L,1549L,1621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213050Inst : IEnumerable<long>
{
public static readonly long[] Value=A213050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213050.Bytes);
public long this[int i]=>Value[i];

public static A213050Inst Instance=new A213050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213051
{
public static readonly long[] Value={ 3L,11L,19L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,347L,379L,419L,443L,467L,491L,523L,547L,563L,587L,619L,659L,787L,827L,859L,883L,907L,947L,1019L,1091L,1123L,1171L,1187L,1259L,1283L,1291L,1307L,1427L,1451L,1483L,1499L,1523L,1531L,1571L,1619L,1667L,1747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213051Inst : IEnumerable<long>
{
public static readonly long[] Value=A213051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213051.Bytes);
public long this[int i]=>Value[i];

public static A213051Inst Instance=new A213051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213052
{
public static readonly long[] Value={ 3L,5L,53L,173L,293L,2477L,9173L,22613L,27653L,61613L,74093L,92333L,170957L,360293L,679733L,847997L,2004917L,69009533L,76553573L,138473837L,237536213L,777133013L,883597853L,1728061733L,2050312613L,5534091197L,9447241877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213052Inst : IEnumerable<long>
{
public static readonly long[] Value=A213052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213052.Bytes);
public long this[int i]=>Value[i];

public static A213052Inst Instance=new A213052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213053
{
public static readonly long[] Value={ 2L,1L,7L,2L,3L,3L,6L,2L,8L,2L,1L,1L,2L,2L,1L,6L,5L,7L,4L,0L,8L,2L,7L,9L,3L,2L,5L,5L,6L,2L,4L,7L,0L,7L,3L,4L,2L,2L,3L,0L,4L,4L,9L,1L,5L,4L,3L,5L,5L,8L,7L,4L,8L,2L,3L,6L,5L,4L,4L,9L,0L,2L,7L,7L,1L,4L,5L,0L,5L,3L,4L,3L,5L,8L,9L,0L,6L,3L,2L,2L,9L,1L,8L,5L,5L,6L,8L,0L,5L,0L,6L,5L,3L,9L,2L,3L,5L,4L,9L,5L,1L,5L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213053Inst : IEnumerable<long>
{
public static readonly long[] Value=A213053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213053.Bytes);
public long this[int i]=>Value[i];

public static A213053Inst Instance=new A213053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213054
{
public static readonly long[] Value={ 5L,5L,3L,9L,6L,0L,2L,7L,8L,3L,6L,5L,0L,9L,0L,2L,0L,4L,7L,0L,1L,1L,2L,1L,1L,9L,1L,4L,9L,9L,7L,1L,4L,4L,4L,8L,6L,0L,7L,8L,7L,0L,0L,9L,5L,4L,3L,5L,2L,7L,7L,7L,9L,4L,6L,1L,0L,9L,6L,3L,0L,9L,4L,6L,0L,2L,5L,7L,1L,4L,4L,9L,5L,8L,1L,5L,9L,5L,7L,8L,5L,5L,0L,7L,0L,0L,3L,8L,7L,2L,6L,4L,6L,0L,6L,2L,0L,4L,3L,2L,3L,2L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213054Inst : IEnumerable<long>
{
public static readonly long[] Value=A213054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213054.Bytes);
public long this[int i]=>Value[i];

public static A213054Inst Instance=new A213054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213055
{
public static readonly long[] Value={ 5L,4L,1L,9L,2L,6L,0L,7L,0L,1L,3L,9L,2L,8L,9L,0L,0L,8L,7L,4L,4L,5L,6L,1L,3L,6L,4L,8L,2L,9L,6L,3L,6L,7L,2L,6L,0L,6L,9L,0L,9L,2L,0L,9L,4L,8L,4L,2L,6L,0L,9L,8L,1L,6L,8L,5L,0L,0L,0L,6L,6L,1L,1L,0L,1L,5L,8L,9L,4L,3L,1L,5L,9L,9L,4L,4L,5L,6L,0L,4L,9L,3L,3L,5L,9L,7L,0L,1L,5L,2L,1L,5L,7L,3L,4L,2L,4L,1L,9L,6L,3L,0L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213055Inst : IEnumerable<long>
{
public static readonly long[] Value=A213055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213055.Bytes);
public long this[int i]=>Value[i];

public static A213055Inst Instance=new A213055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213056
{
public static readonly long[] Value={ 1L,1L,0L,4L,4L,1L,4L,4L,5L,0L,0L,8L,4L,4L,4L,8L,9L,4L,0L,4L,12L,1L,4L,8L,8L,4L,0L,8L,8L,4L,8L,16L,8L,5L,0L,12L,12L,0L,8L,12L,13L,0L,0L,8L,8L,8L,12L,8L,16L,4L,0L,16L,12L,4L,4L,20L,13L,4L,0L,16L,20L,8L,8L,8L,8L,9L,0L,12L,16L,4L,12L,12L,16L,0L,0L,16L,20L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213056Inst : IEnumerable<long>
{
public static readonly long[] Value=A213056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213056.Bytes);
public long this[int i]=>Value[i];

public static A213056Inst Instance=new A213056Inst();

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