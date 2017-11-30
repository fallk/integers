using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190021
{
public static readonly long[] Value={ 0L,0L,2L,8L,23L,51L,101L,179L,295L,460L,688L,988L,1382L,1876L,2495L,3258L,4191L,5298L,6613L,8166L,9973L,12065L,14472L,17208L,20341L,23873L,27838L,32282L,37238L,42734L,48840L,55573L,62973L,71067L,79934L,89640L,100172L,111613L,123959L,137336L,151842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190021Inst : IEnumerable<long>
{
public static readonly long[] Value=A190021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190021.Bytes);
public long this[int i]=>Value[i];

public static A190021Inst Instance=new A190021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190022
{
public static readonly long[] Value={ 0L,0L,2L,12L,39L,95L,193L,355L,597L,943L,1426L,2071L,2904L,3977L,5306L,6956L,8963L,11370L,14225L,17587L,21515L,26053L,31310L,37282L,44061L,51785L,60436L,70127L,80939L,92952L,106267L,120982L,137124L,154841L,174225L,195366L,218394L,243457L,270505L,299749L,331441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190022Inst : IEnumerable<long>
{
public static readonly long[] Value=A190022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190022.Bytes);
public long this[int i]=>Value[i];

public static A190022Inst Instance=new A190022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190023
{
public static readonly long[] Value={ 21L,83L,30L,205L,129L,51L,419L,362L,243L,88L,713L,839L,701L,562L,128L,1169L,1638L,1715L,2049L,903L,197L,1709L,2923L,3343L,5879L,3442L,1754L,292L,2471L,4834L,5947L,13342L,10259L,8223L,2937L,457L,3381L,7605L,9789L,26982L,23790L,28628L,14492L,5790L,688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190023Inst : IEnumerable<long>
{
public static readonly long[] Value=A190023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190023.Bytes);
public long this[int i]=>Value[i];

public static A190023Inst Instance=new A190023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190024
{
public static readonly long[] Value={ 512L,45L,158L,458L,834L,1230L,1910L,3018L,5102L,9706L,18522L,34606L,65258L,119934L,217210L,400266L,736570L,1351694L,2506658L,4638314L,8542346L,15797722L,29180334L,53760774L,99319938L,183479122L,338452838L,625204870L,1154917550L,2131346658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190024Inst : IEnumerable<long>
{
public static readonly long[] Value=A190024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190024.Bytes);
public long this[int i]=>Value[i];

public static A190024Inst Instance=new A190024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190025
{
public static readonly long[] Value={ 512L,112L,228L,415L,616L,880L,1205L,1508L,2008L,2793L,3776L,5220L,7274L,9829L,13345L,18256L,24651L,33451L,45700L,61988L,84197L,114766L,155769L,211493L,287826L,390881L,530866L,722029L,980917L,1332459L,1811512L,2461345L,3343817L,4544963L,6175777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190025Inst : IEnumerable<long>
{
public static readonly long[] Value=A190025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190025.Bytes);
public long this[int i]=>Value[i];

public static A190025Inst Instance=new A190025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190026
{
public static readonly long[] Value={ 112L,45L,79L,155L,235L,295L,355L,423L,531L,740L,1037L,1434L,1992L,2706L,3628L,4920L,6665L,9015L,12293L,16738L,22710L,30902L,42006L,56987L,77466L,105302L,142987L,194362L,264198L,358864L,487699L,662831L,900478L,1223669L,1662993L,2259498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190026Inst : IEnumerable<long>
{
public static readonly long[] Value=A190026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190026.Bytes);
public long this[int i]=>Value[i];

public static A190026Inst Instance=new A190026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190027
{
public static readonly long[] Value={ 228L,79L,158L,274L,362L,430L,506L,610L,790L,1094L,1539L,2128L,2917L,3951L,5309L,7171L,9723L,13188L,17946L,24428L,33181L,45089L,61273L,83193L,113026L,153617L,208697L,283598L,385441L,523693L,711599L,967038L,1313966L,1785449L,2426308L,3296908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190027Inst : IEnumerable<long>
{
public static readonly long[] Value=A190027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190027.Bytes);
public long this[int i]=>Value[i];

public static A190027Inst Instance=new A190027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190044
{
public static readonly long[] Value={ 2L,12L,18L,39L,33L,72L,43L,105L,69L,123L,72L,190L,83L,169L,151L,217L,108L,276L,120L,297L,206L,261L,150L,427L,179L,318L,259L,405L,185L,509L,201L,452L,326L,413L,277L,652L,228L,470L,383L,626L,263L,688L,276L,631L,501L,559L,303L,893L,323L,673L,509L,748L,341L,883L,418L,831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190044Inst : IEnumerable<long>
{
public static readonly long[] Value=A190044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190044.Bytes);
public long this[int i]=>Value[i];

public static A190044Inst Instance=new A190044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190045
{
public static readonly long[] Value={ 2L,14L,22L,53L,45L,107L,60L,164L,100L,189L,99L,311L,121L,251L,241L,358L,146L,447L,167L,495L,339L,381L,208L,753L,276L,470L,396L,674L,268L,860L,289L,760L,500L,602L,469L,1131L,326L,690L,576L,1130L,372L,1150L,386L,1020L,849L,813L,430L,1595L,499L,1090L,769L,1215L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190045Inst : IEnumerable<long>
{
public static readonly long[] Value=A190045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190045.Bytes);
public long this[int i]=>Value[i];

public static A190045Inst Instance=new A190045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190046
{
public static readonly long[] Value={ 2L,16L,26L,69L,57L,151L,80L,246L,144L,284L,138L,492L,178L,372L,364L,583L,195L,717L,239L,799L,520L,570L,288L,1314L,399L,716L,601L,1079L,392L,1441L,415L,1278L,751L,909L,723L,1938L,474L,1029L,869L,1981L,515L,1916L,536L,1639L,1380L,1195L,611L,2847L,743L,1776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190046Inst : IEnumerable<long>
{
public static readonly long[] Value=A190046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190046.Bytes);
public long this[int i]=>Value[i];

public static A190046Inst Instance=new A190046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190047
{
public static readonly long[] Value={ 2L,18L,30L,87L,69L,203L,100L,349L,200L,409L,189L,754L,258L,545L,540L,927L,267L,1109L,341L,1272L,780L,849L,393L,2196L,578L,1100L,896L,1694L,578L,2386L,565L,2104L,1122L,1371L,1113L,3273L,672L,1512L,1357L,3363L,696L,3175L,724L,2587L,2242L,1737L,883L,4977L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190047Inst : IEnumerable<long>
{
public static readonly long[] Value=A190047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190047.Bytes);
public long this[int i]=>Value[i];

public static A190047Inst Instance=new A190047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190048
{
public static readonly long[] Value={ 8L,46L,150L,370L,770L,1428L,2436L,3900L,5940L,8690L,12298L,16926L,22750L,29960L,38760L,49368L,62016L,76950L,94430L,114730L,138138L,164956L,195500L,230100L,269100L,312858L,361746L,416150L,476470L,543120L,616528L,697136L,785400L,881790L,986790L,1100898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190048Inst : IEnumerable<long>
{
public static readonly long[] Value=A190048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190048.Bytes);
public long this[int i]=>Value[i];

public static A190048Inst Instance=new A190048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190049
{
public static readonly long[] Value={ 16L,120L,482L,1412L,3402L,7168L,13692L,24264L,40524L,64504L,98670L,145964L,209846L,294336L,404056L,544272L,720936L,940728L,1211098L,1540308L,1937474L,2412608L,2976660L,3641560L,4420260L,5326776L,6376230L,7584892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190049Inst : IEnumerable<long>
{
public static readonly long[] Value=A190049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190049.Bytes);
public long this[int i]=>Value[i];

public static A190049Inst Instance=new A190049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190050
{
public static readonly long[] Value={ 1L,2L,6L,17L,46L,120L,304L,752L,1824L,4352L,10240L,23808L,54784L,124928L,282624L,634880L,1417216L,3145728L,6946816L,15269888L,33423360L,72876032L,158334976L,342884352L,740294656L,1593835520L,3422552064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190050Inst : IEnumerable<long>
{
public static readonly long[] Value=A190050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190050.Bytes);
public long this[int i]=>Value[i];

public static A190050Inst Instance=new A190050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190051
{
public static readonly long[] Value={ 1L,3L,12L,44L,150L,482L,1476L,4344L,12368L,34240L,92544L,244992L,636928L,1629696L,4111360L,10242048L,25227264L,61505536L,148570112L,355860480L,845807616L,1996095488L,4680056832L,10906763264L,25275924480L,58271465472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190051Inst : IEnumerable<long>
{
public static readonly long[] Value=A190051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190051.Bytes);
public long this[int i]=>Value[i];

public static A190051Inst Instance=new A190051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190052
{
public static readonly long[] Value={ 15L,33L,115L,185L,159L,553L,303L,393L,835L,2321L,7859L,1465L,3839L,1985L,3199L,5753L,13823L,3265L,3635L,8921L,4435L,2913L,3183L,12793L,37091L,40049L,19123L,4713L,18623L,19921L,21263L,10265L,64003L,67889L,41939L,44353L,8223L,84593L,21343L,9609L,37103L,17665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190052Inst : IEnumerable<long>
{
public static readonly long[] Value=A190052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190052.Bytes);
public long this[int i]=>Value[i];

public static A190052Inst Instance=new A190052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190053
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,14L,15L,17L,19L,21L,23L,25L,28L,29L,31L,33L,35L,37L,39L,42L,43L,45L,47L,49L,52L,53L,56L,57L,59L,61L,63L,66L,67L,70L,71L,74L,75L,77L,80L,81L,84L,85L,88L,89L,91L,94L,95L,98L,99L,102L,104L,105L,108L,109L,112L,113L,116L,118L,119L,122L,123L,126L,127L,130L,132L,134L,136L,137L,140L,141L,144L,146L,148L,150L,151L,154L,156L,158L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190053Inst : IEnumerable<long>
{
public static readonly long[] Value=A190053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190053.Bytes);
public long this[int i]=>Value[i];

public static A190053Inst Instance=new A190053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190054
{
public static readonly long[] Value={ 4L,8L,13L,18L,22L,27L,32L,36L,41L,46L,50L,55L,60L,64L,69L,73L,78L,83L,87L,92L,97L,101L,106L,111L,115L,120L,125L,129L,133L,139L,143L,147L,153L,157L,161L,167L,171L,175L,181L,185L,189L,194L,199L,203L,208L,213L,217L,222L,227L,231L,236L,241L,245L,250L,255L,259L,264L,268L,273L,278L,282L,287L,292L,296L,301L,306L,310L,315L,320L,324L,328L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190054Inst : IEnumerable<long>
{
public static readonly long[] Value=A190054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190054.Bytes);
public long this[int i]=>Value[i];

public static A190054Inst Instance=new A190054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190055
{
public static readonly long[] Value={ 2L,6L,10L,13L,16L,20L,24L,27L,30L,34L,38L,41L,44L,48L,51L,55L,58L,62L,65L,69L,72L,76L,79L,83L,86L,90L,93L,97L,100L,103L,107L,111L,114L,117L,121L,125L,128L,131L,135L,139L,142L,145L,149L,153L,155L,159L,163L,167L,169L,173L,177L,181L,183L,187L,191L,194L,197L,201L,205L,208L,211L,215L,219L,222L,225L,229L,233L,236L,239L,243L,246L,250L,253L,257L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190055Inst : IEnumerable<long>
{
public static readonly long[] Value=A190055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190055.Bytes);
public long this[int i]=>Value[i];

public static A190055Inst Instance=new A190055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190056
{
public static readonly long[] Value={ 4L,9L,14L,19L,24L,29L,35L,39L,44L,50L,55L,59L,65L,70L,74L,79L,85L,90L,94L,100L,105L,110L,115L,120L,125L,131L,135L,140L,145L,150L,155L,160L,166L,170L,175L,181L,186L,190L,196L,201L,206L,210L,216L,221L,225L,231L,236L,241L,246L,251L,256L,262L,266L,271L,277L,281L,286L,291L,297L,301L,306L,312L,317L,321L,327L,332L,337L,342L,347L,352L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190056Inst : IEnumerable<long>
{
public static readonly long[] Value=A190056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190056.Bytes);
public long this[int i]=>Value[i];

public static A190056Inst Instance=new A190056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190057
{
public static readonly long[] Value={ 2L,5L,8L,11L,13L,17L,20L,22L,26L,28L,31L,34L,37L,40L,43L,46L,48L,52L,54L,57L,61L,63L,66L,69L,72L,75L,78L,81L,83L,87L,89L,92L,96L,98L,101L,104L,107L,109L,113L,116L,118L,122L,124L,127L,130L,133L,136L,139L,142L,144L,148L,151L,153L,157L,159L,162L,165L,168L,171L,174L,177L,179L,183L,185L,188L,192L,194L,197L,200L,203L,205L,209L,212L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190057Inst : IEnumerable<long>
{
public static readonly long[] Value=A190057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190057.Bytes);
public long this[int i]=>Value[i];

public static A190057Inst Instance=new A190057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190058
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,12L,15L,17L,18L,21L,23L,26L,27L,30L,32L,34L,36L,38L,41L,43L,45L,47L,49L,52L,53L,56L,58L,61L,62L,64L,67L,69L,71L,73L,76L,78L,80L,82L,84L,87L,88L,91L,93L,96L,97L,99L,102L,104L,106L,108L,111L,113L,114L,117L,119L,122L,123L,126L,128L,130L,132L,134L,137L,139L,141L,143L,146L,148L,149L,152L,154L,157L,158L,161L,163L,165L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190058Inst : IEnumerable<long>
{
public static readonly long[] Value=A190058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190058.Bytes);
public long this[int i]=>Value[i];

public static A190058Inst Instance=new A190058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190059
{
public static readonly long[] Value={ 2L,6L,9L,12L,15L,19L,22L,25L,29L,32L,35L,39L,42L,45L,48L,52L,54L,58L,62L,65L,68L,71L,75L,78L,81L,85L,87L,91L,95L,98L,101L,104L,108L,110L,114L,118L,120L,124L,127L,131L,134L,137L,141L,143L,147L,151L,153L,157L,160L,164L,166L,170L,174L,176L,180L,183L,186L,190L,193L,197L,199L,203L,207L,209L,213L,216L,219L,222L,226L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190059Inst : IEnumerable<long>
{
public static readonly long[] Value=A190059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190059.Bytes);
public long this[int i]=>Value[i];

public static A190059Inst Instance=new A190059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190076
{
public static readonly long[] Value={ 40L,1896L,28656L,191456L,834717L,2783714L,7737762L,18951546L,41786130L,84902980L,162378720L,292892946L,503182507L,835582280L,1339061119L,2077237619L,3144963614L,4653920446L,6746522401L,9597835033L,13398597773L,18439060711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190076Inst : IEnumerable<long>
{
public static readonly long[] Value=A190076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190076.Bytes);
public long this[int i]=>Value[i];

public static A190076Inst Instance=new A190076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190077
{
public static readonly long[] Value={ 0L,7584L,162028L,1436962L,7843113L,31391655L,101530262L,282859251L,698197690L,1570715217L,3291688243L,6460935664L,12000071771L,21412481203L,36702670681L,60642753250L,97406905547L,152416471950L,232926480058L,348492673798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190077Inst : IEnumerable<long>
{
public static readonly long[] Value=A190077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190077.Bytes);
public long this[int i]=>Value[i];

public static A190077Inst Instance=new A190077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190078
{
public static readonly long[] Value={ 140L,27328L,910716L,10802667L,73725405L,353856100L,1333341624L,4232955454L,11720735320L,29213945353L,67119317038L,143366487211L,287901954546L,552087286271L,1012169804786L,1781377206624L,3036183971866L,5024176668242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190078Inst : IEnumerable<long>
{
public static readonly long[] Value=A190078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190078.Bytes);
public long this[int i]=>Value[i];

public static A190078Inst Instance=new A190078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190079
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,17L,20L,23L,27L,30L,32L,35L,39L,42L,45L,47L,51L,54L,57L,60L,62L,66L,69L,72L,75L,79L,81L,84L,87L,91L,94L,96L,99L,103L,106L,109L,111L,114L,118L,121L,124L,126L,130L,133L,136L,139L,143L,145L,148L,151L,155L,158L,160L,163L,166L,170L,173L,175L,178L,182L,185L,188L,190L,194L,197L,200L,203L,207L,209L,212L,215L,218L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190079Inst : IEnumerable<long>
{
public static readonly long[] Value=A190079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190079.Bytes);
public long this[int i]=>Value[i];

public static A190079Inst Instance=new A190079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190080
{
public static readonly long[] Value={ 3L,7L,10L,14L,18L,22L,25L,29L,33L,37L,40L,44L,48L,52L,55L,59L,63L,67L,71L,74L,78L,82L,86L,89L,93L,97L,101L,104L,108L,112L,116L,119L,123L,127L,131L,135L,138L,142L,146L,150L,153L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,195L,198L,202L,206L,210L,214L,217L,221L,225L,229L,232L,236L,240L,244L,247L,251L,255L,259L,262L,266L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190080Inst : IEnumerable<long>
{
public static readonly long[] Value=A190080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190080.Bytes);
public long this[int i]=>Value[i];

public static A190080Inst Instance=new A190080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190081
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,13L,16L,19L,21L,24L,26L,28L,31L,34L,36L,38L,41L,43L,46L,49L,50L,53L,56L,58L,61L,64L,65L,68L,70L,73L,76L,77L,80L,83L,85L,88L,90L,92L,95L,98L,100L,102L,105L,107L,110L,113L,115L,117L,120L,122L,125L,128L,129L,132L,134L,137L,140L,141L,144L,147L,149L,152L,154L,156L,159L,162L,164L,167L,169L,171L,174L,177L,179L,181L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190081Inst : IEnumerable<long>
{
public static readonly long[] Value=A190081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190081.Bytes);
public long this[int i]=>Value[i];

public static A190081Inst Instance=new A190081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190082
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,26L,29L,32L,35L,38L,41L,44L,47L,50L,53L,56L,60L,62L,65L,68L,71L,74L,77L,80L,83L,86L,89L,92L,95L,98L,101L,104L,107L,110L,113L,117L,120L,122L,125L,128L,131L,134L,137L,140L,143L,146L,149L,152L,155L,158L,161L,164L,167L,170L,173L,177L,180L,183L,185L,188L,191L,194L,197L,200L,203L,206L,209L,212L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190082Inst : IEnumerable<long>
{
public static readonly long[] Value=A190082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190082.Bytes);
public long this[int i]=>Value[i];

public static A190082Inst Instance=new A190082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190083
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,21L,24L,27L,31L,34L,37L,40L,43L,46L,49L,52L,55L,59L,63L,66L,69L,72L,75L,78L,81L,84L,87L,91L,94L,97L,100L,103L,106L,109L,112L,115L,119L,123L,126L,129L,132L,135L,138L,141L,144L,147L,151L,154L,157L,160L,163L,166L,169L,172L,175L,179L,182L,186L,189L,192L,195L,198L,201L,204L,207L,211L,214L,217L,220L,223L,226L,229L,232L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190083Inst : IEnumerable<long>
{
public static readonly long[] Value=A190083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190083.Bytes);
public long this[int i]=>Value[i];

public static A190083Inst Instance=new A190083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190084
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,16L,19L,22L,25L,28L,30L,33L,36L,39L,42L,45L,48L,51L,54L,57L,58L,61L,64L,67L,70L,73L,76L,79L,82L,85L,88L,90L,93L,96L,99L,102L,105L,108L,111L,114L,116L,118L,121L,124L,127L,130L,133L,136L,139L,142L,145L,148L,150L,153L,156L,159L,162L,165L,168L,171L,174L,176L,178L,181L,184L,187L,190L,193L,196L,199L,202L,205L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190084Inst : IEnumerable<long>
{
public static readonly long[] Value=A190084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190084.Bytes);
public long this[int i]=>Value[i];

public static A190084Inst Instance=new A190084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190085
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,16L,18L,20L,22L,25L,27L,30L,32L,35L,37L,39L,41L,44L,46L,49L,51L,54L,56L,57L,60L,62L,65L,67L,70L,72L,75L,76L,79L,81L,84L,86L,89L,91L,94L,95L,98L,100L,103L,105L,108L,110L,113L,115L,116L,119L,121L,124L,126L,129L,131L,134L,135L,138L,140L,143L,145L,148L,150L,153L,154L,157L,159L,162L,164L,167L,169L,171L,173L,175L,178L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190085Inst : IEnumerable<long>
{
public static readonly long[] Value=A190085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190085.Bytes);
public long this[int i]=>Value[i];

public static A190085Inst Instance=new A190085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190086
{
public static readonly long[] Value={ 4L,9L,14L,19L,24L,28L,33L,38L,43L,48L,53L,58L,63L,68L,73L,78L,83L,87L,92L,97L,102L,107L,112L,117L,122L,127L,132L,137L,142L,146L,151L,156L,161L,166L,172L,176L,181L,186L,191L,196L,201L,205L,210L,215L,220L,225L,231L,235L,240L,245L,250L,255L,260L,264L,269L,274L,279L,284L,289L,294L,299L,304L,309L,314L,318L,323L,328L,333L,338L,344L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190086Inst : IEnumerable<long>
{
public static readonly long[] Value=A190086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190086.Bytes);
public long this[int i]=>Value[i];

public static A190086Inst Instance=new A190086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190087
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,15L,17L,21L,23L,26L,29L,31L,34L,36L,40L,42L,45L,47L,50L,52L,55L,59L,61L,64L,66L,69L,71L,74L,77L,80L,82L,85L,88L,90L,93L,96L,99L,101L,104L,106L,109L,111L,114L,118L,120L,123L,125L,128L,130L,133L,136L,139L,141L,144L,147L,149L,152L,155L,158L,160L,163L,165L,168L,170L,174L,177L,179L,182L,184L,187L,189L,193L,195L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190087Inst : IEnumerable<long>
{
public static readonly long[] Value=A190087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190087.Bytes);
public long this[int i]=>Value[i];

public static A190087Inst Instance=new A190087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190088
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,5L,1L,36L,70L,7L,1L,66L,330L,210L,9L,1L,105L,1001L,1716L,495L,11L,1L,153L,2380L,8008L,6435L,1001L,13L,1L,210L,4845L,27132L,43758L,19448L,1820L,15L,1L,276L,8855L,74613L,203490L,184756L,50388L,3060L,17L,1L,351L,14950L,177100L,735471L,1144066L,646646L,116280L,4845L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190088Inst : IEnumerable<long>
{
public static readonly long[] Value=A190088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190088.Bytes);
public long this[int i]=>Value[i];

public static A190088Inst Instance=new A190088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190089
{
public static readonly long[] Value={ 1L,4L,21L,114L,616L,3329L,17991L,97229L,525456L,2839729L,15346786L,82938844L,448227521L,2422362079L,13091204281L,70748973084L,382349636061L,2066337330754L,11167134898976L,60350698792449L,326154101090951L,1762639037938629L,9525854090667496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190089Inst : IEnumerable<long>
{
public static readonly long[] Value=A190089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190089.Bytes);
public long this[int i]=>Value[i];

public static A190089Inst Instance=new A190089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190090
{
public static readonly long[] Value={ 1L,1L,4L,16L,42L,137L,443L,1365L,4316L,13625L,42785L,134758L,424331L,1335378L,4203927L,13233947L,41657808L,131135696L,412803240L,1299458257L,4090567673L,12876698159L,40534529294L,127598621869L,401667591501L,1264408966284L,3980231826575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190090Inst : IEnumerable<long>
{
public static readonly long[] Value=A190090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190090.Bytes);
public long this[int i]=>Value[i];

public static A190090Inst Instance=new A190090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190091
{
public static readonly long[] Value={ 2L,6L,10L,15L,20L,26L,32L,39L,46L,54L,62L,71L,80L,90L,100L,111L,122L,134L,146L,159L,172L,186L,200L,215L,230L,246L,262L,279L,296L,314L,332L,351L,370L,390L,410L,431L,452L,474L,496L,519L,542L,566L,590L,615L,640L,666L,692L,719L,746L,774L,802L,831L,860L,890L,920L,951L,982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190091Inst : IEnumerable<long>
{
public static readonly long[] Value=A190091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190091.Bytes);
public long this[int i]=>Value[i];

public static A190091Inst Instance=new A190091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190140
{
public static readonly long[] Value={ 1L,2L,5L,15L,41L,112L,310L,855L,2356L,6497L,17915L,49395L,136196L,375532L,1035445L,2855010L,7872061L,21705467L,59848025L,165017700L,454999826L,1254561427L,3459175780L,9537912465L,26298684991L,72512809787L,199938041960L,551284948680L,1520046368681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190140Inst : IEnumerable<long>
{
public static readonly long[] Value=A190140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190140.Bytes);
public long this[int i]=>Value[i];

public static A190140Inst Instance=new A190140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190141
{
public static readonly long[] Value={ 2L,4L,5L,8L,10L,18L,22L,34L,41L,63L,77L,111L,135L,190L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190141Inst : IEnumerable<long>
{
public static readonly long[] Value=A190141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190141.Bytes);
public long this[int i]=>Value[i];

public static A190141Inst Instance=new A190141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190142
{
public static readonly long[] Value={ 1L,2L,9L,1L,3L,4L,3L,1L,7L,2L,1L,0L,7L,2L,5L,9L,5L,4L,6L,1L,3L,8L,8L,2L,2L,9L,5L,6L,5L,3L,3L,4L,3L,8L,6L,9L,7L,0L,3L,2L,2L,0L,5L,0L,2L,2L,9L,6L,1L,8L,7L,4L,2L,4L,0L,3L,6L,5L,9L,8L,4L,8L,6L,7L,3L,9L,6L,4L,3L,9L,4L,9L,0L,6L,5L,2L,4L,1L,4L,9L,4L,0L,8L,9L,9L,7L,7L,9L,0L,3L,7L,0L,7L,9L,3L,4L,1L,3L,7L,3L,3L,8L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190142Inst : IEnumerable<long>
{
public static readonly long[] Value=A190142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190142.Bytes);
public long this[int i]=>Value[i];

public static A190142Inst Instance=new A190142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190143
{
public static readonly long[] Value={ 5L,4L,6L,6L,8L,0L,3L,2L,4L,4L,6L,6L,4L,2L,3L,3L,7L,1L,4L,6L,2L,1L,7L,2L,7L,2L,4L,7L,0L,9L,5L,0L,0L,2L,7L,2L,2L,6L,3L,0L,2L,5L,6L,8L,9L,8L,5L,2L,7L,9L,2L,1L,6L,6L,1L,4L,5L,4L,3L,4L,9L,8L,1L,2L,6L,4L,9L,0L,4L,2L,0L,4L,8L,4L,0L,8L,5L,9L,4L,9L,0L,0L,9L,7L,3L,2L,6L,7L,0L,6L,5L,1L,6L,0L,3L,7L,3L,0L,3L,0L,4L,0L,6L,8L,2L,1L,6L,0L,7L,7L,4L,4L,8L,4L,2L,9L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190143Inst : IEnumerable<long>
{
public static readonly long[] Value=A190143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190143.Bytes);
public long this[int i]=>Value[i];

public static A190143Inst Instance=new A190143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190144
{
public static readonly long[] Value={ 2L,6L,0L,5L,0L,7L,2L,7L,0L,5L,2L,9L,7L,3L,2L,2L,8L,7L,0L,8L,0L,3L,4L,2L,6L,4L,1L,2L,4L,1L,8L,3L,8L,7L,8L,5L,1L,3L,7L,0L,8L,5L,7L,3L,6L,3L,2L,7L,6L,6L,3L,7L,2L,2L,4L,3L,8L,5L,8L,5L,0L,8L,4L,0L,7L,3L,1L,0L,5L,7L,5L,9L,3L,7L,1L,6L,1L,9L,7L,5L,1L,7L,0L,4L,7L,7L,4L,9L,9L,4L,5L,4L,7L,4L,8L,4L,5L,6L,1L,7L,0L,8L,8L,9L,4L,7L,7L,6L,2L,0L,9L,5L,9L,7L,8L,5L,2L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190144Inst : IEnumerable<long>
{
public static readonly long[] Value=A190144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190144.Bytes);
public long this[int i]=>Value[i];

public static A190144Inst Instance=new A190144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190145
{
public static readonly long[] Value={ 1L,6L,6L,7L,4L,4L,7L,9L,3L,5L,8L,0L,3L,6L,9L,3L,9L,0L,5L,5L,8L,0L,5L,6L,7L,5L,1L,2L,8L,7L,3L,3L,9L,6L,0L,2L,0L,3L,9L,4L,4L,7L,8L,0L,1L,1L,3L,8L,1L,7L,7L,1L,6L,7L,0L,0L,5L,3L,7L,2L,8L,2L,2L,7L,6L,2L,0L,5L,8L,9L,3L,2L,9L,0L,2L,5L,2L,7L,7L,9L,1L,7L,0L,2L,4L,5L,2L,5L,4L,9L,9L,7L,7L,0L,8L,8L,1L,2L,2L,4L,8L,2L,4L,1L,6L,2L,6L,3L,3L,6L,8L,6L,1L,5L,1L,1L,1L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190145Inst : IEnumerable<long>
{
public static readonly long[] Value=A190145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190145.Bytes);
public long this[int i]=>Value[i];

public static A190145Inst Instance=new A190145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190146
{
public static readonly long[] Value={ 2L,3L,3L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190146Inst : IEnumerable<long>
{
public static readonly long[] Value=A190146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190146.Bytes);
public long this[int i]=>Value[i];

public static A190146Inst Instance=new A190146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190147
{
public static readonly long[] Value={ 1L,5L,0L,7L,8L,1L,0L,6L,6L,7L,6L,2L,2L,8L,9L,8L,2L,8L,3L,8L,3L,3L,1L,5L,3L,9L,0L,3L,7L,6L,5L,3L,7L,7L,7L,2L,7L,2L,4L,7L,3L,4L,6L,8L,8L,5L,1L,9L,3L,8L,9L,5L,5L,8L,5L,5L,3L,1L,9L,1L,3L,9L,0L,8L,6L,3L,0L,1L,2L,5L,3L,8L,1L,3L,3L,9L,5L,8L,9L,8L,9L,1L,1L,6L,7L,1L,4L,7L,5L,0L,5L,2L,5L,1L,0L,6L,3L,0L,6L,1L,3L,1L,7L,1L,2L,7L,1L,9L,4L,9L,9L,2L,2L,7L,3L,6L,6L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190147Inst : IEnumerable<long>
{
public static readonly long[] Value=A190147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190147.Bytes);
public long this[int i]=>Value[i];

public static A190147Inst Instance=new A190147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190148
{
public static readonly long[] Value={ 5L,11L,23L,37L,53L,79L,101L,131L,167L,211L,271L,293L,349L,397L,457L,523L,601L,653L,727L,811L,887L,971L,1061L,1163L,1279L,1381L,1471L,1571L,1693L,1811L,1933L,2053L,2207L,2341L,2467L,2609L,2741L,2917L,3049L,3203L,3373L,3533L,3701L,3877L,4057L,4243L,4421L,4621L,4813L,5003L,5209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190148Inst : IEnumerable<long>
{
public static readonly long[] Value=A190148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190148.Bytes);
public long this[int i]=>Value[i];

public static A190148Inst Instance=new A190148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190149
{
public static readonly long[] Value={ 10010L,100010L,100110L,110010L,1000010L,1000100L,1000110L,1001010L,1001110L,1010010L,1100010L,1100110L,1110010L,10000010L,10000100L,10000110L,10001010L,10001100L,10001110L,10010010L,10010110L,10011010L,10011110L,10100010L,10100110L,10110010L,11000010L,11000100L,11000110L,11001010L,11001110L,11010010L,11100010L,11100110L,11110010L,100000010L,100000100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190149Inst : IEnumerable<long>
{
public static readonly long[] Value=A190149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190149.Bytes);
public long this[int i]=>Value[i];

public static A190149Inst Instance=new A190149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190150
{
public static readonly long[] Value={ 18L,34L,38L,50L,66L,68L,70L,74L,78L,82L,98L,102L,114L,130L,132L,134L,138L,140L,142L,146L,150L,154L,158L,162L,166L,178L,194L,196L,198L,202L,206L,210L,226L,230L,242L,258L,260L,262L,264L,266L,268L,270L,274L,276L,278L,282L,284L,286L,290L,294L,298L,302L,306L,310L,314L,318L,322L,324L,326L,330L,334L,338L,354L,358L,370L,386L,388L,390L,394L,396L,398L,402L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190150Inst : IEnumerable<long>
{
public static readonly long[] Value=A190150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190150.Bytes);
public long this[int i]=>Value[i];

public static A190150Inst Instance=new A190150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190151
{
public static readonly long[] Value={ 9L,17L,19L,25L,33L,34L,35L,37L,39L,41L,49L,51L,57L,65L,66L,67L,69L,70L,71L,73L,75L,77L,79L,81L,83L,89L,97L,98L,99L,101L,103L,105L,113L,115L,121L,129L,130L,131L,132L,133L,134L,135L,137L,138L,139L,141L,142L,143L,145L,147L,149L,151L,153L,155L,157L,159L,161L,162L,163L,165L,167L,169L,177L,179L,185L,193L,194L,195L,197L,198L,199L,201L,203L,205L,207L,209L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190151Inst : IEnumerable<long>
{
public static readonly long[] Value=A190151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190151.Bytes);
public long this[int i]=>Value[i];

public static A190151Inst Instance=new A190151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190152
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,28L,35L,1L,1L,55L,210L,84L,1L,1L,91L,715L,924L,165L,1L,1L,136L,1820L,5005L,3003L,286L,1L,1L,190L,3876L,18564L,24310L,8008L,455L,1L,1L,253L,7315L,54264L,125970L,92378L,18564L,680L,1L,1L,325L,12650L,134596L,490314L,646646L,293930L,38760L,969L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190152Inst : IEnumerable<long>
{
public static readonly long[] Value=A190152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190152.Bytes);
public long this[int i]=>Value[i];

public static A190152Inst Instance=new A190152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190153
{
public static readonly long[] Value={ 1L,2L,12L,65L,351L,1897L,10252L,55405L,299426L,1618192L,8745217L,47261895L,255418101L,1380359512L,7459895657L,40315615410L,217878227876L,1177482265857L,6363483400447L,34390259761825L,185855747875876L,1004422742303477L,5428215467030962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190153Inst : IEnumerable<long>
{
public static readonly long[] Value=A190153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190153.Bytes);
public long this[int i]=>Value[i];

public static A190153Inst Instance=new A190153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190154
{
public static readonly long[] Value={ 1L,1L,2L,11L,30L,91L,303L,936L,2936L,9300L,29209L,91917L,289547L,911218L,2868341L,9029949L,28424456L,89477119L,281667368L,886657081L,2791106585L,8786130132L,27657838272L,87064082194L,274068969337L,862741399379L,2715822822365L,8549136143060L,26911817257385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190154Inst : IEnumerable<long>
{
public static readonly long[] Value=A190154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190154.Bytes);
public long this[int i]=>Value[i];

public static A190154Inst Instance=new A190154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190155
{
public static readonly long[] Value={ 1L,2L,12L,64L,385L,2346L,14672L,92936L,595179L,3841970L,24959726L,162988464L,1068860884L,7034520304L,46437268905L,307351081056L,2038878634695L,13552394472612L,90242046694715L,601847594327000L,4019556724362165L,26879647264387170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190155Inst : IEnumerable<long>
{
public static readonly long[] Value=A190155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190155.Bytes);
public long this[int i]=>Value[i];

public static A190155Inst Instance=new A190155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190220
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,21L,22L,31L,33L,40L,41L,43L,44L,53L,55L,61L,62L,63L,66L,71L,73L,77L,82L,83L,86L,88L,93L,97L,99L,110L,211L,220L,311L,331L,421L,422L,431L,433L,440L,443L,511L,521L,541L,622L,631L,633L,641L,643L,653L,661L,662L,733L,743L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190220Inst : IEnumerable<long>
{
public static readonly long[] Value=A190220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190220.Bytes);
public long this[int i]=>Value[i];

public static A190220Inst Instance=new A190220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190221
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,33L,34L,35L,36L,37L,38L,39L,44L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,66L,67L,68L,69L,77L,78L,79L,88L,89L,99L,111L,112L,113L,114L,115L,116L,117L,118L,119L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190221Inst : IEnumerable<long>
{
public static readonly long[] Value=A190221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190221.Bytes);
public long this[int i]=>Value[i];

public static A190221Inst Instance=new A190221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190222
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,23L,31L,37L,53L,71L,73L,113L,127L,131L,137L,151L,157L,173L,211L,223L,227L,233L,251L,257L,271L,277L,311L,313L,317L,331L,337L,353L,373L,521L,523L,557L,571L,577L,727L,733L,751L,757L,773L,1117L,1123L,1151L,1153L,1171L,1213L,1217L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190222Inst : IEnumerable<long>
{
public static readonly long[] Value=A190222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190222.Bytes);
public long this[int i]=>Value[i];

public static A190222Inst Instance=new A190222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190223
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,15L,17L,21L,22L,23L,25L,31L,33L,35L,37L,51L,53L,55L,71L,73L,75L,77L,111L,113L,115L,121L,125L,127L,131L,137L,151L,155L,157L,173L,175L,211L,213L,217L,221L,223L,227L,231L,233L,251L,253L,257L,271L,275L,277L,311L,313L,317L,331L,337L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190223Inst : IEnumerable<long>
{
public static readonly long[] Value=A190223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190223.Bytes);
public long this[int i]=>Value[i];

public static A190223Inst Instance=new A190223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190224
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190224Inst : IEnumerable<long>
{
public static readonly long[] Value=A190224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190224.Bytes);
public long this[int i]=>Value[i];

public static A190224Inst Instance=new A190224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190225
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,8L,10L,12L,13L,14L,16L,18L,19L,20L,21L,22L,24L,26L,27L,28L,29L,30L,32L,34L,35L,36L,37L,38L,40L,42L,43L,44L,46L,48L,49L,50L,51L,52L,54L,56L,57L,58L,59L,60L,62L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,78L,79L,80L,81L,82L,84L,86L,87L,88L,89L,90L,92L,94L,95L,96L,97L,98L,100L,101L,102L,103L,104L,106L,108L,109L,110L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190225Inst : IEnumerable<long>
{
public static readonly long[] Value=A190225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190225.Bytes);
public long this[int i]=>Value[i];

public static A190225Inst Instance=new A190225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190226
{
public static readonly long[] Value={ 1L,3L,9L,11L,15L,17L,23L,25L,31L,33L,39L,41L,45L,47L,53L,55L,61L,63L,69L,75L,77L,83L,85L,91L,93L,99L,105L,107L,113L,115L,121L,123L,127L,129L,135L,137L,143L,145L,151L,153L,157L,159L,165L,167L,173L,175L,181L,187L,189L,195L,197L,203L,205L,209L,211L,217L,219L,225L,227L,233L,235L,239L,241L,247L,249L,255L,257L,263L,269L,271L,277L,279L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190226Inst : IEnumerable<long>
{
public static readonly long[] Value=A190226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190226.Bytes);
public long this[int i]=>Value[i];

public static A190226Inst Instance=new A190226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190227
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190227Inst : IEnumerable<long>
{
public static readonly long[] Value=A190227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190227.Bytes);
public long this[int i]=>Value[i];

public static A190227Inst Instance=new A190227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190228
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,10L,12L,14L,15L,19L,20L,24L,25L,26L,29L,30L,31L,35L,36L,40L,41L,45L,46L,47L,50L,52L,55L,57L,60L,62L,63L,65L,67L,68L,70L,72L,73L,75L,77L,78L,80L,82L,83L,87L,88L,89L,92L,93L,94L,97L,98L,99L,103L,104L,108L,109L,113L,114L,115L,118L,120L,123L,125L,126L,128L,130L,133L,135L,136L,138L,140L,141L,143L,145L,146L,150L,151L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190228Inst : IEnumerable<long>
{
public static readonly long[] Value=A190228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190228.Bytes);
public long this[int i]=>Value[i];

public static A190228Inst Instance=new A190228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190229
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,16L,17L,18L,21L,22L,23L,27L,28L,32L,33L,34L,37L,38L,39L,42L,43L,44L,48L,49L,51L,53L,54L,56L,58L,59L,61L,64L,66L,69L,71L,74L,76L,79L,81L,84L,85L,86L,90L,91L,95L,96L,100L,101L,102L,105L,106L,107L,110L,111L,112L,116L,117L,119L,121L,122L,124L,127L,129L,131L,132L,134L,137L,139L,142L,144L,147L,148L,149L,152L,153L,154L,158L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190229Inst : IEnumerable<long>
{
public static readonly long[] Value=A190229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190229.Bytes);
public long this[int i]=>Value[i];

public static A190229Inst Instance=new A190229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190230
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190230Inst : IEnumerable<long>
{
public static readonly long[] Value=A190230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190230.Bytes);
public long this[int i]=>Value[i];

public static A190230Inst Instance=new A190230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190231
{
public static readonly long[] Value={ 7L,10L,11L,13L,14L,15L,17L,18L,19L,20L,23L,26L,30L,33L,34L,36L,37L,38L,39L,40L,46L,49L,52L,53L,56L,57L,59L,60L,61L,65L,68L,69L,72L,73L,75L,76L,78L,79L,80L,81L,88L,91L,92L,94L,95L,96L,98L,99L,101L,102L,107L,111L,114L,115L,117L,118L,119L,120L,121L,122L,123L,130L,133L,134L,136L,137L,138L,140L,141L,142L,143L,146L,149L,153L,156L,157L,159L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190231Inst : IEnumerable<long>
{
public static readonly long[] Value=A190231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190231.Bytes);
public long this[int i]=>Value[i];

public static A190231Inst Instance=new A190231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190232
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,12L,16L,21L,22L,24L,25L,27L,28L,29L,31L,32L,35L,41L,42L,43L,44L,45L,47L,48L,50L,51L,54L,55L,58L,62L,63L,64L,66L,67L,70L,71L,74L,77L,82L,83L,84L,85L,86L,87L,89L,90L,93L,97L,100L,103L,104L,105L,106L,108L,109L,110L,112L,113L,116L,124L,125L,126L,127L,128L,129L,131L,132L,135L,139L,144L,145L,147L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190232Inst : IEnumerable<long>
{
public static readonly long[] Value=A190232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190232.Bytes);
public long this[int i]=>Value[i];

public static A190232Inst Instance=new A190232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190233
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190233Inst : IEnumerable<long>
{
public static readonly long[] Value=A190233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190233.Bytes);
public long this[int i]=>Value[i];

public static A190233Inst Instance=new A190233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190234
{
public static readonly long[] Value={ 3L,6L,8L,9L,11L,12L,13L,16L,19L,21L,22L,24L,25L,26L,29L,32L,34L,35L,37L,38L,39L,42L,45L,48L,50L,51L,52L,55L,58L,61L,63L,64L,65L,68L,71L,74L,75L,76L,77L,78L,84L,87L,88L,89L,90L,91L,97L,100L,101L,102L,103L,104L,105L,110L,113L,114L,115L,116L,117L,118L,123L,126L,127L,129L,130L,131L,136L,137L,139L,140L,142L,143L,144L,149L,150L,152L,153L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190234Inst : IEnumerable<long>
{
public static readonly long[] Value=A190234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190234.Bytes);
public long this[int i]=>Value[i];

public static A190234Inst Instance=new A190234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190235
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,14L,15L,17L,18L,20L,23L,27L,28L,30L,31L,33L,36L,40L,41L,43L,44L,46L,47L,49L,53L,54L,56L,57L,59L,60L,62L,66L,67L,69L,70L,72L,73L,79L,80L,81L,82L,83L,85L,86L,92L,93L,94L,95L,96L,98L,99L,106L,107L,108L,109L,111L,112L,119L,120L,121L,122L,124L,125L,128L,132L,133L,134L,135L,138L,141L,145L,146L,147L,148L,151L,154L,158L,159L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190235Inst : IEnumerable<long>
{
public static readonly long[] Value=A190235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190235.Bytes);
public long this[int i]=>Value[i];

public static A190235Inst Instance=new A190235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190300
{
public static readonly long[] Value={ 4L,6L,9L,25L,49L,169L,289L,361L,529L,841L,961L,1369L,1681L,1849L,2209L,2809L,3481L,3721L,4489L,5041L,5329L,6241L,6889L,7921L,9409L,10201L,10609L,11449L,11881L,12769L,16129L,17161L,18769L,19321L,22201L,22801L,24649L,26569L,27889L,29929L,32041L,32761L,36481L,37249L,38809L,39601L,44521L,49729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190300Inst : IEnumerable<long>
{
public static readonly long[] Value=A190300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190300.Bytes);
public long this[int i]=>Value[i];

public static A190300Inst Instance=new A190300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190301
{
public static readonly BigInteger[] Value={ 1L,0L,37L,0L,0L,0L,15873L,0L,12345679L,0L,1L,0L,8547L,0L,0L,0L,65359477124183L,0L,5847953216374269L,0L,5291L,0L,BigInteger.Parse("48309178743961352657"),0L,0L,0L,BigInteger.Parse("4115226337448559670781893"),0L,BigInteger.Parse("38314176245210727969348659"),0L,3584229390681L,0L,3367L,0L,0L,0L,3L,0L,2849L,0L,271L,0L };
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
public class A190301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190301Inst Instance=new A190301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190302
{
public static readonly long[] Value={ 1L,5L,4L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190302Inst : IEnumerable<long>
{
public static readonly long[] Value=A190302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190302.Bytes);
public long this[int i]=>Value[i];

public static A190302Inst Instance=new A190302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190303
{
public static readonly long[] Value={ 4L,4L,6L,6L,8L,4L,3L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190303Inst : IEnumerable<long>
{
public static readonly long[] Value=A190303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190303.Bytes);
public long this[int i]=>Value[i];

public static A190303Inst Instance=new A190303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190304
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,14L,16L,19L,21L,24L,27L,29L,32L,34L,36L,39L,42L,44L,47L,49L,51L,54L,56L,59L,62L,64L,66L,69L,71L,74L,77L,79L,82L,84L,86L,89L,91L,94L,97L,99L,101L,104L,106L,109L,112L,114L,116L,119L,121L,124L,127L,129L,132L,133L,136L,139L,141L,144L,147L,149L,151L,154L,156L,159L,162L,164L,167L,169L,171L,174L,177L,179L,182L,183L,186L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190304Inst : IEnumerable<long>
{
public static readonly long[] Value=A190304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190304.Bytes);
public long this[int i]=>Value[i];

public static A190304Inst Instance=new A190304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190305
{
public static readonly long[] Value={ 2L,5L,8L,11L,13L,17L,20L,23L,25L,28L,31L,35L,37L,40L,43L,46L,48L,52L,55L,58L,60L,63L,67L,70L,73L,75L,78L,81L,85L,87L,90L,93L,96L,98L,102L,105L,108L,110L,113L,117L,120L,122L,125L,128L,131L,135L,137L,140L,143L,146L,148L,152L,155L,158L,160L,163L,166L,170L,172L,175L,178L,181L,184L,187L,190L,193L,196L,198L,202L,205L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190305Inst : IEnumerable<long>
{
public static readonly long[] Value=A190305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190305.Bytes);
public long this[int i]=>Value[i];

public static A190305Inst Instance=new A190305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190306
{
public static readonly long[] Value={ 3L,7L,10L,15L,18L,22L,26L,30L,33L,38L,41L,45L,50L,53L,57L,61L,65L,68L,72L,76L,80L,83L,88L,92L,95L,100L,103L,107L,111L,115L,118L,123L,126L,130L,134L,138L,142L,145L,150L,153L,157L,161L,165L,168L,173L,176L,180L,185L,188L,192L,195L,200L,203L,207L,211L,215L,218L,223L,227L,230L,235L,238L,242L,246L,250L,253L,257L,261L,265L,269L,273L,277L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190306Inst : IEnumerable<long>
{
public static readonly long[] Value=A190306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190306.Bytes);
public long this[int i]=>Value[i];

public static A190306Inst Instance=new A190306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190307
{
public static readonly long[] Value={ 137L,1373L,2137L,3137L,9137L,13709L,13711L,13721L,13723L,13729L,13751L,13757L,13759L,13763L,13781L,13789L,13799L,15137L,17137L,21377L,21379L,24137L,29137L,30137L,31379L,36137L,45137L,47137L,51137L,61379L,62137L,66137L,77137L,78137L,81371L,81373L,83137L,84137L,86137L,89137L,91373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190307Inst : IEnumerable<long>
{
public static readonly long[] Value=A190307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190307.Bytes);
public long this[int i]=>Value[i];

public static A190307Inst Instance=new A190307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190308
{
public static readonly long[] Value={ 1L,3L,18L,31L,36L,45L,87L,136L,145L,225L,275L,357L,418L,428L,460L,505L,512L,528L,539L,549L,640L,663L,728L,768L,838L,855L,876L,886L,910L,942L,960L,995L,1026L,1030L,1047L,1067L,1083L,1125L,1133L,1157L,1191L,1212L,1291L,1300L,1400L,1443L,1470L,1480L,1491L,1539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190308Inst : IEnumerable<long>
{
public static readonly long[] Value=A190308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190308.Bytes);
public long this[int i]=>Value[i];

public static A190308Inst Instance=new A190308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190309
{
public static readonly long[] Value={ 0L,0L,2L,5L,11L,19L,29L,40L,58L,74L,94L,113L,141L,168L,201L,227L,267L,304L,348L,390L,438L,483L,537L,590L,657L,709L,776L,837L,913L,979L,1057L,1130L,1225L,1299L,1396L,1472L,1576L,1663L,1768L,1863L,1974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190309Inst : IEnumerable<long>
{
public static readonly long[] Value=A190309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190309.Bytes);
public long this[int i]=>Value[i];

public static A190309Inst Instance=new A190309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190310
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,5L,9L,12L,19L,24L,32L,37L,51L,57L,69L,80L,99L,107L,127L,136L,161L,176L,196L,207L,246L,262L,286L,306L,343L,357L,399L,414L,460L,485L,517L,544L,605L,623L,659L,689L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190310Inst : IEnumerable<long>
{
public static readonly long[] Value=A190310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190310.Bytes);
public long this[int i]=>Value[i];

public static A190310Inst Instance=new A190310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190311
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190311Inst : IEnumerable<long>
{
public static readonly long[] Value=A190311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190311.Bytes);
public long this[int i]=>Value[i];

public static A190311Inst Instance=new A190311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190312
{
public static readonly long[] Value={ 0L,0L,40L,368L,1704L,5704L,15400L,36096L,75632L,145968L,263592L,451392L,738360L,1163552L,1774840L,2632344L,3808992L,5394752L,7493936L,10233832L,13759008L,18241312L,23877984L,30896984L,39551456L,50137240L,62983128L,78459880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190312Inst : IEnumerable<long>
{
public static readonly long[] Value=A190312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190312.Bytes);
public long this[int i]=>Value[i];

public static A190312Inst Instance=new A190312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190313
{
public static readonly long[] Value={ 0L,0L,3L,18L,57L,137L,280L,517L,863L,1368L,2069L,3007L,4218L,5774L,7704L,10109L,13025L,16523L,20671L,25567L,31274L,37891L,45529L,54213L,64082L,75320L,87901L,102014L,117736L,135217L,154606L,176024L,199502L,225290L,253485L,284305L,317811L,354282L,393618L,436202L,482332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190313Inst : IEnumerable<long>
{
public static readonly long[] Value=A190313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190313.Bytes);
public long this[int i]=>Value[i];

public static A190313Inst Instance=new A190313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190314
{
public static readonly BigInteger[] Value={ 0L,1L,5L,38L,390L,5049L,78960L,1447886L,30461872L,723267369L,19130274880L,557794986814L,17775137850624L,614607897664305L,22917282895782912L,916671255921364950L,BigInteger.Parse("39152092883971954688"),BigInteger.Parse("1778431981539189344177"),BigInteger.Parse("85607684151779322519552"),BigInteger.Parse("4353142694568849287025142"),BigInteger.Parse("233169669255877689516032000") };
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
public class A190314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190314Inst Instance=new A190314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190315
{
public static readonly long[] Value={ 1L,2L,9L,48L,265L,1500L,8638L,50360L,296325L,1756160L,10467556L,62683896L,376838098L,2272896626L,13747543035L,83354081728L,506467851061L,3083121435312L,18799746616104L,114804614071760L,702016963933404L,4297947201746176L,26342178216979384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190315Inst : IEnumerable<long>
{
public static readonly long[] Value=A190315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190315.Bytes);
public long this[int i]=>Value[i];

public static A190315Inst Instance=new A190315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190396
{
public static readonly long[] Value={ 0L,1L,78L,1278L,10002L,50191L,189208L,584958L,1563488L,3737987L,8181786L,16669638L,32003238L,58438623L,102234772L,172344406L,281269668L,446107043L,689807558L,1042679982L,1544166426L,2244921423L,3209227248L,4517779918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190396Inst : IEnumerable<long>
{
public static readonly long[] Value=A190396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190396.Bytes);
public long this[int i]=>Value[i];

public static A190396Inst Instance=new A190396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190397
{
public static readonly long[] Value={ 0L,0L,28L,1668L,29092L,252584L,1441634L,6222996L,22004086L,66972760L,181332416L,446905476L,1019470032L,2179712872L,4410518630L,8510498516L,15756224370L,28128603736L,48622240660L,81660504068L,133643402268L,213660267432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190397Inst : IEnumerable<long>
{
public static readonly long[] Value=A190397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190397.Bytes);
public long this[int i]=>Value[i];

public static A190397Inst Instance=new A190397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190398
{
public static readonly long[] Value={ 0L,4L,72L,496L,2100L,6708L,17640L,40384L,83376L,158900L,284108L,482160L,783484L,1227156L,1862400L,2750208L,3965080L,5596884L,7752836L,10559600L,14165508L,18742900L,24490584L,31636416L,40440000L,51195508L,64234620L,79929584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190398Inst : IEnumerable<long>
{
public static readonly long[] Value=A190398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190398.Bytes);
public long this[int i]=>Value[i];

public static A190398Inst Instance=new A190398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190399
{
public static readonly long[] Value={ 0L,1L,54L,1068L,8550L,45873L,177968L,562032L,1519560L,3662625L,8057390L,16477020L,31712850L,58018793L,101639700L,171525568L,280160068L,444636297L,687881890L,1040201500L,1541008350L,2240952065L,3204279960L,4511682288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190399Inst : IEnumerable<long>
{
public static readonly long[] Value=A190399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190399.Bytes);
public long this[int i]=>Value[i];

public static A190399Inst Instance=new A190399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190400
{
public static readonly long[] Value={ 0L,0L,0L,976L,18510L,201528L,1232448L,5637824L,20502396L,63720920L,174647286L,434439792L,997037470L,2141831160L,4348204020L,8412482304L,15605151496L,27903377016L,48291880442L,81188237680L,132977239290L,212739639640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190400Inst : IEnumerable<long>
{
public static readonly long[] Value=A190400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190400.Bytes);
public long this[int i]=>Value[i];

public static A190400Inst Instance=new A190400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190401
{
public static readonly long[] Value={ 0L,0L,0L,384L,19100L,557808L,5841780L,41338400L,209264796L,859752800L,2982181004L,9131392296L,25196132260L,63968987264L,151223202900L,336724832384L,711538908572L,1437022315440L,2787781494732L,5219454908200L,9464698212228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190401Inst : IEnumerable<long>
{
public static readonly long[] Value=A190401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190401.Bytes);
public long this[int i]=>Value[i];

public static A190401Inst Instance=new A190401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190402
{
public static readonly long[] Value={ 2L,4L,8L,14L,20L,27L,45L,52L,75L,148L,195L,244L,292L,364L,628L,729L,772L,1108L,1196L,1215L,1252L,1406L,1552L,1588L,1684L,1701L,1828L,2164L,2452L,2644L,2692L,2924L,2932L,3028L,3125L,3508L,3825L,3982L,3988L,4372L,4462L,4612L,4804L,4852L,4948L,5284L,5524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190402Inst : IEnumerable<long>
{
public static readonly long[] Value=A190402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190402.Bytes);
public long this[int i]=>Value[i];

public static A190402Inst Instance=new A190402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190403
{
public static readonly long[] Value={ 4L,27L,60L,84L,132L,140L,204L,220L,228L,260L,270L,340L,372L,378L,444L,492L,564L,572L,580L,620L,644L,702L,708L,740L,804L,812L,820L,836L,860L,884L,918L,945L,1026L,1068L,1180L,1242L,1276L,1284L,1292L,1308L,1316L,1364L,1420L,1460L,1484L,1485L,1508L,1564L,1566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190403Inst : IEnumerable<long>
{
public static readonly long[] Value=A190403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190403.Bytes);
public long this[int i]=>Value[i];

public static A190403Inst Instance=new A190403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190404
{
public static readonly long[] Value={ 8L,2L,0L,8L,1L,6L,2L,8L,0L,3L,2L,7L,5L,7L,6L,9L,3L,3L,1L,4L,6L,9L,2L,1L,3L,8L,5L,1L,1L,2L,7L,1L,4L,7L,1L,7L,1L,1L,3L,0L,3L,0L,7L,6L,8L,9L,7L,8L,3L,6L,9L,8L,7L,3L,9L,0L,2L,3L,2L,5L,8L,1L,1L,1L,9L,0L,0L,7L,2L,3L,0L,1L,8L,6L,6L,6L,7L,5L,8L,8L,7L,8L,0L,0L,1L,8L,2L,0L,8L,5L,8L,1L,1L,6L,7L,9L,5L,6L,6L,5L,4L,3L,0L,4L,4L,8L,6L,7L,6L,5L,8L,1L,7L,1L,8L,0L,9L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190404Inst : IEnumerable<long>
{
public static readonly long[] Value=A190404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190404.Bytes);
public long this[int i]=>Value[i];

public static A190404Inst Instance=new A190404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190405
{
public static readonly long[] Value={ 6L,4L,1L,6L,3L,2L,5L,6L,0L,6L,5L,5L,1L,5L,3L,8L,6L,6L,2L,9L,3L,8L,4L,2L,7L,7L,0L,2L,2L,5L,4L,2L,9L,4L,3L,4L,2L,2L,6L,0L,6L,1L,5L,3L,7L,9L,5L,6L,7L,3L,9L,7L,4L,7L,8L,0L,4L,6L,5L,1L,6L,2L,2L,3L,8L,0L,1L,4L,4L,6L,0L,3L,7L,3L,3L,3L,5L,1L,7L,7L,5L,6L,0L,0L,3L,6L,4L,1L,7L,1L,6L,2L,3L,3L,5L,9L,1L,3L,3L,0L,8L,6L,0L,8L,9L,7L,3L,5L,3L,1L,6L,3L,4L,3L,6L,1L,9L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190405Inst : IEnumerable<long>
{
public static readonly long[] Value=A190405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190405.Bytes);
public long this[int i]=>Value[i];

public static A190405Inst Instance=new A190405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190406
{
public static readonly long[] Value={ 5L,3L,1L,3L,7L,2L,1L,0L,0L,1L,1L,5L,2L,7L,7L,1L,3L,5L,4L,7L,9L,8L,7L,9L,8L,5L,8L,9L,6L,2L,5L,5L,3L,5L,3L,1L,7L,1L,2L,8L,4L,3L,2L,0L,1L,8L,6L,2L,0L,6L,6L,3L,9L,4L,0L,7L,8L,8L,8L,7L,1L,6L,1L,3L,5L,7L,8L,9L,0L,6L,8L,8L,0L,2L,3L,7L,7L,6L,0L,4L,7L,6L,0L,7L,3L,0L,3L,4L,5L,7L,7L,9L,6L,0L,7L,1L,2L,3L,4L,9L,2L,0L,6L,1L,0L,7L,1L,1L,5L,2L,2L,0L,6L,3L,9L,0L,0L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190406Inst : IEnumerable<long>
{
public static readonly long[] Value=A190406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190406.Bytes);
public long this[int i]=>Value[i];

public static A190406Inst Instance=new A190406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190407
{
public static readonly long[] Value={ 1L,2L,6L,9L,5L,5L,0L,3L,2L,4L,6L,5L,0L,4L,8L,5L,7L,8L,4L,1L,6L,2L,5L,0L,5L,4L,3L,6L,3L,5L,7L,2L,5L,6L,7L,8L,8L,0L,6L,9L,6L,2L,1L,6L,8L,1L,9L,0L,1L,4L,6L,8L,0L,0L,2L,3L,1L,5L,0L,6L,1L,7L,8L,4L,9L,2L,5L,0L,9L,9L,2L,2L,7L,6L,2L,2L,7L,3L,0L,7L,5L,3L,8L,2L,1L,6L,5L,1L,3L,8L,3L,2L,3L,0L,9L,6L,1L,4L,3L,1L,3L,9L,1L,4L,3L,1L,4L,5L,8L,3L,2L,5L,4L,2L,1L,3L,0L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190407Inst : IEnumerable<long>
{
public static readonly long[] Value=A190407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190407.Bytes);
public long this[int i]=>Value[i];

public static A190407Inst Instance=new A190407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190408
{
public static readonly long[] Value={ 8L,3L,8L,5L,5L,1L,8L,4L,0L,4L,3L,4L,4L,8L,1L,2L,4L,0L,0L,6L,1L,6L,3L,2L,3L,3L,1L,3L,5L,5L,8L,0L,0L,1L,4L,4L,8L,7L,3L,7L,5L,6L,9L,0L,4L,6L,6L,5L,1L,7L,4L,8L,1L,8L,6L,4L,6L,1L,7L,9L,5L,0L,0L,9L,1L,2L,3L,6L,8L,4L,3L,2L,7L,4L,2L,6L,4L,2L,5L,2L,2L,5L,3L,4L,5L,5L,8L,0L,4L,4L,9L,3L,0L,0L,2L,8L,6L,4L,6L,2L,9L,4L,5L,5L,9L,5L,9L,1L,6L,8L,0L,0L,8L,0L,4L,4L,2L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190408Inst : IEnumerable<long>
{
public static readonly long[] Value=A190408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190408.Bytes);
public long this[int i]=>Value[i];

public static A190408Inst Instance=new A190408Inst();

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